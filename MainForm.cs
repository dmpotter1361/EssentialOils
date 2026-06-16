using System.Drawing.Printing;

namespace EssentialOils;

public sealed class MainForm : Form
{
    private readonly OilCatalog _catalog;

    // Note + carrier list boxes.
    private readonly ListBox _carrierList = NewOilList();
    private readonly ListBox _topList = NewOilList();
    private readonly ListBox _midList = NewOilList();
    private readonly ListBox _baseList = NewOilList();
    private readonly ListBox _bottleList = new() { Font = OilFont, ItemHeight = 21 };

    private readonly TextBox _recipeBox = new()
    {
        Font = OilFont, Multiline = true, ScrollBars = ScrollBars.Vertical,
    };

    private readonly CheckBox _researchCarrier = NewResearchToggle("Research Carrier Oil");
    private readonly CheckBox _researchTop = NewResearchToggle("Research Top Note");
    private readonly CheckBox _researchMid = NewResearchToggle("Research Middle Note");
    private readonly CheckBox _researchBase = NewResearchToggle("Research Base Note");

    private readonly Dictionary<string, Label> _familyLabels = new();
    private readonly Dictionary<string, Label> _effectLabels = new();

    private readonly Button _createBtn = new() { Text = "Create Recipe", Font = OilFont };
    private readonly Button _printBtn = NewActionButton("printer icon.png", "Print");
    private readonly Button _copyBtn = NewActionButton("copy icon.png", "Copy");
    private readonly Button _resetBtn = NewActionButton(null, "Reset");
    private readonly Button _saveBtn = NewActionButton(null, "Save");

    private readonly PrintDocument _printDoc = new();
    private readonly ToolTip _toolTip = new();

    private static readonly Font OilFont = new("Segoe UI", 12F);

    private List<ResearchColumn> _columns = [];

    public MainForm(OilCatalog catalog)
    {
        _catalog = catalog;
        BuildLayout();
        PopulateData();
        WireEvents();
    }

    // ---- UI construction ----

    private void BuildLayout()
    {
        Text = "Essential Oil Mixer";
        FormBorderStyle = FormBorderStyle.Fixed3D;
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(882, 546);
        MaximizeBox = false;
        TryLoadIcon();

        // Research toggles (they double as the column headers).
        Place(_researchCarrier, 10, 9, 150, 54);
        Place(_researchTop, 168, 9, 151, 54);
        Place(_researchMid, 325, 9, 151, 54);
        Place(_researchBase, 482, 9, 151, 54);
        Place(_createBtn, 639, 9, 231, 54);

        // List boxes.
        Place(_carrierList, 10, 69, 151, 340);
        Place(_topList, 168, 69, 151, 340);
        Place(_midList, 325, 69, 151, 340);
        Place(_baseList, 482, 69, 151, 340);
        Place(_recipeBox, 639, 69, 231, 413);

        Place(_bottleList, 10, 429, 150, 109);

        // Fragrance family labels (Panel1).
        var familyPanel = new Panel { Location = new Point(168, 429), Size = new Size(465, 48) };
        int[] familyX = [51, 122, 193, 264, 335];
        for (int i = 0; i < OilCatalog.Families.Count; i++)
        {
            string family = OilCatalog.Families[i];
            var lbl = NewCategoryLabel(family, familyX[i], 12, 71);
            _familyLabels[family] = lbl;
            familyPanel.Controls.Add(lbl);
        }
        Controls.Add(familyPanel);

        // Effect labels (Panel2).
        var effectPanel = new Panel { Location = new Point(168, 483), Size = new Size(465, 55) };
        int[] effectX = [45, 139, 233, 327];
        for (int i = 0; i < OilCatalog.Effects.Count; i++)
        {
            string effect = OilCatalog.Effects[i];
            var lbl = NewCategoryLabel(effect, effectX[i], 14, 94);
            _effectLabels[effect] = lbl;
            effectPanel.Controls.Add(lbl);
        }
        Controls.Add(effectPanel);

        // Action buttons.
        Place(_resetBtn, 639, 488, 50, 50);
        Place(_copyBtn, 708, 488, 50, 50);
        Place(_printBtn, 764, 488, 50, 50);
        Place(_saveBtn, 820, 488, 50, 50);

        _toolTip.SetToolTip(_createBtn, "Build the recipe from your selections.");
        _toolTip.SetToolTip(_printBtn, "Print recipe to printer.");
        _toolTip.SetToolTip(_copyBtn, "Copy recipe to clipboard.");
        _toolTip.SetToolTip(_resetBtn, "Reset the recipe.");
        _toolTip.SetToolTip(_saveBtn, "Save recipe to disk.");
        _toolTip.SetToolTip(_bottleList, "Select the size of your bottle. The calculations will be adjusted accordingly.");
        const string listHint = "You may select one or more items.\nUse CTRL+click, or Shift to select a range.";
        foreach (var lb in new[] { _carrierList, _topList, _midList, _baseList })
            _toolTip.SetToolTip(lb, listHint);
    }

    private void PopulateData()
    {
        _topList.Items.AddRange(_catalog.Columns.Top.ToArray());
        _midList.Items.AddRange(_catalog.Columns.Middle.ToArray());
        _baseList.Items.AddRange(_catalog.Columns.Base.ToArray());
        _carrierList.Items.AddRange(_catalog.Columns.Carrier.ToArray());

        _bottleList.Items.AddRange(["15ml", "30ml", "60ml", "120ml", "240ml", "425ml", "480ml", "960ml"]);
        _bottleList.SelectedIndex = 2;   // 60ml, as in the original
        _carrierList.SelectedIndex = 0;  // a carrier is required for any recipe

        _columns =
        [
            new(NoteTier.Top, _topList, _researchTop, "Research Top Note", "Researching Top Note", DescribeOil),
            new(NoteTier.Middle, _midList, _researchMid, "Research Middle Note", "Researching Middle Note", DescribeOil),
            new(NoteTier.Base, _baseList, _researchBase, "Research Base Note", "Researching Base Note", DescribeOil),
            new(null, _carrierList, _researchCarrier, "Research Carrier Oil", "Researching Carrier Oils", DescribeCarrier),
        ];
    }

    private void WireEvents()
    {
        foreach (var col in _columns)
        {
            var c = col; // capture
            c.Toggle.CheckedChanged += (_, _) => OnResearchToggled(c);
            c.List.SelectedIndexChanged += (_, _) => OnListSelectionChanged(c);
        }

        _createBtn.Click += (_, _) => OnCreateRecipe();
        _copyBtn.Click += (_, _) => OnCopy();
        _resetBtn.Click += (_, _) => OnReset();
        _saveBtn.Click += (_, _) => OnSave();
        _printBtn.Click += (_, _) => OnPrint();
        _recipeBox.TextChanged += (_, _) => UpdateActionButtons();
        _printDoc.PrintPage += PrintRecipePage;

        UpdateActionButtons();
    }

    // ---- Behaviour ----

    private void OnResearchToggled(ResearchColumn col)
    {
        if (col.Toggle.Checked)
        {
            foreach (var other in _columns)
                if (other != col) other.Toggle.Checked = false;

            col.Toggle.BackColor = Color.Aqua;
            col.Toggle.Text = col.ActiveText;
            col.List.SelectionMode = SelectionMode.One;
            col.List.ClearSelected();
        }
        else
        {
            col.Toggle.BackColor = SystemColors.Control;
            col.Toggle.Text = col.BaseText;
            col.List.SelectionMode = SelectionMode.MultiExtended;
        }
    }

    private void OnListSelectionChanged(ResearchColumn col)
    {
        if (col.Toggle.Checked)
        {
            if (col.List.SelectedItem is string name)
                OpenResearch(name, col.Describe(name));
        }
        else
        {
            UpdateHighlights();
        }
    }

    private void OpenResearch(string name, string? description)
    {
        var form = new ResearchForm(name, description ?? string.Empty);
        form.Show(this);
    }

    private void OnCreateRecipe()
    {
        int bottleMl = ParseBottleSize(_bottleList.SelectedItem as string);
        var result = Recipe.Build(
            bottleMl,
            SelectedNames(_carrierList),
            SelectedOils(NoteTier.Top),
            SelectedOils(NoteTier.Middle),
            SelectedOils(NoteTier.Base));

        _recipeBox.Text = result.Text;
        ApplyHighlights(result.Families, result.Effects);
    }

    private void UpdateHighlights() =>
        ApplyHighlights(
            Recipe.HighlightFamilies(SelectedOils(NoteTier.Top), SelectedOils(NoteTier.Middle), SelectedOils(NoteTier.Base)),
            Recipe.HighlightEffects(SelectedOils(NoteTier.Top), SelectedOils(NoteTier.Middle), SelectedOils(NoteTier.Base)));

    private void ApplyHighlights(IReadOnlySet<string> families, IReadOnlySet<string> effects)
    {
        foreach (var (name, lbl) in _familyLabels)
            lbl.BackColor = families.Contains(name) ? Color.DodgerBlue : SystemColors.Control;
        foreach (var (name, lbl) in _effectLabels)
            lbl.BackColor = effects.Contains(name) ? Color.DodgerBlue : SystemColors.Control;
    }

    private void OnCopy()
    {
        if (string.IsNullOrEmpty(_recipeBox.Text)) return;
        try { Clipboard.SetText(_recipeBox.Text); }
        catch (Exception) { /* clipboard can transiently fail; ignore as the original did */ }
    }

    private void OnReset()
    {
        if (MessageBox.Show("Are you sure you want to reset?", "Reset", MessageBoxButtons.YesNo) != DialogResult.Yes)
            return;

        _topList.ClearSelected();
        _midList.ClearSelected();
        _baseList.ClearSelected();
        _carrierList.ClearSelected();
        _recipeBox.Clear();
        ApplyHighlights(new HashSet<string>(), new HashSet<string>());
    }

    private void OnSave()
    {
        using var dialog = new SaveFileDialog
        {
            FileName = "Recipe_" + RandomWord(),
            Title = "Please select a file name and location",
            Filter = "Text files|*.txt|All files|*.*",
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            DefaultExt = ".txt",
        };
        if (dialog.ShowDialog(this) == DialogResult.OK)
            File.WriteAllText(dialog.FileName, _recipeBox.Text);
    }

    private void OnPrint()
    {
        using var dialog = new PrintDialog { Document = _printDoc };
        if (dialog.ShowDialog(this) == DialogResult.OK)
            _printDoc.Print();
    }

    private void PrintRecipePage(object sender, PrintPageEventArgs e)
    {
        if (e.Graphics is null) return;
        using var font = new Font("Courier New", 12);
        var rect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
        using var format = new StringFormat(StringFormatFlags.LineLimit) { Trimming = StringTrimming.Word };
        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
        e.Graphics.DrawString(_recipeBox.Text, font, Brushes.Black, rect, format);
    }

    private void UpdateActionButtons()
    {
        bool hasText = !string.IsNullOrEmpty(_recipeBox.Text);
        _printBtn.Enabled = _copyBtn.Enabled = _resetBtn.Enabled = _saveBtn.Enabled = hasText;
    }

    // ---- Helpers ----

    private string? DescribeOil(string name) => _catalog.FindOil(name)?.Description;
    private string? DescribeCarrier(string name) => _catalog.FindCarrier(name)?.Description;

    private IReadOnlyList<string> SelectedNames(ListBox list) => list.SelectedItems.Cast<string>().ToList();

    private IReadOnlyList<Oil> SelectedOils(NoteTier tier) =>
        ListFor(tier).SelectedItems.Cast<string>()
            .Select(_catalog.FindOil)
            .Where(o => o is not null)
            .ToList()!;

    private ListBox ListFor(NoteTier tier) => tier switch
    {
        NoteTier.Top => _topList,
        NoteTier.Middle => _midList,
        NoteTier.Base => _baseList,
        _ => throw new ArgumentOutOfRangeException(nameof(tier)),
    };

    internal static int ParseBottleSize(string? size)
    {
        string digits = new(string.IsNullOrEmpty(size) ? "" : size.Where(char.IsDigit).ToArray());
        return int.TryParse(digits, out int ml) ? ml : 0;
    }

    private static string RandomWord()
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return string.Concat(Enumerable.Range(0, 6).Select(_ => chars[Random.Shared.Next(chars.Length)]));
    }

    private void Place(Control c, int x, int y, int w, int h)
    {
        c.Location = new Point(x, y);
        c.Size = new Size(w, h);
        Controls.Add(c);
    }

    private static ListBox NewOilList() => new()
    {
        Font = OilFont, ItemHeight = 21, SelectionMode = SelectionMode.MultiExtended,
    };

    private static CheckBox NewResearchToggle(string text) => new()
    {
        Appearance = Appearance.Button, FlatStyle = FlatStyle.Popup, Font = OilFont,
        Text = text, TextAlign = ContentAlignment.MiddleCenter, UseVisualStyleBackColor = true,
    };

    private static Label NewCategoryLabel(string text, int x, int y, int width) => new()
    {
        Text = text, BorderStyle = BorderStyle.FixedSingle, TextAlign = ContentAlignment.MiddleCenter,
        Location = new Point(x, y), Size = new Size(width, 26),
    };

    private static Button NewActionButton(string? imageFile, string fallbackText)
    {
        var btn = new Button
        {
            Font = new Font("Segoe UI", 9F),
            MinimumSize = new Size(50, 50),
            MaximumSize = new Size(50, 50),
            UseVisualStyleBackColor = true,
        };
        Image? img = imageFile is null ? null : TryLoadImage(imageFile);
        if (img is not null)
        {
            btn.BackgroundImage = img;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }
        else
        {
            btn.Text = fallbackText;
        }
        return btn;
    }

    private static Image? TryLoadImage(string file)
    {
        try
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Resources", file);
            return File.Exists(path) ? Image.FromFile(path) : null;
        }
        catch (Exception) { return null; }
    }

    private void TryLoadIcon()
    {
        try
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Resources", "Icon1.ico");
            if (File.Exists(path)) Icon = new Icon(path);
        }
        catch (Exception) { /* icon is cosmetic */ }
    }

    /// <summary>A note tier (or carrier when <see cref="Tier"/> is null) and its research toggle.</summary>
    private sealed record ResearchColumn(
        NoteTier? Tier, ListBox List, CheckBox Toggle, string BaseText, string ActiveText, Func<string, string?> Describe);
}

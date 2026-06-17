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
        // Scale by DPI (not the system font) and let the form size itself to the
        // layout, so it stays correct under any display-scale / text-size setting.
        AutoScaleMode = AutoScaleMode.Dpi;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        StartPosition = FormStartPosition.CenterScreen;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        MaximizeBox = false;
        TryLoadIcon();

        // Everything lives in one auto-sizing grid: 5 columns (carrier / top /
        // middle / base / recipe) over 3 rows (headers, lists, bottom strip).
        // Children Dock-fill their cells, so the whole thing reflows cleanly when
        // WinForms scales the absolute column/row sizes for the monitor's DPI.
        var root = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoSize = true,
            AutoSizeMode = AutoSizeMode.GrowAndShrink,
            ColumnCount = 5,
            RowCount = 3,
            Padding = new Padding(8),
        };
        for (int i = 0; i < 4; i++) root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156));
        root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 246));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 56));    // headers
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 330));   // lists / recipe
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 136));   // bottom strip

        // Row 0 — research toggles (they double as the column headers) + Create.
        AddCell(root, _researchCarrier, 0, 0);
        AddCell(root, _researchTop, 1, 0);
        AddCell(root, _researchMid, 2, 0);
        AddCell(root, _researchBase, 3, 0);
        AddCell(root, _createBtn, 4, 0);

        // Row 1 — the four oil lists + the recipe box.
        AddCell(root, _carrierList, 0, 1);
        AddCell(root, _topList, 1, 1);
        AddCell(root, _midList, 2, 1);
        AddCell(root, _baseList, 3, 1);
        AddCell(root, _recipeBox, 4, 1);

        // Row 2 — bottle size (under carrier), scent-profile chips (under the
        // note columns), and the action buttons (under the recipe).
        AddCell(root, _bottleList, 0, 2);

        var profile = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2 };
        profile.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
        profile.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
        profile.Controls.Add(BuildCategoryRow(OilCatalog.Families, _familyLabels), 0, 0);
        profile.Controls.Add(BuildCategoryRow(OilCatalog.Effects, _effectLabels), 0, 1);
        root.Controls.Add(profile, 1, 2);
        root.SetColumnSpan(profile, 3);

        var actions = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill, FlowDirection = FlowDirection.LeftToRight, WrapContents = true,
        };
        foreach (var b in new[] { _resetBtn, _copyBtn, _printBtn, _saveBtn })
            actions.Controls.Add(b);
        root.Controls.Add(actions, 4, 2);

        Controls.Add(root);

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

    private static void AddCell(TableLayoutPanel host, Control c, int column, int row)
    {
        c.Dock = DockStyle.Fill;
        host.Controls.Add(c, column, row);
    }

    private FlowLayoutPanel BuildCategoryRow(IReadOnlyList<string> names, Dictionary<string, Label> sink)
    {
        var row = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.LeftToRight, WrapContents = true };
        foreach (string name in names)
        {
            var lbl = NewCategoryLabel(name);
            sink[name] = lbl;
            row.Controls.Add(lbl);
        }
        return row;
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

    private static Label NewCategoryLabel(string text) => new()
    {
        Text = text, BorderStyle = BorderStyle.FixedSingle, TextAlign = ContentAlignment.MiddleCenter,
        AutoSize = true, Padding = new Padding(10, 5, 10, 5), Margin = new Padding(3),
    };

    private static Button NewActionButton(string? imageFile, string fallbackText)
    {
        var btn = new Button
        {
            Font = new Font("Segoe UI", 9F),
            MinimumSize = new Size(50, 50),
            MaximumSize = new Size(50, 50),
            Margin = new Padding(3),
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

using System.Drawing.Printing;
using System.Speech.Synthesis;

namespace EssentialOils;

/// <summary>Shows a single oil's description, with print and text-to-speech.</summary>
public sealed class ResearchForm : Form
{
    private readonly SpeechSynthesizer _synth = new();
    private readonly TextBox _text;
    private readonly ComboBox _voice;
    private readonly Button _speakBtn;
    private readonly PrintDocument _printDoc = new();

    private const string DefaultVoice = "Microsoft David Desktop";

    public ResearchForm(string oilName, string description)
    {
        Text = oilName;
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(756, 496);
        MinimumSize = new Size(772, 535);

        var group = new GroupBox
        {
            Text = $"{oilName} Essential Oil",
            FlatStyle = FlatStyle.Popup,
            Location = new Point(12, 12),
            Size = new Size(732, 379),
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
        };
        _text = new TextBox
        {
            Text = description,
            ReadOnly = true, Multiline = true, Dock = DockStyle.Fill,
            ScrollBars = ScrollBars.Vertical, BackColor = Color.White,
            Font = new Font("Segoe UI", 14.25F), TabStop = false,
        };
        group.Controls.Add(_text);
        Controls.Add(group);

        var panel = new Panel
        {
            BorderStyle = BorderStyle.FixedSingle,
            Location = new Point(15, 397), Size = new Size(732, 87),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
        };

        var printBtn = new Button
        {
            Text = "Print", Font = new Font("Segoe UI", 12F),
            Location = new Point(13, 12), Size = new Size(161, 61),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
        };
        printBtn.Click += (_, _) => OnPrint();

        var voiceLabel = new Label
        {
            Text = "Change Voice", Font = new Font("Segoe UI", 12F),
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(358, 6), Size = new Size(200, 21),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
        };
        _voice = new ComboBox
        {
            Location = new Point(356, 32), Size = new Size(202, 23),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
        };
        _voice.Items.AddRange(["Microsoft David Desktop", "Microsoft Zira Desktop"]);

        _speakBtn = new Button
        {
            Text = "Speak Text", Font = new Font("Segoe UI", 12F),
            Location = new Point(564, 12), Size = new Size(161, 61),
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
        };
        _speakBtn.Click += (_, _) => OnSpeakToggle();

        panel.Controls.Add(voiceLabel);
        panel.Controls.Add(_voice);
        panel.Controls.Add(printBtn);
        panel.Controls.Add(_speakBtn);
        Controls.Add(panel);

        _printDoc.PrintPage += PrintPage;
        _synth.SpeakCompleted += (_, _) => _speakBtn.Text = "Speak Text";
        FormClosed += (_, _) => _synth.Dispose();
    }

    private void OnSpeakToggle()
    {
        if (_speakBtn.Text == "Speak Text")
        {
            _synth.SpeakAsyncCancelAll();
            TrySelectVoice(_voice.SelectedItem as string ?? DefaultVoice);
            _synth.SpeakAsync(_text.Text);
            _speakBtn.Text = "Stop Speaking";
        }
        else
        {
            _synth.SpeakAsyncCancelAll();
            _speakBtn.Text = "Speak Text";
        }
    }

    private void TrySelectVoice(string voice)
    {
        try { _synth.SelectVoice(voice); }
        catch (ArgumentException) { /* voice not installed; keep the current default */ }
    }

    private void OnPrint()
    {
        using var dialog = new PrintDialog { Document = _printDoc };
        if (dialog.ShowDialog(this) == DialogResult.OK)
            _printDoc.Print();
    }

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        if (e.Graphics is null) return;
        using var font = new Font("Segoe UI", 10);
        var rect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
        using var format = new StringFormat(StringFormatFlags.LineLimit) { Trimming = StringTrimming.Word };
        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
        e.Graphics.DrawString(_text.Text, font, Brushes.Black, rect, format);
    }
}

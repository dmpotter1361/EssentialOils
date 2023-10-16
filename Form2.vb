Imports System.Collections.ObjectModel
Imports System.Speech.Synthesis

Public Class Form2
    Public myVoice As String = "Microsoft David Desktop"
    Dim sythesizer As New Speech.Synthesis.SpeechSynthesizer()
    Private Sub Form2_Load(sender As Object, e As EventArgs)


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Get the text from the textbox
        Dim text As String = TextBox1.Text
        ' Create a font for the text
        Dim font As New Font("Segoe UI", 10)
        ' Create a rectangle for the text layout
        Dim rect As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
        ' Create a string format for the text formatting
        Dim sf As New StringFormat(StringFormatFlags.FitBlackBox Or StringFormatFlags.LineLimit)
        ' Set the trimming, alignment, and line alignment options
        sf.Trimming = StringTrimming.Word
        sf.Alignment = StringAlignment.Near
        sf.LineAlignment = StringAlignment.Near
        ' Set the text rendering hint for the graphics object
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        ' Draw the text on the graphics object using the font, brush, rectangle, and string format
        e.Graphics.DrawString(text, font, Brushes.Black, rect, sf)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim sythesizer As New Speech.Synthesis.SpeechSynthesizer
        'If ComboBox1.SelectedText = "" Then ComboBox1.SelectedText = "Microsoft David"
        sythesizer.SpeakAsyncCancelAll()
        If ComboBox1.SelectedItem = "" Then myVoice = "Microsoft David Desktop" Else myVoice = ComboBox1.SelectedItem
        'MsgBox(myVoice)
        If Button1.Text = "Speak Text" Then
            sythesizer.SelectVoice(myVoice)
            sythesizer.SpeakAsync(TextBox1.Text)
            Button1.Text = "Stop Speaking"
        Else
            sythesizer.SpeakAsyncCancelAll()
            Button1.Text = "Speak Text"
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim printDialog As New PrintDialog()
        Dim result As DialogResult = printDialog.ShowDialog()
        If result = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

End Class
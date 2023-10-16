<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        Panel1 = New Panel()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Button3 = New Button()
        Button1 = New Button()
        ToolTip1 = New ToolTip(components)
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.AutoSize = True
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(732, 379)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(3, 19)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(726, 357)
        TextBox1.TabIndex = 1
        TextBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(15, 397)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(732, 87)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(358, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 21)
        Label1.TabIndex = 6
        Label1.Text = "Change Voice"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(Label1, "Use the box below to change between voices.")
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Microsoft David Desktop", "Microsoft Zira Desktop"})
        ComboBox1.Location = New Point(356, 32)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(202, 23)
        ComboBox1.TabIndex = 3
        ToolTip1.SetToolTip(ComboBox1, "Select an alternative voice.")
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(13, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(161, 61)
        Button3.TabIndex = 2
        Button3.Text = "Print"
        ToolTip1.SetToolTip(Button3, "Print the above information.")
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(564, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(161, 61)
        Button1.TabIndex = 4
        Button1.Text = "Speak Text"
        ToolTip1.SetToolTip(Button1, "Read aloud the above text.")
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(756, 496)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(772, 535)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class

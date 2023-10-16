<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        ListBox3 = New ListBox()
        TextBox1 = New TextBox()
        ListBox4 = New ListBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox1 = New CheckBox()
        Panel1 = New Panel()
        lblWoody = New Label()
        lblSpicy = New Label()
        lblHerbal = New Label()
        lblFloral = New Label()
        lblCitrus = New Label()
        Panel2 = New Panel()
        lblGrounding = New Label()
        lblCleansing = New Label()
        lblRelaxing = New Label()
        lblEnergizing = New Label()
        Button1 = New Button()
        CheckBox4 = New CheckBox()
        ListBox5 = New ListBox()
        Button2 = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        ToolTip1 = New ToolTip(components)
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 21
        ListBox1.Location = New Point(168, 69)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(151, 340)
        ListBox1.TabIndex = 2
        ToolTip1.SetToolTip(ListBox1, "You may select one or more items. " & vbCrLf & "Use CTRL and click or select a range using the Shift Key for multiple choices.")
        ' 
        ' ListBox2
        ' 
        ListBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 21
        ListBox2.Location = New Point(325, 69)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(151, 340)
        ListBox2.TabIndex = 3
        ToolTip1.SetToolTip(ListBox2, "You may select one or more items. " & vbLf & "Use CTRL and click or select a range using the Shift Key for multiple choices.")
        ' 
        ' ListBox3
        ' 
        ListBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 21
        ListBox3.Location = New Point(482, 69)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(151, 340)
        ListBox3.TabIndex = 4
        ToolTip1.SetToolTip(ListBox3, "You may select one or more items. " & vbLf & "Use CTRL and click or select a range using the Shift Key for multiple choices.")
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(639, 69)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(231, 413)
        TextBox1.TabIndex = 11
        ToolTip1.SetToolTip(TextBox1, "Feel free to add additional text to this recipe. " & vbLf & "Then, you can select all and copy the formula to your notes.")
        ' 
        ' ListBox4
        ' 
        ListBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox4.FormattingEnabled = True
        ListBox4.ItemHeight = 21
        ListBox4.Location = New Point(10, 69)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(151, 340)
        ListBox4.TabIndex = 1
        ToolTip1.SetToolTip(ListBox4, "You may select one or more items. " & vbCrLf & "Use CTRL and click or select a range using the Shift Key for multiple choices.")
        ' 
        ' CheckBox2
        ' 
        CheckBox2.Appearance = Appearance.Button
        CheckBox2.FlatStyle = FlatStyle.Popup
        CheckBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(325, 9)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(151, 54)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "Research Middle Note"
        CheckBox2.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(CheckBox2, "Select to enter or exit research mode. " & vbCrLf & "In research, you will get further information about the type of oil you have selected. " & vbCrLf & "While doing research, it will clear all selected items.")
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.Appearance = Appearance.Button
        CheckBox3.FlatStyle = FlatStyle.Popup
        CheckBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox3.Location = New Point(482, 9)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(151, 54)
        CheckBox3.TabIndex = 9
        CheckBox3.Text = "Research Base Note"
        CheckBox3.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(CheckBox3, "Select to enter or exit research mode. " & vbCrLf & "In research, you will get further information about the type of oil you have selected. " & vbCrLf & "While doing research, it will clear all selected items.")
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Appearance = Appearance.Button
        CheckBox1.FlatStyle = FlatStyle.Popup
        CheckBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(168, 9)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(151, 54)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Research Top Note"
        CheckBox1.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(CheckBox1, "Select to enter or exit research mode. " & vbCrLf & "In research, you will get further information about the type of oil you have selected. " & vbCrLf & "While doing research, it will clear all selected items.")
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblWoody)
        Panel1.Controls.Add(lblSpicy)
        Panel1.Controls.Add(lblHerbal)
        Panel1.Controls.Add(lblFloral)
        Panel1.Controls.Add(lblCitrus)
        Panel1.Location = New Point(168, 429)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(465, 48)
        Panel1.TabIndex = 9
        ' 
        ' lblWoody
        ' 
        lblWoody.BorderStyle = BorderStyle.FixedSingle
        lblWoody.Location = New Point(335, 12)
        lblWoody.Name = "lblWoody"
        lblWoody.Size = New Size(71, 26)
        lblWoody.TabIndex = 0
        lblWoody.Text = "Woody"
        lblWoody.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(lblWoody, "Click to get a brief list of essential oils in this category.")
        ' 
        ' lblSpicy
        ' 
        lblSpicy.BorderStyle = BorderStyle.FixedSingle
        lblSpicy.Location = New Point(264, 12)
        lblSpicy.Name = "lblSpicy"
        lblSpicy.Size = New Size(71, 26)
        lblSpicy.TabIndex = 0
        lblSpicy.Text = "Spicy"
        lblSpicy.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(lblSpicy, "Click to get a brief list of essential oils in this category.")
        ' 
        ' lblHerbal
        ' 
        lblHerbal.BorderStyle = BorderStyle.FixedSingle
        lblHerbal.Location = New Point(193, 12)
        lblHerbal.Name = "lblHerbal"
        lblHerbal.Size = New Size(71, 26)
        lblHerbal.TabIndex = 0
        lblHerbal.Text = "Herbal"
        lblHerbal.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(lblHerbal, "Click to get a brief list of essential oils in this category.")
        ' 
        ' lblFloral
        ' 
        lblFloral.BorderStyle = BorderStyle.FixedSingle
        lblFloral.Location = New Point(122, 12)
        lblFloral.Name = "lblFloral"
        lblFloral.Size = New Size(71, 26)
        lblFloral.TabIndex = 0
        lblFloral.Text = "Floral"
        lblFloral.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(lblFloral, "Click to get a brief list of essential oils in this category.")
        ' 
        ' lblCitrus
        ' 
        lblCitrus.BorderStyle = BorderStyle.FixedSingle
        lblCitrus.Location = New Point(51, 12)
        lblCitrus.Name = "lblCitrus"
        lblCitrus.Size = New Size(71, 26)
        lblCitrus.TabIndex = 0
        lblCitrus.Text = "Citrus"
        lblCitrus.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(lblCitrus, "Click to get a brief list of essential oils in this category.")
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblGrounding)
        Panel2.Controls.Add(lblCleansing)
        Panel2.Controls.Add(lblRelaxing)
        Panel2.Controls.Add(lblEnergizing)
        Panel2.Location = New Point(168, 483)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(465, 55)
        Panel2.TabIndex = 10
        ' 
        ' lblGrounding
        ' 
        lblGrounding.BorderStyle = BorderStyle.FixedSingle
        lblGrounding.Location = New Point(327, 14)
        lblGrounding.Name = "lblGrounding"
        lblGrounding.Size = New Size(94, 26)
        lblGrounding.TabIndex = 0
        lblGrounding.Text = "Grounding"
        lblGrounding.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(lblGrounding, "Click to get a brief list of essential oils in this category.")
        ' 
        ' lblCleansing
        ' 
        lblCleansing.BorderStyle = BorderStyle.FixedSingle
        lblCleansing.Location = New Point(233, 14)
        lblCleansing.Name = "lblCleansing"
        lblCleansing.Size = New Size(94, 26)
        lblCleansing.TabIndex = 0
        lblCleansing.Text = "Cleansing"
        lblCleansing.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(lblCleansing, "Click to get a brief list of essential oils in this category.")
        ' 
        ' lblRelaxing
        ' 
        lblRelaxing.BorderStyle = BorderStyle.FixedSingle
        lblRelaxing.Location = New Point(139, 14)
        lblRelaxing.Name = "lblRelaxing"
        lblRelaxing.Size = New Size(94, 26)
        lblRelaxing.TabIndex = 0
        lblRelaxing.Text = "Relaxing"
        lblRelaxing.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(lblRelaxing, "Click to get a brief list of essential oils in this category.")
        ' 
        ' lblEnergizing
        ' 
        lblEnergizing.BorderStyle = BorderStyle.FixedSingle
        lblEnergizing.Location = New Point(45, 14)
        lblEnergizing.Name = "lblEnergizing"
        lblEnergizing.Size = New Size(94, 26)
        lblEnergizing.TabIndex = 0
        lblEnergizing.Text = "Energizing"
        lblEnergizing.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(lblEnergizing, "Click to get a brief list of essential oils in this category.")
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(639, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(231, 54)
        Button1.TabIndex = 10
        Button1.Text = "Create Recipe"
        ToolTip1.SetToolTip(Button1, resources.GetString("Button1.ToolTip"))
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.Appearance = Appearance.Button
        CheckBox4.FlatStyle = FlatStyle.Popup
        CheckBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox4.Location = New Point(10, 9)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(150, 54)
        CheckBox4.TabIndex = 6
        CheckBox4.Text = "Research Carrier Oil"
        CheckBox4.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(CheckBox4, "Select to enter or exit research mode. " & vbCrLf & "In research, you will get further information about the type of oil you have selected. " & vbCrLf & "While doing research, it will clear all selected items.")
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' ListBox5
        ' 
        ListBox5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox5.FormattingEnabled = True
        ListBox5.ItemHeight = 21
        ListBox5.Items.AddRange(New Object() {"15ml", "30ml", "60ml", "120ml", "240ml", "425ml", "480ml", "960ml"})
        ListBox5.Location = New Point(10, 429)
        ListBox5.Name = "ListBox5"
        ListBox5.Size = New Size(150, 109)
        ListBox5.TabIndex = 5
        ToolTip1.SetToolTip(ListBox5, "Select the size of your bottle. " & vbLf & "The calculations will be adjusted accordingly.")
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.BackgroundImage = My.Resources.Resources.printer_icon
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(764, 488)
        Button2.MaximumSize = New Size(50, 50)
        Button2.MinimumSize = New Size(50, 50)
        Button2.Name = "Button2"
        Button2.Size = New Size(50, 50)
        Button2.TabIndex = 12
        ToolTip1.SetToolTip(Button2, "Print recipe to printer.")
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top
        Button3.BackgroundImage = My.Resources.Resources.copy_icon
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(708, 488)
        Button3.MaximumSize = New Size(50, 50)
        Button3.MinimumSize = New Size(50, 50)
        Button3.Name = "Button3"
        Button3.Size = New Size(50, 50)
        Button3.TabIndex = 13
        ToolTip1.SetToolTip(Button3, "Copy recipe to clipboard.")
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(639, 488)
        Button4.MaximumSize = New Size(50, 50)
        Button4.MinimumSize = New Size(50, 50)
        Button4.Name = "Button4"
        Button4.Size = New Size(50, 50)
        Button4.TabIndex = 14
        ToolTip1.SetToolTip(Button4, "Reset the recipe.")
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Top
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(820, 488)
        Button5.MaximumSize = New Size(50, 50)
        Button5.MinimumSize = New Size(50, 50)
        Button5.Name = "Button5"
        Button5.Size = New Size(50, 50)
        Button5.TabIndex = 15
        ToolTip1.SetToolTip(Button5, "Save recipe to disk.")
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(882, 546)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ListBox5)
        Controls.Add(CheckBox4)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(CheckBox1)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(ListBox4)
        Controls.Add(TextBox1)
        Controls.Add(ListBox3)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCitrus As Label
    Friend WithEvents lblFloral As Label
    Friend WithEvents lblWoody As Label
    Friend WithEvents lblSpicy As Label
    Friend WithEvents lblHerbal As Label
    Friend WithEvents lblEnergizing As Label
    Friend WithEvents lblRelaxing As Label
    Friend WithEvents lblCleansing As Label
    Friend WithEvents lblGrounding As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class

Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Diagnostics.Metrics
Imports System.Drawing.Printing
Imports System.IO
Imports System.Linq.Expressions
Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Pkcs
Imports System.Security.Cryptography.X509Certificates
Imports System.Speech.Synthesis
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports Microsoft.VisualBasic.FileIO


Public Class Form1
    ' Sentence builder for each of the notes for the final recipe
    Public TopNotesBrief As String
    Public MiddleNotesBrief As String
    Public BaseNotesBrief As String

    ' Sentence builder for each of the effects for final recipe
    Public TopEffectsBrief As String
    Public MiddleEffectsBrief As String
    Public BaseEffectsBrief As String

    ' % of Essential Oils usually 3% of recipe so default is .03
    Public intDilutionEssentialRate As Double = 0.03

    ' The following 3 should add up to 100%, the default is 30%/50%/20% so .3, .5, .2 as 30/50/20 Rule
    Public intTopRulePublic As Double = 0.3
    Public intMidRulePublic As Double = 0.5
    Public intBasRulePublic As Double = 0.2

    Dim sfd As New SaveFileDialog()
    Dim myDocsPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Essential Oil Mixer"
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
        Me.Button4.Enabled = False
        Me.Button5.Enabled = False

        Me.ListBox1.SelectionMode = SelectionMode.MultiExtended
        Me.ListBox2.SelectionMode = SelectionMode.MultiExtended
        Me.ListBox3.SelectionMode = SelectionMode.MultiExtended
        Me.ListBox4.SelectionMode = SelectionMode.MultiExtended
        ' Build the Top Notes, make sure they are also in the dictionary (Notes.vb)
        Me.ListBox1.Items.Add("Bergamot")
        Me.ListBox1.Items.Add("Citronella")
        Me.ListBox1.Items.Add("Grapefruit")
        Me.ListBox1.Items.Add("Lemon")
        Me.ListBox1.Items.Add("Lemongrass")
        Me.ListBox1.Items.Add("Lime")
        Me.ListBox1.Items.Add("Sweet Orange")
        Me.ListBox1.Items.Add("Lavender")
        Me.ListBox1.Items.Add("Petitgrain")
        Me.ListBox1.Items.Add("Pine Needle")
        Me.ListBox1.Items.Add("Basil")
        Me.ListBox1.Items.Add("Eucalyptus")
        Me.ListBox1.Items.Add("Spearmint")
        Me.ListBox1.Items.Add("Sage")
        ' Build the Middle Notes, make sure they are also in the dictionary (Notes.vb)
        Me.ListBox2.Items.Add("Citronella")
        Me.ListBox2.Items.Add("Rose Geranium")
        Me.ListBox2.Items.Add("Geranium")
        Me.ListBox2.Items.Add("Lavender")
        Me.ListBox2.Items.Add("Palmarosa")
        Me.ListBox2.Items.Add("Ylang Ylang")
        Me.ListBox2.Items.Add("Coriander")
        Me.ListBox2.Items.Add("Black Pepper")
        Me.ListBox2.Items.Add("Cinnamon Leaf")
        Me.ListBox2.Items.Add("Clove")
        Me.ListBox2.Items.Add("Nutmeg")
        Me.ListBox2.Items.Add("Cypress")
        Me.ListBox2.Items.Add("Juniper Berry")
        Me.ListBox2.Items.Add("Chamomile")
        Me.ListBox2.Items.Add("Clary Sage")
        Me.ListBox2.Items.Add("Marjoram")
        Me.ListBox2.Items.Add("Spearmint")
        Me.ListBox2.Items.Add("Oregano")
        Me.ListBox2.Items.Add("Rosemary")
        Me.ListBox2.Items.Add("Tea Tree")
        Me.ListBox2.Items.Add("Red Thyme")
        ' Build the Base Notes, make sure they are also in the dictionary (Notes.vb)
        Me.ListBox3.Items.Add("Ylang Ylang")
        Me.ListBox3.Items.Add("Black Pepper")
        Me.ListBox3.Items.Add("Cedarwood Atlas")
        Me.ListBox3.Items.Add("Frankincense")
        Me.ListBox3.Items.Add("Patchouli")
        Me.ListBox3.Items.Add("Sandalwood")
        Me.ListBox3.Items.Add("Vetiver")
        Me.ListBox3.Items.Add("Peppermint")
        Me.ListBox3.Items.Add("Myrrh")
        Me.ListBox3.Items.Add("Vanilla")
        ' Build the Carrier Oils, make sure they are also in the dictionary (Notes.vb)
        Me.ListBox4.Items.Add("Coconut")
        Me.ListBox4.Items.Add("Grapeseed")
        Me.ListBox4.Items.Add("Jojoba")
        Me.ListBox4.Items.Add("Sweet almond")
        Me.ListBox4.Items.Add("Avocado")
        Me.ListBox4.Items.Add("Apricot kernel")
        Me.ListBox4.Items.Add("Argan")
        Me.ListBox4.Items.Add("Hazelnut")
        Me.ListBox4.Items.Add("Hemp seed")
        Me.ListBox4.Items.Add("Sunflower")
        Me.ListBox4.Items.Add("Olive")
        Me.ListBox4.Items.Add("Castor")
        ' Need to make sure a default oil as that is required for any recipe
        Me.ListBox4.SelectedIndex = 0
        ' Need to make sure a bottle size is selected as that is required for any recipe
        Me.ListBox5.SelectedIndex = 2
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox1.BackColor = Color.Aqua
            CheckBox1.Text = "Researching Top Note"
            ListBox1.SelectionMode = SelectionMode.One
            Me.ListBox1.ClearSelected()
        Else
            CheckBox1.BackColor = Control.DefaultBackColor
            CheckBox1.Text = "Research Top Note"
            Me.ListBox1.SelectionMode = SelectionMode.MultiExtended
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox2.BackColor = Color.Aqua
            CheckBox2.Text = "Researching Middle Note"
            ListBox2.SelectionMode = SelectionMode.One
            Me.ListBox2.ClearSelected()
        Else
            CheckBox2.BackColor = Control.DefaultBackColor
            CheckBox2.Text = "Research Middle Note"
            Me.ListBox2.SelectionMode = SelectionMode.MultiExtended
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox4.Checked = False
            CheckBox3.BackColor = Color.Aqua
            CheckBox3.Text = "Researching Base Note"
            ListBox3.SelectionMode = SelectionMode.One
            Me.ListBox3.ClearSelected()
        Else
            CheckBox3.BackColor = Control.DefaultBackColor
            CheckBox3.Text = "Research Base Note"
            Me.ListBox3.SelectionMode = SelectionMode.MultiExtended
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.BackColor = Color.Aqua
            CheckBox4.Text = "Researching Carrier Oils"
            ListBox4.SelectionMode = SelectionMode.One
            Me.ListBox4.ClearSelected()
        Else
            CheckBox4.BackColor = Control.DefaultBackColor
            CheckBox4.Text = "Research Carrier Oils"
            Me.ListBox4.SelectionMode = SelectionMode.MultiExtended
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If CheckBox1.Checked = True Then
            If ListBox1.SelectedItem <> "" Then
                Dim myResearch As New Form2
                Dim dictReturn As String = fnScentTop(ListBox1.SelectedItem)
                myResearch.Text = ListBox1.SelectedItem
                'myResearch.Text = ListBox1.SelectedItem + " Essential Oil"
                myResearch.GroupBox1.Text = ListBox1.SelectedItem + " Essential Oil"
                myResearch.TextBox1.Text = dictReturn
                myResearch.Show()
            End If
        Else
            checkProfiles()
        End If
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If CheckBox2.Checked = True Then
            If ListBox2.SelectedItem <> "" Then
                Dim myResearch As New Form2
                Dim dictReturn As String = fnScentMiddle(ListBox2.SelectedItem)
                myResearch.Text = ListBox2.SelectedItem
                myResearch.GroupBox1.Text = ListBox2.SelectedItem + " Essential Oil"
                myResearch.TextBox1.Text = dictReturn
                myResearch.Show()

            End If
        Else
            checkProfiles()
        End If
    End Sub
    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        If CheckBox3.Checked = True Then
            If ListBox3.SelectedItem <> "" Then
                Dim myResearch As New Form2
                Dim dictReturn As String = fnScentBase(ListBox3.SelectedItem)
                myResearch.Text = ListBox3.SelectedItem
                myResearch.GroupBox1.Text = ListBox3.SelectedItem + " Essential Oil"
                myResearch.TextBox1.Text = dictReturn
                myResearch.Show()
            End If
        Else
            checkProfiles()
        End If
    End Sub
    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        If CheckBox4.Checked = True Then
            If ListBox4.SelectedItem <> "" Then
                Dim myResearch As New Form2
                Dim dictReturn As String = fnCarrierOils(ListBox4.SelectedItem)
                myResearch.Text = ListBox4.SelectedItem
                myResearch.GroupBox1.Text = ListBox4.SelectedItem + " Essential Oil"
                myResearch.TextBox1.Text = dictReturn
                myResearch.Show()
            End If
        Else
            checkProfiles()
        End If
    End Sub


    'Function checkProfiles(e As List(Of String))
    Function checkProfiles()
        Dim triggerTopCitrus As Boolean = False
        Dim triggerMiddleCitrus As Boolean = False
        Dim triggerBaseCitrus As Boolean = False
        Dim triggerTopFloral As Boolean = False
        Dim triggerMiddleFloral As Boolean = False
        Dim triggerBaseFloral As Boolean = False
        Dim triggerTopHerbal As Boolean = False
        Dim triggerMiddleHerbal As Boolean = False
        Dim triggerBaseHerbal As Boolean = False
        Dim triggerTopSpicy As Boolean = False
        Dim triggerMiddleSpicy As Boolean = False
        Dim triggerBaseSpicy As Boolean = False
        Dim triggerTopWoody As Boolean = False
        Dim triggerMiddleWoody As Boolean = False
        Dim triggerBaseWoody As Boolean = False
        Dim triggerTopEffectEnergizing As Boolean = False
        Dim triggerTopEffectRelaxing As Boolean = False
        Dim triggerTopEffectCleansing As Boolean = False
        Dim triggerTopEffectGrounding As Boolean = False
        Dim triggerMiddleEffectEnergizing As Boolean = False
        Dim triggerMiddleEffectRelaxing As Boolean = False
        Dim triggerMiddleEffectCleansing As Boolean = False
        Dim triggerMiddleEffectGrounding As Boolean = False
        Dim triggerBaseEffectEnergizing As Boolean = False
        Dim triggerBaseEffectRelaxing As Boolean = False
        Dim triggerBaseEffectCleansing As Boolean = False
        Dim triggerBaseEffectGrounding As Boolean = False

        Dim checkThese As List(Of String)

        lblCitrus.BackColor = Control.DefaultBackColor
        checkThese = ListBox1.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceCitrus(word) <> "" Then lblCitrus.BackColor = Color.DodgerBlue : triggerTopCitrus = True
        Next
        checkThese = ListBox2.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceCitrus(word) <> "" Then lblCitrus.BackColor = Color.DodgerBlue : triggerMiddleCitrus = True
        Next
        checkThese = ListBox3.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceCitrus(word) <> "" Then lblCitrus.BackColor = Color.DodgerBlue : triggerBaseCitrus = True
        Next

        lblFloral.BackColor = Control.DefaultBackColor
        checkThese = ListBox1.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceFloral(word) <> "" Then lblFloral.BackColor = Color.DodgerBlue : triggerTopFloral = True
        Next
        checkThese = ListBox2.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceFloral(word) <> "" Then lblFloral.BackColor = Color.DodgerBlue : triggerMiddleFloral = True
        Next
        checkThese = ListBox3.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceFloral(word) <> "" Then lblFloral.BackColor = Color.DodgerBlue : triggerBaseFloral = True
        Next

        lblHerbal.BackColor = Control.DefaultBackColor
        checkThese = ListBox1.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceHerbal(word) <> "" Then lblHerbal.BackColor = Color.DodgerBlue : triggerTopHerbal = True
        Next
        checkThese = ListBox2.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceHerbal(word) <> "" Then lblHerbal.BackColor = Color.DodgerBlue : triggerMiddleHerbal = True
        Next
        checkThese = ListBox3.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceHerbal(word) <> "" Then lblHerbal.BackColor = Color.DodgerBlue : triggerBaseHerbal = True
        Next

        lblSpicy.BackColor = Control.DefaultBackColor
        checkThese = ListBox1.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceSpicy(word) <> "" Then lblSpicy.BackColor = Color.DodgerBlue : triggerTopSpicy = True
        Next
        checkThese = ListBox2.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceSpicy(word) <> "" Then lblSpicy.BackColor = Color.DodgerBlue : triggerMiddleSpicy = True
        Next
        checkThese = ListBox3.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceSpicy(word) <> "" Then lblSpicy.BackColor = Color.DodgerBlue : triggerBaseSpicy = True
        Next

        lblWoody.BackColor = Control.DefaultBackColor
        checkThese = ListBox1.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceWoody(word) <> "" Then lblWoody.BackColor = Color.DodgerBlue : triggerTopWoody = True
        Next
        checkThese = ListBox2.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceWoody(word) <> "" Then lblWoody.BackColor = Color.DodgerBlue : triggerMiddleWoody = True
        Next
        checkThese = ListBox3.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnFragranceWoody(word) <> "" Then lblWoody.BackColor = Color.DodgerBlue : triggerBaseWoody = True
        Next

        lblEnergizing.BackColor = Control.DefaultBackColor
        checkThese = ListBox1.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeEnergizing(word) <> "" Then lblEnergizing.BackColor = Color.DodgerBlue : triggerTopEffectEnergizing = True
        Next
        checkThese = ListBox2.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeEnergizing(word) <> "" Then lblEnergizing.BackColor = Color.DodgerBlue : triggerMiddleEffectEnergizing = True
        Next
        checkThese = ListBox3.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeEnergizing(word) <> "" Then lblEnergizing.BackColor = Color.DodgerBlue : triggerBaseEffectEnergizing = True
        Next

        lblRelaxing.BackColor = Control.DefaultBackColor
        checkThese = ListBox1.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeRelaxing(word) <> "" Then lblRelaxing.BackColor = Color.DodgerBlue : triggerMiddleEffectRelaxing = True
        Next
        checkThese = ListBox2.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeRelaxing(word) <> "" Then lblRelaxing.BackColor = Color.DodgerBlue : triggerMiddleEffectRelaxing = True
        Next
        checkThese = ListBox3.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeRelaxing(word) <> "" Then lblRelaxing.BackColor = Color.DodgerBlue : triggerBaseEffectRelaxing = True
        Next

        lblCleansing.BackColor = Control.DefaultBackColor
        checkThese = ListBox1.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeCleansing(word) <> "" Then lblCleansing.BackColor = Color.DodgerBlue : triggerTopEffectCleansing = True
        Next
        checkThese = ListBox2.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeCleansing(word) <> "" Then lblCleansing.BackColor = Color.DodgerBlue : triggerMiddleEffectCleansing = True
        Next
        checkThese = ListBox3.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeCleansing(word) <> "" Then lblCleansing.BackColor = Color.DodgerBlue : triggerBaseEffectCleansing = True
        Next

        lblGrounding.BackColor = Control.DefaultBackColor
        checkThese = ListBox1.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeGrounding(word) <> "" Then lblGrounding.BackColor = Color.DodgerBlue : triggerTopEffectGrounding = True
        Next
        checkThese = ListBox2.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeGrounding(word) <> "" Then lblGrounding.BackColor = Color.DodgerBlue : triggerMiddleEffectGrounding = True
        Next
        checkThese = ListBox3.SelectedItems.Cast(Of String)().ToList()
        For Each word As String In checkThese
            If fnScentModeGrounding(word) <> "" Then lblGrounding.BackColor = Color.DodgerBlue : triggerBaseEffectGrounding = True
        Next

        Dim topNotes As New List(Of String)()
        If triggerTopCitrus = True Then topNotes.Add("Citrus")
        If triggerTopFloral = True Then topNotes.Add("Floral")
        If triggerTopSpicy = True Then topNotes.Add("Spicy")
        If triggerTopHerbal = True Then topNotes.Add("Herbal")
        If triggerTopWoody = True Then topNotes.Add("Woody")

        Dim middleNotes As New List(Of String)()
        If triggerMiddleCitrus = True Then middleNotes.Add("Citrus")
        If triggerMiddleFloral = True Then middleNotes.Add("Floral")
        If triggerMiddleSpicy = True Then middleNotes.Add("Spicy")
        If triggerMiddleHerbal = True Then middleNotes.Add("Herbal")
        If triggerMiddleWoody = True Then middleNotes.Add("Woody")

        Dim baseNotes As New List(Of String)()
        If triggerBaseCitrus = True Then baseNotes.Add("Citrus")
        If triggerBaseFloral = True Then baseNotes.Add("Floral")
        If triggerBaseSpicy = True Then baseNotes.Add("Spicy")
        If triggerBaseHerbal = True Then baseNotes.Add("Herbal")
        If triggerBaseWoody = True Then baseNotes.Add("Woody")

        Dim topEffects As New List(Of String)()
        If triggerTopEffectCleansing Then topEffects.Add("Cleansing")
        If triggerTopEffectEnergizing Then topEffects.Add("Energizing")
        If triggerTopEffectRelaxing Then topEffects.Add("Relaxing")
        If triggerTopEffectGrounding Then topEffects.Add("Grounding")

        Dim middleEffects As New List(Of String)()
        If triggerMiddleEffectCleansing Then middleEffects.Add("Cleansing")
        If triggerMiddleEffectEnergizing Then middleEffects.Add("Energizing")
        If triggerMiddleEffectRelaxing Then middleEffects.Add("Relaxing")
        If triggerMiddleEffectGrounding Then middleEffects.Add("Grounding")

        Dim baseEffects As New List(Of String)()
        If triggerBaseEffectCleansing Then baseEffects.Add("Cleansing")
        If triggerBaseEffectEnergizing Then baseEffects.Add("Energizing")
        If triggerBaseEffectRelaxing Then baseEffects.Add("Relaxing")
        If triggerBaseEffectGrounding Then baseEffects.Add("Grounding")

        TopNotesBrief = "Top Notes: " + GetCommaDelimitedString(topNotes)
        MiddleNotesBrief = "Middle Notes: " + GetCommaDelimitedString(middleNotes)
        BaseNotesBrief = "Base Notes: " + GetCommaDelimitedString(baseNotes)
        TopEffectsBrief = "Top Effect: " + GetCommaDelimitedString(topEffects)
        MiddleEffectsBrief = "Middle Effects: " + GetCommaDelimitedString(middleEffects)
        BaseEffectsBrief = "Base Effects: " + GetCommaDelimitedString(baseEffects)

        Return 0
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intBottle As Integer
        Dim dilutionRatio As Double
        Dim amountPerItem As Double
        Dim checkThese As List(Of String)
        Dim selectedBottleSize As String = ListBox5.SelectedItem
        Dim QTopNotes As Boolean = False
        Dim QMidNotes As Boolean = False
        Dim QBasNotes As Boolean = False

        TextBox1.Text = ""

        'If selectedBottleSize = "15ml" Then intBottle = 15
        'If selectedBottleSize = "30ml" Then intBottle = 30
        'If selectedBottleSize = "60ml" Then intBottle = 60
        'If selectedBottleSize = "120ml" Then intBottle = 120

        Dim getml As String = Regex.Replace(selectedBottleSize, "[!^ml]", "")
        'MsgBox(getml)
        intBottle = Convert.ToInt32(getml)

        ' Count and do math for Carrier Oils
        Dim selectedCarrierCount As Integer = ListBox4.SelectedItems.Count

        If selectedCarrierCount <> 0 Then
            dilutionRatio = 1 - intDilutionEssentialRate
            dilutionRatio = intBottle * dilutionRatio
            amountPerItem = Math.Round(dilutionRatio / selectedCarrierCount, 0)
            checkThese = ListBox4.SelectedItems.Cast(Of String)().ToList
            TextBox1.Text = "Carrier Oils:"
            For Each word As String In checkThese
                TextBox1.Text = TextBox1.Text + vbCrLf + "• " + word + " - " + amountPerItem.ToString + "ml"
            Next

        End If

        Dim selectedTopCount As Integer = ListBox1.SelectedItems.Count
        Dim selectedMiddleCount As Integer = ListBox2.SelectedItems.Count
        Dim selectedBaseCount As Integer = ListBox3.SelectedItems.Count
        Dim tempMath As Double = 0

        Dim intTopRule As Double = intTopRulePublic
        Dim intMidRule As Double = intMidRulePublic
        Dim intBasRule As Double = intBasRulePublic


        'if there is no top notes 
        If selectedTopCount = 0 And selectedMiddleCount <> 0 And selectedBaseCount <> 0 Then
            tempMath = intTopRule / 2
            intMidRule = intMidRule + tempMath
            intBasRule = intBasRule + tempMath
            intTopRule = 0
            'MsgBox("Top Count: " + selectedTopCount.ToString + "Mid Count: " + selectedMiddleCount.ToString + "Base Count: " + selectedBaseCount.ToString + vbCrLf + "Top: " + intTopRule.ToString + " Middle: " + intMidRule.ToString + " Base: " + intBasRule.ToString + vbCrLf + "TempMath: " + tempMath.ToString)
        End If
        'If if there is no middle notes
        If selectedTopCount <> 0 And selectedMiddleCount = 0 And selectedBaseCount <> 0 Then
            tempMath = intMidRule / 2
            intMidRule = 0.0
            intTopRule = intTopRule + tempMath
            intBasRule = intBasRule + tempMath
            'MsgBox("Top Count: " + selectedTopCount.ToString + "Mid Count: " + selectedMiddleCount.ToString + "Base Count: " + selectedBaseCount.ToString + vbCrLf + "Top: " + intTopRule.ToString + " Middle: " + intMidRule.ToString + " Base: " + intBasRule.ToString + vbCrLf + "TempMath: " + tempMath.ToString)
        End If
        ' if there is no base notes
        If selectedTopCount <> 0 And selectedMiddleCount <> 0 And selectedBaseCount = 0 Then
            tempMath = intBasRule / 2
            intBasRule = 0.0
            intTopRule = intTopRule + tempMath
            intMidRule = intMidRule + tempMath
            'MsgBox("Top Count: " + selectedTopCount.ToString + "Mid Count: " + selectedMiddleCount.ToString + "Base Count: " + selectedBaseCount.ToString + vbCrLf + "Top: " + intTopRule.ToString + " Middle: " + intMidRule.ToString + " Base: " + intBasRule.ToString + vbCrLf + "TempMath: " + tempMath.ToString)
        End If

        ' if no middle or base notes
        If selectedTopCount <> 0 And selectedMiddleCount = 0 And selectedBaseCount = 0 Then
            tempMath = intMidRule + intBasRule
            intMidRule = 0
            intBasRule = 0
            intTopRule = intTopRule + tempMath
            'MsgBox("Top Count: " + selectedTopCount.ToString + "Mid Count: " + selectedMiddleCount.ToString + "Base Count: " + selectedBaseCount.ToString + vbCrLf + "Top: " + intTopRule.ToString + " Middle: " + intMidRule.ToString + " Base: " + intBasRule.ToString + vbCrLf + "TempMath: " + tempMath.ToString)
        End If
        ' if no top or base notes
        If selectedTopCount = 0 And selectedMiddleCount <> 0 And selectedBaseCount = 0 Then
            tempMath = intTopRule + intBasRule
            intTopRule = 0
            intBasRule = 0
            intMidRule = intMidRule + tempMath
            'MsgBox("Top Count: " + selectedTopCount.ToString + "Mid Count: " + selectedMiddleCount.ToString + "Base Count: " + selectedBaseCount.ToString + vbCrLf + "Top: " + intTopRule.ToString + " Middle: " + intMidRule.ToString + " Base: " + intBasRule.ToString + vbCrLf + "TempMath: " + tempMath.ToString)
        End If
        'if no top or middle notes
        If selectedTopCount = 0 And selectedMiddleCount = 0 And selectedBaseCount <> 0 Then
            tempMath = intTopRule + intMidRule
            intTopRule = 0
            intMidRule = 0
            intBasRule = intBasRule + tempMath
            'MsgBox("Top Count: " + selectedTopCount.ToString + "Mid Count: " + selectedMiddleCount.ToString + "Base Count: " + selectedBaseCount.ToString + vbCrLf + "Top: " + intTopRule.ToString + " Middle: " + intMidRule.ToString + " Base: " + intBasRule.ToString + vbCrLf + "TempMath: " + tempMath.ToString)
        End If

        'MsgBox("Top Count: " + selectedTopCount.ToString + " Mid Count: " + selectedMiddleCount.ToString + " Base Count: " + selectedBaseCount.ToString + vbCrLf + "Top: " + intTopRule.ToString + " Middle: " + intMidRule.ToString + " Base: " + intBasRule.ToString)

        If selectedTopCount <> 0 Then
            dilutionRatio = (intBottle * intDilutionEssentialRate) * intTopRule
            amountPerItem = Math.Round(dilutionRatio / selectedTopCount, 1)
            checkThese = ListBox1.SelectedItems.Cast(Of String)().ToList
            TextBox1.Text = TextBox1.Text + vbCrLf + vbCrLf + "Top Scents:"
            For Each word As String In checkThese
                TextBox1.Text = TextBox1.Text + vbCrLf + "• " + word + " - " + amountPerItem.ToString + "ml"
            Next
        End If



        If selectedMiddleCount <> 0 Then
            dilutionRatio = (intBottle * intDilutionEssentialRate) * intMidRule
            amountPerItem = Math.Round(dilutionRatio / selectedMiddleCount, 1)
            checkThese = ListBox2.SelectedItems.Cast(Of String)().ToList
            TextBox1.Text = TextBox1.Text + vbCrLf + vbCrLf + "Middle Scents:"
            For Each word As String In checkThese
                TextBox1.Text = TextBox1.Text + vbCrLf + "• " + word + " - " + amountPerItem.ToString + "ml"

            Next
        End If


        If selectedBaseCount <> 0 Then
            dilutionRatio = (intBottle * intDilutionEssentialRate) * intBasRule
            amountPerItem = Math.Round(dilutionRatio / selectedBaseCount, 1)
            checkThese = ListBox3.SelectedItems.Cast(Of String)().ToList
            TextBox1.Text = TextBox1.Text + vbCrLf + vbCrLf + "Base Scents:"
            For Each word As String In checkThese
                TextBox1.Text = TextBox1.Text + vbCrLf + "• " + word + " - " + amountPerItem.ToString + "ml"
            Next
        End If

        checkProfiles()


        TextBox1.Text = TextBox1.Text + vbCrLf + vbCrLf + TopNotesBrief
        TextBox1.Text = TextBox1.Text + vbCrLf + MiddleNotesBrief
        TextBox1.Text = TextBox1.Text + vbCrLf + BaseNotesBrief
        TextBox1.Text = TextBox1.Text + vbCrLf + vbCrLf + TopEffectsBrief
        TextBox1.Text = TextBox1.Text + vbCrLf + MiddleEffectsBrief
        TextBox1.Text = TextBox1.Text + vbCrLf + BaseEffectsBrief


    End Sub

    Private Function GetCommaDelimitedString(list As List(Of String)) As String
        Dim sb As New StringBuilder()

        ' Iterate over the items in the list and append each item to the StringBuilder object, separated by a comma.
        For Each item In list
            sb.Append(item.ToString() & ",")
        Next

        ' Convert the StringBuilder object to a string and return it.

        Return sb.ToString().TrimEnd(",")
    End Function

    Private Sub lblEnergizing_Click(sender As Object, e As EventArgs) Handles lblEnergizing.Click
        Dim name As String
        name = fnScentMode("Energizing")
        MsgBox(name, Title:="Energizing")
    End Sub

    Private Sub lblRelaxing_Click(sender As Object, e As EventArgs) Handles lblRelaxing.Click
        Dim name As String
        name = fnScentMode("Relaxing")
        MsgBox(name, Title:="Relaxing")
    End Sub

    Private Sub lblCleansing_Click(sender As Object, e As EventArgs) Handles lblCleansing.Click
        Dim name As String
        name = fnScentMode("Cleansing")
        MsgBox(name, Title:="Cleansing")
    End Sub

    Private Sub lblGrounding_Click(sender As Object, e As EventArgs) Handles lblGrounding.Click
        Dim name As String
        name = fnScentMode("Grounding")
        MsgBox(name, Title:="Grounding")
    End Sub

    Private Sub lblCitrus_Click(sender As Object, e As EventArgs) Handles lblCitrus.Click
        Dim name As String
        name = fnFragrance("Citrus")
        MsgBox(name, Title:="Citrus")
    End Sub

    Private Sub lblFloral_Click(sender As Object, e As EventArgs) Handles lblFloral.Click
        Dim name As String
        name = fnFragrance("Floral")
        MsgBox(name, Title:="Floral")
    End Sub

    Private Sub lblHerbal_Click(sender As Object, e As EventArgs) Handles lblHerbal.Click
        Dim name As String
        name = fnFragrance("Herbal")
        MsgBox(name, Title:="Herbal")
    End Sub

    Private Sub lblSpicy_Click(sender As Object, e As EventArgs) Handles lblSpicy.Click
        Dim name As String
        name = fnFragrance("Spicy")
        MsgBox(name, Title:="Spicy")
    End Sub

    Private Sub lblWoody_Click(sender As Object, e As EventArgs) Handles lblWoody.Click
        Dim name As String
        name = fnFragrance("Woody")
        MsgBox(name, Title:="Woody")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim printDialog As New PrintDialog()
        Dim result As DialogResult = printDialog.ShowDialog()
        If result = DialogResult.OK Then
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Get the text from the textbox
        Dim text As String = TextBox1.Text
        ' Create a font for the text
        Dim font As New Font("Courier New", 12)
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        Else
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim text As String = TextBox1.Text
        If text <> "" Then
            Try
                Clipboard.SetText(text, TextDataFormat.Text)
            Catch ex As Exception
                'MessageBox.Show(ex.Message)
            End Try
            'MsgBox("Copied to Clipboard", Title:="Copied to Clipboard")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to reset?", MsgBoxStyle.YesNo, Title:="Save File")
        If result = DialogResult.Yes Then
            ListBox1.ClearSelected()
            ListBox2.ClearSelected()
            ListBox3.ClearSelected()
            ListBox4.ClearSelected()
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sfd.FileName = "Recipe_" + randomWord()
        sfd.Title = "Please select a file name and location"
        sfd.Filter = "Text files|*.txt|All files|*.*"
        sfd.InitialDirectory = myDocsPath
        sfd.DefaultExt = ".txt"

        ' Display the SaveFileDialog and get the result
        Dim result As DialogResult = sfd.ShowDialog()

        ' Check if the user clicked OK
        If result = DialogResult.OK Then
            ' Get the file name of the selected file
            Dim fileName As String = sfd.FileName

            ' Write the text of TextBox1 to the file
            File.WriteAllText(fileName, TextBox1.Text)
        End If
    End Sub

    Function randomWord()
        Dim rnd As New Random()

        ' Create an array or a string of characters
        Dim chars() As Char = "abcdefgxijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray()

        ' Create an empty string variable
        Dim randomString As String = ""

        ' Loop six times
        For i As Integer = 1 To 6

            ' Generate a random index for the array or the string
            Dim index As Integer = rnd.Next(0, chars.Length)

            ' Select a character based on the index
            Dim c As Char = chars(index)

            ' Append the character to the string
            randomString &= c

        Next
        Return randomString
    End Function
End Class

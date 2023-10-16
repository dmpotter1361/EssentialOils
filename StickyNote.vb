Public Class StickyNote
    Inherits UserControl

    ' Declare the controls and variables
    Private WithEvents pnlNote As Panel
    Private WithEvents lblTitle As Label
    Private WithEvents txtContent As TextBox
    Private WithEvents btnDelete As Button
    Private noteColor As Color
    Private noteTitle As String
    Private noteFile As String

    ' Create a constructor with parameters for the color, title, and file name of the note
    Public Sub New(ByVal color As Color, ByVal title As String, ByVal file As String)
        ' Initialize the controls and variables
        pnlNote = New Panel()
        lblTitle = New Label()
        txtContent = New TextBox()
        btnDelete = New Button()
        noteColor = color
        noteTitle = title
        noteFile = file
        ' Set the properties of the controls
        Me.Size = New Size(200, 200)
        Me.BackColor = Color.Transparent
        pnlNote.Size = Me.Size
        pnlNote.BackColor = noteColor
        lblTitle.AutoSize = False
        lblTitle.Size = New Size(180, 20)
        lblTitle.Location = New Point(10, 10)
        lblTitle.Text = noteTitle
        lblTitle.Font = New Font("Arial", 10, FontStyle.Bold)
        lblTitle.ForeColor = Color.Black
        txtContent.Multiline = True
        txtContent.Size = New Size(180, 150)
        txtContent.Location = New Point(10, 40)
        txtContent.Font = New Font("Arial", 10, FontStyle.Regular)
        txtContent.ForeColor = Color.Black
        btnDelete.Size = New Size(20, 20)
        btnDelete.Location = New Point(170, 10)
        btnDelete.Text = "X"
        btnDelete.Font = New Font("Arial", 10, FontStyle.Bold)
        btnDelete.ForeColor = Color.Black
        btnDelete.BackColor = Color.Red
        ' Add the controls to the user control
        pnlNote.Controls.Add(lblTitle)
        pnlNote.Controls.Add(txtContent)
        pnlNote.Controls.Add(btnDelete)
        Me.Controls.Add(pnlNote)
        ' Load the text from the file if it exists
        If System.IO.File.Exists(noteFile) Then
            Dim sr As New System.IO.StreamReader(noteFile)
            txtContent.Text = sr.ReadToEnd()
            sr.Close()
        End If
    End Sub

    ' Create a property to get or set the file name of the note
    Public Property FileName As String
        Get
            Return noteFile
        End Get
        Set(value As String)
            noteFile = value
            ' Save the text to the file when the file name is changed
            Dim sw As New System.IO.StreamWriter(noteFile)
            sw.Write(txtContent.Text)
            sw.Close()
        End Set
    End Property

    ' Create an event handler for the delete button click event
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Delete the file if it exists
        If System.IO.File.Exists(noteFile) Then
            System.IO.File.Delete(noteFile)
        End If
        ' Remove the user control from its parent container
        Me.Parent.Controls.Remove(Me)
    End Sub

End Class



Imports System.IO
Public Class FrmMyNotepad
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If (TxtEditingArea.Text <> "") Then
            Dim result As Integer = MessageBox.Show("Do you want to save text!", "Notepad", MessageBoxButtons.YesNoCancel)
            If (result = 6) Then
                SaveFile()
            ElseIf (result = 7) Then
                TxtEditingArea.Clear()
            End If
        End If
    End Sub
    Private Sub SaveFile()
        Dim sfd As New SaveFileDialog()  'created object

        If (sfd.ShowDialog() = DialogResult.OK) Then
            Dim sw As New streamwriter(sfd.FileName)
            sw.writeline(TxtEditingArea.Text)
            sw.close()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If (TxtEditingArea.Text <> "") Then
            Dim result As Integer = MessageBox.Show("Do you want to save text!", "Notepad", MessageBoxButtons.YesNoCancel)
            If (result = 6) Then
                SaveFile()
            ElseIf (result = 7) Then
                TxtEditingArea.Clear()
            End If
        End If
    End Sub
    Private Sub OpenFile()
        Dim ofd As New OpenFileDialog() 'created object

        If (ofd.ShowDialog() = DialogResult.OK) Then
            Dim sr As New StreamReader(ofd.FileName)
            TxtEditingArea.Text = sr.ReadLine()
            sr.close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If (WordWrapToolStripMenuItem.Checked) Then
            TxtEditingArea.WordWrap = True
        Else
            TxtEditingArea.WordWrap = False
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim fd As New FontDialog
        If (fd.ShowDialog() = DialogResult.OK) Then
            TxtEditingArea.Font = fd.Font
            Dim sw As New StreamWriter("Notepad.ini")
            sw.WriteLine(fd.Font)
            sw.close()
        End If
    End Sub

    Private Sub FrmMyNotepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As New StreamReader("Notepad.ini")
        Dim myfont As String = sr.ReadLine()
        sr.close()
        Dim searchchar As Char() = {"=", ","}
        Dim fonts As String() = myfont.Split(searchchar, 5)

        TxtEditingArea.Font = New Font(fonts(1), fonts(3))
    End Sub
End Class


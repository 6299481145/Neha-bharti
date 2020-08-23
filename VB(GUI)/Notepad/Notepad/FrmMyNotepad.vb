Public Class FrmMyNotepad
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If (TxtEditingArea.Text <> "") Then
            Dim result As Integer = MessageBox.Show("Do you want to save text!", "Notepad", MessageBoxButtons.YesNoCancel)
            If (result = 6) Then
                savefile()
            ElseIf (Result = 7) Then
                TxtEditingArea.Clear()
            End If
        End If
    End Sub
    Private Sub SaveFile()
        Dim sfd As New SaveFileDialog()
        sfd.ShowDialog()
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
        Dim ofd As New OpenFileDialog()
        ofd.ShowDialog()
    End Sub
End Class


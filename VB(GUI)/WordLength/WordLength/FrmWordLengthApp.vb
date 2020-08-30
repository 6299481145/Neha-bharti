Public Class FrmWordLengthApp
    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim word As String
        Dim i As Integer

        word = TxtWord.Text
        i = word.Length()

        TxtCharacter.Text = i
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtWord.Clear()
        TxtCharacter.Clear()
        TxtWord.Focus()
    End Sub
End Class

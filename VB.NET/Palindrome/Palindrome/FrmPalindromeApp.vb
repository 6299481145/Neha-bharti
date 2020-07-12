Public Class FrmPalindromeApp
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtWord.Clear()
        TxtPalindrome.Clear()
        TxtWord.Focus()
    End Sub
End Class

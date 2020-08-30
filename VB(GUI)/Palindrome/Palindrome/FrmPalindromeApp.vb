Public Class FrmPalindromeApp
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Dim n, temp, r, rev As Integer
        rev = 0
        n = TxtNumber.Text
        temp = n

        While (temp > 0)
            r = temp Mod 10
            rev = (rev * 10) + r
            temp = temp / 10
        End While

        If n = rev Then
            TxtPalindrome.Text = "Yes"
        Else
            TxtPalindrome.Text = "Not "
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtNumber.Clear()
        TxtPalindrome.Clear()
        TxtNumber.Focus()
    End Sub
End Class

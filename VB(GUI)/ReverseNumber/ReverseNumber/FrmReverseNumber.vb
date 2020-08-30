Public Class FrmReverseNumber
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        Dim n, r, rev As Integer

        n = TxtNumber.Text
        While (n > 0)
            r = n Mod 10
            rev = (rev * 10) + r
            n = n / 10
        End While
        TxtReverse.Text = rev
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtNumber.Clear()
        TxtReverse.Clear()
        TxtNumber.Focus()
    End Sub
End Class

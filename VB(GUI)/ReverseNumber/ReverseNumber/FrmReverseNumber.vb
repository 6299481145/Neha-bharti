Public Class FrmReverseNumber
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        Dim n, temp, r, rev As Integer
        rev = 0
        n = TxtNumber.Text
        temp = n

        While (temp > 0)
            r = temp Mod 10
            rev = (rev * 10) + r
            temp = temp \ 10
        End While
        TxtReverse.Text = rev
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtNumber.Clear()
        TxtReverse.Clear()
        TxtNumber.Focus()
    End Sub
End Class

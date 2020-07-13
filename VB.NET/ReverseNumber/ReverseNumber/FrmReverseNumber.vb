Public Class FrmReverseNumber
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        Dim n, r As Integer
        n = TxtNumber.Text
        While (r > 1)
            r = n Mod 10
            n = n / 10
        End While
        TxtReverse.Text = ("")
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtNumber.Clear()
        TxtReverse.Clear()
        TxtNumber.Focus()
    End Sub
End Class

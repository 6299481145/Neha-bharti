Public Class FrmSimpleInterest
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim P, R, T, SI As Integer

        P = TxtPrincipal.Text
        R = TxtRate.Text
        T = TxtTime.Text
        SI = (P * R * T) / 100
        TxtInterest.Text = SI
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtPrincipal.Clear()
        TxtRate.Clear()
        TxtTime.Clear()
        TxtInterest.Clear()
        TxtPrincipal.Focus()
    End Sub
End Class

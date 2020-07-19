Public Class FrmDivisionApp
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtDividend.TextChanged

    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        Dim De, Di, Q, R As Integer
        De = TxtDividend.Text
        Di = TxtDivisior.Text

        Q = De / Di
        TxtQuotient.Text = Q
        R = De Mod Di
        TxtRemainder.Text = R

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtDividend.Clear()
        TxtDivisior.Clear()
        TxtQuotient.Clear()
        TxtRemainder.Clear()
        TxtDividend.Focus()
    End Sub
End Class

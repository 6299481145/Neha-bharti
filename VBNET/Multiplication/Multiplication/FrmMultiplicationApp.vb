Public Class FrmMultiplicationApp
    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        Dim F1, F2, P As Integer
        F1 = TxtFactor1.Text
        F2 = TxtFactor2.Text
        P = F1 * F2
        TxtProduct.Text = P
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtFactor1.Clear()
        TxtFactor2.Clear()
        TxtProduct.Clear()
        TxtFactor1.Focus()
    End Sub
End Class

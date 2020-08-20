Public Class FrmSqureRoot
    Private Sub BtnSqure_Click(sender As Object, e As EventArgs) Handles BtnSqure.Click
        Dim a, b As Double
        a = TxtNumber.Text
        b = a ^ 2
        TxtResult.Text = b
    End Sub

    Private Sub BtnSqureRoot_Click(sender As Object, e As EventArgs) Handles BtnSqureRoot.Click
        Dim a, b As Double
        a = TxtNumber.Text
        b = a ^ (1 / 2)
        TxtResult.Text = b
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtNumber.Clear()
        TxtResult.Clear()
        TxtNumber.Focus()
    End Sub
End Class

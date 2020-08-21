Public Class FrmCubeRoot
    Private Sub BtnCube_Click(sender As Object, e As EventArgs) Handles BtnCube.Click
        Dim a, b As Integer
        a = TxtNumber.Text
        b = a ^ 3
        TxtResult.Text = b
    End Sub

    Private Sub BtnCubeRoot_Click(sender As Object, e As EventArgs) Handles BtnCubeRoot.Click
        Dim a, b As Integer
        a = TxtNumber.Text
        b = a ^ (1 / 3)
        TxtResult.Text = b
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtNumber.Clear()
        TxtResult.Clear()
        TxtNumber.Focus()
    End Sub
End Class

Public Class FrmRectangleAreaApp
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim l, b, a As Integer
        l = TxtLength.Text
        b = TxtBreath.Text
        a = l * b
        TxtArea.Text = a
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtLength.Clear()
        TxtBreath.Clear()
        TxtArea.Clear()
        TxtLength.Focus()
    End Sub
End Class

Public Class FrmFactorial
    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        Dim n, i As Integer
        Dim F As Integer
        F = 1

        n = TxtNumber.Text
        For i = n To 1 Step -1
            F = F * i
        Next
        TxtFactorial.Text = F

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtNumber.Clear()
        TxtFactorial.Clear()
        TxtNumber.Focus()
    End Sub
End Class

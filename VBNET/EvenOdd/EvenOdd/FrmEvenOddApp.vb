Public Class FrmEvenOddApp
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Dim n As Integer
        n = TxtNumber.Text
        If (n Mod 2 = 0) Then
            TxtEvenOdd.Text = ("Even")
        Else
            TxtEvenOdd.Text = (" Odd")
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtNumber.Clear()
        TxtEvenOdd.Clear()
        TxtNumber.Focus()
    End Sub
End Class

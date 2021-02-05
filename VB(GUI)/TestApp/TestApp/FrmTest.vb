Public Class FrmTest
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Dim num As Integer
        Dim res As Integer

        num = TxtNumber.Text
        TxtResult.Text = res

        If num > 0 Then
            TxtResult.Text = ("Positive Number `")
        Else
            TxtResult.Text = ("Negative Number")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtNumber.Clear()
        TxtResult.Clear()
        TxtNumber.Focus()
    End Sub
End Class

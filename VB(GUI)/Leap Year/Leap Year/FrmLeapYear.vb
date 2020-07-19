Public Class Form1
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Dim yr As Integer
        yr = TxtYear.Text

        If (yr Mod 400 = 0) Then
            TxtShow.Text = ("Leap Year")
        Else
            TxtShow.Text = ("Common Year")
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtYear.Clear()
        TxtShow.Clear()
        TxtYear.Focus()
    End Sub
End Class

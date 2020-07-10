Public Class FrmEvenOddApp
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim n As Integer
        n = TxtNumber.Text
        If (n Mod 2 = 0) Then
            MsgBox(n & "is Even")
        Else
            MsgBox(n & "is Odd")
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtNumber.Clear()
        TxtNumber.Focus()
    End Sub
End Class

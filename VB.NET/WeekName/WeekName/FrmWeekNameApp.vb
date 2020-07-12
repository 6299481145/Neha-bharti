Public Class FrmWeekNameApp
    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim n As Integer
        n = TxtNumber.Text
        Select Case n
            Case 1
                TxtName.Text = ("Sunday")
            Case 2
                TxtName.Text = ("Monday")
            Case 3
                TxtName.Text = ("Tuesday")
            Case 4
                TxtName.Text = ("Wednesday")
            Case 5
                TxtName.Text = ("Thrusday")
            Case 6
                TxtName.Text = ("Friday")
            Case 7
                TxtName.Text = ("Saturday")
            Case Else
                TxtName.Text = ("Invalid Value")
        End Select

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtNumber.Clear()
        TxtName.Clear()
        TxtNumber.Focus()

    End Sub
End Class

Public Class FrmSubtractionApp
    Private Sub BtnSub_Click(sender As Object, e As EventArgs) Handles BtnSub.Click
        Dim a, b, c As Integer
        a = TxtSubtrahend.Text
        b = TxtMinuend.Text
        c = a - b
        TxtDifference.Text = c
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtSubtrahend.Clear()
        TxtMinuend.Clear()
        TxtDifference.Clear()
        TxtSubtrahend.Focus()
    End Sub
End Class

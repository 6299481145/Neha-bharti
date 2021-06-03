Public Class Form1
    Dim sr As Integer = 1
    Dim bp As Integer = 1
    Private Sub BtnSR_Click(sender As Object, e As EventArgs) Handles BtnSR.Click

        PpdCommon.Document = PrdSR
        If (PpdCommon.ShowDialog() = 1) Then

        End If
        sr += 1
        If (sr < 10) Then
            BtnSR.Text = "SR00" & sr
        ElseIf (sr < 100) Then
            BtnSR.Text = "SR0" & sr
        Else
            BtnSR.Text = "SR" & sr
        End If
    End Sub

    Private Sub PrdSR_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrdSR.PrintPage
        e.Graphics.DrawString("Counter # 2", New Font("Arial", 14), Brushes.Black, New Point(50, 30))
        e.Graphics.DrawString("BtnSR.text", New Font("Arial", 20), Brushes.Black, New Point(50, 70))
        e.Graphics.DrawString(Today.Date, New Font("Arial", 12), Brushes.Black, New Point(50, 120))
        e.Graphics.DrawRectangle(Pens.Black, 20, 20, 200, 150)
    End Sub

    Private Sub BtnBP_Click(sender As Object, e As EventArgs) Handles BtnBP.Click
        PpdCommon.Document = PrdBP
        If (PpdCommon.ShowDialog() = 1) Then

        End If

        bp += 1
        If (bp < 10) Then
            BtnBP.Text = "BP00" & bp
        ElseIf (bp < 100) Then
            BtnBP.Text = "BP0" & bp
        Else
            BtnBP.Text = "BP" & bp

        End If
    End Sub

    Private Sub PrdBP_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrdBP.PrintPage
        e.Graphics.DrawString("Counter # 3", New Font("Arial", 14), Brushes.Black, New Point(50, 30))
        e.Graphics.DrawString("BtnBP.text", New Font("Arial", 20), Brushes.Black, New Point(50, 70))
        e.Graphics.DrawString(Today.Date, New Font("Arial", 12), Brushes.Black, New Point(50, 120))
        e.Graphics.DrawRectangle(Pens.Black, 20, 20, 200, 150)
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click

    End Sub
End Class

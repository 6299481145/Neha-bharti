Public Class FrmEMICalculator
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim p, r, t, emi, iemi, pemi, ob, cb As Single

        p = TxtPrinciple.Text
        r = TxtInterestRate.Text
        t = TxtTenure.Text

        emi = Math.Round(Pmt(r / 100 / 12, t * 12, -p), 2)

        LblEMI.Text = emi

        LblTotalPrinciple.Text = TxtPrinciple.Text
        LblTotalPaybleAmount.Text = emi * t * 12
        LblTotalInterest.Text = LblTotalPaybleAmount.Text - TxtPrinciple.Text


        '..............Working with datagridview.................
        ob = p
        For i As Integer = 0 To t * 12 - 1
            DgvAmortizationSchedule.Rows.Add()   'Adding rows to datagridview
            DgvAmortizationSchedule.Item("Month", i).Value = i + 1 'Assigining value to Month column
            DgvAmortizationSchedule.Item("OpeningBalance", i).Value = ob
            DgvAmortizationSchedule.Item("Emi12", i).Value = emi
            iemi = Math.Round(IPmt(r / 100 / 12, i + 1, t * 12, -p), 2)
            DgvAmortizationSchedule.Item("InterestPaid", i).Value = iemi
            'pemi = PPmt(r / 100 / 12, i + 1, t * 12, -p)

            pemi = Math.Round(emi - iemi, 2)
            DgvAmortizationSchedule.Item("PrincipalPaid", i).Value = pemi
            cb = Math.Round(ob - pemi, 2)
            DgvAmortizationSchedule.Item("closingBalance", i).Value = cb
            ob = cb
        Next
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtPrinciple.Clear()
        TxtTenure.Clear()
        TxtInterestRate.Clear()


    End Sub
End Class

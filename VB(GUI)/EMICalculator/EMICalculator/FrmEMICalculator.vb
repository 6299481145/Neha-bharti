Public Class FrmEMICalculator
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim p, r, t, emi As Single

        p = TxtPrinciple.Text
        r = TxtInterestRate.Text
        t = TxtTenure.Text

        emi = Pmt(r / 100 / 12, t * 12, -p)

        LblEMI.Text = emi
        'LblTotalPrinciple.Text = TxtTotalPrinciple.Text
        LblTotalPaybleAmount.Text = emi * t * 12
        'LblTotalInterest.Text = LblTotalPaybleAmount.Text - TxtTotalPrinciple.Text
    End Sub
End Class

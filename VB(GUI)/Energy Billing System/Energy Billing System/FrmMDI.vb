Public Class FrmMDI
    Private Sub NewConsumerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewConsumerToolStripMenuItem.Click
        FrmNewConsumer.Show()
    End Sub

    Private Sub TarrifEnergyChargeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarrifEnergyChargeToolStripMenuItem.Click
        FrmTariffEnergyCharge.Show()
    End Sub

    Private Sub BillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillToolStripMenuItem.Click
        FrmBill.Show()
    End Sub

    Private Sub TariffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TariffToolStripMenuItem.Click
        FrmTariff.Show()
    End Sub
End Class

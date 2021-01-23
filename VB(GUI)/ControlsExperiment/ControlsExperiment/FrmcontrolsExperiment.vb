Public Class FrmcontrolsExperiment
    Private Sub LlbClickMe_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlbClickMe.LinkClicked
        MessageBox.Show("Great you have Clicked me!")
    End Sub

    Private Sub LlbClickMe_MouseHover(sender As Object, e As EventArgs) Handles LlbClickMe.MouseHover
        LlbClickMe.LinkColor = Color.Gray
    End Sub

    Private Sub LlbClickMe_MouseMove(sender As Object, e As MouseEventArgs) Handles LlbClickMe.MouseMove
        LlbClickMe.LinkColor = Color.Blue
    End Sub


    Private Sub LstNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstNames.SelectedIndexChanged
        TxtName.Text = LstNames.SelectedItem
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LstNames.Items.Add("Svati Shingh")
        LstNames.Items.Add("Astha Priya")
    End Sub
End Class

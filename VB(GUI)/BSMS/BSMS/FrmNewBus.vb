Imports Mysql.Data.Mysqlclient
Public Class FrmNewBus
    'Dim mysqlcon As New MysqlConnection("server=localhost; Database=BSMS; uid=Neha; pwd=Neha")
    'Dim mysqlcmd As New Mysqlcommand()
    'Dim mysqlDa As New MysqlDataAdapter()
    Dim ds As New DataSet()
    Dim dr As DataRow

    Private Sub FrmNewBus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain         'Setting this form a chid of frmMain

        TxtDateAdded.Text = Today.Date 'Setting current date to TxtDateAdded

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        mysqlcon.open
        mysqlcmd.connection = mysqlcon
        mysqlcmd.commandText = "Select *from Bus"
        mysqlDa.selectCommand = mysqlcmd
        mysqlDa.fill(ds, "Bus")
        dr = ds.Tables("Bus").NewRow
        dr("RegistrationNo") = TxtRegistrationNumber.Text
        dr("Make") = CboMake.Text
        dr("Model") = CboModel.Text
        ds.Tables("Bus").Rows.Add(dr)
        mysqlDa.Update(ds, "Bus")
        mysqlcon.close

        MessageBox.Show("Bus record create Successfully")
    End Sub
End Class
Imports Mysql.Data.Mysqlclient
Public Class FrmNewBus
    Dim mysqlcon As New MySqlConnection("server=localhost; Database=BSMS; uid=Neha; pwd=Neha")
    Dim mysqlcmd As New MySqlCommand()
    Dim mysqlDa As New MySqlDataAdapter()
    Dim ds As New DataSet()
    Dim dr As DataRow
    Dim mysqlDr As MySqlDataReader
    Dim mysqlcb As New MySqlCommandBuilder(mysqlDa)


    Private Sub FrmNewBus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain         'Setting this form a chid of frmMain

        TxtDateAdded.Text = Today.Date 'Setting current date to TxtDateAdded


        '-----------------------Populating CboMake ------------------------
        mysqlcon.Open()
        mysqlcmd.Connection = mysqlcon
        mysqlcmd.CommandText = "SELECT Make from Make"
        mysqlDr = mysqlcmd.ExecuteReader()
        While (mysqlDr.Read())
            CboMake.Items.Add(mysqlDr("Make"))
        End While
        mysqlDr.close()
        mysqlcon.Close()

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        mysqlcon.Open()
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

    Private Sub CboMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMake.SelectedIndexChanged
        '-----------------------Populating CboModel ------------------------
        CboModel.Items.Clear()
        mysqlcon.Open()
        mysqlcmd.Connection = mysqlcon
        mysqlcmd.CommandText = "SELECT Model from Model where Make ='" & CboMake.Text & "'"
        mysqlDr = mysqlcmd.ExecuteReader()
        While (mysqlDr.Read())
            CboModel.Items.Add(mysqlDr("Model"))
        End While
        mysqlDr.Close()
        mysqlcon.Close()
    End Sub
End Class
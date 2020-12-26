Imports MySql.Data.MySqlClient
Public Class FrmMain
    Dim con As New MySqlConnection("Server = localhost; Database = School; Uid= Neha Bharti; Pwd=Neha@1210")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        MessageBox.Show("connection Successful")
        con.Close()
    End Sub
End Class

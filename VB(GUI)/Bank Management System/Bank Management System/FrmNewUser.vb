Imports System.Data.SQLite
Public Class FrmNewUser


    Private Sub FrmNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SQLiteConnection("Data source = C:\SQLite\mydb.db;Version=3;")
        Dim cmd As New SQLiteCommand()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Insert Into User values('U003','Tanishka' ,'Bharti','Kumari','F','2002-5-14','9658435654') "
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data Inserted successfully!")

    End Sub   ' Dim dr As New SQLiteDataReader()

    '    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

    '    End Sub

    '    Private Sub FrmNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Me.MdiParent = FrmMain
    '        TxtDateOfAppointment.Text = Today.Date()
    '    End Sub

    '    Private Sub GenerateUserId()
    '        con.Open()
    '        cmd.Connection = con
    '        cmd.CommandText = "SELECT user_id FROM User"
    '        dr = cmd.ExecuteReader()
    '        While (dr.Read())
    '            TxtUserId.Text = dr("User_id")
    '        End While
    '        dr.Close()
    '        con.Close()

    '        TxtUserId.Text = TxtUserId.Text.Substring(1)

    '        TxtUserId.Text += 1

    '        If (TxtUserId.Text < 10) Then
    '            TxtUserId.Text = "U00" & TxtUserId.Text
    '        ElseIf (TxtUserId.Text < 100) Then
    '            TxtUserId.Text = "U0" & TxtUserId.Text
    '        ElseIf (TxtUserId.Text < 1000) Then
    '            TxtUserId.Text = "U" & TxtUserId.Text
    '        End If
    '    End Sub

    '    Private Sub Resetform()

    '    End Sub

    '    Private Sub TxtUserId_TextChanged(sender As Object, e As EventArgs) Handles TxtUserId.TextChanged

    '    End Sub
End Class
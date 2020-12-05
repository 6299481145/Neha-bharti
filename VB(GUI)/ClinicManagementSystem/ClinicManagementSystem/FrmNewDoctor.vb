Imports System.IO
Imports System.Data.SqlClient
Public Class FrmNewDoctor
    Dim con As New SqlConnection("Server=(localdb)\mssqllocaldb;Database=Clinic")
    Dim cmd As New SqlCommand()
    Dim dr As SqlDataReader
    Private Sub FrmNewDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMDI

        TxtDateOfJoining.Text = Today.Date()

        '...Populating specialization combobox
        CboSpecialization.Items.Add("General Physician")
        CboSpecialization.Items.Add("Opthomologist")
        CboSpecialization.Items.Add("cardiologist")

        GenerateDoctorId()


    End Sub

    Private Sub GenerateDoctorId()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT doctor_id FROM Doctor"
        dr = cmd.ExecuteReader()
        While (dr.Read())
            TxtDoctorId.Text = dr("doctor_id")
        End While
        dr.Close()
        con.Close()

        TxtDoctorId.Text = TxtDoctorId.Text.Substring(1)

        TxtDoctorId.Text += 1

        If (TxtDoctorId.Text < 10) Then
            TxtDoctorId.Text = "D00" & TxtDoctorId.Text
        ElseIf (TxtdoctorId.Text < 100) Then
            TxtDoctorId.Text = "D0" & TxtDoctorId.Text
        ElseIf (TxtdoctorId.Text < 1000) Then
            TxtDoctorId.Text = "D" & TxtDoctorId.Text
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub LlbBrower_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlbBrower.LinkClicked
        Dim ofd As New OpenFileDialog()
        ofd.ShowDialog()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim g As String
        If (RdbMale.Checked) Then
            g = "M"
        Else
            g = "F"
        End If

        con.Open()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Doctor VALUES('" & TxtDoctorId.Text & "','" & TxtName.Text & "','" & g & "','" & DtpDateOfBirth.Value.Date & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data inserted successfully!")
        ResetForm()
    End Sub

    Private Sub TxtDoctorId_TextChanged(sender As Object, e As EventArgs) Handles TxtDoctorId.TextChanged

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        GenerateDoctorId()
        TxtDateOfJoining.Text = Today.Date
        TxtName.Clear()
        RdbMale.Checked = True
        DtpDateOfBirth.Value = Today.Date

        TxtName.Focus()

    End Sub

    Private Sub TxtDateOfJoining_TextChanged(sender As Object, e As EventArgs) Handles TxtDateOfJoining.TextChanged

    End Sub

    Private Sub DtpDateOfBirth_ValueChanged(sender As Object, e As EventArgs) Handles DtpDateOfBirth.ValueChanged

    End Sub
End Class
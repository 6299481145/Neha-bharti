﻿Imports System.IO
Public Class FrmMyNotepad
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If (TxtEditingArea.Text <> "") Then
            If (Me.Text.Substring(0, 1) = "*") Then
                Dim result As Integer = MessageBox.Show("Do you want to save text!", "Notepad", MessageBoxButtons.YesNoCancel)
                If (result = 6) Then
                    SaveFile()
                ElseIf (result = 7) Then
                    TxtEditingArea.Clear()
                End If
            Else
                TxtEditingArea.Clear()
            End If
        End If
    End Sub
    Private Sub SaveFile()
        Dim sfd As New SaveFileDialog()  'created object

        If (sfd.ShowDialog() = DialogResult.OK) Then
            Dim sw As New streamwriter(sfd.FileName)
            sw.writeline(TxtEditingArea.Text)
            sw.close()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If (TxtEditingArea.Text <> "") Then
            Dim result As Integer = MessageBox.Show("Do you want to save text!", "Notepad", MessageBoxButtons.YesNoCancel)
            If (result = 6) Then
                SaveFile()
            ElseIf (result = 7) Then
                TxtEditingArea.Clear()
            End If
        Else
            OpenFile()
        End If
    End Sub
    Private Sub OpenFile()
        Dim ofd As New OpenFileDialog() 'created object

        If (ofd.ShowDialog() = DialogResult.OK) Then
            Dim sr As New StreamReader(ofd.FileName)
            TxtEditingArea.Text = sr.ReadLine()
            Me.Text = ofd.FileName
            sr.close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If (WordWrapToolStripMenuItem.Checked) Then
            TxtEditingArea.WordWrap = True
        Else
            TxtEditingArea.WordWrap = False
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim fd As New FontDialog
        If (fd.ShowDialog() = DialogResult.OK) Then
            TxtEditingArea.Font = fd.Font
            Dim sw As New StreamWriter("Notepad.ini")
            sw.WriteLine(fd.Font)
            sw.close()
        End If
    End Sub

    Private Sub FrmMyNotepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As New StreamReader("Notepad.ini")
        Dim myfont As String = sr.ReadLine()
        sr.close()
        Dim searchchar As Char() = {"=", ","}
        Dim fonts As String() = myfont.Split(searchchar, 5)

        TxtEditingArea.Font = New Font(fonts(1), fonts(3))
    End Sub

    Private Sub TxtEditingArea_TextChanged(sender As Object, e As EventArgs) Handles TxtEditingArea.TextChanged
        Me.Text = "*" & Me.Text
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TxtEditingArea.Undo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TxtEditingArea.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TxtEditingArea.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TxtEditingArea.Paste()
    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click

        TxtEditingArea.Text() = Now()
        'TxtEditingArea.Text() = Today.Date()


    End Sub
End Class


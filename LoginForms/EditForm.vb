﻿
Imports MySql.Data.MySqlClient


Public Class EditForm

    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim myset As DataSet

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123qwe!@#QWE; database=login_db; port=3306; SslMode=None"
        dob.Format = DateTimePickerFormat.Custom
        dob.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        MainForm.Show()
        MainForm.loaddata()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then

                If studname.Text = "" Or studsection.Text = "" Or dob.Text = "" Or studnum.Text = "" Then
                    MsgBox("Fill-out all fields")
                Else
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = "UPDATE tblstudent SET name='" & studname.Text & "', section='" & studsection.Text & "'" & ", dob='" & dob.Text & "'" & " where studnum='" & studnum.Text & "'"
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()
                    MsgBox("Updated Successfully")
                End If
            End If
                mycon.Close()
        Catch ex As Exception
            mycon.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles studnum.TextChanged

    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class EditGrades
    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim myset As DataSet
    Dim id As Integer
    Private Sub EditGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123qwe!@#QWE; database=login_db; port=3306; SslMode=None"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        MainForm.Show()
        MainForm.loaddata()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            mycon.Open()
            Dim query, query2, query3 As String

            query = "Select * from tblgrades where studnum ='" & studnum.Text & "'"
            command = New MySqlCommand(query, mycon)
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                mycon.Close()
                mycon.Open()
                query2 = "update tblgrades SET average='" & average.Text & "', remarks = '" & remarks.Text & "'" & "where studnum='" & studnum.Text & "'"
                command = New MySqlCommand(query2, mycon)
                reader = command.ExecuteReader
            Else
                mycon.Close()
                mycon.Open()
                query3 = "insert into tblgrades SET studnum='" & studnum.Text & ", average ='" & average.Text & "', remarks='" & remarks.Text & "'"
                command = New MySqlCommand(query3, mycon)
                reader = command.ExecuteReader
            End If
            MsgBox("Records Added")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Dispose()
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles studnum.TextChanged

    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class EditGrades
    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim myset As DataSet

    Private Sub EditGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123qwe!@#QWE; database=login_db; port=3306; SslMode=None"
        remarks.Format = DateTimePickerFormat.Custom
        remarks.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        RecordsForm.Show()
        RecordsForm.loaddata()
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            mycon.Open()
            Dim query, query2, query3 As String

            query = "Select * from profile where id ='" & id.Text & "'"
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
                query2 = "update profile SET phone_number='" & average.Text & "', signed_date = '" & remarks.Text & "'" & "where id='" & id.Text & "'"
                command = New MySqlCommand(query2, mycon)
                reader = command.ExecuteReader
            Else
                mycon.Close()
                mycon.Open()
                query3 = "insert into profile SET studnum='" & id.Text & ", phone_number ='" & average.Text & "', signed_date='" & remarks.Text & "'"
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

End Class
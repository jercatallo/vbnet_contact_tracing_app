Imports MySql.Data.MySqlClient

Public Class AddUserForm
    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim myset As DataSet
    Private Sub AddUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123qwe!@#QWE; database=login_db; port=3306; SslMode=None"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            mycon.Open()
            Dim query, query2, query3 As String

            query = "Select * from tbllogin where id ='" & id.Text & "'"
            command = New MySqlCommand(query, mycon)
            reader = command.ExecuteReader


            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                command.Dispose()
                reader.Close()
                MsgBox("Existing in the Database")
            Else
                If id.Text = "" Or username.Text = "" Or password.Text = "" Or firstname.Text = "" Or lastname.Text = "" Or level.Text = "" Then
                    MsgBox("Fill-out all fields")
                Else
                    mycon.Close()
                    mycon.Open()
                    query2 = "Insert Into tbllogin SET id='" & id.Text & "', uname = '" & username.Text & "', pword='" & password.Text & "', fname ='" & firstname.Text & "', lname='" & lastname.Text & "', level='" & level.Text & "'"
                    command = New MySqlCommand(query2, mycon)
                    reader = command.ExecuteReader
                    MsgBox("Records Added")
                End If
            End If
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()
        UsersForm.Show()
        UsersForm.loaddata()

    End Sub
End Class
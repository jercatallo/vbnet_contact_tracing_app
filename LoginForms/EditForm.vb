
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

                If studname.Text = "" Or studaddress.Text = "" Or status.Text = "" Or id.Text = "" Then
                    MsgBox("Fill-out all fields")
                Else
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = "UPDATE person SET name='" & studname.Text & "', address='" & studaddress.Text & "'" & ", status='" & status.Text & "'" & " where id='" & id.Text & "'"
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
End Class
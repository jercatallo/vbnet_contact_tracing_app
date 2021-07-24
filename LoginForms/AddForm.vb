

Imports MySql.Data.MySqlClient

Public Class AddForm

    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim myset As DataSet

    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123qwe!@#QWE; database=login_db; port=3306; SslMode=None"
        signedDate.Format = DateTimePickerFormat.Custom
        signedDate.CustomFormat = "yyyy-MM-dd"
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            mycon.Open()

            Dim query, query2, query3 As String


            If signeeName.Text = "" Or status.Text = "" Or signedDate.Text = "" Or address.Text = "" Or phoneNumber.Text = "" Then
                MsgBox("Fill-out all fields")
            Else
                query2 = "Insert Into person SET name = '" & signeeName.Text & "', address='" & address.Text & "', status='" & status.Text & "'"
                command = New MySqlCommand(query2, mycon)
                reader = command.ExecuteReader

                mycon.Close()
                mycon.Open()
                query3 = "Insert into profile SET phone_number ='" & phoneNumber.Text & "', signed_date='" & signedDate.Text & "'"
                command = New MySqlCommand(query3, mycon)
                reader = command.ExecuteReader
                MsgBox("Records Added")
            End If

            mycon.Close()
        Catch ex As Exception
            mycon.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        RecordsForm.Show()
        RecordsForm.loaddata()
        Me.Close()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        RecordsForm.Show()
        Me.Close()
    End Sub
End Class
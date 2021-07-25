
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
            If mycon.State = ConnectionState.Open Then

                If studname.Text = "" Or studaddress.Text = "" Or status.Text = "" Or id.Text = "" Or average.Text = "" Or remarks.Text = "" Then
                    addMsg.Text = "Fill-out all fields"
                    addMsg.ForeColor = ColorTranslator.FromHtml("Red")
                Else
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = "UPDATE person SET name='" & studname.Text & "', address='" & studaddress.Text & "'" & ", status='" & status.Text & "'" & " where id='" & id.Text & "'"
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()

                    mycon.Open()
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = "update profile SET phone_number='" & average.Text & "', signed_date = '" & remarks.Text & "'" & "where id='" & id.Text & "'"
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()

                    addMsg.Text = "Updated Successfully"
                    addMsg.ForeColor = ColorTranslator.FromHtml("SpringGreen")
                End If
            End If
            mycon.Close()
        Catch ex As Exception
            mycon.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutForm.Show()
        Me.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        RecordsForm.Show()
        Me.Close()
    End Sub
End Class
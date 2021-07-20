

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
        dob.Format = DateTimePickerFormat.Custom
        dob.CustomFormat = "yyyy-MM-dd"
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            mycon.Open()

            Dim query, query2, query3 As String

            query = "Select * from tblstudent where studnum ='" & stud_num.Text & "'"
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
                If stud_num.Text = "" Or stud_name.Text = "" Or stud_section.Text = "" Or dob.Text = "" Or stud_num.Text = "" Or studaverage.Text = "" Or studremarks.Text = "" Then
                    MsgBox("Fill-out all fields")
                Else
                    mycon.Close()
                    mycon.Open()
                    query2 = "Insert Into tblstudent SET studnum='" & stud_num.Text & "', name = '" & stud_name.Text & "', section='" & stud_section.Text & "', dob='" & dob.Text & "'"
                    command = New MySqlCommand(query2, mycon)
                    reader = command.ExecuteReader

                    mycon.Close()
                    mycon.Open()
                    query3 = "Insert into tblgrades SET studnum='" & stud_num.Text & "', average ='" & studaverage.Text & "', remarks='" & studremarks.Text & "'"
                    command = New MySqlCommand(query3, mycon)
                    reader = command.ExecuteReader
                    MsgBox("Records Added")
                End If
            End If
            mycon.Close()
        Catch ex As Exception
            mycon.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        MainForm.Show()
        MainForm.loaddata()
    End Sub

    Private Sub dob_ValueChanged(sender As Object, e As EventArgs) Handles dob.ValueChanged

    End Sub
End Class
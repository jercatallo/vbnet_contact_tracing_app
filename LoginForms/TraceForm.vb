Imports MySql.Data.MySqlClient
Public Class TraceForm
    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim myset As DataSet

    Private Sub TraceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123qwe!@#QWE; database=login_db; port=3306; SslMode=None"
        traceDate.Format = DateTimePickerFormat.Custom
        traceDate.CustomFormat = "yyyy-MM-dd"
        loaddata()

    End Sub
    Public Sub loaddata()
        Try
            mycon.Open()
            myadap.SelectCommand = mycon.CreateCommand
            myadap.SelectCommand.CommandText = "Select person.id, person.name, person.address, person.status, profile.phone_number, profile.signed_date from person LEFT JOIN profile ON person.id = profile.id where signed_date ='" & traceDate.Text & "'"
            myadap.SelectCommand.ExecuteReader()
            mycon.Close()
            myset = New DataSet
            myadap.Fill(myset, "1")
            DataGridView1.DataSource = myset
            DataGridView1.DataMember = "1"
            DataGridView1.Columns(0).Width = "150"
            DataGridView1.Columns(0).HeaderText = "Consignee Id"
            DataGridView1.Columns(1).HeaderText = "Name"
            DataGridView1.Columns(2).HeaderText = "Address"
            DataGridView1.Columns(3).HeaderText = "Status"
            DataGridView1.Columns(4).HeaderText = "Phone Number"
            DataGridView1.Columns(4).Width = "150"
            DataGridView1.Columns(5).HeaderText = "Date Signed"

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btnShowUsersAccount_Click(sender As Object, e As EventArgs)
        UsersForm.Show()
        Me.Close()
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        loaddata()

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        AddForm.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim ans = MsgBox("Delete this record?", vbOKCancel + vbQuestion, "Deleting")
        If ans = vbOK Then
            Try
                mycon.Open()
                Dim query2, query3 As String


                query2 = "Delete from profile where id=" & DataGridView1.CurrentRow.Cells(0).Value & ""
                command = New MySqlCommand(query2, mycon)
                reader = command.ExecuteReader

                mycon.Close()

                mycon.Open()
                query3 = "Delete from person where id=" & DataGridView1.CurrentRow.Cells(0).Value & ""
                command = New MySqlCommand(query3, mycon)
                reader = command.ExecuteReader
                mycon.Close()
                MsgBox("Records Deleted")
                loaddata()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditForm.id.Text = DataGridView1.CurrentRow.Cells(0).Value
        EditForm.studname.Text = DataGridView1.CurrentRow.Cells(1).Value
        EditForm.studaddress.Text = DataGridView1.CurrentRow.Cells(2).Value
        EditForm.status.Text = DataGridView1.CurrentRow.Cells(3).Value
        EditForm.Show()
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        RecordsForm.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutForm.Show()
        Me.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        RecordsForm.Show()
        Me.Close()
    End Sub
End Class

Imports MySql.Data.MySqlClient
Public Class MainForm
    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim myset As DataSet
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123qwe!@#QWE; database=login_db; port=3306; SslMode=None"
        loaddata()
    End Sub

    Public Sub loaddata()
        Try
            mycon.Open()
            Dim getPersonsQuery, getCasesQuery, getTodayAddedQuery, getMostActiveLocationQuery As String
            Dim personsCount, casesCountInt, todayAddedCountInt, activeLocationCountInt As Integer
            Dim activeLocationCountString As String
            getPersonsQuery = "Select * from person"
            command = New MySqlCommand(getPersonsQuery, mycon)
            reader = command.ExecuteReader


            personsCount = 0
            While reader.Read
                personsCount = personsCount + 1
            End While
            registeredCount.Text = personsCount


            mycon.Close()
            mycon.Open()

            getCasesQuery = "Select * from person where status = 'A'"
            command = New MySqlCommand(getCasesQuery, mycon)
            reader = command.ExecuteReader

            casesCountInt = 0
            While reader.Read
                casesCountInt = casesCountInt + 1
            End While
            casesCount.Text = casesCountInt


            mycon.Close()
            mycon.Open()

            getTodayAddedQuery = "select * from profile where signed_date = curdate()"
            command = New MySqlCommand(getTodayAddedQuery, mycon)
            reader = command.ExecuteReader

            todayAddedCountInt = 0
            While reader.Read
                todayAddedCountInt = todayAddedCountInt + 1
            End While
            todayAddedCount.Text = todayAddedCountInt

            mycon.Close()
            mycon.Open()

            getMostActiveLocationQuery = "SELECT *, COUNT(status) FROM login_db.person WHERE status = 'A' GROUP BY address ORDER BY COUNT(status) DESC LIMIT 1;"
            command = New MySqlCommand(getMostActiveLocationQuery, mycon)
            reader = command.ExecuteReader


            With reader
                .Read()
                activeLocationCount.Text = .Item("address")
            End With


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnShowUsersAccount_Click(sender As Object, e As EventArgs)
        UsersForm.Show()
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        loaddata()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs)
        AddForm.Show()
        Me.Close()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Show()
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        RecordsForm.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class
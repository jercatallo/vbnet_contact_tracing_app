
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
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = "Select tblstudent.studnum, tblstudent.name, tblstudent.section, tblstudent.dob, tblgrades.average, tblgrades.remarks from tblstudent LEFT JOIN tblgrades ON tblstudent.studnum = tblgrades.studnum"
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                DataGridView1.DataSource = myset
                DataGridView1.DataMember = "1"
                DataGridView1.Columns(0).HeaderText = "Student Number"
                DataGridView1.Columns(1).HeaderText = "Name"
                DataGridView1.Columns(2).HeaderText = "Section"
                DataGridView1.Columns(3).HeaderText = "Date of Birth"
                DataGridView1.Columns(4).HeaderText = "Average"
                DataGridView1.Columns(5).HeaderText = "Remarks"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        TextBox1.Text = DataGridView1.RowCount - 1
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        EditForm.studnum.Text = DataGridView1.CurrentRow.Cells(0).Value
        EditForm.studname.Text = DataGridView1.CurrentRow.Cells(1).Value
        EditForm.studsection.Text = DataGridView1.CurrentRow.Cells(2).Value
        EditForm.dob.Text = DataGridView1.CurrentRow.Cells(3).Value
        EditForm.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        Dim x = InputBox("Enter User ID", "Search")
        If String.ReferenceEquals(x, String.Empty) Then
            'User pressed cancel
        Else
            Try
                mycon.Open()
                If mycon.State = ConnectionState.Open Then
                    myadap.SelectCommand = mycon.CreateCommand
                    myadap.SelectCommand.CommandText = "SELECT * FROM tbllogin WHERE id = " & x & ""
                    myadap.SelectCommand.ExecuteReader()
                    mycon.Close()
                    myset = New DataSet
                    myadap.Fill(myset, "1")
                    DataGridView1.DataSource = myset
                    DataGridView1.DataMember = "1"
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddForm.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans = MsgBox("Delete this record?", vbOKCancel + vbQuestion, "Deleting")
        If ans = vbOK Then
            Try
                mycon.Open()
                Dim query2, query3 As String


                query2 = "Delete from tblgrades where studnum=" & DataGridView1.CurrentRow.Cells(0).Value & ""
                command = New MySqlCommand(query2, mycon)
                reader = command.ExecuteReader

                mycon.Close()

                mycon.Open()
                query3 = "Delete from tblstudent where studnum=" & DataGridView1.CurrentRow.Cells(0).Value & ""
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

    Private Sub btnEditGrades_Click(sender As Object, e As EventArgs) Handles btnEditGrades.Click

        EditGrades.studnum.Text = DataGridView1.CurrentRow.Cells(0).Value
        EditGrades.average.Text = DataGridView1.CurrentRow.Cells(4).Value
        EditGrades.remarks.Text = DataGridView1.CurrentRow.Cells(5).Value
        EditGrades.Show()
    End Sub

    Private Sub btnEditInfo_Click(sender As Object, e As EventArgs) Handles btnEditInfo.Click
        EditForm.studnum.Text = DataGridView1.CurrentRow.Cells(0).Value
        EditForm.studname.Text = DataGridView1.CurrentRow.Cells(1).Value
        EditForm.studsection.Text = DataGridView1.CurrentRow.Cells(2).Value
        EditForm.dob.Text = DataGridView1.CurrentRow.Cells(3).Value
        EditForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnShowUsersAccount_Click(sender As Object, e As EventArgs) Handles btnShowUsersAccount.Click
        UsersForm.Show()
        Me.Close()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

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


                query2 = "Delete from tblgrades where studnum=" & DataGridView1.CurrentRow.Cells(0).Value & ""
                command = New MySqlCommand(query2, mycon)
                reader = command.ExecuteReader

                mycon.Close()

                mycon.Open()
                query3 = "Delete from tblstudent where studnum=" & DataGridView1.CurrentRow.Cells(0).Value & ""
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
        EditForm.studnum.Text = DataGridView1.CurrentRow.Cells(0).Value
        EditForm.studname.Text = DataGridView1.CurrentRow.Cells(1).Value
        EditForm.studsection.Text = DataGridView1.CurrentRow.Cells(2).Value
        EditForm.dob.Text = DataGridView1.CurrentRow.Cells(3).Value
        EditForm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentD.Text = Now
    End Sub


    Private Sub currentD_Click(sender As Object, e As EventArgs) Handles currentD.Click

    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
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
End Class
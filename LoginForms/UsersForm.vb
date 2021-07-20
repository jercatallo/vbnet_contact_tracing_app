Imports MySql.Data.MySqlClient

Public Class UsersForm
    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim ex As MySqlException
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim myset As DataSet


    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123qwe!@#QWE; database=login_db; port=3306; SslMode=None"
        loaddata()
    End Sub

    Public Sub loaddata()
        Try
            mycon.Open()
            If mycon.State = ConnectionState.Open Then
                myadap.SelectCommand = mycon.CreateCommand
                myadap.SelectCommand.CommandText = "Select * from tbllogin"
                myadap.SelectCommand.ExecuteReader()
                mycon.Close()
                myset = New DataSet
                myadap.Fill(myset, "1")
                DataGridView1.DataSource = myset
                DataGridView1.DataMember = "1"
                DataGridView1.Columns(0).HeaderText = "Student Number"
                DataGridView1.Columns(1).HeaderText = "Name"
                DataGridView1.Columns(2).HeaderText = "Section"
                DataGridView1.Columns(3).HeaderText = "Average"
                DataGridView1.Columns(4).HeaderText = "Remarks"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddUserForm.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans = MsgBox("Delete this record?", vbOKCancel + vbQuestion, "Deleting")
        If ans = vbOK Then
            Try
                mycon.Open()
                Dim query2, query3 As String


                query2 = "Delete from tbllogin where id=" & DataGridView1.CurrentRow.Cells(0).Value & ""
                command = New MySqlCommand(query2, mycon)
                reader = command.ExecuteReader

                mycon.Close()

                MsgBox("Records Deleted")
                loaddata()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentD.Text = Now
    End Sub
End Class
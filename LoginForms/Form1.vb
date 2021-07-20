Imports MySql.Data.MySqlClient

Public Class Form1
    Dim mycon As New MySqlConnection
    Dim myadap As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim ex As MySqlException
    Public Property CheckBox1 As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon.ConnectionString = "server=localhost; username=root; password=123qwe!@#QWE; database=login_db; port=3306; SslMode=None"
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            mycon.Open()
            Dim query As String
            Dim myaccess As String
            Dim name As String
            query = "Select * from tbllogin where uname='" & txtuname.Text & "' and pword='" & txtpword.Text & "'"

            command = New MySqlCommand(query, mycon)
            reader = Command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then

                With reader
                    .Read()
                    myaccess = .Item("level")
                    name = .Item("fname")

                End With
                If myaccess = "3" Then
                    MainForm.btnDelete.Visible = False
                    MainForm.btnEditInfo.Visible = False
                    MainForm.btnShowUsersAccount.Visible = False
                    MainForm.DeleteToolStripMenuItem.Enabled = False
                    MainForm.EditToolStripMenuItem.Enabled = False
                    MainForm.AddToolStripMenuItem.Enabled = False

                ElseIf myaccess = "2" Then
                    MainForm.btnDelete.Visible = False
                    MainForm.btnShowUsersAccount.Visible = False
                    MainForm.DeleteToolStripMenuItem.Enabled = False
                    MainForm.AddToolStripMenuItem.Enabled = False

                End If
                MainForm.Show()
                Me.Close()
            Else
                loginErrorMessage.Text = "Invalid Username/Password"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mycon.Close()
        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub chkpass_CheckedChanged(sender As Object, e As EventArgs) Handles chkpass.CheckedChanged
        If chkpass.Checked = True Then
            txtpword.PasswordChar = ""
        Else
            txtpword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class

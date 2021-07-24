<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.level = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lastname
        '
        Me.lastname.Location = New System.Drawing.Point(967, 464)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(155, 20)
        Me.lastname.TabIndex = 38
        '
        'firstname
        '
        Me.firstname.Location = New System.Drawing.Point(967, 431)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(155, 20)
        Me.firstname.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(877, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(877, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(876, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 24)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Add User"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1048, 551)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 33
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(967, 551)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(967, 396)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(155, 20)
        Me.password.TabIndex = 31
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(967, 363)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(155, 20)
        Me.username.TabIndex = 30
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(967, 330)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(155, 20)
        Me.id.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(877, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(877, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(877, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Admin Id"
        '
        'level
        '
        Me.level.Location = New System.Drawing.Point(966, 494)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(155, 20)
        Me.level.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(876, 497)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Access Level"
        '
        'AddUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 667)
        Me.Controls.Add(Me.level)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddUserForm"
        Me.Text = "AddUserForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lastname As TextBox
    Friend WithEvents firstname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents level As TextBox
    Public WithEvents Label7 As Label
End Class

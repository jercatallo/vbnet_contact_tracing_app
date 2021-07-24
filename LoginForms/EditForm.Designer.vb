<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.studname = New System.Windows.Forms.TextBox()
        Me.studaddress = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.TextBox()
        Me.remarks = New System.Windows.Forms.DateTimePicker()
        Me.average = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnTrace = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(279, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.Label2.Location = New System.Drawing.Point(279, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address"
        '
        'studname
        '
        Me.studname.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!)
        Me.studname.Location = New System.Drawing.Point(283, 188)
        Me.studname.Name = "studname"
        Me.studname.Size = New System.Drawing.Size(253, 40)
        Me.studname.TabIndex = 4
        '
        'studaddress
        '
        Me.studaddress.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!)
        Me.studaddress.Location = New System.Drawing.Point(283, 267)
        Me.studaddress.Name = "studaddress"
        Me.studaddress.Size = New System.Drawing.Size(252, 40)
        Me.studaddress.TabIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.25!)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Location = New System.Drawing.Point(284, 559)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(252, 42)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.25!)
        Me.btnClose.Location = New System.Drawing.Point(284, 607)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(252, 42)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!)
        Me.id.Location = New System.Drawing.Point(284, 113)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(253, 40)
        Me.id.TabIndex = 12
        Me.id.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.Label6.Location = New System.Drawing.Point(279, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Signee Id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.Label7.Location = New System.Drawing.Point(279, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 25)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Status"
        '
        'status
        '
        Me.status.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!)
        Me.status.Location = New System.Drawing.Point(283, 341)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(252, 40)
        Me.status.TabIndex = 30
        '
        'remarks
        '
        Me.remarks.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!)
        Me.remarks.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.remarks.Location = New System.Drawing.Point(283, 502)
        Me.remarks.MaxDate = New Date(9989, 5, 19, 0, 0, 0, 0)
        Me.remarks.Name = "remarks"
        Me.remarks.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.remarks.Size = New System.Drawing.Size(254, 40)
        Me.remarks.TabIndex = 34
        '
        'average
        '
        Me.average.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!)
        Me.average.Location = New System.Drawing.Point(284, 422)
        Me.average.Name = "average"
        Me.average.Size = New System.Drawing.Size(253, 40)
        Me.average.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.Label3.Location = New System.Drawing.Point(279, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Signed Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!)
        Me.Label4.Location = New System.Drawing.Point(279, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Phone Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(634, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(494, 77)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "CONTACT TRACING APP"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(786, 369)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(264, 252)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 77
        Me.PictureBox3.TabStop = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(643, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(469, 164)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = resources.GetString("Label8.Text")
        Me.Label8.UseMnemonic = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label9.Location = New System.Drawing.Point(6, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 33)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "John Doe"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(8, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 25)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Welcome,"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDashboard.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.75!)
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnDashboard.Location = New System.Drawing.Point(0, 136)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(260, 42)
        Me.btnDashboard.TabIndex = 74
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label11.Location = New System.Drawing.Point(44, 624)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(203, 46)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "JJG Contact Tracing App, 2021"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(94, 554)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.75!)
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnLogout.Location = New System.Drawing.Point(0, 271)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(260, 42)
        Me.btnLogout.TabIndex = 71
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnTrace
        '
        Me.btnTrace.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrace.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrace.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.75!)
        Me.btnTrace.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnTrace.Location = New System.Drawing.Point(0, 225)
        Me.btnTrace.Name = "btnTrace"
        Me.btnTrace.Size = New System.Drawing.Size(260, 42)
        Me.btnTrace.TabIndex = 70
        Me.btnTrace.Text = "Trace Contacts"
        Me.btnTrace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrace.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label13.Location = New System.Drawing.Point(53, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(207, 46)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "JJG Contact Tracing App"
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecords.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText
        Me.btnRecords.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecords.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.75!)
        Me.btnRecords.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnRecords.Location = New System.Drawing.Point(0, 180)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(260, 42)
        Me.btnRecords.TabIndex = 67
        Me.btnRecords.Text = "Records"
        Me.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightCyan
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(261, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(921, 56)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "EDIT USER"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1182, 24)
        Me.MenuStrip1.TabIndex = 65
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 667)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnTrace)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnRecords)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.remarks)
        Me.Controls.Add(Me.average)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.studaddress)
        Me.Controls.Add(Me.studname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "EditForm"
        Me.Text = "EditForm"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents studname As TextBox
    Friend WithEvents studaddress As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents id As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents status As TextBox
    Friend WithEvents remarks As DateTimePicker
    Friend WithEvents average As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnTrace As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnRecords As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
End Class

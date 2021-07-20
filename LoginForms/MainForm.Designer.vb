<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnShowUsersAccount = New System.Windows.Forms.Button()
        Me.btnEditGrades = New System.Windows.Forms.Button()
        Me.btnEditInfo = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.currentD = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTrace = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(482, 213)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(634, 241)
        Me.DataGridView1.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(482, 511)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 45)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1016, 460)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(931, 463)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No. of Records"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(767, 511)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 45)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1047, 511)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 45)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnShowUsersAccount
        '
        Me.btnShowUsersAccount.Location = New System.Drawing.Point(864, 511)
        Me.btnShowUsersAccount.Name = "btnShowUsersAccount"
        Me.btnShowUsersAccount.Size = New System.Drawing.Size(87, 45)
        Me.btnShowUsersAccount.TabIndex = 9
        Me.btnShowUsersAccount.Text = "Show Users  Account"
        Me.btnShowUsersAccount.UseVisualStyleBackColor = True
        '
        'btnEditGrades
        '
        Me.btnEditGrades.Location = New System.Drawing.Point(674, 511)
        Me.btnEditGrades.Name = "btnEditGrades"
        Me.btnEditGrades.Size = New System.Drawing.Size(87, 45)
        Me.btnEditGrades.TabIndex = 10
        Me.btnEditGrades.Text = "Edit Grades"
        Me.btnEditGrades.UseVisualStyleBackColor = True
        '
        'btnEditInfo
        '
        Me.btnEditInfo.Location = New System.Drawing.Point(581, 511)
        Me.btnEditInfo.Name = "btnEditInfo"
        Me.btnEditInfo.Size = New System.Drawing.Size(87, 45)
        Me.btnEditInfo.TabIndex = 12
        Me.btnEditInfo.Text = "Edit Info"
        Me.btnEditInfo.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RecordsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1182, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'currentD
        '
        Me.currentD.AutoSize = True
        Me.currentD.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentD.Location = New System.Drawing.Point(824, 156)
        Me.currentD.Name = "currentD"
        Me.currentD.Size = New System.Drawing.Size(199, 39)
        Me.currentD.TabIndex = 14
        Me.currentD.Text = "currentDate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(7, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Welcome,"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightCyan
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(261, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(921, 56)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Admin Dashboard"
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnRecords.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText
        Me.btnRecords.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecords.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 15.75!)
        Me.btnRecords.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnRecords.Location = New System.Drawing.Point(0, 189)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(260, 42)
        Me.btnRecords.TabIndex = 19
        Me.btnRecords.Text = "Records"
        Me.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(77, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 33)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "John Doe"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label8.Location = New System.Drawing.Point(53, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 46)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "JJG Contact Tracing App"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'btnTrace
        '
        Me.btnTrace.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrace.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 15.75!)
        Me.btnTrace.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnTrace.Location = New System.Drawing.Point(0, 278)
        Me.btnTrace.Name = "btnTrace"
        Me.btnTrace.Size = New System.Drawing.Size(260, 42)
        Me.btnTrace.TabIndex = 27
        Me.btnTrace.Text = "Trace Contacts"
        Me.btnTrace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrace.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 15.75!)
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnLogout.Location = New System.Drawing.Point(0, 324)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(260, 42)
        Me.btnLogout.TabIndex = 28
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddRecord.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText
        Me.btnAddRecord.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddRecord.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddRecord.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRecord.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnAddRecord.Location = New System.Drawing.Point(0, 233)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(260, 42)
        Me.btnAddRecord.TabIndex = 29
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(94, 563)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(44, 633)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(378, 46)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "JJG Contact Tracing App, 2021"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDashboard.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 15.75!)
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnDashboard.Location = New System.Drawing.Point(0, 145)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(260, 42)
        Me.btnDashboard.TabIndex = 32
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 667)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnTrace)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRecords)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.currentD)
        Me.Controls.Add(Me.btnEditInfo)
        Me.Controls.Add(Me.btnEditGrades)
        Me.Controls.Add(Me.btnShowUsersAccount)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnShowUsersAccount As Button
    Friend WithEvents btnEditGrades As Button
    Friend WithEvents btnEditInfo As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents currentD As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRecords As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTrace As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDashboard As Button
End Class

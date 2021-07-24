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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTrace = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.casesCount = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.registeredCount = New System.Windows.Forms.Label()
        Me.activeLocationCount = New System.Windows.Forms.Label()
        Me.todayAddedCount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightCyan
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(261, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(921, 56)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ADMIN DASHBOARD"
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
        Me.btnRecords.Location = New System.Drawing.Point(0, 189)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(260, 42)
        Me.btnRecords.TabIndex = 19
        Me.btnRecords.Text = "Records"
        Me.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.UseVisualStyleBackColor = False
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
        Me.btnTrace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrace.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrace.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.75!)
        Me.btnTrace.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnTrace.Location = New System.Drawing.Point(0, 234)
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
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.75!)
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnLogout.Location = New System.Drawing.Point(0, 280)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(260, 42)
        Me.btnLogout.TabIndex = 28
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
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
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDashboard.Font = New System.Drawing.Font("Bahnschrift SemiLight Condensed", 12.75!)
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnDashboard.Location = New System.Drawing.Point(0, 145)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(260, 42)
        Me.btnDashboard.TabIndex = 32
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(6, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 33)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "John Doe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Light Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(8, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Welcome,"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(296, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 228)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Active Cases"
        '
        'casesCount
        '
        Me.casesCount.BackColor = System.Drawing.Color.Red
        Me.casesCount.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.casesCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.casesCount.Location = New System.Drawing.Point(296, 424)
        Me.casesCount.Name = "casesCount"
        Me.casesCount.Size = New System.Drawing.Size(231, 58)
        Me.casesCount.TabIndex = 57
        Me.casesCount.Text = "81"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(744, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(392, 228)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Most Active Cases Area"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Lime
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(296, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(392, 228)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Registered"
        '
        'registeredCount
        '
        Me.registeredCount.BackColor = System.Drawing.Color.Lime
        Me.registeredCount.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registeredCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.registeredCount.Location = New System.Drawing.Point(296, 155)
        Me.registeredCount.Name = "registeredCount"
        Me.registeredCount.Size = New System.Drawing.Size(256, 58)
        Me.registeredCount.TabIndex = 62
        Me.registeredCount.Text = "55"
        '
        'activeLocationCount
        '
        Me.activeLocationCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.activeLocationCount.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activeLocationCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.activeLocationCount.Location = New System.Drawing.Point(744, 154)
        Me.activeLocationCount.Name = "activeLocationCount"
        Me.activeLocationCount.Size = New System.Drawing.Size(268, 59)
        Me.activeLocationCount.TabIndex = 63
        Me.activeLocationCount.Text = "81"
        '
        'todayAddedCount
        '
        Me.todayAddedCount.BackColor = System.Drawing.Color.Blue
        Me.todayAddedCount.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todayAddedCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.todayAddedCount.Location = New System.Drawing.Point(744, 424)
        Me.todayAddedCount.Name = "todayAddedCount"
        Me.todayAddedCount.Size = New System.Drawing.Size(246, 61)
        Me.todayAddedCount.TabIndex = 65
        Me.todayAddedCount.Text = "2"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Blue
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(744, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(392, 228)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Today's Added"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 667)
        Me.Controls.Add(Me.todayAddedCount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.activeLocationCount)
        Me.Controls.Add(Me.registeredCount)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.casesCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnTrace)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnRecords)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRecords As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTrace As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents Label1 As Label
    Friend WithEvents casesCount As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents registeredCount As Label
    Friend WithEvents activeLocationCount As Label
    Friend WithEvents todayAddedCount As Label
    Friend WithEvents Label9 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.stud_section = New System.Windows.Forms.TextBox()
        Me.stud_name = New System.Windows.Forms.TextBox()
        Me.stud_num = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studremarks = New System.Windows.Forms.TextBox()
        Me.studaverage = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dob = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 24)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Add Student"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(193, 266)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(112, 266)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'stud_section
        '
        Me.stud_section.Location = New System.Drawing.Point(114, 163)
        Me.stud_section.Name = "stud_section"
        Me.stud_section.Size = New System.Drawing.Size(264, 20)
        Me.stud_section.TabIndex = 17
        '
        'stud_name
        '
        Me.stud_name.Location = New System.Drawing.Point(113, 95)
        Me.stud_name.Name = "stud_name"
        Me.stud_name.Size = New System.Drawing.Size(264, 20)
        Me.stud_name.TabIndex = 16
        '
        'stud_num
        '
        Me.stud_num.Location = New System.Drawing.Point(113, 62)
        Me.stud_num.Name = "stud_num"
        Me.stud_num.Size = New System.Drawing.Size(264, 20)
        Me.stud_num.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Student Number"
        '
        'studremarks
        '
        Me.studremarks.Location = New System.Drawing.Point(114, 231)
        Me.studremarks.Name = "studremarks"
        Me.studremarks.Size = New System.Drawing.Size(264, 20)
        Me.studremarks.TabIndex = 25
        '
        'studaverage
        '
        Me.studaverage.Location = New System.Drawing.Point(114, 198)
        Me.studaverage.Name = "studaverage"
        Me.studaverage.Size = New System.Drawing.Size(264, 20)
        Me.studaverage.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Remarks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Average"
        '
        'dob
        '
        Me.dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dob.Location = New System.Drawing.Point(112, 127)
        Me.dob.MaxDate = New Date(9989, 5, 19, 0, 0, 0, 0)
        Me.dob.Name = "dob"
        Me.dob.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dob.Size = New System.Drawing.Size(265, 20)
        Me.dob.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Date of Birth"
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 308)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.studremarks)
        Me.Controls.Add(Me.studaverage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.stud_section)
        Me.Controls.Add(Me.stud_name)
        Me.Controls.Add(Me.stud_num)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddForm"
        Me.Text = "AddForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents stud_section As TextBox
    Friend WithEvents stud_name As TextBox
    Friend WithEvents stud_num As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents studremarks As TextBox
    Friend WithEvents studaverage As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dob As DateTimePicker
    Friend WithEvents Label7 As Label
End Class

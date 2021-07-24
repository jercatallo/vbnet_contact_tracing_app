<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditGrades
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
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.average = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.remarks = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(121, 57)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(155, 20)
        Me.id.TabIndex = 21
        Me.id.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Signee Id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Edit Grades"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(201, 150)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(120, 150)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'average
        '
        Me.average.Location = New System.Drawing.Point(120, 83)
        Me.average.Name = "average"
        Me.average.Size = New System.Drawing.Size(155, 20)
        Me.average.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Signed Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Phone Number"
        '
        'remarks
        '
        Me.remarks.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.remarks.Location = New System.Drawing.Point(121, 116)
        Me.remarks.MaxDate = New Date(9989, 5, 19, 0, 0, 0, 0)
        Me.remarks.Name = "remarks"
        Me.remarks.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.remarks.Size = New System.Drawing.Size(155, 20)
        Me.remarks.TabIndex = 29
        '
        'EditGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 667)
        Me.Controls.Add(Me.remarks)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.average)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditGrades"
        Me.Text = "EditGrades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents id As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents average As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents remarks As DateTimePicker
End Class

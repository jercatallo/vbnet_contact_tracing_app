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
        Me.status = New System.Windows.Forms.TextBox()
        Me.signeeName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.phoneNumber = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.signedDate = New System.Windows.Forms.DateTimePicker()
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
        'status
        '
        Me.status.Location = New System.Drawing.Point(114, 163)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(264, 20)
        Me.status.TabIndex = 17
        '
        'signeeName
        '
        Me.signeeName.Location = New System.Drawing.Point(113, 95)
        Me.signeeName.Name = "signeeName"
        Me.signeeName.Size = New System.Drawing.Size(264, 20)
        Me.signeeName.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Status"
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
        'phoneNumber
        '
        Me.phoneNumber.Location = New System.Drawing.Point(114, 198)
        Me.phoneNumber.Name = "phoneNumber"
        Me.phoneNumber.Size = New System.Drawing.Size(264, 20)
        Me.phoneNumber.TabIndex = 25
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(114, 133)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(264, 20)
        Me.address.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Signed Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Phone Number"
        '
        'signedDate
        '
        Me.signedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.signedDate.Location = New System.Drawing.Point(112, 228)
        Me.signedDate.MaxDate = New Date(9989, 5, 19, 0, 0, 0, 0)
        Me.signedDate.Name = "signedDate"
        Me.signedDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.signedDate.Size = New System.Drawing.Size(265, 20)
        Me.signedDate.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Address"
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 308)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.signedDate)
        Me.Controls.Add(Me.phoneNumber)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.signeeName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AddForm"
        Me.Text = "AddForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents status As TextBox
    Friend WithEvents signeeName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents phoneNumber As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents signedDate As DateTimePicker
    Friend WithEvents Label7 As Label
End Class

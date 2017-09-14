<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDriver
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMemNumber = New System.Windows.Forms.Label()
        Me.txtMemNumber = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.lblRegDate = New System.Windows.Forms.Label()
        Me.dtpRagDate = New System.Windows.Forms.DateTimePicker()
        Me.lblOutstandingFee = New System.Windows.Forms.Label()
        Me.txtOutstandingFee = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(113, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(239, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add New Driver"
        '
        'lblMemNumber
        '
        Me.lblMemNumber.AutoSize = True
        Me.lblMemNumber.Location = New System.Drawing.Point(12, 112)
        Me.lblMemNumber.Name = "lblMemNumber"
        Me.lblMemNumber.Size = New System.Drawing.Size(126, 17)
        Me.lblMemNumber.TabIndex = 1
        Me.lblMemNumber.Text = "Membership Num :"
        '
        'txtMemNumber
        '
        Me.txtMemNumber.Location = New System.Drawing.Point(144, 112)
        Me.txtMemNumber.Name = "txtMemNumber"
        Me.txtMemNumber.Size = New System.Drawing.Size(214, 22)
        Me.txtMemNumber.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(54, 157)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 17)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "First Name :"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(144, 154)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(214, 22)
        Me.txtFirstName.TabIndex = 4
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(54, 201)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(84, 17)
        Me.lblSurname.TabIndex = 5
        Me.lblSurname.Text = "Last Name :"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(144, 196)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(214, 22)
        Me.txtLastName.TabIndex = 6
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Location = New System.Drawing.Point(43, 244)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(95, 17)
        Me.lblBirthdate.TabIndex = 7
        Me.lblBirthdate.Text = "Date of Birth :"
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthdate.Location = New System.Drawing.Point(144, 239)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(214, 22)
        Me.dtpBirthdate.TabIndex = 8
        Me.dtpBirthdate.Value = New Date(2017, 11, 4, 0, 0, 0, 0)
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(74, 283)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(64, 17)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender :"
        '
        'cbxGender
        '
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"Male", "Fimale"})
        Me.cbxGender.Location = New System.Drawing.Point(144, 276)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(141, 24)
        Me.cbxGender.TabIndex = 10
        '
        'lblRegDate
        '
        Me.lblRegDate.AutoSize = True
        Me.lblRegDate.Location = New System.Drawing.Point(12, 324)
        Me.lblRegDate.Name = "lblRegDate"
        Me.lblRegDate.Size = New System.Drawing.Size(126, 17)
        Me.lblRegDate.TabIndex = 11
        Me.lblRegDate.Text = "Registration Year :"
        '
        'dtpRagDate
        '
        Me.dtpRagDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRagDate.Location = New System.Drawing.Point(144, 324)
        Me.dtpRagDate.Name = "dtpRagDate"
        Me.dtpRagDate.Size = New System.Drawing.Size(214, 22)
        Me.dtpRagDate.TabIndex = 12
        Me.dtpRagDate.Value = New Date(2017, 10, 7, 0, 0, 0, 0)
        '
        'lblOutstandingFee
        '
        Me.lblOutstandingFee.AutoSize = True
        Me.lblOutstandingFee.Location = New System.Drawing.Point(12, 366)
        Me.lblOutstandingFee.Name = "lblOutstandingFee"
        Me.lblOutstandingFee.Size = New System.Drawing.Size(121, 17)
        Me.lblOutstandingFee.TabIndex = 13
        Me.lblOutstandingFee.Text = "Outstanding Fee :"
        '
        'txtOutstandingFee
        '
        Me.txtOutstandingFee.Location = New System.Drawing.Point(144, 366)
        Me.txtOutstandingFee.Name = "txtOutstandingFee"
        Me.txtOutstandingFee.Size = New System.Drawing.Size(214, 22)
        Me.txtOutstandingFee.TabIndex = 14
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(144, 403)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 41)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(263, 403)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 41)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAddDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 468)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtOutstandingFee)
        Me.Controls.Add(Me.lblOutstandingFee)
        Me.Controls.Add(Me.dtpRagDate)
        Me.Controls.Add(Me.lblRegDate)
        Me.Controls.Add(Me.cbxGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.dtpBirthdate)
        Me.Controls.Add(Me.lblBirthdate)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtMemNumber)
        Me.Controls.Add(Me.lblMemNumber)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmAddDriver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblMemNumber As System.Windows.Forms.Label
    Friend WithEvents txtMemNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblBirthdate As System.Windows.Forms.Label
    Friend WithEvents dtpBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cbxGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblRegDate As System.Windows.Forms.Label
    Friend WithEvents dtpRagDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblOutstandingFee As System.Windows.Forms.Label
    Friend WithEvents txtOutstandingFee As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class

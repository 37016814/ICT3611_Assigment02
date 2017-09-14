<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateMembers
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
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOutstanding = New System.Windows.Forms.Label()
        Me.lblRegDate = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpRegDate = New System.Windows.Forms.DateTimePicker()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.txtOutstandingFee = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMemberNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(95, 54)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(68, 32)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(394, 54)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(68, 32)
        Me.btnLast.TabIndex = 1
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(320, 54)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(68, 32)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(169, 54)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(68, 32)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOutstanding)
        Me.GroupBox1.Controls.Add(Me.lblRegDate)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblBirthdate)
        Me.GroupBox1.Controls.Add(Me.lblLastName)
        Me.GroupBox1.Controls.Add(Me.lblFirstName)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.dtpRegDate)
        Me.GroupBox1.Controls.Add(Me.cbxGender)
        Me.GroupBox1.Controls.Add(Me.dtpBirthdate)
        Me.GroupBox1.Controls.Add(Me.txtOutstandingFee)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtMemberNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 371)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Members"
        '
        'lblOutstanding
        '
        Me.lblOutstanding.AutoSize = True
        Me.lblOutstanding.Location = New System.Drawing.Point(30, 275)
        Me.lblOutstanding.Name = "lblOutstanding"
        Me.lblOutstanding.Size = New System.Drawing.Size(121, 17)
        Me.lblOutstanding.TabIndex = 17
        Me.lblOutstanding.Text = "Outstanding Fee :"
        '
        'lblRegDate
        '
        Me.lblRegDate.AutoSize = True
        Me.lblRegDate.Location = New System.Drawing.Point(80, 236)
        Me.lblRegDate.Name = "lblRegDate"
        Me.lblRegDate.Size = New System.Drawing.Size(76, 17)
        Me.lblRegDate.TabIndex = 16
        Me.lblRegDate.Text = "Reg Date :"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(92, 200)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(64, 17)
        Me.lblGender.TabIndex = 15
        Me.lblGender.Text = "Gender :"
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Location = New System.Drawing.Point(61, 162)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(95, 17)
        Me.lblBirthdate.TabIndex = 14
        Me.lblBirthdate.Text = "Date of Birth :"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(72, 125)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(84, 17)
        Me.lblLastName.TabIndex = 13
        Me.lblLastName.Text = "Last Name :"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(72, 83)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(84, 17)
        Me.lblFirstName.TabIndex = 12
        Me.lblFirstName.Text = "First Name :"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(222, 314)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 40)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtpRegDate
        '
        Me.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRegDate.Location = New System.Drawing.Point(166, 236)
        Me.dtpRegDate.Name = "dtpRegDate"
        Me.dtpRegDate.Size = New System.Drawing.Size(198, 22)
        Me.dtpRegDate.TabIndex = 10
        '
        'cbxGender
        '
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"Male", "Fimale"})
        Me.cbxGender.Location = New System.Drawing.Point(166, 197)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(198, 24)
        Me.cbxGender.TabIndex = 9
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthdate.Location = New System.Drawing.Point(166, 157)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(198, 22)
        Me.dtpBirthdate.TabIndex = 8
        '
        'txtOutstandingFee
        '
        Me.txtOutstandingFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutstandingFee.Location = New System.Drawing.Point(166, 273)
        Me.txtOutstandingFee.Name = "txtOutstandingFee"
        Me.txtOutstandingFee.Size = New System.Drawing.Size(198, 22)
        Me.txtOutstandingFee.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Location = New System.Drawing.Point(166, 120)
        Me.txtLastName.MaxLength = 255
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(198, 22)
        Me.txtLastName.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Location = New System.Drawing.Point(166, 81)
        Me.txtFirstName.MaxLength = 255
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(198, 22)
        Me.txtFirstName.TabIndex = 2
        '
        'txtMemberNumber
        '
        Me.txtMemberNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemberNumber.Location = New System.Drawing.Point(6, 33)
        Me.txtMemberNumber.Name = "txtMemberNumber"
        Me.txtMemberNumber.Size = New System.Drawing.Size(198, 22)
        Me.txtMemberNumber.TabIndex = 0
        Me.txtMemberNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmUpdateMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 518)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnFirst)
        Me.Name = "frmUpdateMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateMembers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtOutstandingFee As System.Windows.Forms.TextBox
    Friend WithEvents dtpRegDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxGender As System.Windows.Forms.ComboBox
    Friend WithEvents dtpBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblOutstanding As System.Windows.Forms.Label
    Friend WithEvents lblRegDate As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblBirthdate As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
End Class

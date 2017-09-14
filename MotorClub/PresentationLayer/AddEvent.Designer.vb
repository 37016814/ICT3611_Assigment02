<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEvent
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
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRegFee = New System.Windows.Forms.Label()
        Me.txtRegfee = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblLaps = New System.Windows.Forms.Label()
        Me.txtLaps = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(150, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(244, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add New Event "
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Location = New System.Drawing.Point(76, 107)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(43, 17)
        Me.lblEventName.TabIndex = 1
        Me.lblEventName.Text = "Title :"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(141, 104)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(284, 22)
        Me.txtTitle.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(73, 161)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 17)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date :"
        '
        'dtpEventDate
        '
        Me.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEventDate.Location = New System.Drawing.Point(141, 156)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(281, 22)
        Me.dtpEventDate.TabIndex = 4
        '
        'lblRegFee
        '
        Me.lblRegFee.AutoSize = True
        Me.lblRegFee.Location = New System.Drawing.Point(-1, 206)
        Me.lblRegFee.Name = "lblRegFee"
        Me.lblRegFee.Size = New System.Drawing.Size(120, 17)
        Me.lblRegFee.TabIndex = 5
        Me.lblRegFee.Text = "Registration Fee :"
        '
        'txtRegfee
        '
        Me.txtRegfee.Location = New System.Drawing.Point(141, 203)
        Me.txtRegfee.Name = "txtRegfee"
        Me.txtRegfee.Size = New System.Drawing.Size(176, 22)
        Me.txtRegfee.TabIndex = 6
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(49, 247)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(70, 17)
        Me.lblLocation.TabIndex = 7
        Me.lblLocation.Text = "Location :"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(141, 247)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(290, 22)
        Me.txtLocation.TabIndex = 8
        '
        'lblLaps
        '
        Me.lblLaps.AutoSize = True
        Me.lblLaps.Location = New System.Drawing.Point(72, 301)
        Me.lblLaps.Name = "lblLaps"
        Me.lblLaps.Size = New System.Drawing.Size(47, 17)
        Me.lblLaps.TabIndex = 9
        Me.lblLaps.Text = "Laps :"
        '
        'txtLaps
        '
        Me.txtLaps.Location = New System.Drawing.Point(141, 301)
        Me.txtLaps.Name = "txtLaps"
        Me.txtLaps.Size = New System.Drawing.Size(115, 22)
        Me.txtLaps.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(141, 350)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 51)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(313, 350)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 51)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AddEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtLaps)
        Me.Controls.Add(Me.lblLaps)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.txtRegfee)
        Me.Controls.Add(Me.lblRegFee)
        Me.Controls.Add(Me.dtpEventDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblEventName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AddEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblEventName As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpEventDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRegFee As System.Windows.Forms.Label
    Friend WithEvents txtRegfee As System.Windows.Forms.TextBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblLaps As System.Windows.Forms.Label
    Friend WithEvents txtLaps As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class

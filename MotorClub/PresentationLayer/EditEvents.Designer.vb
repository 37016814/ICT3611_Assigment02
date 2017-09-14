<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditEvents
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
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtLaps = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtRegfee = New System.Windows.Forms.TextBox()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.lblLaps = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblRegFee = New System.Windows.Forms.Label()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.txtEventTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFirst
        '
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(115, 25)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 31)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Location = New System.Drawing.Point(196, 25)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 31)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(438, 25)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 31)
        Me.btnLast.TabIndex = 2
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(357, 25)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtLaps)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.txtRegfee)
        Me.GroupBox1.Controls.Add(Me.dtpEventDate)
        Me.GroupBox1.Controls.Add(Me.lblLaps)
        Me.GroupBox1.Controls.Add(Me.lblLocation)
        Me.GroupBox1.Controls.Add(Me.lblRegFee)
        Me.GroupBox1.Controls.Add(Me.lblEventDate)
        Me.GroupBox1.Controls.Add(Me.txtEventTitle)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 331)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Event"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(208, 264)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 36)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtLaps
        '
        Me.txtLaps.Location = New System.Drawing.Point(131, 219)
        Me.txtLaps.Name = "txtLaps"
        Me.txtLaps.Size = New System.Drawing.Size(114, 22)
        Me.txtLaps.TabIndex = 10
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(131, 178)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(220, 22)
        Me.txtLocation.TabIndex = 9
        '
        'txtRegfee
        '
        Me.txtRegfee.Location = New System.Drawing.Point(132, 137)
        Me.txtRegfee.Name = "txtRegfee"
        Me.txtRegfee.Size = New System.Drawing.Size(219, 22)
        Me.txtRegfee.TabIndex = 8
        '
        'dtpEventDate
        '
        Me.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEventDate.Location = New System.Drawing.Point(131, 96)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(218, 22)
        Me.dtpEventDate.TabIndex = 7
        '
        'lblLaps
        '
        Me.lblLaps.AutoSize = True
        Me.lblLaps.Location = New System.Drawing.Point(77, 219)
        Me.lblLaps.Name = "lblLaps"
        Me.lblLaps.Size = New System.Drawing.Size(47, 17)
        Me.lblLaps.TabIndex = 5
        Me.lblLaps.Text = "Laps :"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(54, 178)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(70, 17)
        Me.lblLocation.TabIndex = 4
        Me.lblLocation.Text = "Location :"
        '
        'lblRegFee
        '
        Me.lblRegFee.AutoSize = True
        Me.lblRegFee.Location = New System.Drawing.Point(6, 137)
        Me.lblRegFee.Name = "lblRegFee"
        Me.lblRegFee.Size = New System.Drawing.Size(120, 17)
        Me.lblRegFee.TabIndex = 3
        Me.lblRegFee.Text = "Registration Fee :"
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Location = New System.Drawing.Point(38, 96)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(86, 17)
        Me.lblEventDate.TabIndex = 2
        Me.lblEventDate.Text = "Event Date :"
        '
        'txtEventTitle
        '
        Me.txtEventTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEventTitle.Location = New System.Drawing.Point(7, 37)
        Me.txtEventTitle.Name = "txtEventTitle"
        Me.txtEventTitle.ReadOnly = True
        Me.txtEventTitle.Size = New System.Drawing.Size(218, 22)
        Me.txtEventTitle.TabIndex = 0
        '
        'frmEditEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 456)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Name = "frmEditEvents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EditEvents"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEventTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblRegFee As System.Windows.Forms.Label
    Friend WithEvents lblEventDate As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtLaps As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtRegfee As System.Windows.Forms.TextBox
    Friend WithEvents dtpEventDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblLaps As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class

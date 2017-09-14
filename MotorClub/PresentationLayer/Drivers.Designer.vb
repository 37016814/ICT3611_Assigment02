<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrivers
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
        Me.dgvDriverData = New System.Windows.Forms.DataGridView()
        Me.cbxDrivers = New System.Windows.Forms.ComboBox()
        Me.lblDriver = New System.Windows.Forms.Label()
        Me.txtFindDriver = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.msDriverAction = New System.Windows.Forms.MenuStrip()
        Me.msiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiAddDriver = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiEditMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiAllMembers = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiDeleteDriver = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDelDriver = New System.Windows.Forms.TextBox()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.dgvDriverData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msDriverAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDriverData
        '
        Me.dgvDriverData.AllowUserToAddRows = False
        Me.dgvDriverData.AllowUserToDeleteRows = False
        Me.dgvDriverData.AllowUserToOrderColumns = True
        Me.dgvDriverData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDriverData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDriverData.Location = New System.Drawing.Point(12, 171)
        Me.dgvDriverData.Name = "dgvDriverData"
        Me.dgvDriverData.ReadOnly = True
        Me.dgvDriverData.RowTemplate.Height = 24
        Me.dgvDriverData.Size = New System.Drawing.Size(627, 167)
        Me.dgvDriverData.TabIndex = 0
        '
        'cbxDrivers
        '
        Me.cbxDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDrivers.FormattingEnabled = True
        Me.cbxDrivers.Location = New System.Drawing.Point(72, 98)
        Me.cbxDrivers.Name = "cbxDrivers"
        Me.cbxDrivers.Size = New System.Drawing.Size(303, 24)
        Me.cbxDrivers.TabIndex = 1
        '
        'lblDriver
        '
        Me.lblDriver.AutoSize = True
        Me.lblDriver.Location = New System.Drawing.Point(12, 98)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(54, 17)
        Me.lblDriver.TabIndex = 2
        Me.lblDriver.Text = "Driver :"
        '
        'txtFindDriver
        '
        Me.txtFindDriver.Location = New System.Drawing.Point(72, 139)
        Me.txtFindDriver.Name = "txtFindDriver"
        Me.txtFindDriver.Size = New System.Drawing.Size(180, 22)
        Me.txtFindDriver.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(258, 134)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 33)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'msDriverAction
        '
        Me.msDriverAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiFile, Me.msiAddDriver, Me.msiEditMember, Me.msiAllMembers, Me.msiDeleteDriver})
        Me.msDriverAction.Location = New System.Drawing.Point(0, 0)
        Me.msDriverAction.Name = "msDriverAction"
        Me.msDriverAction.Size = New System.Drawing.Size(651, 28)
        Me.msDriverAction.TabIndex = 5
        Me.msDriverAction.Text = "MenuStrip1"
        '
        'msiFile
        '
        Me.msiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripSeparator1, Me.mnuFileExit})
        Me.msiFile.Name = "msiFile"
        Me.msiFile.Size = New System.Drawing.Size(44, 24)
        Me.msiFile.Text = "File"
        '
        'msiAddDriver
        '
        Me.msiAddDriver.Name = "msiAddDriver"
        Me.msiAddDriver.Size = New System.Drawing.Size(93, 24)
        Me.msiAddDriver.Text = "Add Driver"
        '
        'msiEditMember
        '
        Me.msiEditMember.Name = "msiEditMember"
        Me.msiEditMember.Size = New System.Drawing.Size(107, 24)
        Me.msiEditMember.Text = "Edit Member"
        '
        'msiAllMembers
        '
        Me.msiAllMembers.Name = "msiAllMembers"
        Me.msiAllMembers.Size = New System.Drawing.Size(145, 24)
        Me.msiAllMembers.Text = "View All Members "
        '
        'msiDeleteDriver
        '
        Me.msiDeleteDriver.Enabled = False
        Me.msiDeleteDriver.Name = "msiDeleteDriver"
        Me.msiDeleteDriver.Size = New System.Drawing.Size(109, 24)
        Me.msiDeleteDriver.Text = "Delete Driver"
        '
        'txtDelDriver
        '
        Me.txtDelDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelDriver.Location = New System.Drawing.Point(426, 100)
        Me.txtDelDriver.Name = "txtDelDriver"
        Me.txtDelDriver.ReadOnly = True
        Me.txtDelDriver.Size = New System.Drawing.Size(188, 22)
        Me.txtDelDriver.TabIndex = 6
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 24)
        Me.mnuFileExit.Text = "E&xit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'frmDrivers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 350)
        Me.Controls.Add(Me.txtDelDriver)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtFindDriver)
        Me.Controls.Add(Me.lblDriver)
        Me.Controls.Add(Me.cbxDrivers)
        Me.Controls.Add(Me.dgvDriverData)
        Me.Controls.Add(Me.msDriverAction)
        Me.MainMenuStrip = Me.msDriverAction
        Me.Name = "frmDrivers"
        Me.Text = "Drivers"
        CType(Me.dgvDriverData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msDriverAction.ResumeLayout(False)
        Me.msDriverAction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDriverData As System.Windows.Forms.DataGridView
    Friend WithEvents cbxDrivers As System.Windows.Forms.ComboBox
    Friend WithEvents lblDriver As System.Windows.Forms.Label
    Friend WithEvents txtFindDriver As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents msDriverAction As System.Windows.Forms.MenuStrip
    Friend WithEvents msiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiAddDriver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDelDriver As System.Windows.Forms.TextBox
    Friend WithEvents msiDeleteDriver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiAllMembers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiEditMember As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
End Class

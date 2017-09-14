<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeleteMember
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
        Me.lblDriver = New System.Windows.Forms.Label()
        Me.cbxMemberNumber = New System.Windows.Forms.ComboBox()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.txtDeleteMember = New System.Windows.Forms.TextBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.msUserAction = New System.Windows.Forms.MenuStrip()
        Me.msiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiAddMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiEditMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiDeleteMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msUserAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDriver
        '
        Me.lblDriver.AutoSize = True
        Me.lblDriver.Location = New System.Drawing.Point(13, 75)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(121, 17)
        Me.lblDriver.TabIndex = 0
        Me.lblDriver.Text = "Member Number :"
        '
        'cbxMemberNumber
        '
        Me.cbxMemberNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMemberNumber.FormattingEnabled = True
        Me.cbxMemberNumber.Location = New System.Drawing.Point(140, 72)
        Me.cbxMemberNumber.Name = "cbxMemberNumber"
        Me.cbxMemberNumber.Size = New System.Drawing.Size(209, 24)
        Me.cbxMemberNumber.TabIndex = 1
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToAddRows = False
        Me.dgvMembers.AllowUserToDeleteRows = False
        Me.dgvMembers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Location = New System.Drawing.Point(12, 147)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.ReadOnly = True
        Me.dgvMembers.RowTemplate.Height = 24
        Me.dgvMembers.Size = New System.Drawing.Size(572, 150)
        Me.dgvMembers.TabIndex = 2
        '
        'txtDeleteMember
        '
        Me.txtDeleteMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeleteMember.Location = New System.Drawing.Point(355, 73)
        Me.txtDeleteMember.Name = "txtDeleteMember"
        Me.txtDeleteMember.Size = New System.Drawing.Size(198, 22)
        Me.txtDeleteMember.TabIndex = 3
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(143, 119)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(206, 22)
        Me.txtFind.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(355, 113)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 28)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'msUserAction
        '
        Me.msUserAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiFile, Me.msiAddMember, Me.msiEditMember, Me.msiDeleteMember, Me.msiExit})
        Me.msUserAction.Location = New System.Drawing.Point(0, 0)
        Me.msUserAction.Name = "msUserAction"
        Me.msUserAction.Size = New System.Drawing.Size(596, 28)
        Me.msUserAction.TabIndex = 6
        Me.msUserAction.Text = "MenuStrip1"
        '
        'msiFile
        '
        Me.msiFile.Name = "msiFile"
        Me.msiFile.Size = New System.Drawing.Size(44, 24)
        Me.msiFile.Text = "File"
        '
        'msiAddMember
        '
        Me.msiAddMember.Name = "msiAddMember"
        Me.msiAddMember.Size = New System.Drawing.Size(109, 24)
        Me.msiAddMember.Text = "Add Member"
        '
        'msiEditMember
        '
        Me.msiEditMember.Name = "msiEditMember"
        Me.msiEditMember.Size = New System.Drawing.Size(107, 24)
        Me.msiEditMember.Text = "Edit Member"
        '
        'msiDeleteMember
        '
        Me.msiDeleteMember.Enabled = False
        Me.msiDeleteMember.Name = "msiDeleteMember"
        Me.msiDeleteMember.Size = New System.Drawing.Size(125, 24)
        Me.msiDeleteMember.Text = "Delete Member"
        '
        'msiExit
        '
        Me.msiExit.Name = "msiExit"
        Me.msiExit.Size = New System.Drawing.Size(45, 24)
        Me.msiExit.Text = "Exit"
        '
        'FrmDeleteMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(596, 306)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.txtDeleteMember)
        Me.Controls.Add(Me.dgvMembers)
        Me.Controls.Add(Me.cbxMemberNumber)
        Me.Controls.Add(Me.lblDriver)
        Me.Controls.Add(Me.msUserAction)
        Me.Name = "FrmDeleteMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msUserAction.ResumeLayout(False)
        Me.msUserAction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDriver As System.Windows.Forms.Label
    Friend WithEvents cbxMemberNumber As System.Windows.Forms.ComboBox
    Friend WithEvents dgvMembers As System.Windows.Forms.DataGridView
    Friend WithEvents txtDeleteMember As System.Windows.Forms.TextBox
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents msUserAction As System.Windows.Forms.MenuStrip
    Friend WithEvents msiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiDeleteMember As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiAddMember As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiEditMember As System.Windows.Forms.ToolStripMenuItem
End Class

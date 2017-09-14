<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvents
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
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.dgvEvents = New System.Windows.Forms.DataGridView()
        Me.cbxEventTitle = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiDeleteEvent = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.txtDelEvent = New System.Windows.Forms.TextBox()
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(160, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(121, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Events "
        '
        'lblEvent
        '
        Me.lblEvent.AutoSize = True
        Me.lblEvent.Location = New System.Drawing.Point(12, 100)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(52, 17)
        Me.lblEvent.TabIndex = 1
        Me.lblEvent.Text = "Event :"
        '
        'dgvEvents
        '
        Me.dgvEvents.AllowUserToAddRows = False
        Me.dgvEvents.AllowUserToDeleteRows = False
        Me.dgvEvents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEvents.Location = New System.Drawing.Point(15, 180)
        Me.dgvEvents.Name = "dgvEvents"
        Me.dgvEvents.ReadOnly = True
        Me.dgvEvents.RowTemplate.Height = 24
        Me.dgvEvents.Size = New System.Drawing.Size(678, 150)
        Me.dgvEvents.TabIndex = 2
        '
        'cbxEventTitle
        '
        Me.cbxEventTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEventTitle.FormattingEnabled = True
        Me.cbxEventTitle.Location = New System.Drawing.Point(70, 100)
        Me.cbxEventTitle.Name = "cbxEventTitle"
        Me.cbxEventTitle.Size = New System.Drawing.Size(339, 24)
        Me.cbxEventTitle.TabIndex = 3
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(70, 140)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(218, 22)
        Me.txtFind.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(294, 134)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(91, 34)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'msMenu
        '
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NewUserToolStripMenuItem, Me.msiDeleteEvent, Me.EditEventToolStripMenuItem})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(702, 28)
        Me.msMenu.TabIndex = 6
        Me.msMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.NewUserToolStripMenuItem.Text = "Add Event"
        '
        'msiDeleteEvent
        '
        Me.msiDeleteEvent.Enabled = False
        Me.msiDeleteEvent.Name = "msiDeleteEvent"
        Me.msiDeleteEvent.Size = New System.Drawing.Size(105, 24)
        Me.msiDeleteEvent.Text = "Delete Event"
        '
        'EditEventToolStripMenuItem
        '
        Me.EditEventToolStripMenuItem.Name = "EditEventToolStripMenuItem"
        Me.EditEventToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.EditEventToolStripMenuItem.Text = "Edit Event"
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Location = New System.Drawing.Point(441, 114)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(83, 17)
        Me.lblEventName.TabIndex = 7
        Me.lblEventName.Text = "Event Title :"
        '
        'txtDelEvent
        '
        Me.txtDelEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelEvent.Location = New System.Drawing.Point(444, 134)
        Me.txtDelEvent.Name = "txtDelEvent"
        Me.txtDelEvent.Size = New System.Drawing.Size(246, 22)
        Me.txtDelEvent.TabIndex = 8
        '
        'frmEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 342)
        Me.Controls.Add(Me.txtDelEvent)
        Me.Controls.Add(Me.lblEventName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.cbxEventTitle)
        Me.Controls.Add(Me.dgvEvents)
        Me.Controls.Add(Me.lblEvent)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.msMenu)
        Me.MainMenuStrip = Me.msMenu
        Me.Name = "frmEvents"
        Me.Text = "Events"
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblEvent As System.Windows.Forms.Label
    Friend WithEvents dgvEvents As System.Windows.Forms.DataGridView
    Friend WithEvents cbxEventTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEventName As System.Windows.Forms.Label
    Friend WithEvents txtDelEvent As System.Windows.Forms.TextBox
    Friend WithEvents msiDeleteEvent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRaceResults
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
        Me.lblRaceResult = New System.Windows.Forms.Label()
        Me.lblDriver = New System.Windows.Forms.Label()
        Me.cbxDriver = New System.Windows.Forms.ComboBox()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.cbxRace = New System.Windows.Forms.ComboBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.MotorClubDataSet1 = New DataLayer.MotorClubDataSet()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotorClubDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRaceResult
        '
        Me.lblRaceResult.AutoSize = True
        Me.lblRaceResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaceResult.Location = New System.Drawing.Point(98, 26)
        Me.lblRaceResult.Name = "lblRaceResult"
        Me.lblRaceResult.Size = New System.Drawing.Size(204, 36)
        Me.lblRaceResult.TabIndex = 0
        Me.lblRaceResult.Text = "Race Results"
        '
        'lblDriver
        '
        Me.lblDriver.AutoSize = True
        Me.lblDriver.Location = New System.Drawing.Point(24, 104)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(54, 17)
        Me.lblDriver.TabIndex = 1
        Me.lblDriver.Text = "Driver :"
        '
        'cbxDriver
        '
        Me.cbxDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDriver.FormattingEnabled = True
        Me.cbxDriver.Location = New System.Drawing.Point(86, 101)
        Me.cbxDriver.Name = "cbxDriver"
        Me.cbxDriver.Size = New System.Drawing.Size(216, 24)
        Me.cbxDriver.TabIndex = 2
        '
        'lblRace
        '
        Me.lblRace.AutoSize = True
        Me.lblRace.Location = New System.Drawing.Point(29, 150)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(49, 17)
        Me.lblRace.TabIndex = 3
        Me.lblRace.Text = "Race :"
        '
        'cbxRace
        '
        Me.cbxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRace.FormattingEnabled = True
        Me.cbxRace.Location = New System.Drawing.Point(86, 147)
        Me.cbxRace.Name = "cbxRace"
        Me.cbxRace.Size = New System.Drawing.Size(216, 24)
        Me.cbxRace.TabIndex = 4
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(12, 192)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(66, 17)
        Me.lblPosition.TabIndex = 5
        Me.lblPosition.Text = "Position :"
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(86, 192)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(216, 22)
        Me.txtPosition.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(376, 92)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 40)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(376, 146)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 40)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(376, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(12, 238)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.RowTemplate.Height = 24
        Me.dgvResults.Size = New System.Drawing.Size(527, 150)
        Me.dgvResults.TabIndex = 10
        '
        'MotorClubDataSet1
        '
        Me.MotorClubDataSet1.DataSetName = "MotorClubDataSet"
        Me.MotorClubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmRaceResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 396)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.cbxRace)
        Me.Controls.Add(Me.lblRace)
        Me.Controls.Add(Me.cbxDriver)
        Me.Controls.Add(Me.lblDriver)
        Me.Controls.Add(Me.lblRaceResult)
        Me.Name = "FrmRaceResults"
        Me.Text = "RaceResults"
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotorClubDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRaceResult As System.Windows.Forms.Label
    Friend WithEvents lblDriver As System.Windows.Forms.Label
    Friend WithEvents cbxDriver As System.Windows.Forms.ComboBox
    Friend WithEvents lblRace As System.Windows.Forms.Label
    Friend WithEvents cbxRace As System.Windows.Forms.ComboBox
    Friend WithEvents MotorClubDataSet1 As DataLayer.MotorClubDataSet
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MotoClub
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
        Me.btnDrivers = New System.Windows.Forms.Button()
        Me.btnEvents = New System.Windows.Forms.Button()
        Me.btnRaces = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PboxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(92, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(281, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Motor Club Project"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDrivers
        '
        Me.btnDrivers.Location = New System.Drawing.Point(98, 255)
        Me.btnDrivers.Name = "btnDrivers"
        Me.btnDrivers.Size = New System.Drawing.Size(102, 53)
        Me.btnDrivers.TabIndex = 2
        Me.btnDrivers.Text = "&Drivers"
        Me.btnDrivers.UseVisualStyleBackColor = True
        '
        'btnEvents
        '
        Me.btnEvents.Location = New System.Drawing.Point(246, 255)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(115, 53)
        Me.btnEvents.TabIndex = 3
        Me.btnEvents.Text = "&Events"
        Me.btnEvents.UseVisualStyleBackColor = True
        '
        'btnRaces
        '
        Me.btnRaces.Location = New System.Drawing.Point(98, 327)
        Me.btnRaces.Name = "btnRaces"
        Me.btnRaces.Size = New System.Drawing.Size(102, 53)
        Me.btnRaces.TabIndex = 4
        Me.btnRaces.Text = "&RaceResults"
        Me.btnRaces.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 327)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 53)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PboxLogo
        '
        Me.PboxLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PboxLogo.Image = Global.PresentationLayer.My.Resources.Resources.club_logo
        Me.PboxLogo.Location = New System.Drawing.Point(98, 89)
        Me.PboxLogo.Name = "PboxLogo"
        Me.PboxLogo.Size = New System.Drawing.Size(263, 149)
        Me.PboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxLogo.TabIndex = 1
        Me.PboxLogo.TabStop = False
        '
        'MotoClub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 392)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRaces)
        Me.Controls.Add(Me.btnEvents)
        Me.Controls.Add(Me.btnDrivers)
        Me.Controls.Add(Me.PboxLogo)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "MotoClub"
        Me.Text = "MotorClub"
        CType(Me.PboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PboxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnDrivers As System.Windows.Forms.Button
    Friend WithEvents btnEvents As System.Windows.Forms.Button
    Friend WithEvents btnRaces As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class

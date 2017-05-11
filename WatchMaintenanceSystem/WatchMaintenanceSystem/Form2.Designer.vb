<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.grpServices = New System.Windows.Forms.GroupBox()
        Me.surfacePanel = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkConSurface = New System.Windows.Forms.CheckedListBox()
        Me.strapPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cblConStrap = New System.Windows.Forms.CheckedListBox()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkSide = New System.Windows.Forms.CheckedListBox()
        Me.dialPanel = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkDial = New System.Windows.Forms.CheckedListBox()
        Me.circlePanel = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkCircle = New System.Windows.Forms.CheckedListBox()
        Me.crownPanel = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkCrown = New System.Windows.Forms.CheckedListBox()
        Me.pusherPanel = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkPusher = New System.Windows.Forms.CheckedListBox()
        Me.panelCondition = New System.Windows.Forms.Panel()
        Me.lbCondition = New System.Windows.Forms.ListBox()
        Me.lblWatchDesc = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpServices.SuspendLayout()
        Me.surfacePanel.SuspendLayout()
        Me.strapPanel.SuspendLayout()
        Me.sidePanel.SuspendLayout()
        Me.dialPanel.SuspendLayout()
        Me.circlePanel.SuspendLayout()
        Me.crownPanel.SuspendLayout()
        Me.pusherPanel.SuspendLayout()
        Me.panelCondition.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpServices
        '
        Me.grpServices.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpServices.Controls.Add(Me.panelCondition)
        Me.grpServices.Font = New System.Drawing.Font("Arial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.grpServices.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grpServices.Location = New System.Drawing.Point(244, 165)
        Me.grpServices.Name = "grpServices"
        Me.grpServices.Size = New System.Drawing.Size(476, 269)
        Me.grpServices.TabIndex = 34
        Me.grpServices.TabStop = False
        Me.grpServices.Text = "Watch Condition"
        '
        'surfacePanel
        '
        Me.surfacePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.surfacePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.surfacePanel.Controls.Add(Me.Label16)
        Me.surfacePanel.Controls.Add(Me.chkConSurface)
        Me.surfacePanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surfacePanel.Location = New System.Drawing.Point(451, 15)
        Me.surfacePanel.Name = "surfacePanel"
        Me.surfacePanel.Size = New System.Drawing.Size(114, 112)
        Me.surfacePanel.TabIndex = 37
        Me.surfacePanel.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label16.Location = New System.Drawing.Point(3, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Crystal"
        '
        'chkConSurface
        '
        Me.chkConSurface.CheckOnClick = True
        Me.chkConSurface.FormattingEnabled = True
        Me.chkConSurface.Items.AddRange(New Object() {"Crystal Crack", "Crystal Missing", "Crystal Scratch"})
        Me.chkConSurface.Location = New System.Drawing.Point(3, 30)
        Me.chkConSurface.Name = "chkConSurface"
        Me.chkConSurface.Size = New System.Drawing.Size(107, 79)
        Me.chkConSurface.TabIndex = 0
        '
        'strapPanel
        '
        Me.strapPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.strapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.strapPanel.Controls.Add(Me.Label8)
        Me.strapPanel.Controls.Add(Me.cblConStrap)
        Me.strapPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strapPanel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.strapPanel.Location = New System.Drawing.Point(37, 15)
        Me.strapPanel.Name = "strapPanel"
        Me.strapPanel.Size = New System.Drawing.Size(131, 112)
        Me.strapPanel.TabIndex = 34
        Me.strapPanel.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(3, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Strap"
        '
        'cblConStrap
        '
        Me.cblConStrap.CheckOnClick = True
        Me.cblConStrap.FormattingEnabled = True
        Me.cblConStrap.Items.AddRange(New Object() {"Strap Dent", "Strap Discolour", "Strap Scratch"})
        Me.cblConStrap.Location = New System.Drawing.Point(3, 24)
        Me.cblConStrap.Name = "cblConStrap"
        Me.cblConStrap.Size = New System.Drawing.Size(119, 79)
        Me.cblConStrap.TabIndex = 100
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sidePanel.Controls.Add(Me.Label18)
        Me.sidePanel.Controls.Add(Me.chkSide)
        Me.sidePanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sidePanel.Location = New System.Drawing.Point(578, 18)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(120, 112)
        Me.sidePanel.TabIndex = 40
        Me.sidePanel.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label18.Location = New System.Drawing.Point(3, 2)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 19)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Case"
        '
        'chkSide
        '
        Me.chkSide.CheckOnClick = True
        Me.chkSide.FormattingEnabled = True
        Me.chkSide.Items.AddRange(New Object() {"Case Dent", "Case Discolour", "Case Scratch"})
        Me.chkSide.Location = New System.Drawing.Point(3, 24)
        Me.chkSide.Name = "chkSide"
        Me.chkSide.Size = New System.Drawing.Size(104, 79)
        Me.chkSide.TabIndex = 102
        '
        'dialPanel
        '
        Me.dialPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dialPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dialPanel.Controls.Add(Me.Label17)
        Me.dialPanel.Controls.Add(Me.chkDial)
        Me.dialPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dialPanel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.dialPanel.Location = New System.Drawing.Point(315, 15)
        Me.dialPanel.Name = "dialPanel"
        Me.dialPanel.Size = New System.Drawing.Size(120, 112)
        Me.dialPanel.TabIndex = 38
        Me.dialPanel.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 19)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Dial"
        '
        'chkDial
        '
        Me.chkDial.CheckOnClick = True
        Me.chkDial.FormattingEnabled = True
        Me.chkDial.Items.AddRange(New Object() {"Dial Discolour", "Dial Missing"})
        Me.chkDial.Location = New System.Drawing.Point(3, 24)
        Me.chkDial.Name = "chkDial"
        Me.chkDial.Size = New System.Drawing.Size(104, 79)
        Me.chkDial.TabIndex = 103
        '
        'circlePanel
        '
        Me.circlePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.circlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.circlePanel.Controls.Add(Me.Label15)
        Me.circlePanel.Controls.Add(Me.chkCircle)
        Me.circlePanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.circlePanel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.circlePanel.Location = New System.Drawing.Point(459, 149)
        Me.circlePanel.Name = "circlePanel"
        Me.circlePanel.Size = New System.Drawing.Size(120, 112)
        Me.circlePanel.TabIndex = 39
        Me.circlePanel.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 19)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Bezel"
        '
        'chkCircle
        '
        Me.chkCircle.CheckOnClick = True
        Me.chkCircle.FormattingEnabled = True
        Me.chkCircle.Items.AddRange(New Object() {"Bezel Dent", "Bezel Discolor", "Bezel Missing", "Bezel Scratch"})
        Me.chkCircle.Location = New System.Drawing.Point(3, 24)
        Me.chkCircle.Name = "chkCircle"
        Me.chkCircle.Size = New System.Drawing.Size(104, 79)
        Me.chkCircle.TabIndex = 101
        '
        'crownPanel
        '
        Me.crownPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.crownPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crownPanel.Controls.Add(Me.Label14)
        Me.crownPanel.Controls.Add(Me.chkCrown)
        Me.crownPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crownPanel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.crownPanel.Location = New System.Drawing.Point(319, 146)
        Me.crownPanel.Name = "crownPanel"
        Me.crownPanel.Size = New System.Drawing.Size(120, 112)
        Me.crownPanel.TabIndex = 36
        Me.crownPanel.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 19)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Crown"
        '
        'chkCrown
        '
        Me.chkCrown.CheckOnClick = True
        Me.chkCrown.FormattingEnabled = True
        Me.chkCrown.Items.AddRange(New Object() {"Crown Damaged", "Crown Missing", "Crown Scratch"})
        Me.chkCrown.Location = New System.Drawing.Point(3, 24)
        Me.chkCrown.Name = "chkCrown"
        Me.chkCrown.Size = New System.Drawing.Size(104, 79)
        Me.chkCrown.TabIndex = 101
        '
        'pusherPanel
        '
        Me.pusherPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pusherPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pusherPanel.Controls.Add(Me.Label13)
        Me.pusherPanel.Controls.Add(Me.chkPusher)
        Me.pusherPanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pusherPanel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.pusherPanel.Location = New System.Drawing.Point(185, 15)
        Me.pusherPanel.Name = "pusherPanel"
        Me.pusherPanel.Size = New System.Drawing.Size(120, 112)
        Me.pusherPanel.TabIndex = 35
        Me.pusherPanel.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 19)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Pusher"
        '
        'chkPusher
        '
        Me.chkPusher.CheckOnClick = True
        Me.chkPusher.FormattingEnabled = True
        Me.chkPusher.Items.AddRange(New Object() {"Pusher Dented", "Pusher Discolour", "Pusher Scratch"})
        Me.chkPusher.Location = New System.Drawing.Point(3, 24)
        Me.chkPusher.Name = "chkPusher"
        Me.chkPusher.Size = New System.Drawing.Size(104, 79)
        Me.chkPusher.TabIndex = 101
        '
        'panelCondition
        '
        Me.panelCondition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelCondition.Controls.Add(Me.lbCondition)
        Me.panelCondition.Controls.Add(Me.lblWatchDesc)
        Me.panelCondition.Location = New System.Drawing.Point(304, 41)
        Me.panelCondition.Name = "panelCondition"
        Me.panelCondition.Size = New System.Drawing.Size(237, 195)
        Me.panelCondition.TabIndex = 32
        '
        'lbCondition
        '
        Me.lbCondition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCondition.FormattingEnabled = True
        Me.lbCondition.ItemHeight = 16
        Me.lbCondition.Location = New System.Drawing.Point(3, 35)
        Me.lbCondition.Name = "lbCondition"
        Me.lbCondition.Size = New System.Drawing.Size(145, 132)
        Me.lbCondition.TabIndex = 2
        '
        'lblWatchDesc
        '
        Me.lblWatchDesc.AutoSize = True
        Me.lblWatchDesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatchDesc.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblWatchDesc.Location = New System.Drawing.Point(15, 13)
        Me.lblWatchDesc.Name = "lblWatchDesc"
        Me.lblWatchDesc.Size = New System.Drawing.Size(0, 19)
        Me.lblWatchDesc.TabIndex = 0
        Me.lblWatchDesc.UseMnemonic = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WatchMaintenanceSystem.My.Resources.Resources.WatchCondition
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(51, 180)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 195)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 446)
        Me.Controls.Add(Me.circlePanel)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.crownPanel)
        Me.Controls.Add(Me.surfacePanel)
        Me.Controls.Add(Me.grpServices)
        Me.Controls.Add(Me.strapPanel)
        Me.Controls.Add(Me.dialPanel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pusherPanel)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.grpServices.ResumeLayout(False)
        Me.surfacePanel.ResumeLayout(False)
        Me.surfacePanel.PerformLayout()
        Me.strapPanel.ResumeLayout(False)
        Me.strapPanel.PerformLayout()
        Me.sidePanel.ResumeLayout(False)
        Me.sidePanel.PerformLayout()
        Me.dialPanel.ResumeLayout(False)
        Me.dialPanel.PerformLayout()
        Me.circlePanel.ResumeLayout(False)
        Me.circlePanel.PerformLayout()
        Me.crownPanel.ResumeLayout(False)
        Me.crownPanel.PerformLayout()
        Me.pusherPanel.ResumeLayout(False)
        Me.pusherPanel.PerformLayout()
        Me.panelCondition.ResumeLayout(False)
        Me.panelCondition.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpServices As GroupBox
    Friend WithEvents surfacePanel As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents chkConSurface As CheckedListBox
    Friend WithEvents strapPanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents cblConStrap As CheckedListBox
    Friend WithEvents sidePanel As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents chkSide As CheckedListBox
    Friend WithEvents dialPanel As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents chkDial As CheckedListBox
    Friend WithEvents circlePanel As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents chkCircle As CheckedListBox
    Friend WithEvents crownPanel As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents chkCrown As CheckedListBox
    Friend WithEvents pusherPanel As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents chkPusher As CheckedListBox
    Friend WithEvents panelCondition As Panel
    Friend WithEvents lbCondition As ListBox
    Friend WithEvents lblWatchDesc As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

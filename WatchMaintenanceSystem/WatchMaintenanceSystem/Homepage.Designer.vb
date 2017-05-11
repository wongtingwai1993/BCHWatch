<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.txtInsert = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvReminder = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tblHomepage = New System.Windows.Forms.TableLayoutPanel()
        Me.tblReminder = New System.Windows.Forms.TableLayoutPanel()
        Me.tblStatus = New System.Windows.Forms.TableLayoutPanel()
        Me.tblButtonList = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.dgvReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblHomepage.SuspendLayout()
        Me.tblReminder.SuspendLayout()
        Me.tblStatus.SuspendLayout()
        Me.tblButtonList.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.Location = New System.Drawing.Point(3, 340)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(110, 40)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Check Database"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'txtInsert
        '
        Me.txtInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsert.Location = New System.Drawing.Point(3, 40)
        Me.txtInsert.Name = "txtInsert"
        Me.txtInsert.Size = New System.Drawing.Size(110, 40)
        Me.txtInsert.TabIndex = 1
        Me.txtInsert.Text = "Insert Invoice"
        Me.txtInsert.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "WorkShop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvReminder
        '
        Me.dgvReminder.AllowUserToAddRows = False
        Me.dgvReminder.AllowUserToDeleteRows = False
        Me.dgvReminder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReminder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReminder.Location = New System.Drawing.Point(3, 43)
        Me.dgvReminder.Name = "dgvReminder"
        Me.dgvReminder.ReadOnly = True
        Me.dgvReminder.Size = New System.Drawing.Size(684, 314)
        Me.dgvReminder.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Reminder"
        '
        'btnIssue
        '
        Me.btnIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.Location = New System.Drawing.Point(3, 100)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(109, 38)
        Me.btnIssue.TabIndex = 5
        Me.btnIssue.Text = "Issue Invoice"
        Me.btnIssue.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Location = New System.Drawing.Point(3, 220)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(110, 40)
        Me.btnHistory.TabIndex = 7
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.Location = New System.Drawing.Point(3, 280)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(110, 40)
        Me.btnMaintenance.TabIndex = 6
        Me.btnMaintenance.Text = "Maintenance"
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox2.Image = Global.WatchMaintenanceSystem.My.Resources.Resources.greenOK
        Me.PictureBox2.Location = New System.Drawing.Point(69, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox3.Image = Global.WatchMaintenanceSystem.My.Resources.Resources.yellowWarn
        Me.PictureBox3.Location = New System.Drawing.Point(272, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox4.Image = Global.WatchMaintenanceSystem.My.Resources.Resources.warning
        Me.PictureBox4.Location = New System.Drawing.Point(473, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(41, 29)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 35)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "1-5 Days"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 35)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "5-7 Days"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(520, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 35)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "More than 7 Days"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(804, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Version 7.4"
        '
        'tblHomepage
        '
        Me.tblHomepage.AutoSize = True
        Me.tblHomepage.ColumnCount = 4
        Me.tblHomepage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblHomepage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblHomepage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.tblHomepage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblHomepage.Controls.Add(Me.tblReminder, 2, 0)
        Me.tblHomepage.Controls.Add(Me.tblButtonList, 1, 0)
        Me.tblHomepage.Controls.Add(Me.Label5, 2, 1)
        Me.tblHomepage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblHomepage.Location = New System.Drawing.Point(0, 0)
        Me.tblHomepage.Name = "tblHomepage"
        Me.tblHomepage.RowCount = 2
        Me.tblHomepage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHomepage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblHomepage.Size = New System.Drawing.Size(928, 427)
        Me.tblHomepage.TabIndex = 15
        '
        'tblReminder
        '
        Me.tblReminder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblReminder.ColumnCount = 1
        Me.tblReminder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblReminder.Controls.Add(Me.Label1, 0, 0)
        Me.tblReminder.Controls.Add(Me.tblStatus, 0, 2)
        Me.tblReminder.Controls.Add(Me.dgvReminder, 0, 1)
        Me.tblReminder.Location = New System.Drawing.Point(188, 3)
        Me.tblReminder.Name = "tblReminder"
        Me.tblReminder.RowCount = 3
        Me.tblReminder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblReminder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblReminder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblReminder.Size = New System.Drawing.Size(690, 401)
        Me.tblReminder.TabIndex = 7
        '
        'tblStatus
        '
        Me.tblStatus.ColumnCount = 8
        Me.tblStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.580866!))
        Me.tblStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.38952!))
        Me.tblStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.22323!))
        Me.tblStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.38952!))
        Me.tblStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.22323!))
        Me.tblStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.38952!))
        Me.tblStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.22323!))
        Me.tblStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.580866!))
        Me.tblStatus.Controls.Add(Me.Label4, 6, 0)
        Me.tblStatus.Controls.Add(Me.PictureBox4, 5, 0)
        Me.tblStatus.Controls.Add(Me.Label3, 4, 0)
        Me.tblStatus.Controls.Add(Me.PictureBox3, 3, 0)
        Me.tblStatus.Controls.Add(Me.Label2, 2, 0)
        Me.tblStatus.Controls.Add(Me.PictureBox2, 1, 0)
        Me.tblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblStatus.Location = New System.Drawing.Point(3, 363)
        Me.tblStatus.Name = "tblStatus"
        Me.tblStatus.RowCount = 1
        Me.tblStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblStatus.Size = New System.Drawing.Size(684, 35)
        Me.tblStatus.TabIndex = 5
        '
        'tblButtonList
        '
        Me.tblButtonList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblButtonList.AutoSize = True
        Me.tblButtonList.ColumnCount = 1
        Me.tblButtonList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblButtonList.Controls.Add(Me.btnClick, 0, 6)
        Me.tblButtonList.Controls.Add(Me.btnMaintenance, 0, 5)
        Me.tblButtonList.Controls.Add(Me.btnHistory, 0, 4)
        Me.tblButtonList.Controls.Add(Me.Button1, 0, 3)
        Me.tblButtonList.Controls.Add(Me.txtInsert, 0, 1)
        Me.tblButtonList.Controls.Add(Me.btnIssue, 0, 2)
        Me.tblButtonList.Location = New System.Drawing.Point(49, 3)
        Me.tblButtonList.Name = "tblButtonList"
        Me.tblButtonList.RowCount = 7
        Me.tblButtonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.433962!))
        Me.tblButtonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434!))
        Me.tblButtonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434!))
        Me.tblButtonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434!))
        Me.tblButtonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434!))
        Me.tblButtonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434!))
        Me.tblButtonList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434!))
        Me.tblButtonList.Size = New System.Drawing.Size(133, 401)
        Me.tblButtonList.TabIndex = 15
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WatchMaintenanceSystem.My.Resources.Resources.system_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(928, 427)
        Me.Controls.Add(Me.tblHomepage)
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        CType(Me.dgvReminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblHomepage.ResumeLayout(False)
        Me.tblHomepage.PerformLayout()
        Me.tblReminder.ResumeLayout(False)
        Me.tblReminder.PerformLayout()
        Me.tblStatus.ResumeLayout(False)
        Me.tblStatus.PerformLayout()
        Me.tblButtonList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClick As System.Windows.Forms.Button
    Friend WithEvents txtInsert As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvReminder As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents btnMaintenance As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tblHomepage As TableLayoutPanel
    Friend WithEvents tblReminder As TableLayoutPanel
    Friend WithEvents tblStatus As TableLayoutPanel
    Friend WithEvents tblButtonList As TableLayoutPanel
End Class

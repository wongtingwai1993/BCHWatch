<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.trying = New System.Windows.Forms.Label
        Me.tFadeOut = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button
        Me.pbWatch = New System.Windows.Forms.PictureBox
        Me.watchDesc = New System.Windows.Forms.Label
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox
        CType(Me.pbWatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'trying
        '
        Me.trying.AutoSize = True
        Me.trying.Location = New System.Drawing.Point(121, 261)
        Me.trying.Name = "trying"
        Me.trying.Size = New System.Drawing.Size(39, 13)
        Me.trying.TabIndex = 2
        Me.trying.Text = "Label1"
        '
        'tFadeOut
        '
        Me.tFadeOut.Interval = 500
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(55, 296)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Button1"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'pbWatch
        '
        Me.pbWatch.BackgroundImage = Global.WatchMaintenanceSystem.My.Resources.Resources.WatchCondition
        Me.pbWatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbWatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbWatch.Location = New System.Drawing.Point(41, 63)
        Me.pbWatch.Name = "pbWatch"
        Me.pbWatch.Size = New System.Drawing.Size(187, 195)
        Me.pbWatch.TabIndex = 1
        Me.pbWatch.TabStop = False
        '
        'watchDesc
        '
        Me.watchDesc.AutoSize = True
        Me.watchDesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.watchDesc.Location = New System.Drawing.Point(258, 52)
        Me.watchDesc.Name = "watchDesc"
        Me.watchDesc.Size = New System.Drawing.Size(0, 19)
        Me.watchDesc.TabIndex = 5
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"testing", "testing", "testing"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(177, 12)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox1.TabIndex = 6
        Me.CheckedListBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "1"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckedListBox2)
        Me.Panel1.Location = New System.Drawing.Point(234, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 146)
        Me.Panel1.TabIndex = 8
        Me.Panel1.Visible = False
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"testing", "testing", "testing"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(14, 23)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox2.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 374)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.watchDesc)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.trying)
        Me.Controls.Add(Me.pbWatch)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbWatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbWatch As System.Windows.Forms.PictureBox
    Friend WithEvents trying As System.Windows.Forms.Label
    Friend WithEvents tFadeOut As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents watchDesc As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckedListBox2 As System.Windows.Forms.CheckedListBox
End Class

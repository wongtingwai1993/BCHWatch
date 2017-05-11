<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMaintain
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
        Me.btnAddOutsource = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddOutsource
        '
        Me.btnAddOutsource.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAddOutsource.Location = New System.Drawing.Point(40, 49)
        Me.btnAddOutsource.Name = "btnAddOutsource"
        Me.btnAddOutsource.Size = New System.Drawing.Size(112, 65)
        Me.btnAddOutsource.TabIndex = 0
        Me.btnAddOutsource.Text = "Add outsource company"
        Me.btnAddOutsource.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(40, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 65)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AdminMaintain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 277)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAddOutsource)
        Me.Name = "AdminMaintain"
        Me.Text = "AdminMaintain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddOutsource As Button
    Friend WithEvents Button2 As Button
End Class

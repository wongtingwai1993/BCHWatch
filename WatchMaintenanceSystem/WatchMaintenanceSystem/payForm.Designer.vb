<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.lbCondition = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtService = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.rbNo = New System.Windows.Forms.RadioButton
        Me.rbThree = New System.Windows.Forms.RadioButton
        Me.rbSix = New System.Windows.Forms.RadioButton
        Me.rbTwelve = New System.Windows.Forms.RadioButton
        Me.errNIL = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.errNIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.Yellow
        Me.txtPrice.Location = New System.Drawing.Point(309, 312)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(131, 31)
        Me.txtPrice.TabIndex = 1
        Me.txtPrice.Text = "RM XXX"
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(392, 368)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(110, 42)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lbCondition
        '
        Me.lbCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCondition.FormattingEnabled = True
        Me.lbCondition.ItemHeight = 16
        Me.lbCondition.Location = New System.Drawing.Point(122, 74)
        Me.lbCondition.Name = "lbCondition"
        Me.lbCondition.Size = New System.Drawing.Size(318, 132)
        Me.lbCondition.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Condition"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Service"
        '
        'txtService
        '
        Me.txtService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtService.Location = New System.Drawing.Point(122, 237)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(318, 22)
        Me.txtService.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 45)
        Me.Panel1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(213, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Payment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "NIL"
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.Location = New System.Drawing.Point(122, 280)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(44, 20)
        Me.rbNo.TabIndex = 9
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbThree
        '
        Me.rbThree.AutoSize = True
        Me.rbThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbThree.Location = New System.Drawing.Point(186, 280)
        Me.rbThree.Name = "rbThree"
        Me.rbThree.Size = New System.Drawing.Size(72, 20)
        Me.rbThree.TabIndex = 10
        Me.rbThree.TabStop = True
        Me.rbThree.Text = "3 month"
        Me.rbThree.UseVisualStyleBackColor = True
        '
        'rbSix
        '
        Me.rbSix.AutoSize = True
        Me.rbSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSix.Location = New System.Drawing.Point(275, 280)
        Me.rbSix.Name = "rbSix"
        Me.rbSix.Size = New System.Drawing.Size(72, 20)
        Me.rbSix.TabIndex = 11
        Me.rbSix.TabStop = True
        Me.rbSix.Text = "6 month"
        Me.rbSix.UseVisualStyleBackColor = True
        '
        'rbTwelve
        '
        Me.rbTwelve.AutoSize = True
        Me.rbTwelve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTwelve.Location = New System.Drawing.Point(361, 280)
        Me.rbTwelve.Name = "rbTwelve"
        Me.rbTwelve.Size = New System.Drawing.Size(79, 20)
        Me.rbTwelve.TabIndex = 12
        Me.rbTwelve.TabStop = True
        Me.rbTwelve.Text = "12 month"
        Me.rbTwelve.UseVisualStyleBackColor = True
        '
        'errNIL
        '
        Me.errNIL.ContainerControl = Me
        '
        'payForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 431)
        Me.Controls.Add(Me.rbTwelve)
        Me.Controls.Add(Me.rbSix)
        Me.Controls.Add(Me.rbThree)
        Me.Controls.Add(Me.rbNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtService)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbCondition)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "payForm"
        Me.Text = "payForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.errNIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents lbCondition As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtService As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbThree As System.Windows.Forms.RadioButton
    Friend WithEvents rbSix As System.Windows.Forms.RadioButton
    Friend WithEvents rbTwelve As System.Windows.Forms.RadioButton
    Friend WithEvents errNIL As System.Windows.Forms.ErrorProvider
End Class

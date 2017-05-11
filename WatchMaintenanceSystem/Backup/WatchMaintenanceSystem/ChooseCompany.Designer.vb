<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseCompany
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
        Me.cbCompany = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.btnIssue = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.rbHand = New System.Windows.Forms.RadioButton
        Me.rbPost = New System.Windows.Forms.RadioButton
        Me.errName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errAddress = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errTel = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errDelivery = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtIssue = New System.Windows.Forms.TextBox
        Me.errIssueBy = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.errName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errTel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errIssueBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCompany
        '
        Me.cbCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCompany.FormattingEnabled = True
        Me.cbCompany.Location = New System.Drawing.Point(111, 64)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(237, 24)
        Me.cbCompany.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tel"
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(111, 144)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(237, 104)
        Me.txtAddress.TabIndex = 5
        '
        'txtTel
        '
        Me.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(111, 272)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(237, 22)
        Me.txtTel.TabIndex = 6
        '
        'btnIssue
        '
        Me.btnIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.Location = New System.Drawing.Point(240, 415)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(108, 35)
        Me.btnIssue.TabIndex = 7
        Me.btnIssue.Text = "Issue"
        Me.btnIssue.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(12, 415)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 35)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Name"
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(111, 101)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(237, 22)
        Me.txtName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Delivery"
        '
        'rbHand
        '
        Me.rbHand.AutoSize = True
        Me.rbHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHand.Location = New System.Drawing.Point(111, 359)
        Me.rbHand.Name = "rbHand"
        Me.rbHand.Size = New System.Drawing.Size(78, 20)
        Me.rbHand.TabIndex = 12
        Me.rbHand.TabStop = True
        Me.rbHand.Text = "By Hand"
        Me.rbHand.UseVisualStyleBackColor = True
        '
        'rbPost
        '
        Me.rbPost.AutoSize = True
        Me.rbPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPost.Location = New System.Drawing.Point(276, 359)
        Me.rbPost.Name = "rbPost"
        Me.rbPost.Size = New System.Drawing.Size(72, 20)
        Me.rbPost.TabIndex = 13
        Me.rbPost.TabStop = True
        Me.rbPost.Text = "By Post"
        Me.rbPost.UseVisualStyleBackColor = True
        '
        'errName
        '
        Me.errName.ContainerControl = Me
        '
        'errAddress
        '
        Me.errAddress.ContainerControl = Me
        '
        'errTel
        '
        Me.errTel.ContainerControl = Me
        '
        'errDelivery
        '
        Me.errDelivery.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Choose Company"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Issue By"
        '
        'txtIssue
        '
        Me.txtIssue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssue.Location = New System.Drawing.Point(111, 309)
        Me.txtIssue.Name = "txtIssue"
        Me.txtIssue.Size = New System.Drawing.Size(237, 22)
        Me.txtIssue.TabIndex = 16
        '
        'errIssueBy
        '
        Me.errIssueBy.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 40)
        Me.Panel1.TabIndex = 17
        '
        'ChooseCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 475)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtIssue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rbPost)
        Me.Controls.Add(Me.rbHand)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnIssue)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCompany)
        Me.Name = "ChooseCompany"
        Me.Text = "ChooseCompany"
        CType(Me.errName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errTel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errIssueBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbHand As System.Windows.Forms.RadioButton
    Friend WithEvents rbPost As System.Windows.Forms.RadioButton
    Friend WithEvents errName As System.Windows.Forms.ErrorProvider
    Friend WithEvents errAddress As System.Windows.Forms.ErrorProvider
    Friend WithEvents errTel As System.Windows.Forms.ErrorProvider
    Friend WithEvents errDelivery As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtIssue As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents errIssueBy As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

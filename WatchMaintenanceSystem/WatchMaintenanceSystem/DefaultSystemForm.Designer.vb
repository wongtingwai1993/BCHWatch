<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class defaultSystemForm
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.txtPrefix = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.errLocation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errAddress = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errPrefix = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errFax = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errTel = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errPrefix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errFax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errTel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Location: "
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(17, 131)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(66, 16)
        Me.Label.TabIndex = 2
        Me.Label.Text = "Address: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prefix: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tel: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fax: "
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(101, 83)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(133, 22)
        Me.txtLocation.TabIndex = 6
        '
        'txtPrefix
        '
        Me.txtPrefix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefix.Location = New System.Drawing.Point(101, 176)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(133, 22)
        Me.txtPrefix.TabIndex = 7
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(101, 288)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(133, 22)
        Me.txtTel.TabIndex = 8
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(101, 233)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(133, 22)
        Me.txtFax.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(101, 131)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(311, 22)
        Me.txtAddress.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(375, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(17, 326)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 34)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'errLocation
        '
        Me.errLocation.ContainerControl = Me
        '
        'errAddress
        '
        Me.errAddress.ContainerControl = Me
        '
        'errPrefix
        '
        Me.errPrefix.ContainerControl = Me
        '
        'errFax
        '
        Me.errFax.ContainerControl = Me
        '
        'errTel
        '
        Me.errTel.ContainerControl = Me
        '
        'defaultSystemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 382)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "defaultSystemForm"
        Me.Text = "defaultSystemForm"
        CType(Me.errLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errPrefix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errFax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errTel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents errLocation As System.Windows.Forms.ErrorProvider
    Friend WithEvents errAddress As System.Windows.Forms.ErrorProvider
    Friend WithEvents errPrefix As System.Windows.Forms.ErrorProvider
    Friend WithEvents errFax As System.Windows.Forms.ErrorProvider
    Friend WithEvents errTel As System.Windows.Forms.ErrorProvider
End Class

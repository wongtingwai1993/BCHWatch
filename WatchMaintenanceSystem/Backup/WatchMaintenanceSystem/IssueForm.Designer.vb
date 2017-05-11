<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class issueForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(issueForm))
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBrand = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPhone2 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbYear = New System.Windows.Forms.ComboBox
        Me.cbMonth = New System.Windows.Forms.ComboBox
        Me.cbDay = New System.Windows.Forms.ComboBox
        Me.chkWarrantly = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSerial = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkGender = New System.Windows.Forms.CheckedListBox
        Me.chkBrace = New System.Windows.Forms.CheckedListBox
        Me.chkType = New System.Windows.Forms.CheckedListBox
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtIssueBy = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtReceipt = New System.Windows.Forms.TextBox
        Me.errName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errPhone = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errBrand = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errModel = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errGender = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errIssueBy = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.printDocument = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.errWatchType = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errBrace = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errSurface = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errConditionScratch = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errConditionCrack = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errConditionDiscolour = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errConditionOther = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.Printtest = New System.Windows.Forms.PrintDialog
        Me.strapTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pusherTimer = New System.Windows.Forms.Timer(Me.components)
        Me.crownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.circleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.surfaceTimer = New System.Windows.Forms.Timer(Me.components)
        Me.dialTimer = New System.Windows.Forms.Timer(Me.components)
        Me.sideTimer = New System.Windows.Forms.Timer(Me.components)
        Me.serviceGroup = New System.Windows.Forms.GroupBox
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtServices = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.errDate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errCondition = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errSerial = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errServices = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnIssue = New System.Windows.Forms.Button
        Me.grpServices = New System.Windows.Forms.GroupBox
        Me.surfacePanel = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.chkConSurface = New System.Windows.Forms.CheckedListBox
        Me.strapPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.cblConStrap = New System.Windows.Forms.CheckedListBox
        Me.sidePanel = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.chkSide = New System.Windows.Forms.CheckedListBox
        Me.dialPanel = New System.Windows.Forms.Panel
        Me.Label17 = New System.Windows.Forms.Label
        Me.chkDial = New System.Windows.Forms.CheckedListBox
        Me.circlePanel = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.chkCircle = New System.Windows.Forms.CheckedListBox
        Me.crownPanel = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.chkCrown = New System.Windows.Forms.CheckedListBox
        Me.pusherPanel = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkPusher = New System.Windows.Forms.CheckedListBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbCondition = New System.Windows.Forms.ListBox
        Me.lblWatchDesc = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.printPreviewMaintain = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocumentMaintain = New System.Drawing.Printing.PrintDocument
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.errName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errIssueBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errWatchType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errBrace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errSurface, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errConditionScratch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errConditionCrack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errConditionDiscolour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errConditionOther, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.serviceGroup.SuspendLayout()
        CType(Me.errDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServices.SuspendLayout()
        Me.surfacePanel.SuspendLayout()
        Me.strapPanel.SuspendLayout()
        Me.sidePanel.SuspendLayout()
        Me.dialPanel.SuspendLayout()
        Me.circlePanel.SuspendLayout()
        Me.crownPanel.SuspendLayout()
        Me.pusherPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblName.Location = New System.Drawing.Point(6, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(63, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.txtName.Location = New System.Drawing.Point(202, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(241, 30)
        Me.txtName.TabIndex = 1
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblPhone.Location = New System.Drawing.Point(6, 78)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(150, 24)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.txtPhone.Location = New System.Drawing.Point(202, 72)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(241, 30)
        Me.txtPhone.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brand"
        '
        'txtBrand
        '
        Me.txtBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBrand.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.txtBrand.Location = New System.Drawing.Point(184, 37)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(259, 30)
        Me.txtBrand.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Model"
        '
        'txtModel
        '
        Me.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModel.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.txtModel.Location = New System.Drawing.Point(184, 72)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(259, 30)
        Me.txtModel.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.BackgroundImage = Global.WatchMaintenanceSystem.My.Resources.Resources.system_background
        Me.GroupBox1.Controls.Add(Me.txtPhone2)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 182)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer"
        '
        'txtPhone2
        '
        Me.txtPhone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhone2.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.txtPhone2.Location = New System.Drawing.Point(202, 111)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(241, 30)
        Me.txtPhone2.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label21.Location = New System.Drawing.Point(5, 117)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(172, 24)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Phone Number#2"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.BackgroundImage = Global.WatchMaintenanceSystem.My.Resources.Resources.system_background
        Me.GroupBox2.Controls.Add(Me.cbYear)
        Me.GroupBox2.Controls.Add(Me.cbMonth)
        Me.GroupBox2.Controls.Add(Me.cbDay)
        Me.GroupBox2.Controls.Add(Me.chkWarrantly)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtSerial)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.chkGender)
        Me.GroupBox2.Controls.Add(Me.chkBrace)
        Me.GroupBox2.Controls.Add(Me.chkType)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtBrand)
        Me.GroupBox2.Controls.Add(Me.txtModel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 412)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Watch"
        '
        'cbYear
        '
        Me.cbYear.Enabled = False
        Me.cbYear.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Location = New System.Drawing.Point(295, 138)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(80, 31)
        Me.cbYear.TabIndex = 10
        '
        'cbMonth
        '
        Me.cbMonth.Enabled = False
        Me.cbMonth.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.cbMonth.FormattingEnabled = True
        Me.cbMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbMonth.Location = New System.Drawing.Point(237, 138)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(52, 31)
        Me.cbMonth.TabIndex = 9
        '
        'cbDay
        '
        Me.cbDay.Enabled = False
        Me.cbDay.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbDay.Location = New System.Drawing.Point(184, 138)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(47, 31)
        Me.cbDay.TabIndex = 8
        '
        'chkWarrantly
        '
        Me.chkWarrantly.AutoSize = True
        Me.chkWarrantly.BackColor = System.Drawing.Color.Transparent
        Me.chkWarrantly.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.chkWarrantly.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.chkWarrantly.Location = New System.Drawing.Point(381, 142)
        Me.chkWarrantly.Name = "chkWarrantly"
        Me.chkWarrantly.Size = New System.Drawing.Size(62, 27)
        Me.chkWarrantly.TabIndex = 7
        Me.chkWarrantly.Text = "Yes"
        Me.chkWarrantly.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label4.Location = New System.Drawing.Point(6, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Warranty"
        '
        'txtSerial
        '
        Me.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerial.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.txtSerial.Location = New System.Drawing.Point(184, 104)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(259, 30)
        Me.txtSerial.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "S/ No"
        '
        'chkGender
        '
        Me.chkGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.chkGender.CheckOnClick = True
        Me.chkGender.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.chkGender.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.chkGender.FormattingEnabled = True
        Me.chkGender.Items.AddRange(New Object() {"Men", "Ladies", "Unisex"})
        Me.chkGender.Location = New System.Drawing.Point(23, 213)
        Me.chkGender.Name = "chkGender"
        Me.chkGender.Size = New System.Drawing.Size(120, 154)
        Me.chkGender.TabIndex = 11
        '
        'chkBrace
        '
        Me.chkBrace.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.chkBrace.CheckOnClick = True
        Me.chkBrace.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.chkBrace.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.chkBrace.FormattingEnabled = True
        Me.chkBrace.Items.AddRange(New Object() {"Strap", "Steel", "Rubber", "Gold ", "Titanium", "Ceramic"})
        Me.chkBrace.Location = New System.Drawing.Point(312, 213)
        Me.chkBrace.Name = "chkBrace"
        Me.chkBrace.Size = New System.Drawing.Size(122, 154)
        Me.chkBrace.TabIndex = 13
        '
        'chkType
        '
        Me.chkType.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.chkType.CheckOnClick = True
        Me.chkType.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.chkType.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.chkType.FormattingEnabled = True
        Me.chkType.Items.AddRange(New Object() {"Auto", "Quartz"})
        Me.chkType.Location = New System.Drawing.Point(165, 213)
        Me.chkType.Name = "chkType"
        Me.chkType.Size = New System.Drawing.Size(124, 154)
        Me.chkType.TabIndex = 12
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = Global.WatchMaintenanceSystem.My.Resources.Resources.back_icon
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(12, 671)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(183, 44)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.WatchMaintenanceSystem.My.Resources.Resources.insertIcon
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(1152, 112)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(140, 44)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label9.Location = New System.Drawing.Point(657, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txtDate.Location = New System.Drawing.Point(715, 7)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(111, 29)
        Me.txtDate.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label10.Location = New System.Drawing.Point(13, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 24)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Issue By"
        '
        'txtIssueBy
        '
        Me.txtIssueBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIssueBy.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.txtIssueBy.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIssueBy.Location = New System.Drawing.Point(119, 254)
        Me.txtIssueBy.Name = "txtIssueBy"
        Me.txtIssueBy.Size = New System.Drawing.Size(111, 30)
        Me.txtIssueBy.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label11.Location = New System.Drawing.Point(411, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 22)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Receipt No"
        '
        'txtReceipt
        '
        Me.txtReceipt.Enabled = False
        Me.txtReceipt.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txtReceipt.Location = New System.Drawing.Point(520, 6)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(122, 29)
        Me.txtReceipt.TabIndex = 26
        '
        'errName
        '
        Me.errName.ContainerControl = Me
        '
        'errPhone
        '
        Me.errPhone.ContainerControl = Me
        '
        'errBrand
        '
        Me.errBrand.ContainerControl = Me
        '
        'errModel
        '
        Me.errModel.ContainerControl = Me
        '
        'errGender
        '
        Me.errGender.ContainerControl = Me
        '
        'errIssueBy
        '
        Me.errIssueBy.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WatchMaintenanceSystem.My.Resources.Resources.printButton
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1152, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 44)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'printDocument
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.printDocument
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'errWatchType
        '
        Me.errWatchType.ContainerControl = Me
        '
        'errBrace
        '
        Me.errBrace.ContainerControl = Me
        '
        'errSurface
        '
        Me.errSurface.ContainerControl = Me
        '
        'errConditionScratch
        '
        Me.errConditionScratch.ContainerControl = Me
        '
        'errConditionCrack
        '
        Me.errConditionCrack.ContainerControl = Me
        '
        'errConditionDiscolour
        '
        Me.errConditionDiscolour.ContainerControl = Me
        '
        'errConditionOther
        '
        Me.errConditionOther.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Location = New System.Drawing.Point(201, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 22)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txtStatus.Location = New System.Drawing.Point(276, 7)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(122, 29)
        Me.txtStatus.TabIndex = 30
        '
        'Printtest
        '
        Me.Printtest.Document = Me.printDocument
        Me.Printtest.UseEXDialog = True
        '
        'strapTimer
        '
        Me.strapTimer.Interval = 700
        '
        'pusherTimer
        '
        Me.pusherTimer.Interval = 700
        '
        'crownTimer
        '
        Me.crownTimer.Interval = 700
        '
        'circleTimer
        '
        Me.circleTimer.Interval = 700
        '
        'surfaceTimer
        '
        Me.surfaceTimer.Interval = 700
        '
        'dialTimer
        '
        Me.dialTimer.Interval = 700
        '
        'sideTimer
        '
        Me.sideTimer.Interval = 700
        '
        'serviceGroup
        '
        Me.serviceGroup.BackColor = System.Drawing.Color.LightSteelBlue
        Me.serviceGroup.BackgroundImage = Global.WatchMaintenanceSystem.My.Resources.Resources.system_background
        Me.serviceGroup.Controls.Add(Me.txtRemark)
        Me.serviceGroup.Controls.Add(Me.Label20)
        Me.serviceGroup.Controls.Add(Me.txtServices)
        Me.serviceGroup.Controls.Add(Me.Label19)
        Me.serviceGroup.Controls.Add(Me.txtIssueBy)
        Me.serviceGroup.Controls.Add(Me.Label10)
        Me.serviceGroup.Font = New System.Drawing.Font("Arial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.serviceGroup.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.serviceGroup.Location = New System.Drawing.Point(520, 345)
        Me.serviceGroup.Name = "serviceGroup"
        Me.serviceGroup.Size = New System.Drawing.Size(610, 303)
        Me.serviceGroup.TabIndex = 35
        Me.serviceGroup.TabStop = False
        Me.serviceGroup.Text = "Service && Remark"
        '
        'txtRemark
        '
        Me.txtRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemark.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.txtRemark.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRemark.Location = New System.Drawing.Point(120, 87)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(442, 116)
        Me.txtRemark.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label20.Location = New System.Drawing.Point(13, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 24)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Remark"
        '
        'txtServices
        '
        Me.txtServices.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtServices.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.txtServices.Location = New System.Drawing.Point(120, 43)
        Me.txtServices.Name = "txtServices"
        Me.txtServices.Size = New System.Drawing.Size(442, 30)
        Me.txtServices.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label19.Location = New System.Drawing.Point(10, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 24)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Service"
        '
        'errDate
        '
        Me.errDate.ContainerControl = Me
        '
        'errCondition
        '
        Me.errCondition.ContainerControl = Me
        '
        'errSerial
        '
        Me.errSerial.ContainerControl = Me
        '
        'errServices
        '
        Me.errServices.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.WatchMaintenanceSystem.My.Resources.Resources.companyLogo
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(11, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 30)
        Me.Panel2.TabIndex = 6
        '
        'btnIssue
        '
        Me.btnIssue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIssue.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnIssue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.Image = Global.WatchMaintenanceSystem.My.Resources.Resources.insertIcon
        Me.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssue.Location = New System.Drawing.Point(1152, 169)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(140, 44)
        Me.btnIssue.TabIndex = 36
        Me.btnIssue.Text = "Issue"
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'grpServices
        '
        Me.grpServices.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpServices.BackgroundImage = Global.WatchMaintenanceSystem.My.Resources.Resources.system_background
        Me.grpServices.Controls.Add(Me.surfacePanel)
        Me.grpServices.Controls.Add(Me.strapPanel)
        Me.grpServices.Controls.Add(Me.sidePanel)
        Me.grpServices.Controls.Add(Me.dialPanel)
        Me.grpServices.Controls.Add(Me.circlePanel)
        Me.grpServices.Controls.Add(Me.crownPanel)
        Me.grpServices.Controls.Add(Me.pusherPanel)
        Me.grpServices.Controls.Add(Me.Panel1)
        Me.grpServices.Controls.Add(Me.PictureBox1)
        Me.grpServices.Font = New System.Drawing.Font("Arial", 17.0!, System.Drawing.FontStyle.Bold)
        Me.grpServices.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grpServices.Location = New System.Drawing.Point(520, 45)
        Me.grpServices.Name = "grpServices"
        Me.grpServices.Size = New System.Drawing.Size(610, 281)
        Me.grpServices.TabIndex = 37
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
        Me.surfacePanel.Location = New System.Drawing.Point(116, 140)
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
        Me.strapPanel.Location = New System.Drawing.Point(99, 2)
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
        Me.sidePanel.Location = New System.Drawing.Point(83, 171)
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
        Me.dialPanel.Location = New System.Drawing.Point(91, 22)
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
        Me.circlePanel.Location = New System.Drawing.Point(151, 168)
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
        Me.crownPanel.Location = New System.Drawing.Point(167, 134)
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
        Me.pusherPanel.Location = New System.Drawing.Point(163, -4)
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lbCondition)
        Me.Panel1.Controls.Add(Me.lblWatchDesc)
        Me.Panel1.Location = New System.Drawing.Point(304, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 195)
        Me.Panel1.TabIndex = 32
        '
        'lbCondition
        '
        Me.lbCondition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCondition.FormattingEnabled = True
        Me.lbCondition.ItemHeight = 16
        Me.lbCondition.Location = New System.Drawing.Point(9, 35)
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
        Me.PictureBox1.Location = New System.Drawing.Point(16, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 195)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'printPreviewMaintain
        '
        Me.printPreviewMaintain.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewMaintain.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewMaintain.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewMaintain.Document = Me.PrintDocumentMaintain
        Me.printPreviewMaintain.Enabled = True
        Me.printPreviewMaintain.Icon = CType(resources.GetObject("printPreviewMaintain.Icon"), System.Drawing.Icon)
        Me.printPreviewMaintain.Name = "printPreviewMaintain"
        Me.printPreviewMaintain.Visible = False
        '
        'PrintDocumentMaintain
        '
        '
        'issueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.WatchMaintenanceSystem.My.Resources.Resources.backgrounds_04
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1304, 732)
        Me.Controls.Add(Me.grpServices)
        Me.Controls.Add(Me.btnIssue)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.serviceGroup)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtReceipt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "issueForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issue Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.errName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errBrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errIssueBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errWatchType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errBrace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errSurface, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errConditionScratch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errConditionCrack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errConditionDiscolour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errConditionOther, System.ComponentModel.ISupportInitialize).EndInit()
        Me.serviceGroup.ResumeLayout(False)
        Me.serviceGroup.PerformLayout()
        CType(Me.errDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errCondition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errSerial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errServices, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBrand As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIssueBy As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtReceipt As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents errName As System.Windows.Forms.ErrorProvider
    Friend WithEvents errPhone As System.Windows.Forms.ErrorProvider
    Friend WithEvents errBrand As System.Windows.Forms.ErrorProvider
    Friend WithEvents errModel As System.Windows.Forms.ErrorProvider
    Friend WithEvents errGender As System.Windows.Forms.ErrorProvider
    Friend WithEvents errIssueBy As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents printDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents errWatchType As System.Windows.Forms.ErrorProvider
    Friend WithEvents errBrace As System.Windows.Forms.ErrorProvider
    Friend WithEvents errSurface As System.Windows.Forms.ErrorProvider
    Friend WithEvents errConditionScratch As System.Windows.Forms.ErrorProvider
    Friend WithEvents errConditionCrack As System.Windows.Forms.ErrorProvider
    Friend WithEvents errConditionDiscolour As System.Windows.Forms.ErrorProvider
    Friend WithEvents errConditionOther As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Printtest As System.Windows.Forms.PrintDialog
    Friend WithEvents strapTimer As System.Windows.Forms.Timer
    Friend WithEvents pusherTimer As System.Windows.Forms.Timer
    Friend WithEvents crownTimer As System.Windows.Forms.Timer
    Friend WithEvents circleTimer As System.Windows.Forms.Timer
    Friend WithEvents surfaceTimer As System.Windows.Forms.Timer
    Friend WithEvents dialTimer As System.Windows.Forms.Timer
    Friend WithEvents sideTimer As System.Windows.Forms.Timer
    Friend WithEvents serviceGroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtServices As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chkGender As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkBrace As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkType As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cbDay As System.Windows.Forms.ComboBox
    Friend WithEvents chkWarrantly As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents errDate As System.Windows.Forms.ErrorProvider
    Friend WithEvents errCondition As System.Windows.Forms.ErrorProvider
    Friend WithEvents errSerial As System.Windows.Forms.ErrorProvider
    Friend WithEvents errServices As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents grpServices As System.Windows.Forms.GroupBox
    Friend WithEvents surfacePanel As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chkConSurface As System.Windows.Forms.CheckedListBox
    Friend WithEvents strapPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cblConStrap As System.Windows.Forms.CheckedListBox
    Friend WithEvents sidePanel As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chkSide As System.Windows.Forms.CheckedListBox
    Friend WithEvents dialPanel As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkDial As System.Windows.Forms.CheckedListBox
    Friend WithEvents circlePanel As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkCircle As System.Windows.Forms.CheckedListBox
    Friend WithEvents crownPanel As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkCrown As System.Windows.Forms.CheckedListBox
    Friend WithEvents pusherPanel As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkPusher As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbCondition As System.Windows.Forms.ListBox
    Friend WithEvents lblWatchDesc As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents printPreviewMaintain As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocumentMaintain As System.Drawing.Printing.PrintDocument
End Class

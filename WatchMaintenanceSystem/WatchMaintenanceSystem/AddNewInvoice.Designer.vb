<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewInvoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewInvoice))
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtPhone2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.errName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errPhone = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errBrand = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errModel = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errGender = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errIssueBy = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.printDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.errWatchType = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errBrace = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errSurface = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errConditionScratch = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errConditionCrack = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errConditionDiscolour = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errConditionOther = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Printtest = New System.Windows.Forms.PrintDialog()
        Me.strapTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pusherTimer = New System.Windows.Forms.Timer(Me.components)
        Me.crownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.circleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.surfaceTimer = New System.Windows.Forms.Timer(Me.components)
        Me.dialTimer = New System.Windows.Forms.Timer(Me.components)
        Me.sideTimer = New System.Windows.Forms.Timer(Me.components)
        Me.conditionPanel = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtServices = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.errDate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errSerial = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errServices = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tblWhole = New System.Windows.Forms.TableLayoutPanel()
        Me.tblBody = New System.Windows.Forms.TableLayoutPanel()
        Me.tblLeft = New System.Windows.Forms.TableLayoutPanel()
        Me.tblWatch = New System.Windows.Forms.TableLayoutPanel()
        Me.tblWatchDetail = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblDropbox = New System.Windows.Forms.TableLayoutPanel()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.chkWarrantly = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.panelWatch = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.tblWatchMoreDetail = New System.Windows.Forms.TableLayoutPanel()
        Me.chkType = New System.Windows.Forms.CheckedListBox()
        Me.chkGender = New System.Windows.Forms.CheckedListBox()
        Me.chkBrace = New System.Windows.Forms.CheckedListBox()
        Me.CustDesignPanel = New System.Windows.Forms.Panel()
        Me.tblCustomer = New System.Windows.Forms.TableLayoutPanel()
        Me.panelCustomer = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tblRight = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtIssueBy = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.tblTopPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.panelWatchDesign = New System.Windows.Forms.Panel()
        Me.panelWatchCondition = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tblCondition = New System.Windows.Forms.TableLayoutPanel()
        Me.tblConditionButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClearCon = New System.Windows.Forms.Button()
        Me.lbCondition = New System.Windows.Forms.ListBox()
        Me.pcbWatchSketch = New System.Windows.Forms.PictureBox()
        Me.tblWatchCon = New System.Windows.Forms.TableLayoutPanel()
        Me.panelWatchConDesign = New System.Windows.Forms.Panel()
        Me.panelServiceDesign = New System.Windows.Forms.Panel()
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
        CType(Me.errDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblWhole.SuspendLayout()
        Me.tblBody.SuspendLayout()
        Me.tblLeft.SuspendLayout()
        Me.tblWatch.SuspendLayout()
        Me.tblWatchDetail.SuspendLayout()
        Me.tblDropbox.SuspendLayout()
        Me.panelWatch.SuspendLayout()
        Me.tblWatchMoreDetail.SuspendLayout()
        Me.CustDesignPanel.SuspendLayout()
        Me.tblCustomer.SuspendLayout()
        Me.panelCustomer.SuspendLayout()
        Me.tblRight.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.topPanel.SuspendLayout()
        Me.tblTopPanel.SuspendLayout()
        Me.panelWatchDesign.SuspendLayout()
        Me.panelWatchCondition.SuspendLayout()
        Me.tblCondition.SuspendLayout()
        Me.tblConditionButton.SuspendLayout()
        CType(Me.pcbWatchSketch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblWatchCon.SuspendLayout()
        Me.panelWatchConDesign.SuspendLayout()
        Me.panelServiceDesign.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblName.Location = New System.Drawing.Point(3, 63)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 18)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.txtName.Location = New System.Drawing.Point(138, 60)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(241, 24)
        Me.txtName.TabIndex = 1
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPhone.Location = New System.Drawing.Point(3, 111)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(114, 18)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.txtPhone.Location = New System.Drawing.Point(138, 108)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(241, 24)
        Me.txtPhone.TabIndex = 2
        '
        'txtPhone2
        '
        Me.txtPhone2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPhone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhone2.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.txtPhone2.Location = New System.Drawing.Point(138, 156)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(241, 24)
        Me.txtPhone2.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(3, 150)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 36)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Phone Number#2"
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
        'conditionPanel
        '
        Me.conditionPanel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.conditionPanel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.conditionPanel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.conditionPanel.Location = New System.Drawing.Point(114, 87)
        Me.conditionPanel.Multiline = True
        Me.conditionPanel.Name = "conditionPanel"
        Me.conditionPanel.Size = New System.Drawing.Size(274, 89)
        Me.conditionPanel.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(3, 84)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 18)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Remark"
        '
        'txtServices
        '
        Me.txtServices.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtServices.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.txtServices.Location = New System.Drawing.Point(114, 27)
        Me.txtServices.Name = "txtServices"
        Me.txtServices.Size = New System.Drawing.Size(192, 24)
        Me.txtServices.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(3, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 18)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Service"
        '
        'errDate
        '
        Me.errDate.ContainerControl = Me
        '
        'errSerial
        '
        Me.errSerial.ContainerControl = Me
        '
        'errServices
        '
        Me.errServices.ContainerControl = Me
        '
        'tblWhole
        '
        Me.tblWhole.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tblWhole.ColumnCount = 4
        Me.tblWhole.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblWhole.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblWhole.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblWhole.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblWhole.Controls.Add(Me.tblBody, 1, 2)
        Me.tblWhole.Controls.Add(Me.btnBack, 1, 3)
        Me.tblWhole.Controls.Add(Me.TableLayoutPanel1, 2, 2)
        Me.tblWhole.Controls.Add(Me.topPanel, 0, 0)
        Me.tblWhole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblWhole.Location = New System.Drawing.Point(0, 0)
        Me.tblWhole.Name = "tblWhole"
        Me.tblWhole.RowCount = 5
        Me.tblWhole.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblWhole.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblWhole.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tblWhole.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblWhole.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblWhole.Size = New System.Drawing.Size(1304, 732)
        Me.tblWhole.TabIndex = 36
        '
        'tblBody
        '
        Me.tblBody.ColumnCount = 2
        Me.tblBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tblBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.tblBody.Controls.Add(Me.tblLeft, 0, 0)
        Me.tblBody.Controls.Add(Me.tblRight, 1, 0)
        Me.tblBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBody.Location = New System.Drawing.Point(68, 112)
        Me.tblBody.Name = "tblBody"
        Me.tblBody.RowCount = 1
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblBody.Size = New System.Drawing.Size(1037, 506)
        Me.tblBody.TabIndex = 1
        '
        'tblLeft
        '
        Me.tblLeft.AutoSize = True
        Me.tblLeft.ColumnCount = 1
        Me.tblLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLeft.Controls.Add(Me.CustDesignPanel, 0, 0)
        Me.tblLeft.Controls.Add(Me.panelWatchDesign, 0, 1)
        Me.tblLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLeft.Location = New System.Drawing.Point(3, 3)
        Me.tblLeft.Name = "tblLeft"
        Me.tblLeft.RowCount = 2
        Me.tblLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tblLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tblLeft.Size = New System.Drawing.Size(460, 500)
        Me.tblLeft.TabIndex = 0
        '
        'tblWatch
        '
        Me.tblWatch.ColumnCount = 1
        Me.tblWatch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblWatch.Controls.Add(Me.tblWatchDetail, 0, 0)
        Me.tblWatch.Controls.Add(Me.tblWatchMoreDetail, 0, 1)
        Me.tblWatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblWatch.Location = New System.Drawing.Point(0, 0)
        Me.tblWatch.Name = "tblWatch"
        Me.tblWatch.RowCount = 2
        Me.tblWatch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.tblWatch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tblWatch.Size = New System.Drawing.Size(452, 292)
        Me.tblWatch.TabIndex = 30
        '
        'tblWatchDetail
        '
        Me.tblWatchDetail.ColumnCount = 2
        Me.tblWatchDetail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblWatchDetail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tblWatchDetail.Controls.Add(Me.Label3, 0, 3)
        Me.tblWatchDetail.Controls.Add(Me.Label2, 0, 2)
        Me.tblWatchDetail.Controls.Add(Me.Label1, 0, 1)
        Me.tblWatchDetail.Controls.Add(Me.tblDropbox, 1, 4)
        Me.tblWatchDetail.Controls.Add(Me.Label4, 0, 4)
        Me.tblWatchDetail.Controls.Add(Me.txtBrand, 1, 1)
        Me.tblWatchDetail.Controls.Add(Me.panelWatch, 0, 0)
        Me.tblWatchDetail.Controls.Add(Me.txtModel, 1, 2)
        Me.tblWatchDetail.Controls.Add(Me.txtSerial, 1, 3)
        Me.tblWatchDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblWatchDetail.Location = New System.Drawing.Point(3, 3)
        Me.tblWatchDetail.Name = "tblWatchDetail"
        Me.tblWatchDetail.RowCount = 5
        Me.tblWatchDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152!))
        Me.tblWatchDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.21212!))
        Me.tblWatchDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.21212!))
        Me.tblWatchDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.21212!))
        Me.tblWatchDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.21212!))
        Me.tblWatchDetail.Size = New System.Drawing.Size(446, 154)
        Me.tblWatchDetail.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(3, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "S/ No"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(3, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Model"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brand"
        '
        'tblDropbox
        '
        Me.tblDropbox.ColumnCount = 4
        Me.tblDropbox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblDropbox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblDropbox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblDropbox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblDropbox.Controls.Add(Me.cbYear, 0, 0)
        Me.tblDropbox.Controls.Add(Me.cbMonth, 0, 0)
        Me.tblDropbox.Controls.Add(Me.cbDay, 0, 0)
        Me.tblDropbox.Controls.Add(Me.chkWarrantly, 3, 0)
        Me.tblDropbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDropbox.Location = New System.Drawing.Point(136, 122)
        Me.tblDropbox.Name = "tblDropbox"
        Me.tblDropbox.RowCount = 1
        Me.tblDropbox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDropbox.Size = New System.Drawing.Size(307, 29)
        Me.tblDropbox.TabIndex = 29
        '
        'cbYear
        '
        Me.cbYear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbYear.Enabled = False
        Me.cbYear.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Location = New System.Drawing.Point(155, 3)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(70, 25)
        Me.cbYear.TabIndex = 11
        '
        'cbMonth
        '
        Me.cbMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbMonth.Enabled = False
        Me.cbMonth.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cbMonth.FormattingEnabled = True
        Me.cbMonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbMonth.Location = New System.Drawing.Point(79, 3)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(70, 25)
        Me.cbMonth.TabIndex = 10
        '
        'cbDay
        '
        Me.cbDay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbDay.Enabled = False
        Me.cbDay.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbDay.Location = New System.Drawing.Point(3, 3)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(70, 25)
        Me.cbDay.TabIndex = 9
        '
        'chkWarrantly
        '
        Me.chkWarrantly.AutoSize = True
        Me.chkWarrantly.BackColor = System.Drawing.Color.Transparent
        Me.chkWarrantly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkWarrantly.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.chkWarrantly.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkWarrantly.Location = New System.Drawing.Point(231, 3)
        Me.chkWarrantly.Name = "chkWarrantly"
        Me.chkWarrantly.Size = New System.Drawing.Size(73, 23)
        Me.chkWarrantly.TabIndex = 12
        Me.chkWarrantly.Text = "Yes"
        Me.chkWarrantly.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(3, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Warranty"
        '
        'txtBrand
        '
        Me.txtBrand.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBrand.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.txtBrand.Location = New System.Drawing.Point(136, 27)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(192, 24)
        Me.txtBrand.TabIndex = 1
        '
        'panelWatch
        '
        Me.panelWatch.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tblWatchDetail.SetColumnSpan(Me.panelWatch, 2)
        Me.panelWatch.Controls.Add(Me.Label7)
        Me.panelWatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelWatch.Location = New System.Drawing.Point(3, 3)
        Me.panelWatch.Name = "panelWatch"
        Me.panelWatch.Size = New System.Drawing.Size(440, 17)
        Me.panelWatch.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Watch"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtModel
        '
        Me.txtModel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.txtModel.Location = New System.Drawing.Point(136, 59)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(192, 24)
        Me.txtModel.TabIndex = 5
        '
        'txtSerial
        '
        Me.txtSerial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerial.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.txtSerial.Location = New System.Drawing.Point(136, 91)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(192, 24)
        Me.txtSerial.TabIndex = 3
        '
        'tblWatchMoreDetail
        '
        Me.tblWatchMoreDetail.ColumnCount = 3
        Me.tblWatchMoreDetail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblWatchMoreDetail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblWatchMoreDetail.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblWatchMoreDetail.Controls.Add(Me.chkType, 0, 0)
        Me.tblWatchMoreDetail.Controls.Add(Me.chkGender, 0, 0)
        Me.tblWatchMoreDetail.Controls.Add(Me.chkBrace, 2, 0)
        Me.tblWatchMoreDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblWatchMoreDetail.Location = New System.Drawing.Point(3, 163)
        Me.tblWatchMoreDetail.Name = "tblWatchMoreDetail"
        Me.tblWatchMoreDetail.RowCount = 1
        Me.tblWatchMoreDetail.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblWatchMoreDetail.Size = New System.Drawing.Size(446, 126)
        Me.tblWatchMoreDetail.TabIndex = 30
        '
        'chkType
        '
        Me.chkType.BackColor = System.Drawing.SystemColors.Control
        Me.chkType.CheckOnClick = True
        Me.chkType.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.chkType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkType.FormattingEnabled = True
        Me.chkType.Items.AddRange(New Object() {"Auto", "Quartz", "Solar", "Kinetic"})
        Me.chkType.Location = New System.Drawing.Point(151, 3)
        Me.chkType.Name = "chkType"
        Me.chkType.Size = New System.Drawing.Size(124, 118)
        Me.chkType.TabIndex = 13
        '
        'chkGender
        '
        Me.chkGender.BackColor = System.Drawing.SystemColors.Control
        Me.chkGender.CheckOnClick = True
        Me.chkGender.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.chkGender.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGender.FormattingEnabled = True
        Me.chkGender.Items.AddRange(New Object() {"Men", "Ladies", "Unisex"})
        Me.chkGender.Location = New System.Drawing.Point(3, 3)
        Me.chkGender.Name = "chkGender"
        Me.chkGender.Size = New System.Drawing.Size(120, 118)
        Me.chkGender.TabIndex = 12
        '
        'chkBrace
        '
        Me.chkBrace.BackColor = System.Drawing.SystemColors.Control
        Me.chkBrace.CheckOnClick = True
        Me.chkBrace.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.chkBrace.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBrace.FormattingEnabled = True
        Me.chkBrace.Items.AddRange(New Object() {"Strap", "Steel", "Rubber", "Gold ", "Titanium", "Ceramic"})
        Me.chkBrace.Location = New System.Drawing.Point(299, 3)
        Me.chkBrace.Name = "chkBrace"
        Me.chkBrace.Size = New System.Drawing.Size(122, 118)
        Me.chkBrace.TabIndex = 14
        '
        'CustDesignPanel
        '
        Me.CustDesignPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustDesignPanel.Controls.Add(Me.tblCustomer)
        Me.CustDesignPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustDesignPanel.Location = New System.Drawing.Point(3, 3)
        Me.CustDesignPanel.Name = "CustDesignPanel"
        Me.CustDesignPanel.Size = New System.Drawing.Size(454, 194)
        Me.CustDesignPanel.TabIndex = 31
        '
        'tblCustomer
        '
        Me.tblCustomer.ColumnCount = 2
        Me.tblCustomer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblCustomer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tblCustomer.Controls.Add(Me.Label21, 0, 3)
        Me.tblCustomer.Controls.Add(Me.txtPhone2, 1, 3)
        Me.tblCustomer.Controls.Add(Me.lblPhone, 0, 2)
        Me.tblCustomer.Controls.Add(Me.txtPhone, 1, 2)
        Me.tblCustomer.Controls.Add(Me.lblName, 0, 1)
        Me.tblCustomer.Controls.Add(Me.txtName, 1, 1)
        Me.tblCustomer.Controls.Add(Me.panelCustomer, 0, 0)
        Me.tblCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblCustomer.Location = New System.Drawing.Point(0, 0)
        Me.tblCustomer.Name = "tblCustomer"
        Me.tblCustomer.RowCount = 4
        Me.tblCustomer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCustomer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCustomer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCustomer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCustomer.Size = New System.Drawing.Size(452, 192)
        Me.tblCustomer.TabIndex = 29
        '
        'panelCustomer
        '
        Me.panelCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tblCustomer.SetColumnSpan(Me.panelCustomer, 2)
        Me.panelCustomer.Controls.Add(Me.Label6)
        Me.panelCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCustomer.Location = New System.Drawing.Point(3, 3)
        Me.panelCustomer.Name = "panelCustomer"
        Me.panelCustomer.Size = New System.Drawing.Size(446, 42)
        Me.panelCustomer.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Customer"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tblRight
        '
        Me.tblRight.ColumnCount = 1
        Me.tblRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblRight.Controls.Add(Me.panelWatchConDesign, 0, 0)
        Me.tblRight.Controls.Add(Me.panelServiceDesign, 0, 1)
        Me.tblRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblRight.Location = New System.Drawing.Point(469, 3)
        Me.tblRight.Name = "tblRight"
        Me.tblRight.RowCount = 2
        Me.tblRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblRight.Size = New System.Drawing.Size(565, 500)
        Me.tblRight.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.conditionPanel, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label20, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtServices, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtIssueBy, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label23, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(557, 242)
        Me.TableLayoutPanel3.TabIndex = 34
        '
        'txtIssueBy
        '
        Me.txtIssueBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIssueBy.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.txtIssueBy.Location = New System.Drawing.Point(114, 183)
        Me.txtIssueBy.Name = "txtIssueBy"
        Me.txtIssueBy.Size = New System.Drawing.Size(192, 24)
        Me.txtIssueBy.TabIndex = 10
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(3, 180)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 18)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Issue By"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TableLayoutPanel3.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(551, 18)
        Me.Panel2.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 23)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Service && Remark"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Image = Global.WatchMaintenanceSystem.My.Resources.Resources.back_icon
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(68, 634)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(169, 47)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInsert, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1111, 112)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(124, 100)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WatchMaintenanceSystem.My.Resources.Resources.printButton
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 44)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInsert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Image = Global.WatchMaintenanceSystem.My.Resources.Resources.Plus_40
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(3, 53)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(118, 44)
        Me.btnInsert.TabIndex = 17
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tblWhole.SetColumnSpan(Me.topPanel, 4)
        Me.topPanel.Controls.Add(Me.tblTopPanel)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.topPanel.Location = New System.Drawing.Point(3, 3)
        Me.topPanel.Name = "topPanel"
        Me.tblWhole.SetRowSpan(Me.topPanel, 2)
        Me.topPanel.Size = New System.Drawing.Size(1298, 103)
        Me.topPanel.TabIndex = 29
        '
        'tblTopPanel
        '
        Me.tblTopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.tblTopPanel.ColumnCount = 6
        Me.tblTopPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.001!))
        Me.tblTopPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33233!))
        Me.tblTopPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.001!))
        Me.tblTopPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33233!))
        Me.tblTopPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.001!))
        Me.tblTopPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33233!))
        Me.tblTopPanel.Controls.Add(Me.Label5, 0, 0)
        Me.tblTopPanel.Controls.Add(Me.txtStatus, 1, 0)
        Me.tblTopPanel.Controls.Add(Me.Label11, 2, 0)
        Me.tblTopPanel.Controls.Add(Me.txtReceipt, 3, 0)
        Me.tblTopPanel.Controls.Add(Me.Label9, 4, 0)
        Me.tblTopPanel.Controls.Add(Me.txtDate, 5, 0)
        Me.tblTopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.tblTopPanel.Name = "tblTopPanel"
        Me.tblTopPanel.RowCount = 2
        Me.tblTopPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTopPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0!))
        Me.tblTopPanel.Size = New System.Drawing.Size(1298, 103)
        Me.tblTopPanel.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 103)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Status"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtStatus.Enabled = False
        Me.txtStatus.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txtStatus.Location = New System.Drawing.Point(132, 37)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(208, 29)
        Me.txtStatus.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(434, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 103)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Receipt No"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtReceipt
        '
        Me.txtReceipt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtReceipt.Enabled = False
        Me.txtReceipt.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txtReceipt.Location = New System.Drawing.Point(563, 37)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(223, 29)
        Me.txtReceipt.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(865, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 103)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDate
        '
        Me.txtDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDate.Enabled = False
        Me.txtDate.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.txtDate.Location = New System.Drawing.Point(994, 37)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(184, 29)
        Me.txtDate.TabIndex = 14
        '
        'panelWatchDesign
        '
        Me.panelWatchDesign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelWatchDesign.Controls.Add(Me.tblWatch)
        Me.panelWatchDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelWatchDesign.Location = New System.Drawing.Point(3, 203)
        Me.panelWatchDesign.Name = "panelWatchDesign"
        Me.panelWatchDesign.Size = New System.Drawing.Size(454, 294)
        Me.panelWatchDesign.TabIndex = 32
        '
        'panelWatchCondition
        '
        Me.panelWatchCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.tblWatchCon.SetColumnSpan(Me.panelWatchCondition, 2)
        Me.panelWatchCondition.Controls.Add(Me.Label10)
        Me.panelWatchCondition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelWatchCondition.Location = New System.Drawing.Point(3, 3)
        Me.panelWatchCondition.Name = "panelWatchCondition"
        Me.panelWatchCondition.Size = New System.Drawing.Size(551, 18)
        Me.panelWatchCondition.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 23)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Watch Conditions"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tblCondition
        '
        Me.tblCondition.ColumnCount = 1
        Me.tblCondition.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblCondition.Controls.Add(Me.lbCondition, 0, 0)
        Me.tblCondition.Controls.Add(Me.tblConditionButton, 0, 1)
        Me.tblCondition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblCondition.Location = New System.Drawing.Point(281, 27)
        Me.tblCondition.Name = "tblCondition"
        Me.tblCondition.RowCount = 2
        Me.tblCondition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblCondition.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblCondition.Size = New System.Drawing.Size(273, 212)
        Me.tblCondition.TabIndex = 36
        '
        'tblConditionButton
        '
        Me.tblConditionButton.ColumnCount = 2
        Me.tblConditionButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblConditionButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblConditionButton.Controls.Add(Me.btnClearCon, 1, 0)
        Me.tblConditionButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblConditionButton.Location = New System.Drawing.Point(3, 172)
        Me.tblConditionButton.Name = "tblConditionButton"
        Me.tblConditionButton.RowCount = 1
        Me.tblConditionButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblConditionButton.Size = New System.Drawing.Size(267, 37)
        Me.tblConditionButton.TabIndex = 0
        '
        'btnClearCon
        '
        Me.btnClearCon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearCon.Location = New System.Drawing.Point(173, 3)
        Me.btnClearCon.Name = "btnClearCon"
        Me.btnClearCon.Size = New System.Drawing.Size(91, 31)
        Me.btnClearCon.TabIndex = 0
        Me.btnClearCon.Text = "Clear"
        Me.btnClearCon.UseVisualStyleBackColor = True
        '
        'lbCondition
        '
        Me.lbCondition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbCondition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCondition.FormattingEnabled = True
        Me.lbCondition.ItemHeight = 16
        Me.lbCondition.Location = New System.Drawing.Point(3, 3)
        Me.lbCondition.Name = "lbCondition"
        Me.lbCondition.Size = New System.Drawing.Size(267, 163)
        Me.lbCondition.TabIndex = 2
        '
        'pcbWatchSketch
        '
        Me.pcbWatchSketch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcbWatchSketch.Image = CType(resources.GetObject("pcbWatchSketch.Image"), System.Drawing.Image)
        Me.pcbWatchSketch.Location = New System.Drawing.Point(3, 27)
        Me.pcbWatchSketch.Name = "pcbWatchSketch"
        Me.pcbWatchSketch.Size = New System.Drawing.Size(272, 212)
        Me.pcbWatchSketch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbWatchSketch.TabIndex = 35
        Me.pcbWatchSketch.TabStop = False
        '
        'tblWatchCon
        '
        Me.tblWatchCon.ColumnCount = 2
        Me.tblWatchCon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblWatchCon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblWatchCon.Controls.Add(Me.pcbWatchSketch, 0, 1)
        Me.tblWatchCon.Controls.Add(Me.tblCondition, 1, 1)
        Me.tblWatchCon.Controls.Add(Me.panelWatchCondition, 0, 0)
        Me.tblWatchCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblWatchCon.Location = New System.Drawing.Point(0, 0)
        Me.tblWatchCon.Name = "tblWatchCon"
        Me.tblWatchCon.RowCount = 2
        Me.tblWatchCon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblWatchCon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tblWatchCon.Size = New System.Drawing.Size(557, 242)
        Me.tblWatchCon.TabIndex = 35
        '
        'panelWatchConDesign
        '
        Me.panelWatchConDesign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelWatchConDesign.Controls.Add(Me.tblWatchCon)
        Me.panelWatchConDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelWatchConDesign.Location = New System.Drawing.Point(3, 3)
        Me.panelWatchConDesign.Name = "panelWatchConDesign"
        Me.panelWatchConDesign.Size = New System.Drawing.Size(559, 244)
        Me.panelWatchConDesign.TabIndex = 35
        '
        'panelServiceDesign
        '
        Me.panelServiceDesign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelServiceDesign.Controls.Add(Me.TableLayoutPanel3)
        Me.panelServiceDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelServiceDesign.Location = New System.Drawing.Point(3, 253)
        Me.panelServiceDesign.Name = "panelServiceDesign"
        Me.panelServiceDesign.Size = New System.Drawing.Size(559, 244)
        Me.panelServiceDesign.TabIndex = 36
        '
        'AddNewInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1304, 732)
        Me.Controls.Add(Me.tblWhole)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "AddNewInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add new Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
        CType(Me.errDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errSerial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblWhole.ResumeLayout(False)
        Me.tblBody.ResumeLayout(False)
        Me.tblBody.PerformLayout()
        Me.tblLeft.ResumeLayout(False)
        Me.tblWatch.ResumeLayout(False)
        Me.tblWatchDetail.ResumeLayout(False)
        Me.tblWatchDetail.PerformLayout()
        Me.tblDropbox.ResumeLayout(False)
        Me.tblDropbox.PerformLayout()
        Me.panelWatch.ResumeLayout(False)
        Me.panelWatch.PerformLayout()
        Me.tblWatchMoreDetail.ResumeLayout(False)
        Me.CustDesignPanel.ResumeLayout(False)
        Me.tblCustomer.ResumeLayout(False)
        Me.tblCustomer.PerformLayout()
        Me.panelCustomer.ResumeLayout(False)
        Me.panelCustomer.PerformLayout()
        Me.tblRight.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.topPanel.ResumeLayout(False)
        Me.tblTopPanel.ResumeLayout(False)
        Me.tblTopPanel.PerformLayout()
        Me.panelWatchDesign.ResumeLayout(False)
        Me.panelWatchCondition.ResumeLayout(False)
        Me.panelWatchCondition.PerformLayout()
        Me.tblCondition.ResumeLayout(False)
        Me.tblConditionButton.ResumeLayout(False)
        CType(Me.pcbWatchSketch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblWatchCon.ResumeLayout(False)
        Me.panelWatchConDesign.ResumeLayout(False)
        Me.panelServiceDesign.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
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
    Friend WithEvents Printtest As System.Windows.Forms.PrintDialog
    Friend WithEvents strapTimer As System.Windows.Forms.Timer
    Friend WithEvents pusherTimer As System.Windows.Forms.Timer
    Friend WithEvents crownTimer As System.Windows.Forms.Timer
    Friend WithEvents circleTimer As System.Windows.Forms.Timer
    Friend WithEvents surfaceTimer As System.Windows.Forms.Timer
    Friend WithEvents dialTimer As System.Windows.Forms.Timer
    Friend WithEvents sideTimer As System.Windows.Forms.Timer
    Friend WithEvents conditionPanel As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtServices As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents errDate As System.Windows.Forms.ErrorProvider
    Friend WithEvents errSerial As System.Windows.Forms.ErrorProvider
    Friend WithEvents errServices As System.Windows.Forms.ErrorProvider
    Friend WithEvents tblWhole As TableLayoutPanel
    Friend WithEvents tblBody As TableLayoutPanel
    Friend WithEvents tblRight As TableLayoutPanel
    Friend WithEvents tblCustomer As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIssueBy As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents panelCustomer As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents topPanel As Panel
    Friend WithEvents tblTopPanel As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtReceipt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents tblLeft As TableLayoutPanel
    Friend WithEvents tblWatch As TableLayoutPanel
    Friend WithEvents tblWatchDetail As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tblDropbox As TableLayoutPanel
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents cbMonth As ComboBox
    Friend WithEvents cbDay As ComboBox
    Friend WithEvents chkWarrantly As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents panelWatch As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents tblWatchMoreDetail As TableLayoutPanel
    Friend WithEvents chkType As CheckedListBox
    Friend WithEvents chkGender As CheckedListBox
    Friend WithEvents chkBrace As CheckedListBox
    Friend WithEvents CustDesignPanel As Panel
    Friend WithEvents panelWatchDesign As Panel
    Friend WithEvents panelWatchConDesign As Panel
    Friend WithEvents tblWatchCon As TableLayoutPanel
    Friend WithEvents pcbWatchSketch As PictureBox
    Friend WithEvents tblCondition As TableLayoutPanel
    Friend WithEvents lbCondition As ListBox
    Friend WithEvents tblConditionButton As TableLayoutPanel
    Friend WithEvents btnClearCon As Button
    Friend WithEvents panelWatchCondition As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents panelServiceDesign As Panel
End Class

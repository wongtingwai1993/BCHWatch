Imports MySql.Data.MySqlClient

Public Class AddNewInvoice
    Dim sqlConnection As MySqlConnection
    Dim sqlCommand As MySqlCommand
    Dim conditionsOfWatch As String = ""
    Dim typeOfWatch As String = ""
    Dim braceOfWatch As String = ""
    Dim surfaceOfWatch As String = ""
    Dim timerStrap As Integer = 0
    Dim timerPusher As Integer = 0
    Dim timerCrown As Integer = 0
    Dim timerCircle As Integer = 0
    Dim timerSurface As Integer = 0
    Dim timerDial As Integer = 0
    Dim timerSide As Integer = 0
    Dim warrantyDate As String = ""
    Dim watchServices As String = ""
    Dim genderOfWatch As String = ""
    Dim quotation As String = ""
    Dim watchRemark As String = ""
    Dim defaultSys As New DefaultSystem
    Dim prefix As String = ""
    Dim canPrint As Boolean = False
    Dim alreadyPrint As Boolean = False

    Private Sub AddNewInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtStatus.Text = "PENDING"

        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()
            Dim query As String

            prefix = defaultSys.getPrefix
            txtReceipt.Text = prefix

            query = "SELECT MAX(receiptId) FROM bch.receipt"

            sqlCommand = New MySqlCommand(query, sqlConnection)
            txtReceipt.Text += (sqlCommand.ExecuteScalar + 1).ToString

        Catch ex As Exception
            prefix = defaultSys.getPrefix
            txtReceipt.Text = prefix
            txtReceipt.Text += "100000"
        End Try


        Dim todayDate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        txtDate.Text = todayDate

        For x As Integer = 1990 To 2050
            cbYear.Items.Add(x)
        Next
    End Sub



    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Homepage.Show()
        Me.Close()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim proceed As Boolean = doChecking()


        If (proceed = True) Then


            Dim todayDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") 'Returns date with AM/PM'



            sqlConnection = New MySqlConnection
            sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
            Try
                sqlConnection.Open()
                Dim sda As New MySqlDataAdapter
                Dim dataset As New DataTable
                Dim bindingSource As New BindingSource

                Dim query As String = ""

                If (warrantyDate = "") Then
                    query = "INSERT INTO bch.receipt (prefix,custName,custPhoneNum,custPhoneNum2,watchBrand,watchModel,watchGender, watchType, watchProblem,watchServices,watchBrace,watchSerial,receiptRemark,dateRepair,invoiceStatus,issueBy)" & _
                        "VALUES ('" & prefix & "','" & txtName.Text & "','" & txtPhone.Text & "','" & txtPhone2.Text & "','" & txtBrand.Text & "','" & txtSerial.Text & "','" & genderOfWatch & "' ,'" & typeOfWatch & "','" & conditionsOfWatch & "','" & watchServices & "','" & braceOfWatch & "','" & txtModel.Text & "' ,'" & conditionPanel.Text & "','" & todayDate & "','P','" & txtIssueBy.Text & "')"

                Else
                    '   Dim parserDate As Date = Date.ParseExact(warrantyDate, "yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)

                    query = "INSERT INTO bch.receipt (prefix,custName,custPhoneNum,custPhoneNum2,watchBrand,watchModel,watchGender,watchWarrantyDate, watchType, watchProblem,watchServices,watchBrace,watchSerial,receiptRemark,dateRepair,invoiceStatus,issueBy)" & _
                        "VALUES ('" & prefix & "','" & txtName.Text & "','" & txtPhone.Text & "','" & txtPhone2.Text & "','" & txtBrand.Text & "','" & txtSerial.Text & "','" & genderOfWatch & "','" & warrantyDate & "','" & typeOfWatch & "','" & conditionsOfWatch & "','" & watchServices & "','" & braceOfWatch & "','" & txtModel.Text & "','" & conditionPanel.Text & "','" & todayDate & "','P','" & txtIssueBy.Text & "')"
                End If




                sqlCommand = New MySqlCommand(query, sqlConnection)



                sqlCommand.ExecuteNonQuery()
                sqlConnection.Close()

                MsgBox("Succesfully insert a new record")
                canPrint = True


            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Function doChecking() As Boolean

        watchRemark = ""
        watchServices = ""
        genderOfWatch = ""
        typeOfWatch = ""
        braceOfWatch = ""

        Dim errorCount As Int32 = 0

        If txtName.Text.Trim.Length = 0 Then
            errName.SetError(txtName, "Please enter name")
            errorCount += 1
        Else
            errName.SetError(txtName, "")
        End If

        If txtPhone.Text.Trim.Length = 0 Then
            errPhone.SetError(txtPhone, "Please enter phone")
            errorCount += 1
        Else
            errPhone.SetError(txtPhone, "")
        End If

        If txtBrand.Text.Trim.Length = 0 Then
            errBrand.SetError(txtBrand, "Please enter brand")
            errorCount += 1
        Else
            errBrand.SetError(txtBrand, "")
        End If

        If txtSerial.Text.Trim.Length = 0 Then
            errModel.SetError(txtSerial, "Please enter model")
            errorCount += 1
        Else
            errModel.SetError(txtSerial, "")
        End If

        If txtIssueBy.Text.Trim.Length = 0 Then
            errIssueBy.SetError(txtIssueBy, "Please enter issue by")
            errorCount += 1
        Else
            errIssueBy.SetError(txtIssueBy, "")
        End If

        If chkType.CheckedItems.Count < 1 Then
            errWatchType.SetError(chkType, "Please choose at least 1")
            errorCount += 1
        Else
            For x As Integer = 0 To chkType.CheckedItems.Count - 1
                typeOfWatch += chkType.CheckedItems(x) + ","
            Next

            errWatchType.SetError(chkType, "")
        End If

        If chkBrace.CheckedItems.Count < 1 Then
            errBrace.SetError(chkBrace, "Please choose at least 1")
            errorCount += 1
        Else
            For x As Integer = 0 To chkBrace.CheckedItems.Count - 1
                braceOfWatch += chkBrace.CheckedItems(x) + ","
            Next

            errBrace.SetError(chkBrace, "")
        End If

        If chkGender.CheckedItems.Count < 1 Then
            errGender.SetError(chkGender, "Please choose at least 1")
            errorCount += 1
        Else
            For x As Integer = 0 To chkGender.CheckedItems.Count - 1
                genderOfWatch += chkGender.CheckedItems(x)

                If Not chkGender.CheckedItems.Count - 1 = x Then
                    genderOfWatch += ","
                End If
            Next

            errSurface.SetError(chkGender, "")
        End If

        'validate for date
        If cbDay.Text.Length = 1 Then
            cbDay.Text = "0" + cbDay.Text
        End If

        If cbMonth.Text.Length = 1 Then
            cbMonth.Text = "0" + cbMonth.Text
        End If


        Dim dateRef As Date
        warrantyDate = cbYear.Text + "/" + cbMonth.Text + "/" + cbDay.Text

        If chkWarrantly.Checked Then
            If (DateTime.TryParseExact(warrantyDate, "yyyy/MM/dd", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, dateRef)) Then
                errDate.SetError(chkWarrantly, "")

            Else
                errDate.SetError(chkWarrantly, "The format for the date is wrong (dd/MM/yyyy)")
                errorCount += 1
            End If
        Else
            warrantyDate = ""
        End If



        'collect all the condition

        For x As Integer = 0 To lbCondition.Items.Count - 1
            conditionsOfWatch += lbCondition.Items(x).ToString + "_*_"
        Next


        'collect all the service
        If txtServices.Text.Trim.Length = 0 Then
            errServices.SetError(txtServices, "Please key in the service of watch")
            errorCount += 1
        Else
            errServices.SetError(txtServices, "")
            watchServices = txtServices.Text
        End If

        'watch serial
        If txtModel.Text.Trim.Length = 0 Then
            errSerial.SetError(txtModel, "Please key in serial number")
            errorCount += 1
        Else
            errSerial.SetError(txtModel, "")
        End If

        'collect all the remark
        Dim remarkLine As Integer = (conditionPanel.Text.Split(vbNewLine)).Count
        Dim counter As Integer = 1

        If conditionPanel.Text.Trim.Length > 0 Then
            For Each strLine As String In conditionPanel.Text.Split(vbNewLine)
                watchRemark += strLine

                If Not counter = remarkLine Then
                    watchRemark += "_*_"
                    counter += 1
                Else

                End If

            Next
        End If



        If errorCount > 0 Then
            conditionsOfWatch = ""
            typeOfWatch = ""
            braceOfWatch = ""
            genderOfWatch = ""
            Return False
        Else
            Return True
        End If

    End Function



    Private Sub printDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument.PrintPage
        Dim descText As New Font("Arial", 8, FontStyle.Regular)
        Dim headerText As New Font("Arial", 12, FontStyle.Bold)
        Dim content As New Font("Arial", 10, FontStyle.Regular)
        Dim conditionText As New Font("Arial", 8, FontStyle.Regular)
        Dim warningText As New Font("Arial", 7, FontStyle.Bold)

        Dim address As String
        Dim address2 As String
        Dim tel As String
        Dim fax As String
        Dim totalTick As Integer = 10

        address = defaultSys.getAddress
        address2 = defaultSys.getAddress2
        tel = defaultSys.getTel
        fax = defaultSys.getFax

        'top block of image 
        e.Graphics.DrawImage(My.Resources.bch_logo, 70, 35)
        e.Graphics.DrawString(address, descText, Brushes.Black, 250, 50)
        e.Graphics.DrawString(address2, descText, Brushes.Black, 250, 70)
        e.Graphics.DrawString("TEL:" + tel, descText, Brushes.Black, 250, 90)
        e.Graphics.DrawString("FAX:" + fax, descText, Brushes.Black, 340, 90)

        'header part
        e.Graphics.DrawString("Receipt No: " + txtReceipt.Text, headerText, Brushes.Black, 70, 120)
        e.Graphics.DrawString("Service Receipt", headerText, Brushes.Black, 380, 120)
        e.Graphics.DrawString("Date: " + txtDate.Text, headerText, Brushes.Black, 600, 120)

        Dim rowValue As Integer = 150
        Dim tableStartX As Integer = 150
        'table drawing for head  (START)
        e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)
        e.Graphics.DrawString("Customer & Details", headerText, Brushes.Black, 70, rowValue)
        rowValue += 20
        e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)

        rowValue += 5
        Dim sameLine As Integer = rowValue
        'customer and watch detal
        e.Graphics.DrawString("Name       : " + txtName.Text, content, Brushes.Black, 70, rowValue)
        rowValue += 20
        e.Graphics.DrawString("Contact    : " + txtPhone.Text, content, Brushes.Black, 70, rowValue)
        rowValue += 20
        e.Graphics.DrawString("Warranty  : " + warrantyDate, content, Brushes.Black, 70, rowValue)

        e.Graphics.DrawString("Brand         : " + txtBrand.Text, content, Brushes.Black, 500, sameLine)
        sameLine += 20
        e.Graphics.DrawString("Model         : " + txtSerial.Text, content, Brushes.Black, 500, sameLine)
        sameLine += 20
        e.Graphics.DrawString("Serial          : " + txtModel.Text, content, Brushes.Black, 500, sameLine)

  
        rowValue += 20

        'table drawing for conditions
        e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)
        e.Graphics.DrawString("Condition of Watch", headerText, Brushes.Black, 70, rowValue)
        rowValue += 20
        e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)

        rowValue += 5

        '290

        'load all condition of watches
        Dim rowMatrix As Integer = 70
        Dim colMatrix As Integer = rowValue

        For x As Integer = 0 To lbCondition.Items.Count - 1

            e.Graphics.DrawString((x + 1).ToString, conditionText, Brushes.Black, rowMatrix, colMatrix)
            e.Graphics.DrawString(lbCondition.Items(x).ToString, conditionText, Brushes.Black, rowMatrix + 20, colMatrix)
            colMatrix += 20

            If colMatrix - rowValue = 80 Then
                rowMatrix += 200
                colMatrix = rowValue
            End If
        Next

        rowValue += 80
        'table drawing for sides
        e.Graphics.DrawLine(Pens.Black, 70, tableStartX, 70, rowValue)
        e.Graphics.DrawLine(Pens.Black, 750, tableStartX, 750, rowValue)

        'ending of the table
        e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)

        rowValue += 5

        e.Graphics.DrawString("Service Request : " + txtServices.Text, content, Brushes.Black, 70, rowValue)
        rowValue += 20
        e.Graphics.DrawString("Remark :" + conditionPanel.Text, content, Brushes.Black, 70, rowValue)
        rowValue += 20
        'issue by
        e.Graphics.DrawString("Issue By: " + txtIssueBy.Text, content, Brushes.Black, 70, rowValue)

        'customer signature 
        rowValue += 30
        e.Graphics.DrawString("Customer Signature", content, Brushes.Black, 610, rowValue)
        e.Graphics.DrawLine(Pens.Black, 600, rowValue-5, 750, rowValue - 5)

        'warning
        Dim warning1 As String = "Others conditions of watch not mentioned or missed out, its status remain unknown to the company"
        e.Graphics.DrawString("**" + warning1, warningText, Brushes.Black, 70, rowValue)
        rowValue += 20
        Dim warning2 As String = "Customer hereby agreed, repaired goods, not claimed after 90 days will be disposed off, without further notice."
        e.Graphics.DrawString("**" + warning2, warningText, Brushes.Black, 70, rowValue)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If canPrint Then
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0
            PrintPreviewDialog1.WindowState = FormWindowState.Maximized
            PrintPreviewDialog1.ShowDialog()
            'Printtest.ShowDialog()
            If alreadyPrint Then
                Homepage.Show()
                Me.Close()
            End If

        Else
            MsgBox("Insert a record before proceed to print")
        End If
    End Sub



    Private Sub chkWarrantly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWarrantly.CheckedChanged
        If chkWarrantly.Checked Then
            cbDay.Enabled = True
            cbMonth.Enabled = True
            cbYear.Enabled = True
        Else
            cbDay.Enabled = False
            cbMonth.Enabled = False
            cbYear.Enabled = False
        End If
    End Sub


    Private Sub printDocument_BeginPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles printDocument.BeginPrint
        If printDocument.PrintController.IsPreview = False Then
            alreadyPrint = True
        End If

    End Sub

    Private Sub printDocument_QueryPageSettings(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.QueryPageSettingsEventArgs) Handles printDocument.QueryPageSettings

    End Sub

    Private Sub pcbWatchSketch_MouseEnter(sender As Object, e As EventArgs) Handles pcbWatchSketch.MouseEnter
        pcbWatchSketch.Image = My.Resources.watch_sketch_hover
    End Sub

    Private Sub pcbWatchSketch_MouseLeave(sender As Object, e As EventArgs) Handles pcbWatchSketch.MouseLeave
        pcbWatchSketch.Image = My.Resources.watch_sketch
    End Sub

    Private Sub pcbWatchSketch_Click(sender As Object, e As EventArgs) Handles pcbWatchSketch.Click
        Dim watchConditionForm As New WatchConditionForm
        watchConditionForm.setData(Me.lbCondition)

        watchConditionForm.ShowDialog()

        ' clear the item before getting data
        lbCondition.Items.Clear()
        lbCondition.Items.AddRange(watchConditionForm.getData.Items)

        If WatchConditionForm.Visible = False Then
            WatchConditionForm.Close()
        End If
    End Sub

    Private Sub btnClearCon_Click(sender As Object, e As EventArgs) Handles btnClearCon.Click
        lbCondition.Items.Clear()
    End Sub

    Private Sub tblCustomer_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles tblCustomer.CellPaint
        'Dim pen As New Pen(Color.Black)
        'If e.Row = 0 Then
        '    If e.Column = 0 Then
        '        e.Graphics.DrawLine(pen, e.CellBounds.Location, New Point(e.CellBounds.Right, e.CellBounds.Top))
        '    End If
        'End If




    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class WorkshopDetail
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
    Dim receiptId As String = ""
    Dim watchRemark As String = ""
    Dim payform As New payForm
    Dim defaultSystem As New DefaultSystem
    Dim passPrefix As String = ""
    Dim initialQuotationPrice As String = ""
    Dim alreadyPrint As Boolean = False
    Dim NIL As Integer = 0


    Public Sub GetData(ByVal rec As String)
        receiptId = rec
    End Sub

    Private Sub AddNewInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtStatus.Text = "OUTSOURCE"

        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Dim sqlReader As MySqlDataReader

        Try
            sqlConnection.Open()

            Dim query As String
            query = "SELECT * FROM bch.receipt inner join bch.invoice on bch.receipt.receiptId = bch.invoice.receiptId  WHERE bch.receipt.receiptId = '" & receiptId & "'"

            sqlCommand = New MySqlCommand(query, sqlConnection)
            sqlReader = sqlCommand.ExecuteReader

            If sqlReader.Read Then

                passPrefix = sqlReader.GetString("prefix")
                txtReceipt.Text = sqlReader.GetString("prefix")
                txtReceipt.Text += sqlReader.GetInt32("receiptId").ToString
                txtName.Text = sqlReader.GetString("custName")
                txtPhone.Text = sqlReader.GetString("custPhoneNum")
                txtBrand.Text = sqlReader.GetString("watchBrand")
                txtModel.Text = sqlReader.GetString("watchModel")
                txtSerial.Text = sqlReader.GetString("watchSerial")
                txtPhone2.Text = sqlReader.GetString("custPhoneNum2")
                Try
                    txtQuotation.Text = sqlReader.GetDouble("quotationPrice").ToString("0.00")
                    initialQuotationPrice = txtQuotation.Text

                Catch ex As Exception

                End Try


                For x As Integer = 0 To chkGender.Items.Count - 1
                    If InStr(sqlReader.GetString("watchGender"), chkGender.Items(x).ToString) Then
                        chkGender.SetItemChecked(x, True)
                    End If
                Next

                For x As Integer = 0 To chkType.Items.Count - 1
                    If InStr(sqlReader.GetString("watchType"), chkType.Items(x).ToString) Then
                        chkType.SetItemChecked(x, True)
                    End If
                Next

                For x As Integer = 0 To chkBrace.Items.Count - 1
                    If InStr(sqlReader.GetString("watchBrace"), chkBrace.Items(x).ToString) Then
                        chkBrace.SetItemChecked(x, True)
                    End If
                Next

                txtSerial.Text = sqlReader.GetString("watchSerial")

                'warrantly date
                Try
                    If sqlReader.GetDateTime("watchWarrantyDate").ToString.Length > 0 Then
                        chkWarrantly.Checked = True

                        cbDay.Text = sqlReader.GetDateTime("watchWarrantyDate").Day.ToString
                        cbMonth.Text = sqlReader.GetDateTime("watchWarrantyDate").Month.ToString()
                        cbYear.Text = sqlReader.GetDateTime("watchWarrantyDate").Year.ToString()

                        If cbDay.Text.Length = 1 Then
                            cbDay.Text = "0" + cbDay.Text
                        End If

                        If cbMonth.Text.Length = 1 Then
                            cbMonth.Text = "0" + cbMonth.Text
                        End If

                    End If
                Catch ex As Exception
                End Try

                'watch condition
                For Each strLine As String In sqlReader.GetString("watchProblem").Split("_*_")
                    If Not (strLine = "") And Not strLine = "*" Then
                        lbCondition.Items.Add(strLine)
                    End If
                Next

                'watch sevice
                For Each strLine As String In sqlReader.GetString("watchServices").Split("_*_")
                    If Not (strLine = "") And Not strLine = "*" Then
                        txtServices.Text += strLine
                    End If
                    If strLine = "*" Then
                        txtServices.Text += vbNewLine
                    End If
                    txtServices.Text = txtServices.Text.Replace("*", "")
                Next
                'watch remark
                For Each strLine As String In sqlReader.GetString("receiptRemark").Split("_*_")
                    If Not (strLine = "") And Not strLine = "*" Then
                        txtRemark.Text += strLine
                    End If
                    If strLine = "*" Then
                        txtRemark.Text += vbNewLine
                    End If
                    txtRemark.Text = txtRemark.Text.Replace("*", "")
                Next


                'watch status
                Dim status As String = sqlReader.GetString("invoiceStatus")

                If status = "P" Then
                    txtStatus.Text = "PENDING"
                ElseIf status = "C" Then
                    txtStatus.Text = "COMPLETE"
                    lblDateComplete.Visible = True
                    txtDateComplete.Visible = True
                    txtDateComplete.Enabled = False
                    lblNil.Visible = True
                    txtNil.Visible = True
                    txtNil.Enabled = False
                    txtQuotation.Enabled = False
                    cbDay.Enabled = False
                    cbMonth.Enabled = False
                    cbYear.Enabled = False

                    txtDateComplete.Text = sqlReader.GetString("dateComplete")
                    txtNil.Text = sqlReader.GetString("NIL")

                    btnUpdate.Visible = False
                    btnPay.Visible = False
                    btnReject.Visible = False
                ElseIf status = "R" Then
                    txtStatus.Text = "REJECTED"
                End If
                'issue by
                txtIssueBy.Text = sqlReader.GetString("issueBy")
                txtDate.Text = sqlReader.GetString("dateRepair")

            End If

        Catch ex As Exception

        End Try

        sqlConnection.Close()


        'Dim todayDate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        'txtDate.Text = todayDate

        For x As Integer = 1990 To 2050
            cbYear.Items.Add(x)
        Next
    End Sub



    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Workshop.Show()
        Me.Close()
    End Sub



    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim proceed As Boolean = doChecking()


        If (proceed = True) Then


            Dim todayDate As String = Date.Now.ToString("yyyy/MM/dd") 'Returns date with AM/PM'



            sqlConnection = New MySqlConnection
            sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
            Try
                sqlConnection.Open()
                Dim sda As New MySqlDataAdapter
                Dim dataset As New DataTable
                Dim bindingSource As New BindingSource

                Dim query As String = ""

                If (warrantyDate = "") Then
                    query = "INSERT INTO bch.receipt (custName,custPhoneNum,custPhoneNum2,watchBrand,watchModel,watchGender, watchType, watchProblem,watchServices,watchBrace,watchSerial,dateRepair,invoiceStatus,issueBy)" & _
                        "VALUES ('" & txtName.Text & "','" & txtPhone.Text & "','" & txtPhone2.Text & "','" & txtBrand.Text & "','" & txtModel.Text & "','" & genderOfWatch & "' ,'" & typeOfWatch & "','" & conditionsOfWatch & "','" & watchServices & "','" & braceOfWatch & "','" & txtSerial.Text & "' ,'" & todayDate & "','P','" & txtIssueBy.Text & "')"

                Else
                    '   Dim parserDate As Date = Date.ParseExact(warrantyDate, "yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)

                    query = "INSERT INTO bch.receipt (custName,custPhoneNum,custPhoneNum2,watchBrand,watchModel,watchGender,watchWarrantyDate, watchType, watchProblem,watchServices,watchBrace,watchSerial,dateRepair,invoiceStatus,issueBy)" & _
                        "VALUES ('" & txtName.Text & "','" & txtPhone.Text & "','" & txtPhone2.Text & "','" & txtBrand.Text & "','" & txtModel.Text & "','" & genderOfWatch & "','" & warrantyDate & "','" & typeOfWatch & "','" & conditionsOfWatch & "','" & watchServices & "','" & braceOfWatch & "','" & txtSerial.Text & "','" & todayDate & "','P','" & txtIssueBy.Text & "')"
                End If




                sqlCommand = New MySqlCommand(query, sqlConnection)



                sqlCommand.ExecuteNonQuery()
                sqlConnection.Close()

                MsgBox("Succesfully insert a new record")
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
        conditionsOfWatch = ""


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

        If txtModel.Text.Trim.Length = 0 Then
            errModel.SetError(txtModel, "Please enter model")
            errorCount += 1
        Else
            errModel.SetError(txtModel, "")
        End If

        If txtIssueBy.Text.Trim.Length = 0 Then
            errIssueBy.SetError(txtIssueBy, "Please enter issue by")
            errorCount += 1
        Else
            errIssueBy.SetError(txtIssueBy, "")
        End If

        If txtQuotation.Text.Trim.Length = 0 Then
            errQuotation.SetError(txtQuotation, "Please enter quotation")
            errorCount += 1
        Else
            errQuotation.SetError(txtQuotation, "")
        End If

        Try
            Double.Parse(txtQuotation.Text.Trim)
            errQuotation.SetError(txtQuotation, "")
        Catch ex As Exception
            errQuotation.SetError(txtQuotation, "Please enter a properly amount of quotation")
            errorCount += 1
        End Try

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
                genderOfWatch += chkGender.CheckedItems(x) + ","
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
        Else '
            warrantyDate = ""
        End If


        'collect all the remark
        Dim remarkLine As Integer = (txtRemark.Text.Split(vbNewLine)).Count
        Dim counter As Integer = 1

        If txtRemark.Text.Trim.Length > 0 Then
            For Each strLine As String In txtRemark.Text.Split(vbNewLine)
                watchRemark += strLine

                If Not counter = remarkLine Then
                    watchRemark += "_*_"
                    counter += 1
                Else

                End If

            Next
        End If


        ''collect all the condition
        'If lbCondition.Items.Count = 0 Then
        '    errCondition.SetError(lbCondition, "Please key in the condition of watch")
        '    errorCount += 1
        'Else
        '    errCondition.SetError(lbCondition, "")
        '    For x As Integer = 0 To lbCondition.Items.Count - 1
        '        conditionsOfWatch += lbCondition.Items(x).ToString + "_*_"
        '    Next

        'End If


        'collect all the service
        If txtServices.Text.Trim.Length = 0 Then
            errServices.SetError(txtServices, "Please key in the service of watch")
            errorCount += 1
        Else
            errServices.SetError(txtServices, "")
            watchServices = txtServices.Text
        End If

        'watch serial
        If txtSerial.Text.Trim.Length = 0 Then
            errSerial.SetError(txtSerial, "Please key in serial number")
            errorCount += 1
        Else
            errSerial.SetError(txtSerial, "")
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
        Dim moneyText As New Font("Arial", 18, FontStyle.Bold)

        Dim address As String
        Dim address2 As String
        Dim tel As String
        Dim fax As String
        Dim totalTick As Integer = 10

        Dim printNIL As String = ""
        'set NIL
        If txtNil.Text = "" Then
            printNIL = NIL
        Else
            printNIL = txtNil.Text
        End If

        address = defaultSystem.getAddress
        address2 = defaultSystem.getAddress2
        tel = defaultSystem.getTel
        fax = defaultSystem.getFax

        'top block of image 
        'top block of image 
        e.Graphics.DrawImage(My.Resources.bch_logo, 70, 35)
        e.Graphics.DrawString(address, descText, Brushes.Black, 250, 50)
        e.Graphics.DrawString(address2, descText, Brushes.Black, 250, 65)
        e.Graphics.DrawString("TEL:" + tel, descText, Brushes.Black, 250, 80)
        e.Graphics.DrawString("FAX:" + fax, descText, Brushes.Black, 340, 80)
        e.Graphics.DrawString("GST NO: 000936509440", descText, Brushes.Black, 250, 95)

        'header part
        e.Graphics.DrawString("Receipt No: " + txtReceipt.Text, headerText, Brushes.Black, 70, 130)
        e.Graphics.DrawString("Service Receipt", headerText, Brushes.Black, 380, 130)
        e.Graphics.DrawString("Date: " + DateTime.Now.ToString("dd-MM-yyyy"), headerText, Brushes.Black, 600, 130)

        Dim rowValue As Integer = 160
        Dim tableStartX As Integer = 160
        Dim tableSide As Integer = 750
        Dim tableHalf As Integer = tableSide / 2
        'table drawing for head  (START)
        e.Graphics.DrawLine(Pens.Black, 70, 160, 750, rowValue)
        e.Graphics.DrawString("Customer & Watch Details", headerText, Brushes.Black, 70, rowValue)
        rowValue += 20
        e.Graphics.DrawLine(Pens.Black, 70, 180, 750, rowValue)

        rowValue += 5
        Dim sameLine As Integer = rowValue
        'customer and watch detal
        e.Graphics.DrawString("Name            : " + txtName.Text, content, Brushes.Black, 70, rowValue)
        rowValue += 20
        e.Graphics.DrawString("Contact         : " + txtPhone.Text, content, Brushes.Black, 70, rowValue)
        rowValue += 20
        e.Graphics.DrawString("Warranty       : " + warrantyDate, content, Brushes.Black, 70, rowValue)

        e.Graphics.DrawString("Brand         : " + txtBrand.Text, content, Brushes.Black, 500, sameLine)
        sameLine += 20
        e.Graphics.DrawString("Model         : " + txtModel.Text, content, Brushes.Black, 500, sameLine)
        sameLine += 20
        e.Graphics.DrawString("Serial         : " + txtSerial.Text, content, Brushes.Black, 500, sameLine)


        rowValue += 20

        Dim endTableOfConditon As Integer = 0
        Dim startTableOfCondition As Integer = 0
        'table drawing for conditions
        e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)
        startTableOfCondition = rowValue
        e.Graphics.DrawString("Condition of Watch", headerText, Brushes.Black, 70, rowValue)
        e.Graphics.DrawString("Payment", headerText, Brushes.Black, tableHalf, rowValue)
        rowValue += 20
        e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)
        endTableOfConditon = rowValue
        rowValue += 5

        '290

        'load all condition of watches
        Dim rowMatrix As Integer = 70
        Dim colMatrix As Integer = rowValue

        For x As Integer = 0 To lbCondition.Items.Count - 1

            e.Graphics.DrawString((x + 1).ToString, content, Brushes.Black, rowMatrix, colMatrix)
            e.Graphics.DrawString(lbCondition.Items(x).ToString, conditionText, Brushes.Black, rowMatrix + 20, colMatrix)
            colMatrix += 20

            If colMatrix - rowValue = 80 Then
                rowMatrix += 170
                colMatrix = rowValue
            End If
        Next

        'Half table with price
        Dim halfTableRow As Integer = rowValue
        e.Graphics.DrawString("Inclusive GST 6%: ", content, Brushes.Black, tableHalf, halfTableRow)
        halfTableRow += 30

        Dim totalValue As Double = 0.0
        Dim succeed As Boolean = Double.TryParse(txtQuotation.Text, totalValue)
        'e.Graphics.DrawString("RM" + Math.Round(CDbl((totalValue * 1.06).ToString), 1).ToString("0.00"), moneyText, Brushes.Black, tableHalf, halfTableRow)
        e.Graphics.DrawString("RM" + totalValue.ToString("0.00"), moneyText, Brushes.Black, tableHalf, halfTableRow)


        rowValue += 80
        'table drawing for sides
        e.Graphics.DrawLine(Pens.Black, 70, tableStartX, 70, rowValue)
        e.Graphics.DrawLine(Pens.Black, tableSide, tableStartX, tableSide, endTableOfConditon)
        'table drawing half 
        e.Graphics.DrawLine(Pens.Black, tableHalf, startTableOfCondition, tableHalf, rowValue)

        'ending of the table
        e.Graphics.DrawLine(Pens.Black, 70, rowValue, tableHalf, rowValue)

        rowValue += 5

        e.Graphics.DrawString("Service Request : " + txtServices.Text, content, Brushes.Black, 70, rowValue)
        rowValue += 20

        e.Graphics.DrawString("NIL : " + NIL.ToString + " month", content, Brushes.Black, 70, rowValue)
        rowValue += 20

        e.Graphics.DrawString("Remark : " + txtRemark.Text.Trim, content, Brushes.Black, 70, rowValue)
        rowValue += 20

        'issue by
        e.Graphics.DrawString("Issue By: " + txtIssueBy.Text, content, Brushes.Black, 70, rowValue)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
        ' Printtest.ShowDialog()
    End Sub

    Private Sub chkWarrantly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWarrantly.CheckedChanged
        If chkWarrantly.Checked Then
            cbDay.Enabled = False
            cbMonth.Enabled = False
            cbYear.Enabled = False
        Else
            cbDay.Enabled = False
            cbMonth.Enabled = False
            cbYear.Enabled = False
        End If
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click

        Dim proceed As Boolean = doChecking()

        If initialQuotationPrice = txtQuotation.Text Then
            If proceed Then
                payform.GetData(conditionsOfWatch, watchServices, txtQuotation.Text)
                payform.ShowDialog()
                Dim confirmation As Boolean = payform.getConfirmatin
                NIL = payform.getNIL

                If confirmation Then
                    PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0
                    PrintPreviewDialog1.WindowState = FormWindowState.Maximized
                    PrintPreviewDialog1.ShowDialog()

                End If

            End If
        Else
            MsgBox("You have change the price but without updating the latest price, please press UPDATE before PAY")

        End If




    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim proceed As Boolean = doChecking()


        If (proceed = True) Then


            Dim todayDate As String = Date.Now.ToString("yyyy/MM/dd") 'Returns date with AM/PM'



            sqlConnection = New MySqlConnection
            sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
            Try
                sqlConnection.Open()
                Dim sda As New MySqlDataAdapter
                Dim dataset As New DataTable
                Dim bindingSource As New BindingSource

                Dim query As String = ""
                Dim quotaQuery As String = ""

                If (warrantyDate = "") Then
                    query = "UPDATE bch.receipt SET custName='" & txtName.Text & "',custPhoneNum='" & txtPhone.Text & "',custPhoneNum2='" & txtPhone2.Text & "',watchBrand='" & txtBrand.Text & "',watchModel='" & txtModel.Text & "',watchGender='" & genderOfWatch & "', watchType='" & typeOfWatch & "', watchProblem='" & conditionsOfWatch & "',watchServices='" & watchServices & "',watchBrace='" & braceOfWatch & "',watchSerial='" & txtSerial.Text & "',dateRepair='" & todayDate & "',receiptRemark='" & watchRemark & "',invoiceStatus='O',issueBy='" & txtIssueBy.Text & "'" & _
                        "WHERE receiptId = '" & receiptId & "'"

                    quotaQuery = "UPDATE bch.invoice SET quotationPrice = '" & Math.Round(CDbl(txtQuotation.Text), 1).ToString("0.00") & "' WHERE receiptId = '" & receiptId & "'"
                Else
                    query = "UPDATE bch.receipt SET custName='" & txtName.Text & "',custPhoneNum='" & txtPhone.Text & "',custPhoneNum2='" & txtPhone2.Text & "',watchBrand='" & txtBrand.Text & "',watchModel='" & txtModel.Text & "',watchGender='" & genderOfWatch & "',watchWarrantyDate='" & warrantyDate & "', watchType='" & typeOfWatch & "', watchProblem='" & conditionsOfWatch & "',watchServices='" & watchServices & "',watchBrace='" & braceOfWatch & "',watchSerial='" & txtSerial.Text & "',dateRepair='" & todayDate & "',receiptRemark='" & watchRemark & "',invoiceStatus='O',issueBy='" & txtIssueBy.Text & "'" & _
                        "WHERE receiptId = '" & receiptId & "'"
                    quotaQuery = "UPDATE bch.invoice SET quotationPrice = '" & Math.Round(CDbl(txtQuotation.Text), 1).ToString("0.00") & "' WHERE receiptId = '" & receiptId & "'"
                End If

                'Math.Round(CDbl(txtQuotation.Text), 1).ToString("0.00")



                sqlCommand = New MySqlCommand(query, sqlConnection)
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New MySqlCommand(quotaQuery, sqlConnection)
                sqlCommand.ExecuteNonQuery()
                sqlConnection.Close()

                MsgBox("Succesfully Update Current Record")
                txtQuotation.Text = Math.Round(CDbl(txtQuotation.Text), 1).ToString("0.00")
                initialQuotationPrice = txtQuotation.Text

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub txtStatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReject.Click
        Dim deliveryForm As New deliveryChargeForm
        deliveryForm.GetData(receiptId, passPrefix)

        deliveryForm.ShowDialog()

    End Sub

    Private Sub printDocument_BeginPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles printDocument.BeginPrint
        If printDocument.PrintController.IsPreview = False Then

            sqlConnection = New MySqlConnection
            sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"


            Try
                sqlConnection.Open()

                Dim query As String

                Dim todayDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") 'Returns date with AM/PM'

                query = "UPDATE bch.receipt SET invoiceStatus = 'C',NIL=" & NIL & " ,dateComplete= '" & todayDate & "'  WHERE receiptId = '" & receiptId & "'"

                sqlCommand = New MySqlCommand(query, sqlConnection)
                sqlCommand.ExecuteNonQuery()

                sqlConnection.Close()
                MsgBox("The transaction is done completely")

                alreadyPrint = True

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

 
    Private Sub printDocumentUpdate_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub pcbWatchSketch_Click(sender As Object, e As EventArgs) Handles pcbWatchSketch.Click
        Dim watchConditionForm As New WatchConditionForm
        watchConditionForm.setData(Me.lbCondition)

        watchConditionForm.ShowDialog()

        ' clear the item before getting data
        lbCondition.Items.Clear()
        lbCondition.Items.AddRange(watchConditionForm.getData.Items)

        If watchConditionForm.Visible = False Then
            watchConditionForm.Close()
        End If
    End Sub
    Private Sub pcbWatchSketch_MouseEnter(sender As Object, e As EventArgs) Handles pcbWatchSketch.MouseEnter, pcbWatchSketch.MouseEnter
        pcbWatchSketch.Image = My.Resources.watch_sketch_hover
    End Sub

    Private Sub pcbWatchSketch_MouseLeave(sender As Object, e As EventArgs) Handles pcbWatchSketch.MouseLeave, pcbWatchSketch.MouseLeave
        pcbWatchSketch.Image = My.Resources.watch_sketch
    End Sub
End Class
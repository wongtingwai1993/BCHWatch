Imports MySql.Data.MySqlClient

Public Class issueForm
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
    Dim receiptId As String
    Dim watchRemark As String = ""
    Dim choseCompany As New ChooseCompany
    Dim sysDefault As New DefaultSystem
    Dim canUpdate As Boolean = True
    Dim alreadyPrint As Boolean = False


    Public Sub GetData(ByVal id As String)
        receiptId = id
    End Sub


    Private Sub AddNewInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtStatus.Text = "PENDING"

        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Dim sqlReader As MySqlDataReader

        Try
            sqlConnection.Open()

            Dim query As String
            query = "SELECT * FROM bch.receipt WHERE receiptId = '" & receiptId & "'"

            sqlCommand = New MySqlCommand(query, sqlConnection)
            sqlReader = sqlCommand.ExecuteReader

            If sqlReader.Read Then
                txtReceipt.Text = sqlReader.GetString("prefix")
                txtReceipt.Text += sqlReader.GetInt32("receiptId").ToString
                txtName.Text = sqlReader.GetString("custName")
                txtPhone.Text = sqlReader.GetString("custPhoneNum")
                txtBrand.Text = sqlReader.GetString("watchBrand")
                txtModel.Text = sqlReader.GetString("watchModel")

                If sqlReader.GetString("invoiceStatus") = "C" Then
                    txtStatus.Text = "COMPLETE"
                End If

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
                        retriggerCondition(strLine)
                    End If

                Next
                'watch services

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
                ElseIf status = "S" Then
                    txtSerial.Text = "SUCCESS"
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
    Private Sub retriggerCondition(ByVal condition As String)
        If cblConStrap.Items.Contains(condition) Then
            Dim index As Integer = cblConStrap.Items.IndexOf(condition)
            cblConStrap.SetItemChecked(index, True)

        ElseIf chkPusher.Items.Contains(condition) Then
            Dim index As Integer = chkPusher.Items.IndexOf(condition)
            chkPusher.SetItemChecked(index, True)

        ElseIf chkConSurface.Items.Contains(condition) Then
            Dim index As Integer = chkConSurface.Items.IndexOf(condition)
            chkConSurface.SetItemChecked(index, True)

        ElseIf chkCrown.Items.Contains(condition) Then
            Dim index As Integer = chkCrown.Items.IndexOf(condition)
            chkCrown.SetItemChecked(index, True)

        ElseIf chkBrace.Items.Contains(condition) Then
            Dim index As Integer = chkBrace.Items.IndexOf(condition)
            chkBrace.SetItemChecked(index, True)

        ElseIf chkCircle.Items.Contains(condition) Then
            Dim index As Integer = chkCircle.Items.IndexOf(condition)
            chkCircle.SetItemChecked(index, True)

        ElseIf chkDial.Items.Contains(condition) Then
            Dim index As Integer = chkDial.Items.IndexOf(condition)
            chkDial.SetItemChecked(index, True)

        ElseIf chkSide.Items.Contains(condition) Then
            Dim index As Integer = chkSide.Items.IndexOf(condition)
            chkSide.SetItemChecked(index, True)

        End If
    End Sub


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Homepage.Show()
        Me.Close()
    End Sub



    Private Function doChecking() As Boolean
        Dim errorCount As Int32 = 0

        watchRemark = ""
        watchServices = ""
        genderOfWatch = ""
        typeOfWatch = ""
        braceOfWatch = ""
        conditionsOfWatch = ""

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
                If Not x = chkGender.CheckedItems.Count - 1 Then
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


        'collect all the condition
        If lbCondition.Items.Count = 0 Then
            errCondition.SetError(lbCondition, "Please key in the condition of watch")
            errorCount += 1
        Else
            errCondition.SetError(lbCondition, "")
            For x As Integer = 0 To lbCondition.Items.Count - 1
                conditionsOfWatch += lbCondition.Items(x).ToString + "_*_"
            Next

        End If


        'collect all the service
        If txtServices.Text.Trim.Length = 0 Then
            errCondition.SetError(txtServices, "Please key in the condition of watch")
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

        Dim address As String
        Dim address2 As String = ""
        Dim tel As String
        Dim fax As String
        Dim totalTick As Integer = 10

        Dim proceed As Boolean = doChecking()

        If proceed Then

            address = sysDefault.getAddress
            address2 = sysDefault.getAddress2
            tel = sysDefault.getTel
            fax = sysDefault.getFax

            'top block of image 
            e.Graphics.DrawImage(My.Resources.bch_logo, 70, 35)
            e.Graphics.DrawString(address, descText, Brushes.Black, 250, 50)
            e.Graphics.DrawString(address2, descText, Brushes.Black, 250, 70)
            e.Graphics.DrawString("TEL:" + tel, descText, Brushes.Black, 250, 90)
            e.Graphics.DrawString("FAX:" + fax, descText, Brushes.Black, 340, 90)

            Dim rowValue As Integer = 130
            'header part
            e.Graphics.DrawString("Issue Id     : ", headerText, Brushes.Black, 70, rowValue)
            e.Graphics.DrawString(txtReceipt.Text, content, Brushes.Black, 170, rowValue)
            rowValue += 20
            e.Graphics.DrawString("Date           : ", headerText, Brushes.Black, 70, rowValue)
            e.Graphics.DrawString(txtDate.Text, content, Brushes.Black, 170, rowValue)
            rowValue += 20
            e.Graphics.DrawString("Deliver To : ", headerText, Brushes.Black, 70, rowValue)
            e.Graphics.DrawString(choseCompany.txtName.Text, content, Brushes.Black, 170, rowValue)
            rowValue += 20

            e.Graphics.DrawString("Address    : ", headerText, Brushes.Black, 70, rowValue)

            Dim companyAdd As String() = choseCompany.txtAddress.Text.Split(vbNewLine)
            Dim weirdStuff As Integer = 0

            For Each strLine As String In companyAdd
                If Not strLine = "" And weirdStuff >= 1 Then
                    e.Graphics.DrawString(strLine, content, Brushes.Black, 170, rowValue)
                    rowValue += 15
                ElseIf Not strLine = "" Then
                    e.Graphics.DrawString(strLine, content, Brushes.Black, 170, rowValue)
                End If

                weirdStuff += 1

            Next





            rowValue += 20

            'table drawing for head  (START)
            Dim tableRowStartX As Integer

            e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)
            tableRowStartX = rowValue
            e.Graphics.DrawString("Customer & Details", headerText, Brushes.Black, 70, rowValue)
            rowValue += 20
            e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)
            rowValue += 5

            Dim sameLine As Integer = 0
            'customer and watch detal
            e.Graphics.DrawString("Brand           : " + txtBrand.Text, content, Brushes.Black, 70, rowValue)
            sameLine = rowValue
            rowValue += 20
            e.Graphics.DrawString("Model           : " + txtModel.Text, content, Brushes.Black, 70, rowValue)
            rowValue += 20
            e.Graphics.DrawString("Serial           : " + txtSerial.Text, content, Brushes.Black, 70, rowValue)
            rowValue += 20
            e.Graphics.DrawString("Warrantly     : " + warrantyDate, content, Brushes.Black, 70, rowValue)
            rowValue += 20

            e.Graphics.DrawString("Delivery      : " + choseCompany.deliveryMethod, content, Brushes.Black, 500, sameLine)

            'table drawing for conditions
            e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)
            e.Graphics.DrawString("Condition of Watch", headerText, Brushes.Black, 70, rowValue)
            rowValue += 20
            e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)
            rowValue += 5

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
            e.Graphics.DrawLine(Pens.Black, 70, tableRowStartX, 70, rowValue)
            e.Graphics.DrawLine(Pens.Black, 750, tableRowStartX, 750, rowValue)
            'ending of the table
            e.Graphics.DrawLine(Pens.Black, 70, rowValue, 750, rowValue)
            rowValue += 5
            e.Graphics.DrawString("Service Request : " + txtServices.Text, content, Brushes.Black, 70, rowValue)
            rowValue += 20
            e.Graphics.DrawString("Remarks :" + txtRemark.Text, content, Brushes.Black, 70, rowValue)
            rowValue += 20
            'issue by
            e.Graphics.DrawString("Issue By: " + txtIssueBy.Text, content, Brushes.Black, 70, rowValue)
            'issue invoice by
            rowValue += 20
            e.Graphics.DrawString("Invoice Issue By: " + choseCompany.txtIssue.Text, content, Brushes.Black, 70, rowValue)
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'printPreviewMaintain.PrintPreviewControl.Zoom = 1.0
        'printPreviewMaintain.WindowState = FormWindowState.Maximized
        'printPreviewMaintain.ShowDialog()


        Printtest.ShowDialog()

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove

        Dim strapRange As Boolean = e.X > 70 And e.X < 103 And e.Y > 5 And e.Y < 20
        Dim dialRange As Boolean = (e.X > 63 And e.X < 84) And (e.Y > 74 And e.Y < 103)
        Dim surfaceRange As Boolean = e.X > 44 And e.X < 120 And e.Y > 58 And e.Y < 130
        Dim crownRange As Boolean = e.X > 138 And e.X < 156 And e.Y > 81 And e.Y < 104
        Dim pusherRange As Boolean = e.X > 134 And e.X < 153 And e.Y > 51 And e.Y < 75
        Dim sideRange As Boolean = (e.X > 49 And e.X < 74) And (e.Y > 145 And e.Y < 173)
        Dim circleRange As Boolean = e.X > 114 And e.X < 131 And e.Y > 135 And e.Y < 152


        If strapRange Then
            lblWatchDesc.Text = "Condition of Strap"
            strapTimer.Start()
            strapPanel.Visible = True
            closeAllPanel(1)
        ElseIf dialRange Then
            lblWatchDesc.Text = "Condition of Dial"
            dialTimer.Start()
            dialPanel.Visible = True
            closeAllPanel(5)
        ElseIf surfaceRange Then
            lblWatchDesc.Text = "Condition of Crystal"
            surfaceTimer.Start()
            surfacePanel.Visible = True
            closeAllPanel(4)
        ElseIf crownRange Then
            lblWatchDesc.Text = "Condition of Crown"
            crownTimer.Start()
            crownPanel.Visible = True
            closeAllPanel(3)
        ElseIf pusherRange Then
            lblWatchDesc.Text = "Condition of Pusher"
            pusherTimer.Start()
            pusherPanel.Visible = True
            closeAllPanel(2)
        ElseIf sideRange Then
            lblWatchDesc.Text = "Condition of Case"
            sideTimer.Start()
            sidePanel.Visible = True
            closeAllPanel(7)
        ElseIf circleRange Then
            lblWatchDesc.Text = "Condition of Bezel"
            circleTimer.Start()
            circlePanel.Visible = True
            closeAllPanel(6)
        Else
            lblWatchDesc.Text = "Please Point 1"
            timerStrap = 0
            timerPusher = 0
            timerCrown = 0
            timerCircle = 0
            timerSurface = 0
            timerDial = 0
            timerSide = 0
        End If
    End Sub

    Private Sub tFadeout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles strapTimer.Tick

        If timerStrap = 1 Then
            strapPanel.Visible = False
            strapTimer.Stop()
        End If
        timerStrap += 1
    End Sub

    Private Sub closeAllPanel(ByVal panelChoice As Integer)

        Select Case panelChoice
            Case 1
                strapPanel.Visible = True
                pusherPanel.Visible = False
                crownPanel.Visible = False
                surfacePanel.Visible = False
                dialPanel.Visible = False
                circlePanel.Visible = False
                sidePanel.Visible = False
            Case 2
                strapPanel.Visible = False
                pusherPanel.Visible = True
                crownPanel.Visible = False
                surfacePanel.Visible = False
                dialPanel.Visible = False
                circlePanel.Visible = False
                sidePanel.Visible = False
            Case 3
                strapPanel.Visible = False
                pusherPanel.Visible = False
                crownPanel.Visible = True
                surfacePanel.Visible = False
                dialPanel.Visible = False
                circlePanel.Visible = False
                sidePanel.Visible = False
            Case 4
                strapPanel.Visible = False
                pusherPanel.Visible = False
                crownPanel.Visible = False
                surfacePanel.Visible = True
                dialPanel.Visible = False
                circlePanel.Visible = False
                sidePanel.Visible = False
            Case 5
                strapPanel.Visible = False
                pusherPanel.Visible = False
                crownPanel.Visible = False
                surfacePanel.Visible = False
                dialPanel.Visible = True
                circlePanel.Visible = False
                sidePanel.Visible = False
            Case 6
                strapPanel.Visible = False
                pusherPanel.Visible = False
                crownPanel.Visible = False
                surfacePanel.Visible = False
                dialPanel.Visible = False
                circlePanel.Visible = True
                sidePanel.Visible = False
            Case 7
                strapPanel.Visible = False
                pusherPanel.Visible = False
                crownPanel.Visible = False
                surfacePanel.Visible = False
                dialPanel.Visible = False
                circlePanel.Visible = False
                sidePanel.Visible = True
            Case Else


        End Select

    End Sub
    'strap
    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        strapPanel.Visible = True
        closeAllPanel(1)
        timerStrap = 0
        strapTimer.Stop()
    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        strapTimer.Start()
    End Sub

    Private Sub CheckedListBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cblConStrap.MouseMove
        strapPanel.Visible = True
        closeAllPanel(1)
        timerStrap = 0
        strapTimer.Stop()
    End Sub

    Private Sub CheckedListBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cblConStrap.MouseLeave
        strapTimer.Start()
    End Sub

    Private Sub cblConStrap_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles cblConStrap.ItemCheck
        If cblConStrap.GetItemChecked(e.Index) = False Then
            lbCondition.Items.Add(cblConStrap.Items(e.Index).ToString)
        Else
            lbCondition.Items.Remove(cblConStrap.Items(e.Index).ToString)
        End If
    End Sub


    'pusher
    Private Sub pusherTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pusherTimer.Tick
        If timerPusher = 1 Then
            pusherPanel.Visible = False
            pusherTimer.Stop()
        End If
        timerPusher += 1
    End Sub
    Private Sub chkPusher_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        pusherPanel.Visible = True
        pusherTimer.Stop()
        timerPusher = 0
    End Sub


    Private Sub chkPusher_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pusherTimer.Start()
    End Sub
    Private Sub chkPusher_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chkPusher.ItemCheck
        If chkPusher.GetItemChecked(e.Index) = False Then
            lbCondition.Items.Add(chkPusher.Items(e.Index).ToString)
        Else
            lbCondition.Items.Remove(chkPusher.Items(e.Index).ToString)
        End If

    End Sub



    'crown 

    Private Sub crownTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pusherTimer.Tick, crownTimer.Tick
        If timerCrown = 1 Then
            crownPanel.Visible = False
            crownTimer.Stop()
        End If
        timerCrown += 1
    End Sub
    Private Sub chkCrown_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chkPusher.MouseMove, chkCrown.MouseMove
        crownPanel.Visible = True
        timerCrown = 0
        crownTimer.Stop()
    End Sub

    Private Sub chkCrown_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPusher.MouseLeave, chkCrown.MouseLeave
        crownTimer.Start()
    End Sub

    Private Sub chkCrown_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chkCrown.ItemCheck
        If chkCrown.GetItemChecked(e.Index) = False Then
            lbCondition.Items.Add(chkCrown.Items(e.Index).ToString)
        Else
            lbCondition.Items.Remove(chkCrown.Items(e.Index).ToString)
        End If
    End Sub

    'circle
    Private Sub circleTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pusherTimer.Tick, crownTimer.Tick, circleTimer.Tick
        If timerCircle = 1 Then
            circlePanel.Visible = False
            circleTimer.Stop()
        End If
        timerCircle += 1
    End Sub
    Private Sub chkCircle_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chkCircle.MouseMove
        circlePanel.Visible = True
        timerCircle = 0
        circleTimer.Stop()
    End Sub



    Private Sub chkCircle_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPusher.MouseLeave, chkCircle.MouseLeave
        circleTimer.Start()
    End Sub

    Private Sub chkCircle_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chkCircle.ItemCheck
        If chkCircle.GetItemChecked(e.Index) = False Then
            lbCondition.Items.Add(chkCircle.Items(e.Index).ToString)
        Else
            lbCondition.Items.Remove(chkCircle.Items(e.Index).ToString)
        End If
    End Sub
    'surface
    Private Sub surfaceTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pusherTimer.Tick, crownTimer.Tick, circleTimer.Tick, surfaceTimer.Tick
        If timerSurface = 1 Then
            surfacePanel.Visible = False
            surfaceTimer.Stop()
        End If
        timerSurface += 1
    End Sub


    Private Sub chkConSurface_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPusher.MouseLeave, chkCrown.MouseLeave
        surfaceTimer.Start()
    End Sub
    Private Sub chkConSurface_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chkConSurface.MouseUp, chkConSurface.MouseMove
        surfacePanel.Visible = True
        timerSurface = 0
        surfaceTimer.Stop()
    End Sub
    Private Sub chkConSurface_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chkConSurface.ItemCheck
        If chkConSurface.GetItemChecked(e.Index) = False Then
            lbCondition.Items.Add(chkConSurface.Items(e.Index).ToString)
        Else
            lbCondition.Items.Remove(chkConSurface.Items(e.Index).ToString)
        End If
    End Sub


    'dial
    Private Sub dialTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pusherTimer.Tick, crownTimer.Tick, circleTimer.Tick, dialTimer.Tick
        If timerDial = 1 Then
            dialPanel.Visible = False
            dialTimer.Stop()
        End If
        timerDial += 1
    End Sub

    Private Sub chkDial_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chkDial.MouseMove
        dialPanel.Visible = True
        dialTimer.Stop()
        timerDial = 0

    End Sub

    Private Sub chkDial_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPusher.MouseLeave, chkCrown.MouseLeave, chkCircle.MouseLeave, chkDial.MouseLeave
        dialTimer.Start()
    End Sub


    Private Sub chkDial_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chkDial.ItemCheck

        If chkDial.GetItemChecked(e.Index) = False Then
            lbCondition.Items.Add(chkDial.Items(e.Index).ToString)
        Else
            lbCondition.Items.Remove(chkDial.Items(e.Index).ToString)
        End If


    End Sub

    'side
    Private Sub sideTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pusherTimer.Tick, crownTimer.Tick, circleTimer.Tick, surfaceTimer.Tick, dialTimer.Tick, sideTimer.Tick
        If timerSide = 1 Then
            sidePanel.Visible = False
            sideTimer.Stop()
        End If
        timerSide += 1
    End Sub


    Private Sub chkSide_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPusher.MouseLeave, chkCrown.MouseLeave, chkCircle.MouseLeave, chkDial.MouseLeave
        sideTimer.Start()
    End Sub
    Private Sub chkSide_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chkSide.MouseUp, chkSide.MouseMove
        sidePanel.Visible = True
        timerSide = 0
        sideTimer.Stop()
    End Sub
    Private Sub chkSide_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chkSide.ItemCheck
        If chkSide.GetItemChecked(e.Index) = False Then
            lbCondition.Items.Add(chkSide.Items(e.Index).ToString)
        Else
            lbCondition.Items.Remove(chkSide.Items(e.Index).ToString)
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

    Private Sub btnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssue.Click

        choseCompany = New ChooseCompany
        choseCompany.ShowDialog()
        Dim confirm As Boolean = choseCompany.getConfirmation()
        choseCompany.Dispose()

        If confirm Then
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0
            PrintPreviewDialog1.WindowState = FormWindowState.Maximized
            PrintPreviewDialog1.ShowDialog()


            If alreadyPrint Then
                Homepage.Show()
                Me.Close()

            End If

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

                Dim query As String = ""

                If (warrantyDate = "") Then
                    query = "UPDATE bch.receipt SET custName='" & txtName.Text & "',custPhoneNum='" & txtPhone.Text & "',custPhoneNum2='" & txtPhone2.Text & "',watchBrand='" & txtBrand.Text & "',watchModel='" & txtModel.Text & "',watchGender='" & genderOfWatch & "', watchWarrantyDate= @noWarranty ,watchType='" & typeOfWatch & "', watchProblem='" & conditionsOfWatch & "',watchServices='" & watchServices & "',watchBrace='" & braceOfWatch & "',watchSerial='" & txtSerial.Text & "',dateRepair='" & todayDate & "',receiptRemark='" & watchRemark & "',invoiceStatus='P',issueBy='" & txtIssueBy.Text & "'" & _
                        "WHERE receiptId = '" & receiptId & "'"


                Else
                    query = "UPDATE bch.receipt SET custName='" & txtName.Text & "',custPhoneNum='" & txtPhone.Text & "',custPhoneNum2='" & txtPhone2.Text & "',watchBrand='" & txtBrand.Text & "',watchModel='" & txtModel.Text & "',watchGender='" & genderOfWatch & "',watchWarrantyDate='" & warrantyDate & "', watchType='" & typeOfWatch & "', watchProblem='" & conditionsOfWatch & "',watchServices='" & watchServices & "',watchBrace='" & braceOfWatch & "',watchSerial='" & txtSerial.Text & "',dateRepair='" & todayDate & "',receiptRemark='" & watchRemark & "',invoiceStatus='P',issueBy='" & txtIssueBy.Text & "'" & _
                        "WHERE receiptId = '" & receiptId & "'"
                End If




                sqlCommand = New MySqlCommand(query, sqlConnection)
                If warrantyDate = "" Then
                    sqlCommand.Parameters.AddWithValue("@noWarranty", DBNull.Value)
                End If



                sqlCommand.ExecuteNonQuery()
                sqlConnection.Close()

                MsgBox("Succesfully update current record")
            Catch ex As Exception

            End Try

        End If
    End Sub




    Private Sub printDocument_BeginPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles printDocument.BeginPrint
        If printDocument.PrintController.IsPreview = False Then

            If canUpdate Then
                sqlConnection = New MySqlConnection
                sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"

                sqlConnection.Open()

                Dim query As String
                query = "INSERT INTO bch.invoice (companyName, companyAddress, companyTel, deliveryMethod, receiptId) VALUES ('" & choseCompany.txtName.Text & "','" & choseCompany.txtAddress.Text & "' , '" & choseCompany.txtTel.Text & "', '" & choseCompany.deliveryMethod & "','" & receiptId & "')"


                sqlCommand = New MySqlCommand(query, sqlConnection)
                sqlCommand.ExecuteNonQuery()

                'query = "SELECT issueId FROM invoice ORDER BY issueId DESC LIMIT 1"
                'sqlCommand = New MySqlCommand(query, sqlConnection)
                'question 1 (get the latest record and print in invoice?)
                'Dim haha As String = sqlCommand.ExecuteScalar().ToString
                ' MsgBox(haha)

                query = "UPDATE bch.receipt SET invoiceStatus = 'O' where receiptId = '" & receiptId & "'"
                sqlCommand = New MySqlCommand(query, sqlConnection)

                sqlCommand.ExecuteNonQuery()

                sqlConnection.Close()
                MsgBox("Successfully outsource the watch")

                alreadyPrint = True
                canUpdate = False

            End If

            Try

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub PrintDocumentMaintain_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentMaintain.PrintPage
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

        address = sysDefault.getAddress
        address2 = sysDefault.getAddress2
        tel = sysDefault.getTel
        fax = sysDefault.getFax

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
        e.Graphics.DrawString("Model         : " + txtModel.Text, content, Brushes.Black, 500, sameLine)
        sameLine += 20
        e.Graphics.DrawString("Serial          : " + txtSerial.Text, content, Brushes.Black, 500, sameLine)


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
        e.Graphics.DrawString("Remark :" + txtRemark.Text, content, Brushes.Black, 70, rowValue)
        rowValue += 20
        'issue by
        e.Graphics.DrawString("Issue By: " + txtIssueBy.Text, content, Brushes.Black, 70, rowValue)

        'customer signature 
        rowValue += 30
        e.Graphics.DrawString("Customer Signature", content, Brushes.Black, 610, rowValue)
        e.Graphics.DrawLine(Pens.Black, 600, rowValue - 5, 750, rowValue - 5)

        'warning
        Dim warning1 As String = "Others conditions of watch not mentioned or missed out, its status remain unknown to the company"
        e.Graphics.DrawString("**" + warning1, warningText, Brushes.Black, 70, rowValue)
        rowValue += 20
        Dim warning2 As String = "Customer hereby agreed, repaired goods, not claimed after 90 days will be disposed off, without further notice."
        e.Graphics.DrawString("**" + warning2, warningText, Brushes.Black, 70, rowValue)


    End Sub

    Private Sub printDocument_QueryPageSettings(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.QueryPageSettingsEventArgs) Handles printDocument.QueryPageSettings
        'e.PageSettings.Landscape = True
    End Sub

    Private Sub PrintDocumentMaintain_QueryPageSettings(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.QueryPageSettingsEventArgs) Handles PrintDocumentMaintain.QueryPageSettings
        e.PageSettings.Landscape = True


    End Sub
End Class
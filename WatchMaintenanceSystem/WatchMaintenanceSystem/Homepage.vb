Imports MySql.Data.MySqlClient



Public Class Homepage
    Dim sqlConnection As MySqlConnection

    Private Sub btnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClick.Click
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()
            MessageBox.Show("Done")
            sqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInsert.Click
        AddNewInvoice.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Workshop.Show()
        Me.Close()

    End Sub

    Private Sub Homepage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlConnection As MySqlConnection
        Dim sqlCommand As MySqlCommand

        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()
            Dim sda As New MySqlDataAdapter
            Dim dataset As New DataTable
            Dim bindingSource As New BindingSource

            Dim query As String



            query = "Select receiptId,custName,custPhoneNum,watchBrand,dateRepair from bch.receipt where invoiceStatus='P' and dateRepair <= @dateBefore order by dateRepair ASC "


            sqlCommand = New MySqlCommand(query, sqlConnection)
            sda.SelectCommand = sqlCommand

            sda.SelectCommand.Parameters.AddWithValue("@dateBefore", Date.Now.ToString("yyyy/MM/dd HH:mm:ss"))


            sda.Fill(dataset)
            bindingSource.DataSource = dataset
            dgvReminder.DataSource = bindingSource
            sda.Update(dataset)

            dgvReminder.Columns(0).HeaderText = "Receipt No"
            dgvReminder.Columns(1).HeaderText = "Name"
            dgvReminder.Columns(2).HeaderText = "Phone No"
            dgvReminder.Columns(3).HeaderText = "Watch Brand"
            dgvReminder.Columns(4).HeaderText = "Date Import"

            sqlConnection.Close()
        Catch ex As Exception

        End Try


        Dim img As New DataGridViewImageColumn()
        dgvReminder.Columns.Insert(0, img)
        img.HeaderText = ""
        img.Width = 40


        For x As Integer = 0 To dgvReminder.RowCount - 1
            dgvReminder.Rows(x).Height += 20
            Dim valueDate As Date = dgvReminder.Rows(x).Cells(5).Value

            Dim dateRange As Long = DateDiff(DateInterval.Day, valueDate, Date.Now)

            If Date.Now.Year.ToString.Equals(valueDate.Year.ToString) Then
                If dateRange >= 7 Then
                    dgvReminder.Rows(x).Cells(0).Value = My.Resources.warning
                ElseIf dateRange >= 5 Then
                    dgvReminder.Rows(x).Cells(0).Value = My.Resources.yellowWarn
                Else
                    dgvReminder.Rows(x).Cells(0).Value = My.Resources.greenOK

                End If
            Else
                dgvReminder.Rows(x).Cells(0).Value = My.Resources.warning
            End If



        Next



    End Sub


    Private Sub btnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssue.Click
        IssueSearch.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaintenance.Click
        LoginForm.ShowDialog()


    End Sub

    Private Sub dgvReminder_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvReminder.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvReminder.Rows(e.RowIndex)

            Dim issueform As New issueForm
            issueform.GetData(row.Cells("receiptId").Value.ToString)
            issueform.ShowDialog()
            'Me.Close()

        End If
    End Sub


    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        HistoryForm.Show()
        Me.Close()

    End Sub
End Class

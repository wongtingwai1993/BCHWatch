Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class detailReportForm
    Dim sqlCon As MySqlConnection
    Dim sqlCom As MySqlCommand

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlCon = New MySqlConnection
        sqlCon.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"

        Try
            sqlCon.Open()

            Dim sda As New MySqlDataAdapter
            Dim dataset As New DataTable
            Dim binding As New BindingSource

            Dim query As String
            query = "SELECT r.receiptId, r.prefix,r.custName,r.watchBrand,r.watchModel,i.deliveryMethod, CAST((100/106* i.quotationPrice) as Decimal(10,2)), CAST((6/106* i.quotationPrice) as Decimal(10,2)),i.quotationPrice, r.dateComplete from bch.receipt r INNER JOIN bch.invoice i ON r.receiptId = i.receiptId " +
            "WHERE r.dateComplete between '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTo.Value.ToString("yyyy-MM-dd") + "' AND r.invoiceStatus = 'C' "

            sqlCom = New MySqlCommand(query, sqlCon)
            sda.SelectCommand = sqlCom

            'input parameter
            'sda.SelectCommand.Parameters.AddWithValue("start", dtpFrom.Value.ToString())
            'sda.SelectCommand.Parameters.AddWithValue("end", dtpTo.Value.ToString())

            'here to put select parameter value
            'If txtName.Text.Trim.Length > 0 Then
            '    sda.SelectCommand.Parameters.AddWithValue("name", "%" & txtName.Text & "%")
            'End If

            sda.Fill(dataset)
            binding.DataSource = dataset
            dgvReport.DataSource = binding
            sda.Update(dataset)

            dgvReport.Columns(0).HeaderText = "Receipt No"
            dgvReport.Columns(1).HeaderText = "Prefix"
            dgvReport.Columns(2).HeaderText = "Customer Name"
            dgvReport.Columns(3).HeaderText = "Watch Brand"
            dgvReport.Columns(4).HeaderText = "Watch Model"
            dgvReport.Columns(5).HeaderText = "Delivery Method"
            dgvReport.Columns(6).HeaderText = "Price Excluded GST"
            dgvReport.Columns(7).HeaderText = "GST Price"
            dgvReport.Columns(8).HeaderText = "Price Included GST"
            dgvReport.Columns(9).HeaderText = "Date Complete"

            sqlCon.Close()



        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Try
            Dim xlapp As Excel.Application
            Dim xlworkbook As Excel.Workbook
            Dim xlworksheet As Excel.Worksheet
            Dim misvalue As Object = Reflection.Missing.Value

            xlapp = New Excel.Application
            xlworkbook = xlapp.Workbooks.Add(misvalue)
            xlworksheet = xlworkbook.Sheets("sheet1")


            For i = 0 To dgvReport.RowCount - 2
                For j = 0 To dgvReport.ColumnCount - 1
                    For k As Integer = 1 To dgvReport.Columns.Count
                        xlworksheet.Cells(1, k) = dgvReport.Columns(k - 1).HeaderText
                        xlworksheet.Cells(i + 2, j + 1) = dgvReport(j, i).Value.ToString()
                    Next
                Next
            Next

            Dim filePath = Environment.CurrentDirectory
            xlworksheet.SaveAs(filePath + "\DetailReport-" + Now.ToString("yyyyMMdd_hhmmss") + ".xlsx")
            xlworkbook.Close()
            xlapp.Quit()

            releaseObject(xlapp)
            releaseObject(xlworkbook)
            releaseObject(xlworksheet)


            MessageBox.Show("Done exporting excel")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try



    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub detailReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = Date.Now.AddMonths(-1)
    End Sub
End Class
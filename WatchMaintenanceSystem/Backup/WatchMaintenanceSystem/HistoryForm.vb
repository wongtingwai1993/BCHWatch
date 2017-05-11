Imports MySql.Data.MySqlClient

Public Class HistoryForm
    Dim sqlConnection As MySqlConnection
    Dim sqlCommand As MySqlCommand
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()
            Dim sda As New MySqlDataAdapter
            Dim dataset As New DataTable
            Dim bindingSource As New BindingSource

            Dim query As String
            query = "Select receiptId,custName,custPhoneNum,watchBrand,dateRepair from bch.receipt "

            If txtInvoice.Text.Trim.Length > 0 Then
                query += "where receiptId = @id "
            Else
                query += "where receiptId!=0 and invoiceStatus='C' "
            End If


            If txtName.Text.Trim.Length > 0 Then
                query += "and custName LIKE @name "
            End If

            If txtPhone.Text.Trim.Length > 0 Then
                query += "and custPhoneNum LIKE @num "
            End If


            sqlCommand = New MySqlCommand(query, sqlConnection)
            sda.SelectCommand = sqlCommand

            If txtName.Text.Trim.Length > 0 Then
                sda.SelectCommand.Parameters.AddWithValue("name", "%" & txtName.Text & "%")
            End If

            If txtPhone.Text.Trim.Length > 0 Then
                sda.SelectCommand.Parameters.AddWithValue("num", "%" & txtPhone.Text & "%")
            End If

            If txtInvoice.Text.Trim.Length > 0 Then
                sda.SelectCommand.Parameters.AddWithValue("id", txtInvoice.Text)
            End If


            sda.Fill(dataset)
            bindingSource.DataSource = dataset
            dgvInfo.DataSource = bindingSource
            sda.Update(dataset)

            dgvInfo.Columns(0).HeaderText = "Receipt No"
            dgvInfo.Columns(1).HeaderText = "Name"
            dgvInfo.Columns(2).HeaderText = "Phone No"
            dgvInfo.Columns(3).HeaderText = "Watch Brand"
            dgvInfo.Columns(4).HeaderText = "Date Import"

            sqlConnection.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Homepage.Show()
        Me.Close()

    End Sub

    Private Sub dgvInfo_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvInfo.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvInfo.Rows(e.RowIndex)

            Dim workshop As New WorkshopDetail
            workshop.GetData(row.Cells("receiptId").Value.ToString)
            workshop.Show()
            Me.Close()

        End If
    End Sub
End Class
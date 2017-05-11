Imports MySql.Data.MySqlClient

Public Class deliveryChargeForm
    Dim sqlConnection As MySqlConnection
    Dim sqlCommand As MySqlCommand
    Dim sysDefault As New DefaultSystem

    Dim receiptId As String
    Dim receiptPrefix As String

    Public Sub GetData(ByVal id As String, ByVal prefix As String)
        receiptPrefix = prefix
        receiptId = id
    End Sub


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click

        Try
            sqlConnection = New MySqlConnection
            sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
            sqlConnection.Open()


            Dim query As String = ""

            query = "INSERT INTO bch.delivery(drCancelBy, drCharges,receiptId) VALUES('" & txtCancelBy.Text & "'," & txtCharges.Text & "," & receiptId & ")"

            sqlCommand = New MySqlCommand(query, sqlConnection)



            sqlCommand.ExecuteNonQuery()
            sqlConnection.Close()

            MsgBox("Succesfully cancel the record")


            'Need to update the workshop receipt to R

            sqlConnection = New MySqlConnection
            sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"

            sqlConnection.Open()

            query = "UPDATE bch.receipt SET invoiceStatus = 'R' WHERE receiptId = '" & receiptId & "'"

            sqlCommand = New MySqlCommand(query, sqlConnection)

            sqlCommand.ExecuteNonQuery()
            sqlConnection.Close()


        Catch ex As Exception

        End Try


    End Sub


    Private Sub deliveryChargeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtReceiptId.Text = receiptPrefix + receiptId
    End Sub
End Class
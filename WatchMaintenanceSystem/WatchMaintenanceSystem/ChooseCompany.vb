Imports MySql.Data.MySqlClient
Public Class ChooseCompany
    Dim sqlConnection As MySqlConnection
    Dim sqlCommand As MySqlCommand
    Dim confirmation As Boolean = False
    Public deliveryMethod As String = ""

    Private Sub ChooseCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Dim sqlReader As MySqlDataReader

        Try
            sqlConnection.Open()

            Dim query As String
            query = "SELECT companyName FROM bch.company "

            sqlCommand = New MySqlCommand(query, sqlConnection)
            sqlReader = sqlCommand.ExecuteReader

            While sqlReader.Read
                cbCompany.Items.Add(sqlReader.GetString("companyName"))
            End While

            sqlConnection.Close()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub cbCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCompany.SelectedIndexChanged
        Dim companyName As String = cbCompany.Text

        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Dim sqlReader As MySqlDataReader

        Try
            sqlConnection.Open()

            Dim query As String
            query = "SELECT * FROM bch.company WHERE companyName = '" & companyName & "' "

            sqlCommand = New MySqlCommand(query, sqlConnection)
            sqlReader = sqlCommand.ExecuteReader

            If sqlReader.Read Then
                txtName.Text = companyName
                txtAddress.Text = sqlReader.GetString("companyAddress")
                txtTel.Text = sqlReader.GetString("companyTel")
            End If

            sqlConnection.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssue.Click

        Dim proceed As Boolean = doChecking()

        If proceed Then
            confirmation = True
            Me.Hide()
        End If

    End Sub

    Private Function doChecking() As Boolean
        Dim errorCount As Integer = 0

        'company name
        If Not txtName.Text.Trim.Length > 0 Then
            errName.SetError(txtName, "Please Key in Company Name")
            errorCount += 1
        Else
            errName.SetError(txtName, "")
        End If
        'company Address
        If Not txtAddress.Text.Trim.Length > 0 Then
            errAddress.SetError(txtAddress, "Please Key in Company Address")
            errorCount += 1
        Else
            errAddress.SetError(txtAddress, "")
        End If
        'company tel
        If Not txtTel.Text.Trim.Length > 0 Then
            errTel.SetError(txtTel, "Please Key in Company Telephone")
            errorCount += 1
        Else
            errTel.SetError(txtTel, "")
        End If
        'issue by
        If Not txtIssue.Text.Trim.Length > 0 Then
            errIssueBy.SetError(txtIssue, "Please Key in Issue By")
            errorCount += 1
        Else
            errIssueBy.SetError(txtIssue, "")
        End If
        'deivery method
        If deliveryMethod = "" Then
            errDelivery.SetError(rbPost, "Please Select Delivery Method")
            errorCount += 1
        Else
            errDelivery.SetError(rbPost, "")
        End If

        If errorCount > 0 Then
            Return False
        Else
            Return True
        End If


    End Function


    Public Function getConfirmation() As Boolean
        Return confirmation
    End Function


    Private Sub rbPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPost.CheckedChanged
        deliveryMethod = rbPost.Text
    End Sub
    Private Sub rbHand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHand.CheckedChanged
        deliveryMethod = rbHand.Text
    End Sub
End Class
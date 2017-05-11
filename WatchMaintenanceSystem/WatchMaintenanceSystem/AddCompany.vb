Imports MySql.Data.MySqlClient

Public Class AddCompany
    Dim sqlConnection As MySqlConnection
    Dim sqlCommand As MySqlCommand
    Dim sqlReader As MySqlDataReader

    Private Sub AddCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshCompanyCombo()
    End Sub

    Public Sub refreshCompanyCombo()
        cbCompany.Items.Clear()

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

    Private Sub cbCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCompany.SelectedIndexChanged
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
                txtID.Text = sqlReader.GetInt32("companyId")
            End If

            sqlConnection.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"

        'Dim sqlReader As MySqlDataReader

        Try
            sqlConnection.Open()

            Dim searchNameQuery As String
            searchNameQuery = "SELECT * FROM bch.company WHERE companyName= '" + txtName.Text + "' "
            sqlCommand = New MySqlCommand(searchNameQuery, sqlConnection)
            sqlReader = sqlCommand.ExecuteReader

            If sqlReader.Read Then
                MessageBox.Show("Duplicate company name found, action is abort!")
                Return
            End If



            Dim query As String
            query = "INSERT INTO bch.company(companyName,companyAddress,companyTel) VALUES ('" + txtName.Text + "', '" + txtAddress.Text + "', '" + txtTel.Text + "')"

            sqlCommand = New MySqlCommand(query, sqlConnection)

            sqlCommand.ExecuteNonQuery()

            MessageBox.Show("Insert successfully!")

            sqlConnection.Close()

            refreshCompanyCombo()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click

        If txtID.Text = "" Then
            MessageBox.Show("Please select a company before update!")
        Else
            sqlConnection = New MySqlConnection
            sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"

            Try
                sqlConnection.Open()
                Dim query As String
                query = "UPDATE bch.company SET companyName = '" + txtName.Text + "',companyAddress='" + txtAddress.Text + "', companyTel='" + txtTel.Text + "' WHERE companyID = '" + txtID.Text + "' "
                sqlCommand = New MySqlCommand(query, sqlConnection)
                sqlCommand.ExecuteNonQuery()
                MessageBox.Show("Update Success!")
                sqlConnection.Close()

            Catch ex As Exception

            End Try
        End If



    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If txtID.Text = "" Then
            MessageBox.Show("Please select a company before delete!")
        Else
            sqlConnection = New MySqlConnection
            sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"

            Try
                sqlConnection.Open()
                Dim query As String
                query = "DELETE FROM bch.company where companyId = '" + txtID.Text + "' "
                sqlCommand = New MySqlCommand(query, sqlConnection)
                sqlCommand.ExecuteNonQuery()
                MessageBox.Show("Delete Success!")
                sqlConnection.Close()

            Catch ex As Exception
                Throw ex

            End Try

        End If
        refreshCompanyCombo()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub
End Class
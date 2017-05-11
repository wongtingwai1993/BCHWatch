Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim sqlConnection As MySqlConnection
    Dim sqlCommand As MySqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()
            Dim sqlReader As MySqlDataReader

            Dim query As String = "select * from admin where adminId='" & txtUsername.Text & "' and adminPassword='" & txtPassword.Text & "'"

            sqlCommand = New MySqlCommand(query, sqlConnection)
            sqlReader = sqlCommand.ExecuteReader()

            If sqlReader.Read Then
                MaintenanceMenu.Show()


                Me.Close()

            Else
                MsgBox("Username or password is wrong")
            End If




            sqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Homepage.Show()
        Me.Dispose()

    End Sub
End Class
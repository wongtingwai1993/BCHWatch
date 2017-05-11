Imports MySql.Data.MySqlClient

Public Class DefaultSystem

    Dim sqlConnection As MySqlConnection
    Dim sqlCommand As MySqlCommand
    Dim sqlReader As MySqlDataReader

    Public Function getPrefix() As String
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()

            Dim prefixQuery As String

            prefixQuery = "select locationPrefix from location inner join sysdefault on sysdefault.locationId = location.locationId"

            sqlCommand = New MySqlCommand(prefixQuery, sqlConnection)

            Return sqlCommand.ExecuteScalar


        Catch ex As Exception

        End Try
        Return "Fail to obtain prefix"
    End Function

    Public Function getAddress() As String
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()

            Dim addressQuery As String

            addressQuery = "select locationAddress from location inner join sysdefault on sysdefault.locationId = location.locationId"

            sqlCommand = New MySqlCommand(addressQuery, sqlConnection)

            Return sqlCommand.ExecuteScalar


        Catch ex As Exception

        End Try
        Return "Fail to obtain address"
    End Function



    Public Function getAddress2() As String
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()

            Dim addressQuery As String

            addressQuery = "select locationAddress2 from location inner join sysdefault on sysdefault.locationId = location.locationId"

            sqlCommand = New MySqlCommand(addressQuery, sqlConnection)

            Return sqlCommand.ExecuteScalar


        Catch ex As Exception

        End Try
        Return "Fail to obtain address2"
    End Function
    Public Function getTel() As String
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()

            Dim telQuery As String

            telQuery = "select locationTel from location inner join sysdefault on sysdefault.locationId = location.locationId"

            sqlCommand = New MySqlCommand(telQuery, sqlConnection)

            Return sqlCommand.ExecuteScalar


        Catch ex As Exception

        End Try
        Return "Fail to obtain tel"
    End Function
    Public Function getFax() As String
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()

            Dim faxQuery As String

            faxQuery = "select locationFax from location inner join sysdefault on sysdefault.locationId = location.locationId"

            sqlCommand = New MySqlCommand(faxQuery, sqlConnection)

            Return sqlCommand.ExecuteScalar


        Catch ex As Exception

        End Try
        Return "Fail to obtain fax"
    End Function


    Public Function getLocation() As String
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()

            Dim locationQuery As String

            locationQuery = "select locationName from location inner join sysdefault on sysdefault.locationId = location.locationId"

            sqlCommand = New MySqlCommand(locationQuery, sqlConnection)

            Return sqlCommand.ExecuteScalar


        Catch ex As Exception

        End Try
        Return "Fail to obtain location"
    End Function

    Public Function getLocationId() As String
        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"
        Try
            sqlConnection.Open()

            Dim locationIdQuery As String

            locationIdQuery = "select location.locationId from location inner join sysdefault on sysdefault.locationId = location.locationId"

            sqlCommand = New MySqlCommand(locationIdQuery, sqlConnection)

            Return sqlCommand.ExecuteScalar


        Catch ex As Exception

        End Try
        Return "Fail to obtain location Id"
    End Function

End Class

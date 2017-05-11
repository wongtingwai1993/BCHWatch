Imports MySql.Data.MySqlClient

Public Class defaultSystemForm
    Dim dftSystem As New DefaultSystem
    Dim sqlConnection As MySqlConnection
    Dim sqlCommand As MySqlCommand


    Private Sub defaultSystemForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim haha As String = dftSystem.getAddress
        txtAddress.Text = dftSystem.getAddress
        txtLocation.Text = dftSystem.getLocation
        txtFax.Text = dftSystem.getFax
        txtPrefix.Text = dftSystem.getPrefix
        txtTel.Text = dftSystem.getTel
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim canProceed As Boolean = doChecking()

        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"

        If canProceed Then
            Try
                sqlConnection.Open()

                Dim query As String = ""
                query = "UPDATE bch.location SET locationName='" & txtLocation.Text & "',locationAddress='" & txtAddress.Text & "',locationPrefix='" & txtPrefix.Text & "',locationFax='" & txtFax.Text & "',locationTel='" & txtTel.Text & "'" & _
                    "WHERE locationId = " & dftSystem.getLocationId() & ""

                sqlCommand = New MySqlCommand(query, sqlConnection)
                sqlCommand.ExecuteNonQuery()
                sqlConnection.Close()

                MsgBox("Update Success")

            Catch ex As Exception

                MsgBox("Fail to Update")
            End Try

        End If

    End Sub

    Private Function doChecking() As Boolean
        Dim errCount As Integer = 0

        If txtLocation.Text.Trim.Length = 0 Then
            errLocation.SetError(txtLocation, "Please Enter Location")
            errCount += 1
        Else
            errLocation.SetError(txtLocation, "")
        End If


        If txtAddress.Text.Trim.Length = 0 Then
            errAddress.SetError(txtAddress, "Please Enter Address")
            errCount += 1
        Else
            errAddress.SetError(txtAddress, "")
        End If


        If txtFax.Text.Trim.Length = 0 Then
            errFax.SetError(txtFax, "Please Enter Fax")
            errCount += 1
        Else
            errFax.SetError(txtFax, "")
        End If


        If txtPrefix.Text.Trim.Length = 0 Then
            errPrefix.SetError(txtPrefix, "Please Enter Prefix")
            errCount += 1
        Else
            errPrefix.SetError(txtPrefix, "")
        End If


        If txtTel.Text.Trim.Length = 0 Then
            errTel.SetError(txtTel, "Please Enter Location")
            errCount += 1
        Else
            errTel.SetError(txtTel, "")
        End If

        If errCount > 0 Then
            Return False
        Else
            Return True
        End If



    End Function


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        MaintenanceMenu.Show()
        Me.Dispose()
    End Sub
End Class
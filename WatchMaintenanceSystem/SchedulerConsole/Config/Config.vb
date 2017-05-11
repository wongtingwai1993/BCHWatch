Imports System.Configuration

Public Class Config
    Public Function getEmailList() As List(Of String)
        Dim emailList As New List(Of String)

        Try
            Dim value As Integer = 1
            While Not ConfigurationManager.AppSettings.Get("email_" + value.ToString) Is Nothing
                emailList.Add(ConfigurationManager.AppSettings.Get("email_" + value.ToString))
                value += 1
            End While
        Catch ex As Exception
            Throw ex
        End Try
        Return emailList
    End Function


End Class

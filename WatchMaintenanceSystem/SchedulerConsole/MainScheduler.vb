Imports System
Imports System.Diagnostics
Module MainScheduler
    Dim sSource As String = "Application"
    Dim sLog As String = "BCH"
    Dim sEvent As String = "SchedulingEvent"
    Dim sMachine As String = "."

    Sub Main()
        'this try is catch error occur in event log
        Try
            If Not EventLog.SourceExists(sSource) Then
                EventLog.CreateEventSource(sSource, sLog)
            End If

            Dim myLog As New EventLog()
            myLog.Source = sSource

            'this try is to catch job error log
            Try
                myLog.WriteEntry("Starting to execute Monthly Generated Report...", EventLogEntryType.Information, 234)

                Dim job1 As New MonthylExcelGenerator
                job1.generateMonthlyExcel()
                myLog.WriteEntry("Monthly Generated Report finish executed", EventLogEntryType.Information, 234)
            Catch ex As Exception
                myLog.WriteEntry("Monthly Generated end in error!", EventLogEntryType.Error, 234)
                myLog.WriteEntry(ex.ToString, EventLogEntryType.Error)
            End Try
        Catch ex As Exception

        End Try


    End Sub
    'to check and create a new source if not exist
End Module

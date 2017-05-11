Imports System.Net.Mail
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class MonthylExcelGenerator
    Public Sub generateMonthlyExcel()

        Dim service As New MonthlyGeneratorImpl
        Dim result As List(Of MonthyGenerateController) = service.monthyGenerator

        Try
            Dim xlapp As Excel.Application
            Dim xlworkbook As Excel.Workbook
            Dim xlworksheet As Excel.Worksheet
            Dim misvalue As Object = Reflection.Missing.Value

            xlapp = New Excel.Application
            xlworkbook = xlapp.Workbooks.Add(misvalue)
            xlworksheet = xlworkbook.Sheets("sheet1")

            ' Setting the hearder text (excel cell start from index 1) 
            xlworksheet.Cells(1, 1) = "Receipt Id"
            xlworksheet.Cells(1, 2) = "Prefix"
            xlworksheet.Cells(1, 3) = "Customer Name"
            xlworksheet.Cells(1, 4) = "Watch Brand"
            xlworksheet.Cells(1, 5) = "Watch Model"
            xlworksheet.Cells(1, 6) = "Delivery Method"
            xlworksheet.Cells(1, 7) = "Quotation Price"
            xlworksheet.Cells(1, 8) = "Date Complete"

            Dim row As Integer = 2
            Dim column As Integer = 1
            For i = 0 To result.Count - 1
                xlworksheet.Cells(row, column) = result(i).receiptId
                column += 1
                xlworksheet.Cells(row, column) = result(i).prefix
                column += 1
                xlworksheet.Cells(row, column) = result(i).custName
                column += 1
                xlworksheet.Cells(row, column) = result(i).watchBrand
                column += 1
                xlworksheet.Cells(row, column) = result(i).watchModel
                column += 1
                xlworksheet.Cells(row, column) = result(i).deliveryMethod
                column += 1
                xlworksheet.Cells(row, column) = result(i).quotationPrice
                column += 1
                xlworksheet.Cells(row, column) = result(i).dateComplete

                row += 1
                column = 1
            Next

            Dim filePath = Environment.CurrentDirectory + "\Yeaa-" + Now.ToString("yyyyMMdd_hhmmss") + ".xlsx"
            xlworksheet.SaveAs(filePath)
            xlworkbook.Close()
            xlapp.Quit()

            releaseObject(xlapp)
            releaseObject(xlworkbook)
            releaseObject(xlworksheet)

            sendEmail(filePath)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub sendEmail(filePath As String)
        Dim configTable As New Config
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()

        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("bchPerak@hotmail.com", "bch123perak")
        Smtp_Server.Port = 25
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp-mail.outlook.com"
        Smtp_Server.DeliveryFormat = SmtpDeliveryMethod.Network
        e_mail = New MailMessage()
        e_mail.From = New MailAddress("bchPerak@hotmail.com")

        For Each value In configTable.getEmailList
            e_mail.To.Add(value)
        Next

        e_mail.Subject = "Monthly Job Scheduler From " + Date.Now.AddMonths(-1) + " Until " + Date.Now
        e_mail.IsBodyHtml = False
        e_mail.Body = "This is system generated email which attached with Monthly Excel."

        Dim attach As New Attachment(filePath)
        e_mail.Attachments.Add(attach)
        Smtp_Server.Send(e_mail)

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
End Class

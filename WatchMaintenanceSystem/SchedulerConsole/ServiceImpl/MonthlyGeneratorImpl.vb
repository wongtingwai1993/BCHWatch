Imports MySql.Data.MySqlClient

Public Class MonthlyGeneratorImpl
    Dim sqlCon As MySqlConnection
    Dim sqlCom As MySqlCommand
    Public Function monthyGenerator() As List(Of MonthyGenerateController)
        sqlCon = New MySqlConnection
        sqlCon.ConnectionString = "server=localhost;userid=root;password=123456;database=bch"

        Try
            sqlCon.Open()

            Dim sda As New MySqlDataAdapter
            Dim dataset As New DataTable
            Dim sqlReader As MySqlDataReader

            Dim query As String
            query = "SELECT r.receiptId, r.prefix,r.custName,r.watchBrand,r.watchModel,i.deliveryMethod,i.quotationPrice, r.dateComplete from bch.receipt r INNER JOIN bch.invoice i ON r.receiptId = i.receiptId " +
            "WHERE r.dateComplete between '" + Me.changeDatetoStart(Date.Now.AddMonths(-1)).ToString("yyyy-MM-dd hh:mm:ss") + "' AND '" + Me.changeDatetoStart(Date.Now).ToString("yyyy-MM-dd hh:mm:ss") + "' AND r.invoiceStatus = 'C' "

            sqlCom = New MySqlCommand(query, sqlCon)
            sqlReader = sqlCom.ExecuteReader

            Dim monthlyGeneratorControllers As New List(Of MonthyGenerateController)
            While sqlReader.Read
                Dim monthlyGen As New MonthyGenerateController
                monthlyGen.receiptId = sqlReader.GetString("receiptId")
                monthlyGen.prefix = sqlReader.GetString("prefix")
                monthlyGen.custName = sqlReader.GetString("custName")
                monthlyGen.watchBrand = sqlReader.GetString("watchBrand")
                monthlyGen.watchModel = sqlReader.GetString("watchModel")
                monthlyGen.deliveryMethod = sqlReader.GetString("deliveryMethod")
                monthlyGen.quotationPrice = sqlReader.GetDecimal("quotationPrice")
                monthlyGen.dateComplete = sqlReader.GetDateTime("dateComplete")
                monthlyGeneratorControllers.Add(monthlyGen)
            End While
            Return monthlyGeneratorControllers
        Catch
            Throw
        End Try
    End Function
    Public Function changeDatetoStart(dateParam As Date) As Date
        dateParam.Hour.ToString("00")
        dateParam.Minute.ToString("00")
        dateParam.Second.ToString("00")
        Return dateParam

    End Function
End Class

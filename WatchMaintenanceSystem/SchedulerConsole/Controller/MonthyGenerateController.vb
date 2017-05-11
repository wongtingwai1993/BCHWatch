Public Class MonthyGenerateController


    Private watchBrandValue As String
    Public Property watchBrand() As String
        Get
            Return watchBrandValue
        End Get
        Set(ByVal value As String)
            watchBrandValue = value
        End Set
    End Property
    Private watchModelValue As String
    Public Property watchModel() As String
        Get
            Return watchModelValue
        End Get
        Set(ByVal value As String)
            watchModelValue = value
        End Set
    End Property
    Private deliveryMethodValue As String
    Public Property deliveryMethod() As String
        Get
            Return deliveryMethodValue
        End Get
        Set(ByVal value As String)
            deliveryMethodValue = value
        End Set
    End Property
    Private quotationPriceValue As Decimal
    Public Property quotationPrice() As Decimal
        Get
            Return quotationPriceValue
        End Get
        Set(ByVal value As Decimal)
            quotationPriceValue = value
        End Set
    End Property
    Private dateCompleteValue As Date
    Public Property dateComplete As Date
        Get
            Return dateCompleteValue
        End Get
        Set(ByVal value As Date)
            dateCompleteValue = value
        End Set
    End Property

    Private receiptIdValue As Integer
    Public Property receiptId As Integer
        Get
            Return receiptIdValue
        End Get
        Set(ByVal value As Integer)
            receiptIdValue = value
        End Set
    End Property

    Private prefixValue As String
    Public Property prefix() As String
        Get
            Return prefixValue
        End Get
        Set(ByVal value As String)
            prefixValue = value
        End Set
    End Property

    Private custNameValue As String
    Public Property custName() As String
        Get
            Return custNameValue
        End Get
        Set(ByVal value As String)
            custNameValue = value
        End Set
    End Property

End Class

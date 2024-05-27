Namespace Models
    Public Class Invoice
        '        •	ID,int,key
        '•	Number,string,nvarchar(6)
        '•	Date,datetime,date
        '•	Customer,foreignkey(customer)
        '•	LineItems,list<LineItem>
        '•	Total,currency
        '•	Payment Option
        Public Property Id As Integer
        Public Property InvoiceNumber As String
        Public Property InvoiceDate As DateTime
        Public Property Total As Double
        Public Property Discount As Double
        Public Property IsDiscountInPercentage As Boolean
        Public Property PaymentMode As String
        Public Property LineItems As List(Of LineItem)

        Public Property CustomerId As Integer
        Public Property Customer As Customer

    End Class

End Namespace

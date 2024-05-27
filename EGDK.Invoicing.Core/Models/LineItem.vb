Namespace Models
    Public Class LineItem
        '•	ID
        '•	Invoice
        '•	Product
        '•	Quantity
        '•	Amount
        Public Property Id As Integer
        Public Property Quantity As Integer
        Public Property Amount As Double

        Public Property InvoiceId As Integer
        Public Property Invoice As Invoice

        Public Property ProductId As Integer
    End Class

End Namespace


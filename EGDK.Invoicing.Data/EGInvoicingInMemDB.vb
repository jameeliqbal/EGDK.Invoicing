Imports EGDK.Invoicing.Core
Public Class EGInvoicingInMemDB
    Implements IInMemDB
    Public Sub New()
        FillDB()
    End Sub
    Public Sub FillDB() Implements IInMemDB.FillDB
        Throw New NotImplementedException()
    End Sub
End Class

Imports EGDK.Invoicing.Core.Models

Namespace Repositories
    Public Interface IInvoiceRepository
        Inherits IRepository(Of Invoice)

        Function GetLineItems(id As Integer) As IEnumerable(Of LineItem)
    End Interface

End Namespace


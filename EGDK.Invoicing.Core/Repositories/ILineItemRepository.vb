Imports EGDK.Invoicing.Core.Models

Namespace Repositories
    Public Interface ILineItemRepository
        Inherits IRepository(Of LineItem)

        Function GetLineItemTotal(id As Integer) As Double
        Function GetLineItems(id As Integer) As IEnumerable(Of LineItem)
    End Interface

End Namespace


Imports EGDK.Invoicing.Core.Models

Namespace Repositories
    Public Interface IProductRepository
        Inherits IRepository(Of Product)

        Function GetProductsByCategory(categoryID As Integer) As IEnumerable(Of Product)
    End Interface

End Namespace

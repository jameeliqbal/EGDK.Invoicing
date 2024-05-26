Imports EGDK.Invoicing.Core.Models
Imports EGDK.Invoicing.Core.Repositories

Namespace Repositories
    Public Interface ICategoryRepository
        Inherits IRepository(Of Category)

        Function GetCategoryWithProducts() As IEnumerable(Of Category)
    End Interface

End Namespace
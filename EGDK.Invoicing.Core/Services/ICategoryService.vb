Imports System.Net
Imports EGDK.Invoicing.Core.Models

Namespace Services
    Public Interface ICategoryService
        Function GetAllWithProducts() As IEnumerable(Of Category)
        Function GetCategoryById(id As Integer) As Category
        Function GetCategoryByProductId(productId As Integer) As IEnumerable(Of Category)
        Function CreateCategory(newCategory As Category) As Category
        Sub UpdateCategory(CategoryToBeUpdated As Category, Category As Category)
        Sub DeleteCategory(Category As Category)
    End Interface

End Namespace


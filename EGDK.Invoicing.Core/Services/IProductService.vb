Imports EGDK.Invoicing.Core.Models

Namespace Services
    Public Interface IProductService
        Function GetAllProducts() As IEnumerable(Of Product)
        Function GetProductById(id As Integer) As Product
        Function CreateProduct(newProduct As Product) As Product
        Sub UpdateProduct(productToBeUpdated As Product, product As Product)
        Sub DeleteProduct(product As Product)
    End Interface

End Namespace
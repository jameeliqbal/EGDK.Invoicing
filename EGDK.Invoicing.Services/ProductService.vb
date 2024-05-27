
Imports EGDK.Invoicing.Core
Imports EGDK.Invoicing.Core.Models
Imports EGDK.Invoicing.Core.Services

Public Class ProductService
    Implements IProductService

    Private ReadOnly _unitOfWork As IUnitOfWork

    Public Sub New(unitOfWork As IUnitOfWork)
        Me._unitOfWork = unitOfWork
    End Sub

    Public Function GetAllProducts() As IEnumerable(Of Product) Implements IProductService.GetAllProducts
        Return _unitOfWork.Products.GetAll()
    End Function

    Public Function GetProductById(id As Integer) As Product Implements IProductService.GetProductById
        Return _unitOfWork.Products.GetById(id)
    End Function

    Public Function CreateProduct(newProduct As Product) As Product Implements IProductService.CreateProduct
        _unitOfWork.Products.Add(newProduct)
        _unitOfWork.Commit()
        Return newProduct
    End Function

    Public Sub UpdateProduct(productToBeUpdated As Product, product As Product) Implements IProductService.UpdateProduct
        productToBeUpdated.Price = product.Price
        productToBeUpdated.Description = product.Description
        productToBeUpdated.Name = product.Name
        productToBeUpdated.CategoryId = product.CategoryId
        productToBeUpdated.Quantity = product.Quantity
        _unitOfWork.Commit()
    End Sub

    Public Sub DeleteProduct(product As Product) Implements IProductService.DeleteProduct
        _unitOfWork.Products.Remove(product)
        _unitOfWork.Commit()
    End Sub
End Class

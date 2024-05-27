Imports EGDK.Invoicing.Core.Models
Imports EGDK.Invoicing.Core
Imports EGDK.Invoicing.Core.Services


Public Class CategoryService
    Implements ICategoryService

    Private ReadOnly _unitOfWork As IUnitOfWork

    Public Sub New(unitOfWork As IUnitOfWork)
        Me._unitOfWork = unitOfWork
    End Sub

    Public Function CreateCategory(newCategory As Category) As Category Implements ICategoryService.CreateCategory
        _unitOfWork.Categories.Add(newCategory)
        _unitOfWork.Commit()
        Return newCategory
    End Function
    Public Sub UpdateCategory(CategoryToBeUpdated As Category, Category As Category) Implements ICategoryService.UpdateCategory
        CategoryToBeUpdated.Name = Category.Name
        CategoryToBeUpdated.Description = Category.Description
        _unitOfWork.Commit()
    End Sub
    Public Sub DeleteCategory(Category As Category) Implements ICategoryService.DeleteCategory
        _unitOfWork.Categories.Remove(Category)
        _unitOfWork.Commit()
    End Sub


    Public Function GetAllCategories() As IEnumerable(Of Category) Implements ICategoryService.GetAllCategories
        Return _unitOfWork.Categories.GetAll()
    End Function

    Public Function GetCategoryById(id As Integer) As Category Implements ICategoryService.GetCategoryById
        Return _unitOfWork.Categories.GetById(id)
    End Function

    Public Function GetCategoryByProductId(productId As Integer) As IEnumerable(Of Category) Implements ICategoryService.GetCategoryByProductId
        Throw New NotImplementedException()
    End Function


End Class

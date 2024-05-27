
Imports EGDK.Invoicing.Core.Repositories

Public Interface IUnitOfWork
    Inherits IDisposable
    ReadOnly Property Categories As ICategoryRepository
    ReadOnly Property Products As IProductRepository
    Function Commit() As Integer
End Interface


Imports EGDK.Invoicing.Core.Repositories

Public Interface IUnitOfWork
    Inherits IDisposable
    ReadOnly Property Categories As ICategoryRepository
    Function Commit() As Integer
End Interface

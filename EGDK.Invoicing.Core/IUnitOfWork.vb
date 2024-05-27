
Imports EGDK.Invoicing.Core.Repositories

Public Interface IUnitOfWork
    Inherits IDisposable
    ReadOnly Property Categories As ICategoryRepository
    ReadOnly Property Products As IProductRepository
    ReadOnly Property Customers As ICustomerRepository
    ReadOnly Property Invoices As IInvoiceRepository

    Function Commit() As Integer
End Interface

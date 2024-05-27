Imports EGDK.Invoicing.Core.Models

Namespace Repositories
    Public Interface ICustomerRepository
        Inherits IRepository(Of Customer)

        Function GetInvoiceForCustomer(id As Integer) As IEnumerable(Of Customer)


    End Interface

End Namespace

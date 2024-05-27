Imports EGDK.Invoicing.Core.Models

Namespace Services
    Public Interface ICustomerService
        Function GetAllCustomers() As IEnumerable(Of Customer)
        Function GetCustomerById(id As Integer) As Customer
        Function CreateCustomer(newCustomer As Customer) As Customer
        Sub UpdateCustomer(CustomerToBeUpdated As Customer, Customer As Customer)
        Sub DeleteCustomer(Customer As Customer)
    End Interface

End Namespace

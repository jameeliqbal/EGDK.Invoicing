
Imports EGDK.Invoicing.Core
Imports EGDK.Invoicing.Core.Models
Imports EGDK.Invoicing.Core.Services

Public Class CustomerService
    Implements ICustomerService

    Private ReadOnly _unitOfWork As IUnitOfWork

    Public Sub New(unitOfWork As IUnitOfWork)
        Me._unitOfWork = unitOfWork
    End Sub
    Public Function GetAllCustomers() As IEnumerable(Of Customer) Implements ICustomerService.GetAllCustomers
        Return _unitOfWork.Customers.GetAll()
    End Function

    Public Function GetCustomerById(id As Integer) As Customer Implements ICustomerService.GetCustomerById
        Return _unitOfWork.Customers.GetById(id)
    End Function

    Public Function CreateCustomer(newCustomer As Customer) As Customer Implements ICustomerService.CreateCustomer
        _unitOfWork.Customers.Add(newCustomer)
        _unitOfWork.Commit()
        Return newCustomer
    End Function
    Public Sub UpdateCustomer(CustomerToBeUpdated As Customer, Customer As Customer) Implements ICustomerService.UpdateCustomer
        CustomerToBeUpdated.Address = Customer.Address
        CustomerToBeUpdated.Email = Customer.Email
        CustomerToBeUpdated.Phone = Customer.Phone
        CustomerToBeUpdated.Name = Customer.Name
        _unitOfWork.Commit()
    End Sub

    Public Sub DeleteCustomer(Customer As Customer) Implements ICustomerService.DeleteCustomer
        _unitOfWork.Customers.Remove(Customer)
        _unitOfWork.Commit()
    End Sub

End Class

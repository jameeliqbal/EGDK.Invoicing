Imports EGDK.Invoicing.Core
Imports EGDK.Invoicing.Core.Models
Imports EGDK.Invoicing.Core.Services

Public Class InvoiceService
    Implements IInvoiceService

    Private ReadOnly unitOfWork As IUnitOfWork

    Public Sub New(unitOfWork As IUnitOfWork)
        Me.unitOfWork = unitOfWork
    End Sub

    Public Function GetAllInvoices() As IEnumerable(Of Invoice) Implements IInvoiceService.GetAllInvoices
        Return unitOfWork.Invoices.GetAll()
    End Function

    Public Function GetInvoiceById(id As Integer) As Invoice Implements IInvoiceService.GetInvoiceById
        Return unitOfWork.Invoices.GetById(id)
    End Function

    Public Function CreateInvoice(newInvoice As Invoice) As Invoice Implements IInvoiceService.CreateInvoice
        unitOfWork.Invoices.Add(newInvoice)
        unitOfWork.LineItems.AddRange(newInvoice.LineItems)
        unitOfWork.Commit()
        Return newInvoice
    End Function
    Public Sub UpdateInvoice(InvoiceToBeUpdated As Invoice, Invoice As Invoice) Implements IInvoiceService.UpdateInvoice
        InvoiceToBeUpdated.InvoiceDate = Invoice.InvoiceDate
        InvoiceToBeUpdated.IsDiscountInPercentage = Invoice.IsDiscountInPercentage
        InvoiceToBeUpdated.PaymentMode = Invoice.PaymentMode
        InvoiceToBeUpdated.Discount = Invoice.Discount
        InvoiceToBeUpdated.InvoiceNumber = Invoice.InvoiceNumber
        InvoiceToBeUpdated.Total = Invoice.Total
        unitOfWork.Commit()
    End Sub

    Public Sub DeleteInvoice(Invoice As Invoice) Implements IInvoiceService.DeleteInvoice
        unitOfWork.Invoices.Remove(Invoice)
        unitOfWork.Commit()
    End Sub

    'Public Function GetLineItemsTotal(id As Integer) As Double
    'End Function

    'Public Function GetLineItems(id As Integer) As IEnumerable(Of LineItem)
    'End Function

    Private Function IInvoiceService_GetLineItemsTotal(id As Integer) As Double Implements IInvoiceService.GetLineItemsTotal
        Return unitOfWork.LineItems.GetLineItemTotal(id)
    End Function

    Private Function IInvoiceService_GetLineItems(id As Integer) As IEnumerable(Of LineItem) Implements IInvoiceService.GetLineItems
        Return unitOfWork.LineItems.GetLineItems(id)

    End Function
End Class

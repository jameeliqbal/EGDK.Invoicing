﻿Imports EGDK.Invoicing.Core.Models

Namespace Services
    Public Interface IInvoiceService
        Function GetAllInvoices() As IEnumerable(Of Invoice)
        Function GetInvoiceById(id As Integer) As Invoice
        Function CreateInvoice(newInvoice As Invoice) As Invoice
        Sub UpdateInvoice(InvoiceToBeUpdated As Invoice, Invoice As Invoice)
        Sub DeleteInvoice(Invoice As Invoice)
        Function GetLineItemsTotal(id As Integer) As Double
        Function GetLineItems(id As Integer) As IEnumerable(Of LineItem)

    End Interface

End Namespace


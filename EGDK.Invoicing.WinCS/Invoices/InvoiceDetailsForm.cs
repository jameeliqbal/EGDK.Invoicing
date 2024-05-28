using EGDK.Invoicing.Core;
using EGDK.Invoicing.Core.Models;
using EGDK.Invoicing.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGDK.Invoicing.WinCS.Invoices
{
    public partial class InvoiceDetailsForm : Form
    {
        private readonly IInvoiceService invoiceService;
        private readonly ICustomerService customerService;

        public InvoiceDetailsForm(IInvoiceService invoiceService,   ICustomerService customerService)
        {
            InitializeComponent();
            this.invoiceService = invoiceService;
            this.customerService = customerService;
        }

        public void DislpayInvoiceDetails(Invoice invoice) 
        {
            lblCustomer.Text =customerService.GetCustomerById(invoice.CustomerId).Name;
            lblDiscount.Text= invoice.Discount.ToString();
            lblGrandTotal.Text = invoice.Total.ToString();
            lblInvoiceDate.Text = invoice.InvoiceDate.ToString();
            lblInvoiceNumber.Text = invoice.InvoiceNumber;
            lblPaymentMode.Text = invoice.PaymentMode;

            lblSubTotal.Text = invoiceService.GetLineItemsTotal(invoice.Id).ToString();
            lblTax.Text = "";
 
            dgvLineItems.DataSource = invoiceService.GetLineItems(invoice.Id);
            

        }
    }
}

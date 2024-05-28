using EGDK.Invoicing.Core;
using EGDK.Invoicing.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGDK.Invoicing.WinCS.Invoices
{
    public partial class InvoiceListForm : Form
    {
        private readonly IInvoiceService invoiceService;

        public InvoiceListForm(IInvoiceService invoiceService)
        {
            InitializeComponent();
            this.invoiceService = invoiceService;
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            dgvInvoices.DataSource = invoiceService.GetAllInvoices();
        }
    }
}

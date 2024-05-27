using EGDK.Invoicing.Core;
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
        private readonly IUnitOfWork unitOfWork;

        public InvoiceListForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            dgvInvoices.DataSource = unitOfWork.Invoices.GetAll();
        }
    }
}

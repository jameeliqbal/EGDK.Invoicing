using EGDK.Invoicing.Core;
using EGDK.Invoicing.Core.Models;
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
    public partial class InvoiceLineItemAddForm : Form
    {
        //private readonly IUnitOfWork unitOfWork;
        private LineItem newLineItem;
        public Invoice NewInvoice { get;  set; }
        private bool IsLoading;
        private readonly IProductService productService;

        //public InvoiceLineItemAddForm(IUnitOfWork unitOfWork)
        public InvoiceLineItemAddForm(IProductService productService)
        {
            InitializeComponent();
            //this.unitOfWork = unitOfWork;
            this.productService = productService;
        }

        private void InvoiceLineItemAddForm_Load(object sender, EventArgs e)
        {
            IsLoading = true;
            cmbProduct.DataSource = productService.GetAllProducts();
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";
            IsLoading = false;

            newLineItem = new LineItem();

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;
            newLineItem.ProductId = int.Parse(cmbProduct.SelectedValue.ToString());
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            newLineItem.Quantity = int.Parse(txtQuantity.Text.Trim());
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            newLineItem.Amount = double.Parse(txtAmount.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewInvoice.LineItems.Add(newLineItem);
        }
    }
}

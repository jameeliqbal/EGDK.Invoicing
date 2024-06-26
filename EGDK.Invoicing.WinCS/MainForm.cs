﻿using EGDK.Invoicing.Core.Models;
using EGDK.Invoicing.WinCS.Categories;
using EGDK.Invoicing.WinCS.Customers;
using EGDK.Invoicing.WinCS.Invoices;
using EGDK.Invoicing.WinCS.Products;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGDK.Invoicing.WinCS
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void categoriesListMenu_Click(object sender, EventArgs e)
        {
            ShowMyForm<CategoryListForm>();
        }

        private void productListMenu_Click(object sender, EventArgs e)
        {
            ShowMyForm<ProductsListForm>();
        }

        private void customerListMenu_Click(object sender, EventArgs e)
        {
            ShowMyForm<CustomerListForm>();
        }

        private void InoviceListMenu_Click(object sender, EventArgs e)
        {
            ShowMyForm<InvoiceListForm>();
        }

        private void InvoiceDetailsMenu_Click(object sender, EventArgs e)
        {
            var form = ShowMyForm<InvoiceDetailsForm>() as InvoiceDetailsForm;
            var f = MdiChildren.SingleOrDefault(f => f.Name == "InvoiceListForm");
            if (f is null) return;
            var ilf = f as InvoiceListForm;
            var selectedInvoice = ilf.dgvInvoices.SelectedRows[0].DataBoundItem as Invoice;
            form.DislpayInvoiceDetails(selectedInvoice);
        }

        private void InvoiceAddMenu_Click(object sender, EventArgs e)
        {
            ShowMyForm<InvoiceAddForm>();
        }

        private Form ShowMyForm<T>()
        {
            var formToShow = Program.ServiceProvider.GetRequiredService<T>() as Form;
            formToShow.MdiParent = this;
            formToShow.WindowState = FormWindowState.Maximized;
            formToShow.Show();
            return formToShow;
        }
    }
}

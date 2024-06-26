﻿namespace EGDK.Invoicing.WinCS.Invoices
{
    partial class InvoiceDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label16 = new Label();
            label4 = new Label();
            label15 = new Label();
            label3 = new Label();
            label14 = new Label();
            label2 = new Label();
            lblGrandTotal = new Label();
            lblTax = new Label();
            lblPaymentMode = new Label();
            lblDiscount = new Label();
            lblCustomer = new Label();
            lblSubTotal = new Label();
            lblInvoiceDate = new Label();
            label9 = new Label();
            lblInvoiceNumber = new Label();
            label1 = new Label();
            dgvLineItems = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLineItems).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label16);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label15);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label14);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(lblGrandTotal);
            splitContainer1.Panel1.Controls.Add(lblTax);
            splitContainer1.Panel1.Controls.Add(lblPaymentMode);
            splitContainer1.Panel1.Controls.Add(lblDiscount);
            splitContainer1.Panel1.Controls.Add(lblCustomer);
            splitContainer1.Panel1.Controls.Add(lblSubTotal);
            splitContainer1.Panel1.Controls.Add(lblInvoiceDate);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(lblInvoiceNumber);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvLineItems);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 181;
            splitContainer1.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(507, 129);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 1;
            label16.Text = "Grand Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 129);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 1;
            label4.Text = "Payament Mode";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(507, 95);
            label15.Name = "label15";
            label15.Size = new Size(24, 15);
            label15.TabIndex = 1;
            label15.Text = "Tax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 95);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Customer";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(507, 64);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 1;
            label14.Text = "Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 64);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Invoice Date";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Location = new Point(605, 129);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(31, 15);
            lblGrandTotal.TabIndex = 1;
            lblGrandTotal.Text = "9999";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(605, 95);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(31, 15);
            lblTax.TabIndex = 1;
            lblTax.Text = "9999";
            // 
            // lblPaymentMode
            // 
            lblPaymentMode.AutoSize = true;
            lblPaymentMode.Location = new Point(128, 129);
            lblPaymentMode.Name = "lblPaymentMode";
            lblPaymentMode.Size = new Size(31, 15);
            lblPaymentMode.TabIndex = 1;
            lblPaymentMode.Text = "9999";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(605, 64);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(31, 15);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "9999";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(128, 95);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(31, 15);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "9999";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(605, 38);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(31, 15);
            lblSubTotal.TabIndex = 1;
            lblSubTotal.Text = "9999";
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Location = new Point(128, 64);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(31, 15);
            lblInvoiceDate.TabIndex = 1;
            lblInvoiceDate.Text = "9999";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(507, 38);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 1;
            label9.Text = "Sub-Total";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(128, 38);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(31, 15);
            lblInvoiceNumber.TabIndex = 1;
            lblInvoiceNumber.Text = "9999";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Invoice Number";
            // 
            // dgvLineItems
            // 
            dgvLineItems.AllowUserToAddRows = false;
            dgvLineItems.AllowUserToDeleteRows = false;
            dgvLineItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLineItems.Dock = DockStyle.Fill;
            dgvLineItems.Location = new Point(0, 0);
            dgvLineItems.Name = "dgvLineItems";
            dgvLineItems.ReadOnly = true;
            dgvLineItems.RowTemplate.Height = 25;
            dgvLineItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLineItems.Size = new Size(800, 265);
            dgvLineItems.TabIndex = 0;
            // 
            // InvoiceDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "InvoiceDetailsForm";
            Text = "InvoiceDetailsForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLineItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvLineItems;
        private Label label16;
        private Label label4;
        private Label label15;
        private Label label3;
        private Label label14;
        private Label label2;
        private Label lblGrandTotal;
        private Label lblTax;
        private Label lblPaymentMode;
        private Label lblDiscount;
        private Label lblCustomer;
        private Label lblSubTotal;
        private Label lblInvoiceDate;
        private Label label9;
        private Label lblInvoiceNumber;
        private Label label1;
    }
}
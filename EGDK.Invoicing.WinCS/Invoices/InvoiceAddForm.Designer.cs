namespace EGDK.Invoicing.WinCS.Invoices
{
    partial class InvoiceAddForm
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
            btnAddLineItem = new Button();
            btnSaveInvoice = new Button();
            chkIsPercentage = new CheckBox();
            cmbPaymentMode = new ComboBox();
            cmbCustomer = new ComboBox();
            dtInvoiceDate = new DateTimePicker();
            txtInvoiceNumber = new TextBox();
            txtDiscountAmount = new TextBox();
            label16 = new Label();
            label4 = new Label();
            label15 = new Label();
            label3 = new Label();
            label14 = new Label();
            label2 = new Label();
            lblGrandTotal = new Label();
            lblTax = new Label();
            lblSubTotal = new Label();
            label9 = new Label();
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
            splitContainer1.Panel1.Controls.Add(btnAddLineItem);
            splitContainer1.Panel1.Controls.Add(btnSaveInvoice);
            splitContainer1.Panel1.Controls.Add(chkIsPercentage);
            splitContainer1.Panel1.Controls.Add(cmbPaymentMode);
            splitContainer1.Panel1.Controls.Add(cmbCustomer);
            splitContainer1.Panel1.Controls.Add(dtInvoiceDate);
            splitContainer1.Panel1.Controls.Add(txtInvoiceNumber);
            splitContainer1.Panel1.Controls.Add(txtDiscountAmount);
            splitContainer1.Panel1.Controls.Add(label16);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label15);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label14);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(lblGrandTotal);
            splitContainer1.Panel1.Controls.Add(lblTax);
            splitContainer1.Panel1.Controls.Add(lblSubTotal);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvLineItems);
            splitContainer1.Size = new Size(976, 556);
            splitContainer1.SplitterDistance = 223;
            splitContainer1.TabIndex = 1;
            // 
            // btnAddLineItem
            // 
            btnAddLineItem.Location = new Point(872, 196);
            btnAddLineItem.Name = "btnAddLineItem";
            btnAddLineItem.Size = new Size(92, 24);
            btnAddLineItem.TabIndex = 6;
            btnAddLineItem.Text = "Add Line Item";
            btnAddLineItem.UseVisualStyleBackColor = true;
            btnAddLineItem.Click += btnAddLineItem_Click;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Location = new Point(30, 173);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(92, 34);
            btnSaveInvoice.TabIndex = 6;
            btnSaveInvoice.Text = "Save Invoice";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // chkIsPercentage
            // 
            chkIsPercentage.AutoSize = true;
            chkIsPercentage.Location = new Point(487, 63);
            chkIsPercentage.Name = "chkIsPercentage";
            chkIsPercentage.Size = new Size(107, 19);
            chkIsPercentage.TabIndex = 5;
            chkIsPercentage.Text = "Is Perecentage?";
            chkIsPercentage.UseVisualStyleBackColor = true;
            chkIsPercentage.CheckedChanged += chkIsPercentage_CheckedChanged;
            // 
            // cmbPaymentMode
            // 
            cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMode.FormattingEnabled = true;
            cmbPaymentMode.Items.AddRange(new object[] { "Cash", "Card" });
            cmbPaymentMode.Location = new Point(128, 126);
            cmbPaymentMode.Name = "cmbPaymentMode";
            cmbPaymentMode.Size = new Size(132, 23);
            cmbPaymentMode.TabIndex = 4;
            cmbPaymentMode.SelectedIndexChanged += cmbPaymentMode_SelectedIndexChanged;
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(128, 95);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(132, 23);
            cmbCustomer.TabIndex = 4;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // dtInvoiceDate
            // 
            dtInvoiceDate.Location = new Point(128, 61);
            dtInvoiceDate.Name = "dtInvoiceDate";
            dtInvoiceDate.Size = new Size(132, 23);
            dtInvoiceDate.TabIndex = 3;
            dtInvoiceDate.ValueChanged += dtInvoiceDate_ValueChanged;
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.Location = new Point(128, 30);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.Size = new Size(132, 23);
            txtInvoiceNumber.TabIndex = 2;
            txtInvoiceNumber.TextChanged += txtInvoiceNumber_TextChanged;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(605, 61);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.Size = new Size(100, 23);
            txtDiscountAmount.TabIndex = 2;
            txtDiscountAmount.TextChanged += txtDiscountAmount_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(430, 129);
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
            label15.Location = new Point(430, 95);
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
            label14.Location = new Point(430, 64);
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
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(605, 38);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(31, 15);
            lblSubTotal.TabIndex = 1;
            lblSubTotal.Text = "9999";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(430, 38);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 1;
            label9.Text = "Sub-Total";
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
            dgvLineItems.Size = new Size(976, 329);
            dgvLineItems.TabIndex = 0;
            // 
            // InvoiceAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 556);
            Controls.Add(splitContainer1);
            Name = "InvoiceAddForm";
            Text = "InvoiceAddForm";
            Load += InvoiceAddForm_Load;
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
        private Label label16;
        private Label label4;
        private Label label15;
        private Label label3;
        private Label label14;
        private Label label2;
        private Label lblGrandTotal;
        private Label lblTax;
        private Label lblSubTotal;
        private Label label9;
        private Label label1;
        private DataGridView dgvLineItems;
        private TextBox txtInvoiceNumber;
        private TextBox txtDiscountAmount;
        private ComboBox cmbPaymentMode;
        private ComboBox cmbCustomer;
        private DateTimePicker dtInvoiceDate;
        private Button btnSaveInvoice;
        private CheckBox chkIsPercentage;
        private Button btnAddLineItem;
    }
}
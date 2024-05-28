namespace EGDK.Invoicing.WinCS.Invoices
{
    partial class InvoiceLineItemAddForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtQuantity = new TextBox();
            txtAmount = new TextBox();
            cmbProduct = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 56);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 85);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 0;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 115);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Amount";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(96, 83);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 1;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(96, 112);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 1;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(96, 55);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(185, 23);
            cmbProduct.TabIndex = 2;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(41, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(206, 174);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 43);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save Line Item";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // InvoiceLineItemAddForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(484, 298);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(cmbProduct);
            Controls.Add(txtAmount);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InvoiceLineItemAddForm";
            Text = "InvoiceLineItemAddForm";
            Load += InvoiceLineItemAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtQuantity;
        private TextBox txtAmount;
        private ComboBox cmbProduct;
        private Button btnCancel;
        private Button btnSave;
    }
}
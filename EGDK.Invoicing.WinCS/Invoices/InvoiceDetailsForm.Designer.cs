namespace EGDK.Invoicing.WinCS.Invoices
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
            dgvLineItems = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
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
            splitContainer1.Panel1.Controls.Add(label13);
            splitContainer1.Panel1.Controls.Add(label12);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvLineItems);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 181;
            splitContainer1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Invoice Number";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 95);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Customer";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 38);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 1;
            label5.Text = "9999";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 64);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 1;
            label6.Text = "9999";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(128, 95);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 1;
            label7.Text = "9999";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(128, 129);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 1;
            label8.Text = "9999";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(605, 38);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 1;
            label10.Text = "9999";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(605, 64);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 1;
            label11.Text = "9999";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(605, 95);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 1;
            label12.Text = "9999";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(605, 129);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 1;
            label13.Text = "9999";
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(507, 95);
            label15.Name = "label15";
            label15.Size = new Size(24, 15);
            label15.TabIndex = 1;
            label15.Text = "Tax";
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
        private Label label13;
        private Label label12;
        private Label label8;
        private Label label11;
        private Label label7;
        private Label label10;
        private Label label6;
        private Label label9;
        private Label label5;
        private Label label1;
    }
}
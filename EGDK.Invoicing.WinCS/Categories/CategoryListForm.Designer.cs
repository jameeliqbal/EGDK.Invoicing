namespace EGDK.Invoicing.WinCS.Categories
{
    partial class CategoryListForm
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
            dgvCategoryies = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryies).BeginInit();
            SuspendLayout();
            // 
            // dgvCategoryies
            // 
            dgvCategoryies.AllowUserToAddRows = false;
            dgvCategoryies.AllowUserToDeleteRows = false;
            dgvCategoryies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoryies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoryies.Dock = DockStyle.Fill;
            dgvCategoryies.Location = new Point(0, 0);
            dgvCategoryies.Name = "dgvCategoryies";
            dgvCategoryies.ReadOnly = true;
            dgvCategoryies.RowTemplate.Height = 25;
            dgvCategoryies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoryies.Size = new Size(800, 450);
            dgvCategoryies.TabIndex = 0;
            // 
            // CategoryListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategoryies);
            Name = "CategoryListForm";
            Text = "CategoryListForm";
            Load += CategoryListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoryies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategoryies;
    }
}
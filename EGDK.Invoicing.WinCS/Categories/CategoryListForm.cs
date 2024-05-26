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

namespace EGDK.Invoicing.WinCS.Categories
{
    public partial class CategoryListForm : Form
    {
        private readonly ICategoryService categoryService;
        public CategoryListForm(ICategoryService categoryService)
        {
            InitializeComponent();
            this.categoryService = categoryService;

        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            var categories = categoryService.GetAllWithProducts();
            dgvCategoryies.DataSource = categories;
        }
    }
}

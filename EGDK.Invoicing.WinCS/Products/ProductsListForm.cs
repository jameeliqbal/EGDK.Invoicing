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

namespace EGDK.Invoicing.WinCS.Products
{
    public partial class ProductsListForm : Form
    {
        private readonly IProductService productService;

        public ProductsListForm(IProductService productService)
        {
            InitializeComponent();
            this.productService = productService;
        }

        private void ProductsListForm_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource=productService.GetAllProducts();
        }
    }
}

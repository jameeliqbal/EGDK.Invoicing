using EGDK.Invoicing.Core.Services;
using EGDK.Invoicing.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGDK.Invoicing.WinCS
{
    public partial class Form2 : Form
    {
        private readonly ICategoryService categoryService;
        public Form2(ICategoryService categoryService)
        {
            InitializeComponent();
            this.categoryService = categoryService;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var c = categoryService.GetAllWithProducts();
            Debug.WriteLine("Number of categories: " + c.Count());
        }
    }
}

using EGDK.Invoicing.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace EGDK.Invoicing.WinCS
{
    public partial class Form1 : Form
    {
        private readonly ICategoryService categoryService;
        public Form1(ICategoryService categoryService)
        {
            InitializeComponent();
            this.categoryService = categoryService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            var c = categoryService.GetAllWithProducts();
            Debug.WriteLine("Number of categories: " + c.Count());

           
        }
    }
}

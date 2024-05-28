using EGDK.Invoicing.Core;
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

namespace EGDK.Invoicing.WinCS.Customers
{
    public partial class CustomerListForm : Form
    {
        private readonly ICustomerService customerService;

        public CustomerListForm(ICustomerService customerService)
        {
            InitializeComponent();
            this.customerService = customerService;
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = customerService.GetAllCustomers();
        }
    }
}

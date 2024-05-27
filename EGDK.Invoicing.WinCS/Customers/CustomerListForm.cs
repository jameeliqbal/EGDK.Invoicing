using EGDK.Invoicing.Core;
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
        private readonly IUnitOfWork _unitOfWork;

        public CustomerListForm(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = _unitOfWork.Customers.GetAll();
        }
    }
}

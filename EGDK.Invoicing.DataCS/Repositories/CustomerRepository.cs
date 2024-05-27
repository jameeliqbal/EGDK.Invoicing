
using EGDK.Invoicing.Core.Models;
using EGDK.Invoicing.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGDK.Invoicing.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private EGInvoicingDBContext EGInvoicingDBContext
        {
            get { return Context as EGInvoicingDBContext; }
        }

        public CustomerRepository(EGInvoicingDBContext context)
            : base(context)
        { }

        public IEnumerable<Customer> GetInvoiceForCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}

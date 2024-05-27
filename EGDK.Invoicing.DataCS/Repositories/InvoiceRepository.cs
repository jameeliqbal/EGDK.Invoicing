using EGDK.Invoicing.Core.Models;
using EGDK.Invoicing.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGDK.Invoicing.Data.Repositories
{
    public class InvoiceRepository :Repository<Invoice>,IInvoiceRepository
    {
        private EGInvoicingDBContext EGInvoicingDBContext
        {
            get { return Context as EGInvoicingDBContext; }
        }

        public InvoiceRepository(EGInvoicingDBContext context)
            : base(context)
        { }

        public IEnumerable<LineItem> GetLineItems(int id)
        {
            var lineitems = EGInvoicingDBContext.Invoices.Include(x => x.LineItems).SingleOrDefault(i => i.Id == id).LineItems;
            return lineitems;
            //throw new NotImplementedException();
        }
    }
}

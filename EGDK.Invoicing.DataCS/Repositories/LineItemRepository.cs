using EGDK.Invoicing.Core.Models;
using EGDK.Invoicing.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGDK.Invoicing.Data.Repositories
{
    public class LineItemRepository: Repository<LineItem>,ILineItemRepository
    {
        private EGInvoicingDBContext EGInvoicingDBContext
        {
            get { return Context as EGInvoicingDBContext; }
        }

        public LineItemRepository(EGInvoicingDBContext context)
            : base(context)
        { }

        public double GetLineItemTotal(int id)
        {
          return  EGInvoicingDBContext.LineItems.Sum<LineItem>(li => li.Amount);
        }

        public IEnumerable<LineItem> GetLineItems(int id)
        {
            return EGInvoicingDBContext.LineItems.Where(li => li.InvoiceId == id).ToList();
        }
    }
}

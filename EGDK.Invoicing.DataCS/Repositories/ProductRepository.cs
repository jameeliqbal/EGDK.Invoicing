using EGDK.Invoicing.Core.Models;
using EGDK.Invoicing.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGDK.Invoicing.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private EGInvoicingDBContext EGInvoicingDBContext
        {
            get { return Context as EGInvoicingDBContext; }
        }

        public ProductRepository(EGInvoicingDBContext context)
            :base(context)
        { }

        

        public IEnumerable<Product> GetProductsByCategory(int categoryID)
        {
            var products = EGInvoicingDBContext.Products.Where(p => p.CategoryId == categoryID).ToList();
            return products;
        }
    }
}

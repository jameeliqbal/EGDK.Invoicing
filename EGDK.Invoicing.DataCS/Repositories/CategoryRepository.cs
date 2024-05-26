
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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private EGInvoicingDBContext EGInvoicingDBContext
        {
            get { return Context as EGInvoicingDBContext; }
        }

        public CategoryRepository(EGInvoicingDBContext context)
            : base(context)
        { }

        public IEnumerable<Category> GetCategoryWithProducts()
        {
            throw new NotImplementedException();
            return null;
            //return EGInvoicingDBContext.Categories
            //    .Include(c => c.Products)
            //    .ToList();
        }
    }
}

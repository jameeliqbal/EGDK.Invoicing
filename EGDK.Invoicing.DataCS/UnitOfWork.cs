using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EGDK.Invoicing.Core;
using EGDK.Invoicing.Core.Models;
using EGDK.Invoicing.Core.Repositories;

using EGDK.Invoicing.Data.Repositories;

namespace EGDK.Invoicing.Data
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly EGInvoicingDBContext _context;
        private CategoryRepository _categoryRepository;
        private ProductRepository _productRepository;

        public UnitOfWork(EGInvoicingDBContext context)
        {
            this._context = context;
        }

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
        public IProductRepository Products => _productRepository = _productRepository ?? new  ProductRepository(_context);

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

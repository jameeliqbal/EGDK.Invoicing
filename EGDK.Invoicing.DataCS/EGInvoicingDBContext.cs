using EGDK.Invoicing.Core.Models;
using EGDK.Invoicing.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGDK.Invoicing.Data
{
    public class EGInvoicingDBContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public EGInvoicingDBContext(DbContextOptions<EGInvoicingDBContext>  options)
            :base(options)
        {
            
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}

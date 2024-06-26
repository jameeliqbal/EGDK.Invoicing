﻿
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
        public DbSet<Product> Products { get; set; } 
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<LineItem> LineItems { get; set; }

        public EGInvoicingDBContext(DbContextOptions<EGInvoicingDBContext>  options)
            :base(options)
        {
            
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
        }
    }
}

using EGDK.Invoicing.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGDK.Invoicing.Data.Configurations
{
    public class LineItemsConfiguration : IEntityTypeConfiguration<LineItem>
    {
        public void Configure(EntityTypeBuilder<LineItem> builder)
        {
            builder
               .HasKey(li => li.Id);

            builder
                .Property(li => li.Id)
                .UseIdentityColumn();
            

            builder
                .ToTable("LineItems");

            builder
                .HasOne(li => li.Invoice)
                .WithMany(i => i.LineItems)
                .HasForeignKey(i => i.InvoiceId);

            

        }
    }
}

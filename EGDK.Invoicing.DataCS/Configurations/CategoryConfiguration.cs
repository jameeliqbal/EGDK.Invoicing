﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EGDK.Invoicing.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EGDK.Invoicing.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .UseIdentityColumn();

            builder
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            //builder
            //    .HasOne(m => m.Product)
            //    .WithMany(a => a.Categories)
            //    .HasForeignKey(m => m.ArtistId);

            builder
                .ToTable("Categories");
        }
    }
}
using CW_Week13.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CW_Week13.Configuration
{
    internal class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
                builder
                .HasKey(e => e.SupplierId);
            builder.Property(e => e.CompanyName)
                      .IsRequired()
                      .HasMaxLength(40);
            builder.Property(e => e.ContactName)
                      .HasMaxLength(30);

            builder.Property(e => e.Address)
                      .HasMaxLength(60);

        }
    }
}

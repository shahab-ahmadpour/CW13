using CW_Week13.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Week13.Configuration
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.CustomerId);

            builder.Property(e => e.CustomerId)
                  .IsRequired()
                  .HasMaxLength(5);

            builder.Property(e => e.CompanyName)
                  .IsRequired()
                  .HasMaxLength(40);

            builder.Property(e => e.ContactName)
                  .HasMaxLength(30);

            builder.Property(e => e.ContactTitle)
                  .HasMaxLength(30);

            builder.Property(e => e.Address)
                  .HasMaxLength(60);

            builder.HasMany(e => e.Orders)
                  .WithOne(o => o.Customer)
                  .HasForeignKey(o => o.CustomerId)
                  .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}

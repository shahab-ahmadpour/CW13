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
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.OrderId);

            builder.Property(e => e.OrderDate)
                  .HasColumnType("datetime");

            builder.HasOne(o => o.Customer)
                  .WithMany(c => c.Orders)
                  .HasForeignKey(o => o.CustomerId)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(o => o.Employee)
                  .WithMany(e => e.Orders)
                  .HasForeignKey(o => o.EmployeeId)
                  .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(o => o.Shipper)
                  .WithMany(s => s.Orders)
                  .HasForeignKey(o => o.ShipVia)
                  .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}

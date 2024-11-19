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
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeId);

            builder.Property(e => e.LastName)
                  .IsRequired()
                  .HasMaxLength(20);

            builder.Property(e => e.FirstName)
                  .IsRequired()
                  .HasMaxLength(10);

            builder.Property(e => e.Title)
                  .HasMaxLength(30);

            builder.HasOne(e => e.Manager)
                  .WithMany()
                  .HasForeignKey(e => e.ReportsTo)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

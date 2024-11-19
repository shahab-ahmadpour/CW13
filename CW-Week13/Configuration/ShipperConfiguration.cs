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
    internal class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {

            builder.HasKey(e => e.ShipperId);

            builder.Property(e => e.CompanyName)
                      .IsRequired()
                      .HasMaxLength(40);
        }
    }
}

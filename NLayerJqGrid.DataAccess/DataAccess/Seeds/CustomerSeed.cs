using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerJqGrid.DataAccess.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerJqGrid.DataAccess.DataAccess.Seeds
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.City).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.County).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(13).HasColumnType("varchar");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100).HasColumnType("varchar");

            builder.HasData(
                new Customer { Id = 1, FirstName = "Ramazan", LastName = "Küçükkoç", City = "Konya", County = "Karatay", PhoneNumber = "5436251369", Email = "ramazankucukkoc43@gmail.com", Address = "Fetih Mah. Aşık Nigari Sok. NO:2AB" },
                new Customer { Id = 2, FirstName = "Aliş", LastName = "Tufan", City = "Ankara", County = "Sincan", PhoneNumber = "5427123456", Email = "alistfn06@gmail.com", Address = "Sincan Mah. Aşık Nigari Sok. NO:2AB" }
                );
        }
        
    }
}

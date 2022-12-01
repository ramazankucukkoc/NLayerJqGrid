using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerJqGrid.DataAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Seeds
{
	public class CustomerTransactionSeed : IEntityTypeConfiguration<CustomerTransaction>
	{
		public void Configure(EntityTypeBuilder<CustomerTransaction> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.Description).IsRequired().HasMaxLength(30).HasColumnType("varchar");
			builder.Property(x => x.UnitPrice).IsRequired().HasColumnType("decimal(18,2)");
			builder.HasOne(x => x.Product).WithMany(y => y.CustomerTransactions).HasForeignKey(x => x.ProductId);
			builder.HasOne(x => x.Personel).WithMany(y => y.CustomerTransactions).HasForeignKey(x => x.PersonelId);
			builder.HasOne(x => x.Customer).WithMany(y => y.CustomerTransactions).HasForeignKey(x => x.CustomerId);

			builder.HasData(
				new CustomerTransaction { Id = 1, CustomerId = 1, PersonelId = 1, ProductId = 1, Description = "Ürün Satısı Yapıldı.", Unit = 4, UnitPrice = 20, TotalPrice = 100, Note = "Ürün Satışı Gerçekleştirdik." },
				new CustomerTransaction { Id = 2, CustomerId = 2, PersonelId = 2, ProductId = 1, Description = "Ürün Satısı Yapıldı.", Unit = 10, UnitPrice = 50, TotalPrice = 500, Note = "Ürün Satışı Gerçekleştirdik." });
		}
	}
}

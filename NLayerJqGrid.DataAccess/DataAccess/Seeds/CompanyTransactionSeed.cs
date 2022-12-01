using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerJqGrid.DataAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Seeds
{
	public class CompanyTransactionSeed : IEntityTypeConfiguration<CompanyTransaction>
	{
		public void Configure(EntityTypeBuilder<CompanyTransaction> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.Description).IsRequired().HasMaxLength(50).HasColumnType("varchar");
			builder.Property(x => x.UnitPrice).IsRequired().HasColumnType("decimal(18,2)");
			builder.HasOne(x => x.Product).WithMany(y => y.CompanyTransactions).HasForeignKey(x => x.ProductId);
			builder.HasOne(x => x.Personel).WithMany(y => y.CompanyTransactions).HasForeignKey(x => x.PersonelId);
			builder.HasOne(x => x.Company).WithMany(x => x.CompanyTransactions).HasForeignKey(x => x.CompanyId);

			builder.HasData(
				new CompanyTransaction { Id = 1, CompanyId = 1, PersonelId = 1, ProductId = 2, Description = "Şirket Satı İşlemleri", Unit = 5, UnitPrice = 100, TotalPrice = 500, Note = "Şirket için önemli satışdı." },
				new CompanyTransaction { Id = 2, CompanyId = 1, PersonelId = 1, ProductId = 5, Description = "Şirket Satı İşlemleri Devam Ediyor", Unit = 5, UnitPrice = 100, TotalPrice = 1500, Note = "Şirket için önemli kar yüzdesi güzel satışdı." });

		}
	}
}

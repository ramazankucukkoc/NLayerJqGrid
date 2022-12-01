using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerJqGrid.DataAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Seeds
{
	public class DepartmanSeed : IEntityTypeConfiguration<Departman>
	{
		public void Configure(EntityTypeBuilder<Departman> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.DepartmanName).IsRequired().HasMaxLength(30).HasColumnType("varchar");

			builder.HasData(
				new Departman { Id = 1, DepartmanName = "Müdür", Note = "Müdür Satış Elamanıdır." },
				new Departman { Id = 2, DepartmanName = "Satış Temsilcisi", Note = "Satış Temsilcisi İşlemleri Tamamladı." });
		}
	}
}

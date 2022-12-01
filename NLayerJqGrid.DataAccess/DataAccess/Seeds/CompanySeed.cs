using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerJqGrid.DataAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Seeds
{
	public class CompanySeed : IEntityTypeConfiguration<Company>
	{
		public void Configure(EntityTypeBuilder<Company> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(20).HasColumnType("varchar");
			builder.Property(x => x.DepartmanName).IsRequired().HasMaxLength(20).HasColumnType("varchar");
			builder.Property(x => x.Manager).IsRequired().HasMaxLength(20).HasColumnType("varchar");
			builder.Property(x => x.CompanyPhone).IsRequired().HasMaxLength(13).HasColumnType("varchar");
			builder.Property(x => x.City).IsRequired().HasMaxLength(20).HasColumnType("varchar");
			builder.Property(x => x.County).IsRequired().HasMaxLength(20).HasColumnType("varchar");

			builder.HasData(
				new Company { Id = 1, CompanyName = "Koç", City = "Istanbul", CompanyPhone = "+905436251369", County = "Kartal", Manager = "Ramazan K.KOÇ", DepartmanName = "CEO", ManagerPhone = "+905436251369", Note = "Ramazan K.KOÇ Şirketin CEO'sudur." },
				new Company { Id = 2, CompanyName = "Saran", City = "Ankara", CompanyPhone = "+905436251368", County = "Cumhur", Manager = "Mehmet K.KOÇ", DepartmanName = "CEO", ManagerPhone = "+905436251369", Note = "Mehmet K.KOÇ Şirketin CEO'sudur." });

		}
	}
}

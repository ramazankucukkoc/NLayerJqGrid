using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerJqGrid.DataAccess.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Seeds
{
	public class PersonelSeed : IEntityTypeConfiguration<Personel>
	{
		public void Configure(EntityTypeBuilder<Personel> builder)
		{

			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.PersonelName).IsRequired().HasMaxLength(30).HasColumnType("varchar");
			builder.Property(x => x.LastName).IsRequired().HasMaxLength(30).HasColumnType("varchar");
			builder.HasOne(x => x.Departman).WithMany(x => x.Personels).HasForeignKey(x => x.DepartmanId);

			builder.HasData(
				new Personel { Id = 1, PersonelName = "Ahmet", LastName = "Ak", DepartmanId = 1, },
				new Personel { Id = 2, PersonelName = "Mehmet", LastName = "Kara", DepartmanId = 2, });


		}
	}
}

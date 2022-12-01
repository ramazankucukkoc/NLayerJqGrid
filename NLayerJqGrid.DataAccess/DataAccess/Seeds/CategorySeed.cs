using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerJqGrid.DatatAccess.Entities.Concrete;

namespace NLayerJqGrid.DatatAccess.Seeds
{
	public class CategorySeed : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(30).HasColumnType("varchar");
			//builder.HasMany(x => x.Products).WithOne(x => x.Category);
			builder.ToTable("Categories", "NLayer");


			builder.HasData(
			  new Category { Id = 1, CategoryName = "Cheese", Description = "Kategori Bir" },
 new Category { Id = 2, CategoryName = "Meat", Description = "Kategori İki" },
 new Category { Id = 3, CategoryName = "Fish", Description = "Kategori Üç" },
 new Category { Id = 4, CategoryName = "Bread", Description = "Kategori Dört" }
				);
		}
	}
}

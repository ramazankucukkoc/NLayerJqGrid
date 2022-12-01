using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerJqGrid.DatatAccess.Entities.Concrete;

namespace NLayerJqGrid.DatatAccess.Seeds
{
	public class ProductSeed : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.ProdcutName).IsRequired().HasMaxLength(30).HasColumnType("varchar");
			builder.Property(x => x.Stock).IsRequired();
			builder.Property(x => x.Brand).IsRequired().HasMaxLength(30).HasColumnType("varchar");

			builder.Property(x => x.UnitPrice).IsRequired().HasColumnType("decimal(18,2)");
			builder.Property(x => x.SalesPrice).IsRequired().HasColumnType("decimal(18,2)");
			// builder.Property(x => x.UrunGorsel).IsRequired();

			builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
			builder.ToTable("Products", "NLayer");


			builder.HasData(
			new Product { Id = 1, CategoryId = 1, ProdcutName = "Cheddar", Stock = 22, UnitPrice = 22, SalesPrice = 25, Brand = "Bosch", Description = "Ürün Güzel" },
new Product { Id = 2, CategoryId = 1, ProdcutName = "Brie", Stock = 12, UnitPrice = 20, SalesPrice = 25, Brand = "Arçelik", Description = "Ürün Şahane" },
new Product { Id = 3, CategoryId = 1, ProdcutName = "Stilton", Stock = 13, UnitPrice = 12, SalesPrice = 25, Brand = "Arçelik", Description = "Ürün Güzel" },
new Product { Id = 4, CategoryId = 2, ProdcutName = "Cheshire", Stock = 21, UnitPrice = 32, SalesPrice = 35, Brand = "Arçelik", Description = "Ürün Güzel" },
new Product { Id = 5, CategoryId = 2, ProdcutName = "Swiss", Stock = 31, UnitPrice = 100, SalesPrice = 120, Brand = "Ugur", Description = "Ürün Güzel" },
new Product { Id = 6, CategoryId = 2, ProdcutName = "Gruyere", Stock = 10, UnitPrice = 45, SalesPrice = 65, Brand = "Ugur", Description = "Ürün Güzel" },
new Product { Id = 7, CategoryId = 3, ProdcutName = "Colby", Stock = 100, UnitPrice = 24, SalesPrice = 25, Brand = "Ugur", Description = "Ürün Güzel" },
new Product { Id = 8, CategoryId = 3, ProdcutName = "Mozzela", Stock = 34, UnitPrice = 35, SalesPrice = 43, Brand = "Bosch", Description = "Ürün Güzel" },
new Product { Id = 9, CategoryId = 3, ProdcutName = "Ricotta", Stock = 200, UnitPrice = 20, SalesPrice = 25, Brand = "Bosch", Description = "Ürün Güzel" },
new Product { Id = 10, CategoryId = 4, ProdcutName = "Parmesan", Stock = 321, UnitPrice = 20, SalesPrice = 25, Brand = "Profilo", Description = "Ürün Güzel" },
new Product { Id = 11, CategoryId = 4, ProdcutName = "Ham", Stock = 34, UnitPrice = 20, SalesPrice = 25, Brand = "Profilo", Description = "Ürün Güzel" },
new Product { Id = 12, CategoryId = 4, ProdcutName = "Beef", Stock = 56, UnitPrice = 46, SalesPrice = 55, Brand = "Profilo", Description = "Ürün Güzel" },
new Product { Id = 13, CategoryId = 4, ProdcutName = "Chicken", Stock = 60, UnitPrice = 90, SalesPrice = 95, Brand = "Bosch", Description = "Ürün Güzel" },
new Product { Id = 14, CategoryId = 4, ProdcutName = "Turkey", Stock = 37, UnitPrice = 200, SalesPrice = 250, Brand = "Bosch", Description = "Ürün Güzel" },
new Product { Id = 15, CategoryId = 4, ProdcutName = "Prosciutto", Stock = 400, UnitPrice = 321, SalesPrice = 325, Brand = "Bosch", Description = "Ürün Güzel" });
		}
	}
}

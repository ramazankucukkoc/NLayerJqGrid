using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.DataAccess.Entities.Concrete;
using NLayerJqGrid.DatatAccess.Entities.Concrete;
using System.Reflection;

namespace NLayerJqGrid.DataAccess.Concrete.EntityFramework.Context
{
	public class AppDbContextBase : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
	{
		public AppDbContextBase()
		{

		}
		public AppDbContextBase(DbContextOptions<AppDbContextBase> options) : base(options)
		{

		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=NLayerBackend2;Trusted_Connection=true");

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
		public DbSet<User> AspNetUsers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<CompanyTransaction> CompanyTransactions { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<Personel> Personels { get; set; }
		public DbSet<CustomerTransaction> CustomerTransactions { get; set; }
		public DbSet<Departman> Departmens { get; set; }

	}
}

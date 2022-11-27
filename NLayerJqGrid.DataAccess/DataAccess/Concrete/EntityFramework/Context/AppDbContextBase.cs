using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NLayerJqGrid.Core.Entities.Concrete;
using NLayerJqGrid.DataAccess.Entities.Concrete;
using NLayerJqGrid.DatatAccess.Entities.Concrete;
using System.Reflection;

namespace NLayerJqGrid.DataAccess.Concrete.EntityFramework.Context
{
    public class AppDbContextBase : IdentityDbContext<User,OperationClaim,int,UserClaim,UserRole,UserLogin,RoleClaim,UserToken>
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

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
       
        public DbSet<Category> Categories { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<OperationClaim> OperationClaims { get; set; }

    }
}

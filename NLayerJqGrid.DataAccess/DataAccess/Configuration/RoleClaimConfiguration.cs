using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerJqGrid.Core.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.DataAccess.Configuration
{
	public class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaim>
	{
		public void Configure(EntityTypeBuilder<RoleClaim> builder)
		{
			// Primary key
			builder.HasKey(rc => rc.Id);

			// Maps to the AspNetRoleClaims table
			builder.ToTable("AspNetRoleClaims");
		}


	}
}



using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerJqGrid.Core.Entities.Concrete;

namespace NLayerJqGrid.DataAccess.Configuration
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
   
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.User).WithMany(x => x.OperationClaims).HasForeignKey(x => x.UserId);
            builder.ToTable("OperationClaims", "NLayer");
        }
    }
}

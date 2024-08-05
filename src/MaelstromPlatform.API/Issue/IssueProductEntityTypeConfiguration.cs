using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaelstromPlatform.API.Issue
{
    public class IssueProductEntityTypeConfiguration : IEntityTypeConfiguration<IssueProductEntity>
    {
        public void Configure(EntityTypeBuilder<IssueProductEntity> builder)
        {
            builder
                .HasOne(i => i.Issue)
                .WithMany(ic => ic.Products)
                .HasForeignKey(i => i.IssueSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(c => c.Product)
                .WithMany(ic => ic.Issues)
                .HasForeignKey(c => c.ProductSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
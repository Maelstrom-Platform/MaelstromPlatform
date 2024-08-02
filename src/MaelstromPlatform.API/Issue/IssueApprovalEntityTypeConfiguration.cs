using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaelstromPlatform.API.Issue
{
    public class IssueApprovalEntityTypeConfiguration : IEntityTypeConfiguration<IssueApprovalEntity>
    {
        public void Configure(EntityTypeBuilder<IssueApprovalEntity> builder)
        {
            builder
                .HasOne(a => a.Issue)
                .WithMany(p => p.Approvals)
                .HasForeignKey(i => i.IssueEntitySysId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
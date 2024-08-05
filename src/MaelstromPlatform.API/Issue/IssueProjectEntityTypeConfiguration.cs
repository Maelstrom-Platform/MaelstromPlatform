using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaelstromPlatform.API.Issue
{
    public class IssueProjectEntityTypeConfiguration : IEntityTypeConfiguration<IssueProjectEntity>
    {
        public void Configure(EntityTypeBuilder<IssueProjectEntity> builder)
        {
            builder
                .HasOne(i => i.Issue)
                .WithMany(ic => ic.Projects)
                .HasForeignKey(i => i.IssueSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(c => c.Project)
                .WithMany(ic => ic.Issues)
                .HasForeignKey(c => c.ProjectSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
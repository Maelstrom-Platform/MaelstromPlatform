using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaelstromPlatform.API.Issue
{
    public class IssueTagEntityTypeConfiguration : IEntityTypeConfiguration<IssueTagEntity>
    {
        public void Configure(EntityTypeBuilder<IssueTagEntity> builder)
        {
            builder
                .HasOne(i => i.Issue)
                .WithMany(ic => ic.Tags)
                .HasForeignKey(i => i.IssueSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(c => c.Tag)
                .WithMany(ic => ic.Issues)
                .HasForeignKey(c => c.TagSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
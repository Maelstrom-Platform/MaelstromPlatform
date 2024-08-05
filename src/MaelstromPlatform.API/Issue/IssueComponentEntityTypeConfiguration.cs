using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MaelstromPlatform.API.Component;

namespace MaelstromPlatform.API.Issue
{
    public class IssueComponentEntityTypeConfiguration : IEntityTypeConfiguration<IssueComponentEntity>
    {
        public void Configure(EntityTypeBuilder<IssueComponentEntity> builder)
        {
            builder
                .HasOne(i => i.Issue)
                .WithMany(ic => ic.Components)
                .HasForeignKey(i => i.IssueSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(c => c.Component)
                .WithMany(ic => ic.Issues)
                .HasForeignKey(c => c.ComponentSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
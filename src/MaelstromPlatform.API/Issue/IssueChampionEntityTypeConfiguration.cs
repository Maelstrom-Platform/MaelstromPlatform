using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Customer
{
    public class IssueChampionEntityTypeConfiguration : IEntityTypeConfiguration<IssueChampionEntity>
    {
        public void Configure(EntityTypeBuilder<IssueChampionEntity> builder)
        {
            builder
                .HasOne(i => i.Issue)
                .WithMany(ic => ic.Champions)
                .HasForeignKey(i => i.IssueSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(c => c.Champion)
                .WithMany(ic => ic.IssueChampions)
                .HasForeignKey(c => c.PersonSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Document
{
    public class IssueDocumentEntityTypeConfiguration : IEntityTypeConfiguration<IssueDocumentEntity>
    {
        public void Configure(EntityTypeBuilder<IssueDocumentEntity> builder)
        {
            builder
                .HasOne(i => i.Issue)
                .WithMany(ic => ic.Documents)
                .HasForeignKey(i => i.IssueSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(c => c.Document)
                .WithMany(ic => ic.Issues)
                .HasForeignKey(c => c.DocumentSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
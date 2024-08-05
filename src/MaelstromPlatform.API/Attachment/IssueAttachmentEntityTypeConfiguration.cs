using MaelstromPlatform.API.Attachment;
using MaelstromPlatform.API.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaelstromPlatform.API.Customer
{
    public class IssueAttachmentEntityTypeConfiguration : IEntityTypeConfiguration<IssueAttachmentEntity>
    {
        public void Configure(EntityTypeBuilder<IssueAttachmentEntity> builder)
        {
            builder
                .HasOne(i => i.Issue)
                .WithMany(ic => ic.Attachments)
                .HasForeignKey(i => i.IssueSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(c => c.Attachment)
                .WithMany(ic => ic.Issues)
                .HasForeignKey(c => c.AttachmentSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
using MaelstromPlatform.API.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaelstromPlatform.API.Customer
{
    public class IssueCustomerEntityTypeConfiguration : IEntityTypeConfiguration<IssueCustomerEntity>
    {
        public void Configure(EntityTypeBuilder<IssueCustomerEntity> builder)
        {
            builder
                .HasOne(i => i.Issue)
                .WithMany(ic => ic.IssueCustomers)
                .HasForeignKey(i => i.IssueSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(c => c.Customer)
                .WithMany(ic => ic.IssueCustomers)
                .HasForeignKey(c => c.CustomerSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
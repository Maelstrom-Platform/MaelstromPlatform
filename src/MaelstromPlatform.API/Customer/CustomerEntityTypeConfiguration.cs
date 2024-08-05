using MaelstromPlatform.API.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaelstromPlatform.API.Customer
{
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder
                .HasMany(ic => ic.IssueCustomers)
                .WithOne(c => c.Customer)
                .HasForeignKey(c => c.CustomerSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Customer
{
    public class IssueCustomerEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }
        public Guid IssueSysId { get; set; }
        public IssueEntity Issue { get; set; }
        public Guid CustomerSysId { get; set; }
        public CustomerEntity Customer { get; set; }
    }
}

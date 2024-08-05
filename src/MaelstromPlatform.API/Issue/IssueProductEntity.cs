using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Product;

namespace MaelstromPlatform.API.Issue
{
    public class IssueProductEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public Guid IssueSysId { get; set; }
        public IssueEntity Issue { get; set; }
        public Guid ProductSysId { get; set; }
        public ProductEntity Product { get; set; }
    }
}
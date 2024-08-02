using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaelstromPlatform.API.Issue
{
    public class IssueApprovalEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public Guid IssueEntitySysId { get; set; }
        public IssueEntity Issue { get; set; } = null!;

        public Guid IssueApproverEntitySysId { get; set; }
        public IssueApproverEntity IssueApprover { get; set; } = null!;

        public bool Approved { get; set; }
    }
}
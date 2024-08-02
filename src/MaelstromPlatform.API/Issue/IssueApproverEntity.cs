using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Person;

namespace MaelstromPlatform.API.Issue
{
    public class IssueApproverEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public Guid PersonEntitySysId { get; set; }
        public PersonEntity PersonEntity { get; set; } = null!;
        public bool Optional { get; set; }
    }
}
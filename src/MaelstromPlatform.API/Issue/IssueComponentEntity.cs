using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Component;

namespace MaelstromPlatform.API.Issue
{
    public class IssueComponentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public Guid IssueSysId { get; set; }
        public IssueEntity Issue { get; set; }
        public Guid ComponentSysId { get; set; }
        public ComponentEntity Component { get; set; }
    }
}
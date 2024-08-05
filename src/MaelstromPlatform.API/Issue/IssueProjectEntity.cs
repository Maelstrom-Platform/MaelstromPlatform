using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Project;

namespace MaelstromPlatform.API.Issue
{
    public class IssueProjectEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public Guid IssueSysId { get; set; }
        public IssueEntity Issue { get; set; }
        public Guid ProjectSysId { get; set; }
        public ProjectEntity Project { get; set; }
    }
}
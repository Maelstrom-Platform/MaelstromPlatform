using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Project
{
    public class ProjectEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public string Title { get; set; }
        public ICollection<IssueProjectEntity> Issues { get; set; } = null!;
    }
}

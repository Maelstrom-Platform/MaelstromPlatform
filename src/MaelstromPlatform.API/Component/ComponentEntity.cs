using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Component
{
    public class ComponentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<IssueComponentEntity> Issues { get; set; } = null!;
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MaelstromPlatform.API.Common;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Team
{
    public class TeamEntity(string identifier, string name)
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        [Required][MaxLength(Constants.Identifier)] public string Identifier { get; set; } = identifier;

        [Required] public string Name { get; set; } = name;

        public ICollection<IssueEntity> IssuesFound { get; } = new List<IssueEntity>();
        public ICollection<IssueEntity> IssuesOwned { get; } = new List<IssueEntity>();
        public ICollection<IssueEntity> IssuesReported { get; } = new List<IssueEntity>();
    }
}
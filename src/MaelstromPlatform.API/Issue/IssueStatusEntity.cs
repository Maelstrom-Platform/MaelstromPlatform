using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Common;

namespace MaelstromPlatform.API.Issue
{
    public class IssueStatusEntity(string identifier, string status, string usage)
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        [Required][MaxLength(Constants.Identifier)] public string Identifier { get; set; } = identifier;

        [Required][MaxLength(Constants.List)] public string Status { get; set; } = status;

        [Required][MaxLength(Constants.LargeText)] public string Usage { get; set; } = usage;

        public ICollection<IssueEntity> Issues { get; } = new List<IssueEntity>();
    }
}
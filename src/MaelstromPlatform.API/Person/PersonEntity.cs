using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MaelstromPlatform.API.Common;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Person
{
    public class PersonEntity(string identifier,
        string firstName,
        string middleName,
        string lastName)
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public string Identifier { get; set; } = identifier;

        public string FirstName { get; set; } = firstName;
        public string MiddleName { get; set; } = middleName;
        public string LastName { get; set; } = lastName;
        public ICollection<IssueEntity> IssuesFound { get; } = new List<IssueEntity>();
        public ICollection<IssueEntity> IssuesOwned { get; } = new List<IssueEntity>();
        public ICollection<IssueEntity> IssuesChampioned { get; } = new List<IssueEntity>();
        public ICollection<IssueEntity> IssuesReported { get; } = new List<IssueEntity>();
        public ICollection<IssueChampionEntity> IssueChampions { get; set; }
    }
}
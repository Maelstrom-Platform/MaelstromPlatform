using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MaelstromPlatform.API.Common;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Customer
{
    public class CustomerEntity(string identifier, string organization)
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        [Required][MaxLength(Constants.Identifier)] public string Identifier { get; set; } = identifier;

        public string Organization { get; set; } = organization;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ICollection<IssueEntity> IssuesEncountered { get; } = new List<IssueEntity>();
        public ICollection<IssueCustomerEntity> IssueCustomers { get; set; }
    }
}
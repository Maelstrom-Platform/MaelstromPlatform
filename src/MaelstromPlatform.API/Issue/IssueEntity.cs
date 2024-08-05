using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Attachment;
using MaelstromPlatform.API.Customer;
using MaelstromPlatform.API.Document;
using MaelstromPlatform.API.Person;
using MaelstromPlatform.API.Product;
using MaelstromPlatform.API.Project;
using MaelstromPlatform.API.Team;

namespace MaelstromPlatform.API.Issue
{
    public class IssueEntity(string identifier,
                             string summaryBrief,
                             string summaryLong,
                             DateTime origin,
                             bool approved,
                             bool resolved,
                             string problemStatement,
                             string workAround,
                             string stepsToReproduce,
                             DateTime foundOn,
                             DateTime reportedOn)
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }
        public string Identifier { get; set; } = identifier;
        public string Slug { get; set; }
        public string SummaryBrief { get; set; } = summaryBrief;
        public string SummaryLong { get; set; } = summaryLong;
        public DateTime Origin { get; set; } = origin;
        public bool Approved { get; set; } = approved;
        public Guid IssueStateSysId { get; set; }
        public IssueStateEntity IssueState { get; set; } = null!;
        public Guid IssueStatusSysId { get; set; }
        public IssueStatusEntity IssueStatus { get; set; } = null!;
        public bool Resolved { get; set; } = resolved;
        public Guid IssueSeveritySysId { get; set; }
        public IssueSeverityEntity IssueSeverity { get; set; } = null!;
        public Guid IssuePrioritySysId { get; set; }
        public IssuePriorityEntity IssuePriority { get; set; } = null!;
        public Guid IssueKindSysId { get; set; }
        public IssueKindEntity IssueKind { get; set; } = null!;
        public string ProblemStatement { get; set; } = problemStatement;
        public string WorkAround { get; set; } = workAround;
        public string StepsToReproduce { get; set; } = stepsToReproduce;
        public Guid PrimaryOwnerSysId { get; set; }
        public PersonEntity PrimaryOwner { get; set; } = null!;
        public Guid PrimaryOwnerTeamSysId { get; set; }
        public TeamEntity PrimaryOwnerTeam { get; set; } = null!;
        public Guid PrimaryFoundByTeamSysId { get; set; }
        public TeamEntity PrimaryFoundByTeam { get; set; } = null!;
        public Guid PrimaryReportedByTeamSysId { get; set; }
        public TeamEntity PrimaryReportedByTeam { get; set; } = null!;
        public Guid PrimaryChampionSysId { get; set; }
        public PersonEntity PrimaryChampion { get; set; } = null!;
        public Guid FoundByPrimaryPersonSysId { get; set; }
        public PersonEntity FoundByPrimaryPerson { get; set; } = null!;
        public Guid ReportedByPrimaryPersonSysId { get; set; }
        public PersonEntity ReportedByPrimaryPerson { get; set; } = null!;
        public DateTime FoundOn { get; set; } = foundOn;
        public DateTime ReportedOn { get; set; } = reportedOn;
        public ICollection<IssueApprovalEntity> Approvals { get; } = new List<IssueApprovalEntity>();
        public Guid ProductSysId { get; set; }
        public ProductEntity Product { get; set; } = null!;
        public Guid ProjectSysId { get; set; }
        public ProjectEntity Project { get; set; } = null!;
        public Guid PrimaryCustomerSysId { get; set; }
        public CustomerEntity PrimaryCustomer { get; set; } = null!;
        public ICollection<IssueCustomerEntity> IssueCustomers { get; set; } = null!;
        public ICollection<IssueComponentEntity> Components { get; set; } = null!;
        public ICollection<IssueAttachmentEntity> Attachments { get; set; } = null!;
        public ICollection<IssueChampionEntity> Champions { get; set; } = null!;
        public ICollection<IssueDocumentEntity> Documents { get; set; } = null!;
        public ICollection<IssueProductEntity> Products { get; set; } = null!;
        public ICollection<IssueProjectEntity> Projects { get; set; } = null!;
        public ICollection<IssueTagEntity> Tags { get; set; } = null!;
    }
}

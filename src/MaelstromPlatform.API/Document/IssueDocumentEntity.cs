using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Document
{
    public class IssueDocumentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public Guid IssueSysId { get; set; }
        public IssueEntity Issue { get; set; }
        public Guid DocumentSysId { get; set; }
        public DocumentEntity Document { get; set; }
    }
}
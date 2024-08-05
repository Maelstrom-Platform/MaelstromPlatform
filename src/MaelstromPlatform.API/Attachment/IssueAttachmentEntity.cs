using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Attachment
{
    public class IssueAttachmentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public Guid IssueSysId { get; set; }
        public IssueEntity Issue { get; set; }
        public Guid AttachmentSysId { get; set; }
        public AttachmentEntity Attachment { get; set; }
    }
}

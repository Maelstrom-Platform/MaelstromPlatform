using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaelstromPlatform.API.Attachment
{
    public class AttachmentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public string Name { get; set; }
        public string Path { get; set; }
        public string MIMEType { get; set; }
        public uint Size { get; set; }
        public string Qualifier { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public ICollection<IssueAttachmentEntity> Issues { get; set; } = null!;
    }
}

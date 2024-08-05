using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaelstromPlatform.API.Document
{
    public class DocumentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public string Slug { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public Guid PrimaryAuthor { get; set; }
        public ICollection<IssueDocumentEntity> Issues { get; set; } = null!;
    }
}

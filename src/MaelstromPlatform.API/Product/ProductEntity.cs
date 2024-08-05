using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MaelstromPlatform.API.Issue;

namespace MaelstromPlatform.API.Product
{
    public class ProductEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SysId { get; set; }

        public string Title { get; set; }

        public ICollection<IssueProductEntity> Issues { get; set; } = null!;
    }
}

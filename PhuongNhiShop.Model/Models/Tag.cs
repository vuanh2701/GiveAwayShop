using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReuseShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        public virtual IEnumerable<ConsignmentTag> ConsignmentTags { get; set; }
        public virtual IEnumerable<NewsTag> NewsTags { get; set; }
        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}

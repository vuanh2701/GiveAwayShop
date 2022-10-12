using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace ReuseShop.Model.Models
{
    [Table("NewTags")]
    public class NewsTag
    {
        [Key, Column(Order =0)]
        public int NewsID { get; set; }
        [Key]
        [Column(TypeName ="varchar",Order =1)]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("NewsID")]
        public virtual News News { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}

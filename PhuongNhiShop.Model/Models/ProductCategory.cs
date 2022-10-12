using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ReuseShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string Alias { get; set; }
        [MaxLength(256)]
        public string Description { get; set; }
        
        public int ParentID { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
        [MaxLength(50)]
        public string CreateBy { get; set; }
        
        public DateTime CreatedDate { get; set; }
        [MaxLength(50)]
        public string Status { get; set; }

        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<Product> Product { get; set; }

    }
}

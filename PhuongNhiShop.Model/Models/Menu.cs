using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReuseShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string URL { get; set; }
        [Required]
        public int GroupID { get; set; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }

        public int? DisplayOrder { get; set; }
        [MaxLength(256)]
        public string Target { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}

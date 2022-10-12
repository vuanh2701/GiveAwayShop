using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReuseShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReuseShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }


        [MaxLength(50)]
        public string Department { get; set; }

        [MaxLength(50)]
        public string Sky { get; set; }

        [MaxLength(50)]
        public string Facebook { get; set; }

        [MaxLength(50)]
        public string Mobile { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        
        public bool Status { get; set; }

        [MaxLength(50)]
        public string DisplayOrder { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReuseShop.Model.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string DisplayName { get; set; }
        [MaxLength(256)]
        public string Password { get; set; }
        public int StaffID { get; set; }

        [ForeignKey("StaffID")]
        public virtual Staff Staff { get; set; }
    }
}

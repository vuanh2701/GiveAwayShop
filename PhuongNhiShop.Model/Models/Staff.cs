using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhuongNhiShop.Model.Models
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string MidName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(256)]
        public string FullName { get; set; }
        [Required]
        public DateTime DateBirth { get; set; }
        [Required]
        public int NumberPhone { get; set; }
        [MaxLength(256)]
        public string BankName { get; set; }
        [MaxLength(50)]
        public string BankAccount { get; set; }
        [MaxLength(256)]
        public string Address { get; set; }

        public virtual IEnumerable<Account> Accounts { get; set; }
    }
}

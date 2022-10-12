using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReuseShop.Model.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string Address { get; set; }
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(256)]
        public string BankName { get; set; }
        [MaxLength(50)]
        public string BankAccount { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }

        public virtual IEnumerable<Consignment> Consignments { get; set; } 
        public virtual IEnumerable<Barcode> Barcodes { get; set; } 
        public virtual IEnumerable<Appointment> Appointments { get; set; } 
        public virtual IEnumerable<Schedule> Schedules { get; set; }
    }
}

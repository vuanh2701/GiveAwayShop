using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReuseShop.Model.Models
{
    [Table("Appointments")]
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public int QuantityGoods { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual IEnumerable<Schedule> Schedules { get; set; }

    }
}

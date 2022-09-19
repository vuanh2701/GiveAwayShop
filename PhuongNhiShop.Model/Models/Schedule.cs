using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhuongNhiShop.Model.Models
{
    [Table("Schedules")]
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int AppointmentID { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer  { get; set; }

        [ForeignKey("AppointmentID")]
        public virtual Appointment Appointment { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhuongNhiShop.Model.Models
{
    [Table("Barcodes")]
    public class Barcode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int CustomnerID { get; set; }
        [Required]
        public int ConsignmentID { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string? CreateBy { get; set; }
        [ForeignKey("CustomnerID")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("ConsignmentID")]
        public virtual Consignment Consignment { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ReuseShop.Model.Models
{
    [Table("Consignments")]
    public class Consignment
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

        
        public int CustomerID { get; set; }

        public int CategoryID { get; set; }
        [Required]
        [MaxLength(256)]
        public string CreateBy { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        public decimal? PriceInput { get; set; }
        public decimal PriceOutput { get; set; }
        [MaxLength(50)]
        public string Status { get; set; }
        public DateTime DateInput { get; set; }
        public DateTime DateOutput { get; set; }
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }

        //public Customer customer { get; set; }
        [ForeignKey("CategoryID")]
        public virtual ConsignmentCategory ConsignmentCategory { get; set; }

        [ForeignKey("Id")]
        public virtual Customer Customer { get; set; }

        public virtual IEnumerable<Barcode> Barcodes { get; set; }
        public virtual IEnumerable<ConsignmentTag>ConsignmentTags { get; set; }
    }
}

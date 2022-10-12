using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReuseShop.Model.Models
{
    [Table("ConsignmentTags")]
    public class ConsignmentTag
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key, Column(Order = 1)]
        public int ConsignmentID { get; set; }

        [Key, Column(Order = 2)]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("ConsignmentID")]
        public virtual Consignment Consignment { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}

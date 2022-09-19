using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongNhiShop.Model.Models
{
    [Table("News")]
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public string URL { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public int StaffID { get; set; }

        public int CategoryNewID { get; set; }

        public string Content { get; set; }

        [ForeignKey("CategoryNewID")]
        public virtual CategoryNews CategoryNews { get; set; }

    }
}

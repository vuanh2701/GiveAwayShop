using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReuseShop.Model.Models
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
        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public string URL { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public int StaffID { get; set; }
        public bool Status { get; set; }
        public int CategoryNewID { get; set; }

        public int? ViewCount { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }

        public string Content { get; set; }

        [ForeignKey("CategoryNewID")]
        public virtual NewsCategory CategoryNews { get; set; }

        public virtual IEnumerable<NewsTag> NewsTags { get; set; }
    }
}

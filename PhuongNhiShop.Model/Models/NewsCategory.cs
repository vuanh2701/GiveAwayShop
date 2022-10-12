using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReuseShop.Model.Models
{
    [Table("CategoriesNews")]
    public class NewsCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        
        [MaxLength(500)]
        public string Description { get; set; }

        public int? ParentID { get; set; }
        public bool? HomeFlag { get; set; }
    

        public virtual IEnumerable<News> News { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Models
{
    [Table("Categories")]
    public class Category
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [Key]
        public string Name { get; set; }

        public ICollection<Genre> Genres { get; set; }
    }
}

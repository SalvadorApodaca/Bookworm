using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Models
{
    public class Author
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string AuthFirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public string AuthLastName { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime DeathDay { get; set; }

        [MaxLength(255)]
        public string PicturePath { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

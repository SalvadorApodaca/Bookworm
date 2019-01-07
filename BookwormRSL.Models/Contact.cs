using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("CntFirstName")]
        public string FirstName { get; set; }

        [Required]
        [Column("CntLastName")]
        public string LastName { get; set; }

        public string PicturePath { get; set; }
    }
}

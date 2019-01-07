using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Models
{
    [Table("Book_Lendings")]
    public class BookLending
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Lend_Date")]
        public DateTime LendDate { get; set; }

        [Column("Return_Date")]
        public DateTime ReturnDate { get; set; }

        [Required]
        public int BookId { get; set; }
        
        [Required]
        public int ContactId { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

        [ForeignKey("ContactId")]
        public virtual Contact Contact { get; set; }


    }
}

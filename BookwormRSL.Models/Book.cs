using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Models
{
    [Table("Books")]
    public class Book
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Column("Date_Obtained")]
        public DateTime DateObtained { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Column("Published_Date")]
        public DateTime PublishedDate { get; set; }

        public string PicturePath { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        public int StatusId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }

        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }

        public virtual ICollection<BookLending> BookLendings { get; set; }

        public virtual ICollection<ReadingHistory> ReadingHistories { get; set; }
    }
}

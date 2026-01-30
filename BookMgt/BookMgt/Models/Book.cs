using System.ComponentModel.DataAnnotations;

namespace BookMgt.Models
{
    public class Book
    {
        [Key]
        public int bookid { get; set; }    // shortcut prop

        [Required]
        [Display(Name = "Book Name")]
        public string Bookname { get; set; }

        [Required]
        [Display(Name = "Book Author")]
        public string bookAuthor { get; set; }

        [Required]
        [Display(Name = "Publication Year")]
        public int publicationYear { get; set; }
    }
}

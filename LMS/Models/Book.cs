using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace LMS.Models
{
    public class Book
    {

        [Key]
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int NoOfCopies { get; set; }
        
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }

        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public int IssuedBook { get; set; }
        public bool IsAvailable { get; set; }

    }
}

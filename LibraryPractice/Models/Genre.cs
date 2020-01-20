using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryPractice.Models
{
    public class Genre
    {
        public int ID { get; set; }

        [Display(Name = "Genre")]
        public string GenreName { get; set; }

        [ForeignKey("GenreFK")]
        public ICollection<Book> Books { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryPractice.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Publication")]
        public DateTime PublicationDate { get; set; }
        
        [Display(Name = "Page Count")]
        public int PageCount { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public Genre Genre { get; set; }
        public Condition Condition { get; set; }


    }
}

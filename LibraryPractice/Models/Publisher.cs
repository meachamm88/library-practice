using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryPractice.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }

        [ForeignKey("PublisherFK")]
        public ICollection<Book> Books { get; set; }
    }
}

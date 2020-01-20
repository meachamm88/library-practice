using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryPractice.Models
{
    public class Condition
    {
        public int ID { get; set; }

        [Display(Name = "Condition")]
        public string ConditionStatus { get; set; }

        [ForeignKey("ConditionFK")]
        public ICollection<Book> Books { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStore.Domain.Domain
{
    public class Book : BaseEntity
    {
        [Required]
        public String Title { get; set; }
        [Required]
        public string BookCover { get; set; }
        public String Description { get; set; }
        [Required]
        public Author? Author { get; set; }

        [Required]
        public double Rating { get; set; }
        [Required]
        public Publisher Publisher { get; set; }
        [Required]
        public String Genre { get; set; }
        [Required]
        public Int32 QuantityAvaiable { get; set; }
        [Required]
        public double Price { get; set; }
    }
}

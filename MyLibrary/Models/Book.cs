using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models
{
    class Book
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int GenreId { get; set; }

        public int AuthorId { get; set; }
        [Column(TypeName = "money")]
public decimal Price { get; set; }

        public Genre Genre { get; set; } 
        public Author Author { get; set; }
    }
}

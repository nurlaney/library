using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Count { get; set; }

        [Column(TypeName ="date")]
        public DateTime OrderDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Order Order { get; set; }
        public Book Book { get; set; }
    }
}

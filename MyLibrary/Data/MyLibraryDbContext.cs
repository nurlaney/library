using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary.Data
{
    class MyLibraryDbContext:DbContext
    {
        public MyLibraryDbContext():base("Server=DESKTOP-98T4393;Database=MyLibraryYN;Trusted_Connection=True;MultipleActiveResultSets=true")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }




    }
}

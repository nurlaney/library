using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyLibrary.Data
{
    class MyLibraryDbContext:DbContext
    {
        public MyLibraryDbContext():base("Server=DESKTOP-98T4393;Database=MyLibraryYN;Trusted_Connection=True;MultipleActiveResultSets=true")
        {

        }

        //public DbSet<Book> Books { get; set; }
        //public DbSet<Author> Authors { get; set; }
    }
}

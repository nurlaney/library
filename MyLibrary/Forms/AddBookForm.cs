using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary.Data;
using MyLibrary.Models;
using System.Data.Entity;


namespace MyLibrary.Forms
{
    public partial class AddBookForm : Form
    {
        //private readonly MyLibraryDbContext _context;
        public AddBookForm()
        {
            InitializeComponent();
            //_context = new MyLibraryDbContext();
            //Test();
        }

        //private void Test()
        //{
        //    Book Book = new Book()
        //    {
        //        Name = "1001 Gece"
        //    };

        //    _context.Books.Add(Book);
        //    _context.SaveChanges();
        //}

        private void btncAddBook_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class AddAuthorForm : Form
    {
        //private readonly MyLibraryDbContext _context;
        public AddAuthorForm()
        {
            
            InitializeComponent();
            //_context = new MyLibraryDbContext();
            //Test1();
        }

        //private void Test1()
        //{
        //    Author Author = new Author()
        //    {
        //        Name = "Nizami",
        //        Surname = "Gencevi"
        //    };

        //    _context.Authors.Add(Author);
        //    _context.SaveChanges();
        //}

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {

        }
    }
}

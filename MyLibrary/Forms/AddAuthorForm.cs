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
        private readonly MyLibraryDbContext _context;
        public AddAuthorForm()
        {
            _context = new MyLibraryDbContext();
            InitializeComponent();
        }

        private void Test1()
        {
          Author Author = new Author()
          {
              Name = txtAuthorName.Text,
              Surname = txtAuthorSurname.Text
          };

            _context.Authors.Add(Author);
            _context.SaveChanges();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Test1();
            txtAuthorName.ResetText();
            txtAuthorSurname.ResetText();
            MessageBox.Show("Author Added");
        }
        
    }
}

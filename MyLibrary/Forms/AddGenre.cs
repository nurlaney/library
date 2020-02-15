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
    public partial class AddGenre : Form
    {
        private readonly MyLibraryDbContext _context;
        public AddGenre()
        {
            InitializeComponent();
            _context = new MyLibraryDbContext();
        }
        private void Test3()
        {
            Genre Genre = new Genre()
            {
                Name = txtAddGenre.Text,
            };

            _context.Genres.Add(Genre);
            _context.SaveChanges();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            Test3();
            txtAddGenre.ResetText();
            MessageBox.Show("Genre Added");
        }
    }
}

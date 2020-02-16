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
       private readonly MyLibraryDbContext _context;
        public AddBookForm()
        {
            InitializeComponent();
            _context = new MyLibraryDbContext();
            fillcomboboxgenre();
            fillcomboboxauthor();
          
        }
# region Fill methods
        //genre comboboxun bazadan doldurulmasi
        private void fillcomboboxgenre()
        {
            var genreitems = _context.Genres.ToList();
            foreach (var item in genreitems)
            {
                comboBox1.Items.Add(item.Name);
            }
        }
        
        private void fillcomboboxauthor()
        {
            var authoritems = _context.Authors.ToList();
            foreach (var item in authoritems)
            {

                var fulname = item.Name + " " + item.Surname;
                comboBox2.Items.Add(fulname);
            }
        }
        //end method
        #endregion //

        //yazici elave etme ve janr elave etme pencerelerinin acilmasi
        private void btncAddGenre_Click(object sender, EventArgs e)
        {
            AddGenre addinggenre = new AddGenre();
            addinggenre.Show();
        }

        private void btncAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm addingauthor = new AddAuthorForm();
            addingauthor.Show();
        }
        //pencerelerin acilmasi end

        
        //kitab elave etmek start
        private void addwholebook()
        {
            Book book = new Book()
            {
                Name = txtcBookName.Text,
                GenreId= comboBox1.SelectedIndex,
                AuthorId=comboBox2.SelectedIndex,
                Price =  nmrcPrice.Value
            };


            _context.Books.Add(book);
            _context.SaveChanges();

        }

        private void btncAddBook_Click(object sender, EventArgs e)
        {
            addwholebook();
            MessageBox.Show("Book Added");
            txtcBookName.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            var wholeMyBooks = _context.Books
                                             .Include("Genre")
                                             .Include("Author")

                                             .ToList();

            foreach (var item in wholeMyBooks)
            {
                dtGrdBooks.Rows.Add(item.Name, item.Genre.Name, item.Author.Name + " " + item.Author.Surname, item.Price);
            }
        }
        //kitab elave etmek end




    }
}

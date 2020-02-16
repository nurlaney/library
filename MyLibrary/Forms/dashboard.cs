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
    public partial class dashboardForm : Form
    {
        private readonly MyLibraryDbContext _context;

        public dashboardForm()
        {
            _context = new MyLibraryDbContext();
            InitializeComponent();
        }
        #region kecidler
        //orderse kecid
        private void btnGoOrders_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
            return;
        }
        //kitablara kecid
        private void AddBookDashb_Click(object sender, EventArgs e)
        {
            AddBookForm addingbook = new AddBookForm();
            addingbook.Show();
        }
        //musterilere kecid
        private void btnAddCustomerDashb_Click(object sender, EventArgs e)
        {
            AddCustomerForm addingCustomer = new AddCustomerForm();
            addingCustomer.Show();
        }


        //dashboardForm  hissesi
        #endregion

        private void Dashboard_Load(object sender, EventArgs e)
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
    }
}

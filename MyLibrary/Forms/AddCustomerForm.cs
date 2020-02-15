using MyLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary.Models;
using System.Data.Entity;

namespace MyLibrary.Forms
{
    
    public partial class AddCustomerForm : Form
    {
        private readonly MyLibraryDbContext _context;
        public AddCustomerForm()
        {
            InitializeComponent();
            _context = new MyLibraryDbContext();
        }
        private void Test4()
        {
            Customer customer = new Customer()
            {
                Name = txtcCustomerName.Text,
                Surname = txtcCustomerSurname.Text,
                Email = txtcCustomEmail.Text
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        private void btncCustomerAdd_Click(object sender, EventArgs e)
        {
            Test4();
            txtcCustomEmail.ResetText();
            txtcCustomerName.ResetText();
            txtcCustomerSurname.ResetText();
            MessageBox.Show("Customer Added");
        }
    }
}

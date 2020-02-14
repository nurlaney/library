using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary.Forms;
using CryptoHelper;
using MyLibrary.Data;
using MyLibrary.Models;
using System.Data.Entity;

namespace MyLibrary
{
    public partial class LoginForm : Form
    {
        private readonly MyLibraryDbContext _context;

        public LoginForm()
        {
            _context = new MyLibraryDbContext();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
               
                MessageBox.Show("E-mail daxil edin");
                return;

            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Şifrə daxil edin");
                return;
            }

            User user = _context.Users.FirstOrDefault(u => u.Username == txtUsername.Text);

            if (user != null && Crypto.VerifyHashedPassword(user.Password, txtPassword.Text))
            {
                dashboardForm dashboard = new dashboardForm();
                dashboard.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Username ve ya sifre yanlisdir");


        }
    }
}

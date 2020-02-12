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

namespace MyLibrary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
              dashboardForm dashboard = new dashboardForm();
              dashboard.ShowDialog();

            }
            else
            {
                MessageBox.Show("Username və ya parol səhvdir");
            }

            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                dashboardForm dashboard = new dashboardForm();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username və ya parol səhvdir");
            }



        }
    }
}

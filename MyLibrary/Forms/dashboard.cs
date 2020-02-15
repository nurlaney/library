using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary.Forms
{
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {
            InitializeComponent();
        }


        private void btnGoOrders_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
            return;
        }

        private void AddBookDashb_Click(object sender, EventArgs e)
        {
            AddBookForm addingbook = new AddBookForm();
            addingbook.Show();
        }

        private void btnAddCustomerDashb_Click(object sender, EventArgs e)
        {
            AddCustomerForm addingCustomer = new AddCustomerForm();
            addingCustomer.Show();
        }

        //dashboardForm  Dashbordfrm = new dashboardForm();

    }
}

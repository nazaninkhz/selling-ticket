using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace SellingTicket
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblFullName.Text = CurrentUser.User.FirstName + " " + CurrentUser.User.LastName;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSoldTickets_Click(object sender, EventArgs e)
        {
            frmSoldTickets frm = new frmSoldTickets();
            frm.ShowDialog();
        }

        private void btnSellTicket_Click(object sender, EventArgs e)
        {
            frmSellingTicket frm = new frmSellingTicket();
            frm.ShowDialog();
        }
    }
}

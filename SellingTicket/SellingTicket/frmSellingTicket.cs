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
    public partial class frmSellingTicket : Form
    {
        public frmSellingTicket()
        {
            InitializeComponent();
        }

        private void frmSellingTicket_Load(object sender, EventArgs e)
        {
            cmbDestination.DataSource    =  CityManager.GetAll();
            cmbDestination.ValueMember = "Id";
            cmbDestination.DisplayMember = "Name";

            cmbOrigin.DataSource = CityManager.GetAll();
            cmbOrigin.ValueMember = "Id";
            cmbOrigin.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TicketManager.Add(CurrentUser.User.Id, txtFirstName.Text, txtLastName.Text, rdbMale.Checked, txtTell.Text, txtAddress.Text, (int)cmbOrigin.SelectedValue, (int)cmbDestination.SelectedValue, Convert.ToInt32(txtPrice.Text));
            txtAddress.Text =
                txtFirstName.Text =
                txtLastName.Text = txtPrice.Text = txtTell.Text = "";
            rdbMale.Checked = true;
            cmbDestination.SelectedIndex = 0;
            cmbOrigin.SelectedIndex = 0;
            MessageBox.Show("بلیط صادر گردید");
        }
    }
}

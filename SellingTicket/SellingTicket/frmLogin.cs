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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(txtUserName.Text, txtPassword.Text);
            Authentication auth = new Authentication(user);
            if (auth.IsTrueUser())
            {
                CurrentUser.User = UserManager.GetUserByUserName(txtUserName.Text);
                frmMenu mainMenu = new frmMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("false user");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}

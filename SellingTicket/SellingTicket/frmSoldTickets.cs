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
    public partial class frmSoldTickets : Form
    {
        public frmSoldTickets()
        {
            InitializeComponent();
        }

        private void frmSoldTickets_Load(object sender, EventArgs e)
        {
            dgvAllTickets.DataSource = TicketManager.GetAll();
        }
    }
}

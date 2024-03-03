using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Clients;

namespace Bank
{
    public partial class frmMain : Form
    {
        public frmMain ( )
        {
            InitializeComponent ( );
        }

        private void logOutToolStripMenuItem_Click (object sender , EventArgs e)
        {
            this.Close ( );
        }

        private void showClientsToolStripMenuItem_Click (object sender , EventArgs e)
        {
            frmShowClients frm = new frmShowClients ();
            frm.ShowDialog ( );
        }
    }
}

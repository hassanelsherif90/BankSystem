using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusiness;

namespace Bank.Clients
{
    public partial class frmShowClients : Form
    {
        private static DataTable _dgvAllClients = clsClient.GetAllClients ( );

        private DataTable _dgvClients = _dgvAllClients.DefaultView.ToTable (false, "PersonID",  "FirstName", "LastName","Email", 
                                                                            "Phone","Address","AccountNumber", "PinCode");

        private void _RefreshList ( )
        {
            _dgvAllClients = clsClient.GetAllClients ( );
            _dgvClients = _dgvAllClients.DefaultView.ToTable (false , "PersonID" , "FirstName" , "LastName" , "Email" ,
                                                              "Phone" , "Address" , "AccountNumber" , "PinCode");
            dgvAllClients.DataSource = _dgvClients;

            lblRecordClient.Text = _dgvAllClients.Rows.Count.ToString ();
        }

        public frmShowClients ( )
        {
            InitializeComponent ( );
        }

        private void button1_Click (object sender , EventArgs e)
        {
            this.Close ();
        }

        private void frmShowClients_Load (object sender , EventArgs e)
        {
            dgvAllClients.DataSource = _dgvClients;

            lblRecordClient.Text = dgvAllClients.Rows.Count.ToString ( );
            cbFilterBy.SelectedIndex = 0;

            if ( dgvAllClients.Rows.Count > 0 )
            {

               // "PersonID" , "FirstName" , "LastName" , "Email" , "Phone" , "Address" , "AccountNumber" , "PinCode");
                dgvAllClients.Columns [0].HeaderText = "Person ID";
                dgvAllClients.Columns [0].Width = 150;


                dgvAllClients.Columns [1].HeaderText = "First Name";
                dgvAllClients.Columns [1].Width = 120;

                dgvAllClients.Columns [2].HeaderText = "Last Name";
                dgvAllClients.Columns [2].Width = 120;

                dgvAllClients.Columns [3].HeaderText = "Email";
                dgvAllClients.Columns [3].Width = 200;

                dgvAllClients.Columns [4].HeaderText = "Phone";
                dgvAllClients.Columns [4].Width = 150;

                dgvAllClients.Columns [5].HeaderText = "Address";
                dgvAllClients.Columns [5].Width = 150;
                
                dgvAllClients.Columns [6].HeaderText = "Ac Number";
                dgvAllClients.Columns [6].Width = 120;
                
                dgvAllClients.Columns [7].HeaderText = "Pin Code";
                dgvAllClients.Columns [7].Width = 150;


            }

        }

        private void txtFilterBy_TextChanged (object sender , EventArgs e)
        {
            string FilterColumn = "";



        }

        private void cbFilterBy_SelectedIndexChanged (object sender , EventArgs e)
        {
            txtFilterBy.Visible = ( cbFilterBy.Text != "None" );

            if(txtFilterBy.Visible )
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();    
            }
        }
    }
}

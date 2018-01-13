using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using DatabaseLibrary;
using DocumentLibrary;

namespace WindowsFormsApp
{
    public partial class FrmMain : Form
    {
        // Object contains data from Access database.
        Access access;
        // Customers display in lbxCustomers
        List<Customer> customers;
        // Customers display in lbxCustomersSelected
        List<Customer> customersSelected;

        public FrmMain()
        {
            InitializeComponent();
            access = new Access();
            customers = access.GetData().GetCustomers();
            customersSelected = new List<Customer>();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            access.LoadData();
            LbxCustomers_load();
        }

        private void LbxCustomers_load()
        {
            // Define where is from data.
            lbxCustomers.DataSource = customers;
            // Value show in listbox.
            lbxCustomers.DisplayMember = "LastNameFirstName";
            // Value when row is selected in listbox.
            lbxCustomers.ValueMember = "Id";
        }
    }
}

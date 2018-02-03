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

namespace WindowsFormsApp
{
    public partial class FrmCustomer : Form
    {
        private List<Customer> customers;

        public FrmCustomer(List<Customer> items)
        {
            InitializeComponent();
            customers = new List<Customer>(items);
        }

        /// <summary>
        /// Add new customer in local database and in List<Customer>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxAccept_click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Close this WinForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxCancel_click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}

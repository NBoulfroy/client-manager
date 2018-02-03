using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Substracts the selected customer from lbxCustomers component 
        /// to add in lbxSelectedCustomers component.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxAddCustomer_click(object sender, EventArgs e)
        {
            Customer customer = (Customer)lbxCustomers.SelectedItem;

            Refresh_listbox(lbxCustomers, customers, customer, lbxCustomersSelected, customersSelected);
        }

        /// <summary>
        /// Substracts the selected customer from lbxSelectedCustomers component 
        /// to add in lbxCustomers component.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxRemoveCustomer_click(object sender, EventArgs e)
        {
            Customer customer = (Customer)lbxCustomersSelected.SelectedItem;

            Refresh_listbox(lbxCustomersSelected, customersSelected, customer, lbxCustomers, customers);
        }

        #region pbxAdd

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxAdd_mouseHover(object sender, EventArgs e)
        {
            pbxAdd.Image = global::WindowsFormsApp.Properties.Resources.add_light_32;
        }

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is not on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxAdd_mouseLeave(object sender, EventArgs e)
        {
            pbxAdd.Image = global::WindowsFormsApp.Properties.Resources.add_dark_32;
        }

        /// <summary>
        /// Opens new FrmCustomers WinForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxAdd_click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer(customers);
            frmCustomer.ShowDialog();
        }

        #endregion

        #region pbxRemove

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxRemove_mouseHover(object sender, EventArgs e)
        {
            pbxRemove.Image = global::WindowsFormsApp.Properties.Resources.delete_light_32;
        }

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is not on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxRemove_mouseLeave(object sender, EventArgs e)
        {
            pbxRemove.Image = global::WindowsFormsApp.Properties.Resources.delete_dark_32;
        }

        /// <summary>
        /// Deletes selected customer selected in lbxCustomers component.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxRemove_click(object sender, EventArgs e)
        {

        }

        #endregion

        #region pbxSave

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxSave_mouseHover(object sender, EventArgs e)
        {
            pbxSave.Image = global::WindowsFormsApp.Properties.Resources.save_light_32;
        }

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is not on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxSave_mouseLeave(object sender, EventArgs e)
        {
            pbxSave.Image = global::WindowsFormsApp.Properties.Resources.save_dark_32;
        }

        /// <summary>
        /// Opens new saveFileDialog window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxSave_click(object sender, EventArgs e)
        {
            // Defines all choices.
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|OpenDocument Spreadsheet files (*.ods)|*.ods|Excel 1993-1998 files (*.xls)|*.xls"; // |Excel 2007 files (*.xlsx)|*.xlsx|All files (*.*)|*.*
            saveFileDialog.AddExtension = true;

            // Get choice in DialogResult object.
            DialogResult result = saveFileDialog.ShowDialog();

            // DialogResult treatment.
            if (result == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        CSV csv = new CSV("", saveFileDialog.FileName);
                        csv.DocumentBuilder(customersSelected);
                        break;
                    case 2:
                        Spreadsheet ods = new Spreadsheet("", saveFileDialog.FileName);
                        ods.DocumentBuilder(customersSelected);
                        break;
                    case 3:
                        Spreadsheet excel = new Spreadsheet("", saveFileDialog.FileName);
                        excel.DocumentBuilder(customersSelected);
                        break;
                }
            }
        }

        #endregion

        #region pbxPrint

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxPrint_mouseHover(object sender, EventArgs e)
        {
            pbxPrint.Image = global::WindowsFormsApp.Properties.Resources.print_light_32;
        }

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is not on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxPrint_mouseLeave(object sender, EventArgs e)
        {
            pbxPrint.Image = global::WindowsFormsApp.Properties.Resources.print_dark_32;
        }

        /// <summary>
        /// Opens new print dialog window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxPrint_click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        #endregion

        #region List minipulations

        /// <summary>
        /// Configures and insert data from Access database to lbxCustomers component.
        /// </summary>
        private void LbxCustomers_load()
        {
            // Define where is from data.
            lbxCustomers.DataSource = customers;
            // Value show in listbox.
            lbxCustomers.DisplayMember = "LastNameFirstName";

            lbxCustomers.ValueMember = "Id";
        }

        /// <summary>
        /// Refreshes ListBox components.
        /// </summary>
        /// <param name="listBox">ListBox component</param>
        /// <param name="list">List which contains customers</param>
        /// <param name="customer">Customer object</param>
        /// <param name="otherListBox">ListBox component</param>
        /// <param name="otherList">List which contains customers</param>
        private void Refresh_listbox(ListBox listBox, List<Customer> list, Customer customer, ListBox otherListBox, List<Customer> otherList)
        {
            // Total clean-up for ListBox components.
            listBox.DataSource = null;
            otherListBox.DataSource = null;

            // Extracts data from the list.
            list.Remove(customer);

            // Inserts data in an other list.
            otherList.Add(customer);

            // Defines DataSource for ListBox components.
            listBox.DataSource = list;
            otherListBox.DataSource = otherList;

            // Displays data in ListBox components.
            listBox.DisplayMember = "LastNameFirstName";
            listBox.ValueMember = "Id";
            otherListBox.DisplayMember = "LastNameFirstName";
            otherListBox.ValueMember = "Id";
        }

        #endregion
    }
}

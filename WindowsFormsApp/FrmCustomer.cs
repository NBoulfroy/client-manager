using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary;
using DatabaseLibrary;

namespace WindowsFormsApp
{
    public partial class FrmCustomer : Form
    {
        private FrmMain frmMain;
        private Access access;
        private List<Customer> list;

        public FrmCustomer(FrmMain frmMain, Access access, List<Customer> list)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            this.access = access;
            this.list = list;
        }

        /// <summary>
        /// Actions when the window is open.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            // PictureBox element disabled.
            pbxAccept.Enabled = false;
        }

        #region pbxAccept element

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxAccept_mouseHover(object sender, EventArgs e)
        {
            pbxAccept.Image = Properties.Resources.accept_light_32;
        }

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is not on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxAccept_mouseLeave(object sender, EventArgs e)
        {
            pbxAccept.Image = Properties.Resources.accept_dark_32;
        }

        /// <summary>
        /// Add new customer in local database and in List<Customer>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxAccept_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add this customer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Adds Customer in database and in memory.
                access.AddCustomer(tbxLastName.Text, tbxFirstName.Text);

                // Refreshes the main WinForm which contains customers list.
                frmMain.Refresh_listBox(frmMain.lbxCustomers, list);

                // Verifications about all listboxes components in main WinForm.
                frmMain.ListBoxesVerifications();

                // Hide this window.
                Hide();
                // Close this window.
                Close();
            }
        }

        #endregion

        #region pbxCancel element

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxCancel_mouseHover(object sender, EventArgs e)
        {
            pbxCancel.Image = Properties.Resources.cancel_light_32;
        }

        /// <summary>
        /// Changes the image in Picturebox component when the mouse is not on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxCancel_mouseLeave(object sender, EventArgs e)
        {
            pbxCancel.Image = Properties.Resources.cancel_dark_32;
        }

        /// <summary>
        /// Close this WinForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxCancel_click(object sender, EventArgs e)
        {
            // Hide this window.
            Hide();
            // Close this window.
            Close();
        }

        #endregion

        #region Texbox manipulation

        /// <summary>
        /// TexBox element verification.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxVerification(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxLastName.Text) && !string.IsNullOrEmpty(tbxFirstName.Text))
            {
                pbxAccept.Image = Properties.Resources.accept_dark_32;
                pbxAccept.Enabled = true;
            }
            else
            {
                pbxAccept.Image = Properties.Resources.accept_disabled_32;
                pbxAccept.Enabled = false;
            }
        }

        #endregion
    }
}

namespace WindowsFormsApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.lbxCustomersSelected = new System.Windows.Forms.ListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblCustomersSelected = new System.Windows.Forms.Label();
            this.ttpAdd = new System.Windows.Forms.ToolTip(this.components);
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.ttpSave = new System.Windows.Forms.ToolTip(this.components);
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.ttpPrint = new System.Windows.Forms.ToolTip(this.components);
            this.pbxPrint = new System.Windows.Forms.PictureBox();
            this.ttpAddCustomer = new System.Windows.Forms.ToolTip(this.components);
            this.pbxAddCustomer = new System.Windows.Forms.PictureBox();
            this.ttpRemoveCustomer = new System.Windows.Forms.ToolTip(this.components);
            this.pbxRemoveCustomer = new System.Windows.Forms.PictureBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.ttpRemove = new System.Windows.Forms.ToolTip(this.components);
            this.pbxRemove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.ItemHeight = 16;
            this.lbxCustomers.Location = new System.Drawing.Point(12, 39);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(316, 420);
            this.lbxCustomers.TabIndex = 0;
            // 
            // lbxCustomersSelected
            // 
            this.lbxCustomersSelected.FormattingEnabled = true;
            this.lbxCustomersSelected.ItemHeight = 16;
            this.lbxCustomersSelected.Location = new System.Drawing.Point(428, 39);
            this.lbxCustomersSelected.Name = "lbxCustomersSelected";
            this.lbxCustomersSelected.Size = new System.Drawing.Size(316, 420);
            this.lbxCustomersSelected.TabIndex = 4;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(12, 13);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(79, 17);
            this.lblCustomers.TabIndex = 8;
            this.lblCustomers.Text = "Customers:";
            // 
            // lblCustomersSelected
            // 
            this.lblCustomersSelected.AutoSize = true;
            this.lblCustomersSelected.Location = new System.Drawing.Point(428, 13);
            this.lblCustomersSelected.Name = "lblCustomersSelected";
            this.lblCustomersSelected.Size = new System.Drawing.Size(136, 17);
            this.lblCustomersSelected.TabIndex = 9;
            this.lblCustomersSelected.Text = "Selected customers:";
            // 
            // ttpAdd
            // 
            this.ttpAdd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpAdd.ToolTipTitle = "Information:";
            // 
            // pbxAdd
            // 
            this.pbxAdd.Image = global::WindowsFormsApp.Properties.Resources.add_dark_32;
            this.pbxAdd.Location = new System.Drawing.Point(12, 465);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(32, 32);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAdd.TabIndex = 5;
            this.pbxAdd.TabStop = false;
            this.ttpAdd.SetToolTip(this.pbxAdd, "Adds customer.");
            this.pbxAdd.Click += new System.EventHandler(this.PbxAdd_click);
            this.pbxAdd.MouseLeave += new System.EventHandler(this.PbxAdd_mouseLeave);
            this.pbxAdd.MouseHover += new System.EventHandler(this.PbxAdd_mouseHover);
            // 
            // ttpSave
            // 
            this.ttpSave.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpSave.ToolTipTitle = "Information:";
            // 
            // pbxSave
            // 
            this.pbxSave.Image = global::WindowsFormsApp.Properties.Resources.save_dark_32;
            this.pbxSave.Location = new System.Drawing.Point(655, 465);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(32, 32);
            this.pbxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxSave.TabIndex = 7;
            this.pbxSave.TabStop = false;
            this.ttpSave.SetToolTip(this.pbxSave, "Saves in a spreadsheet file selected customers.");
            this.pbxSave.Click += new System.EventHandler(this.PbxSave_click);
            this.pbxSave.MouseLeave += new System.EventHandler(this.PbxSave_mouseLeave);
            this.pbxSave.MouseHover += new System.EventHandler(this.PbxSave_mouseHover);
            // 
            // ttpPrint
            // 
            this.ttpPrint.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpPrint.ToolTipTitle = "Information:";
            // 
            // pbxPrint
            // 
            this.pbxPrint.Image = global::WindowsFormsApp.Properties.Resources.print_dark_32;
            this.pbxPrint.Location = new System.Drawing.Point(700, 465);
            this.pbxPrint.Name = "pbxPrint";
            this.pbxPrint.Size = new System.Drawing.Size(32, 32);
            this.pbxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPrint.TabIndex = 6;
            this.pbxPrint.TabStop = false;
            this.ttpPrint.SetToolTip(this.pbxPrint, "Prints selected customers.");
            this.pbxPrint.Click += new System.EventHandler(this.PbxPrint_click);
            this.pbxPrint.MouseLeave += new System.EventHandler(this.PbxPrint_mouseLeave);
            this.pbxPrint.MouseHover += new System.EventHandler(this.PbxPrint_mouseHover);
            // 
            // ttpAddCustomer
            // 
            this.ttpAddCustomer.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpAddCustomer.ToolTipTitle = "Information:";
            // 
            // pbxAddCustomer
            // 
            this.pbxAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbxAddCustomer.Image")));
            this.pbxAddCustomer.Location = new System.Drawing.Point(332, 160);
            this.pbxAddCustomer.Name = "pbxAddCustomer";
            this.pbxAddCustomer.Size = new System.Drawing.Size(64, 64);
            this.pbxAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAddCustomer.TabIndex = 10;
            this.pbxAddCustomer.TabStop = false;
            this.ttpAddCustomer.SetToolTip(this.pbxAddCustomer, "Adds customer in selected customers list.");
            this.pbxAddCustomer.Click += new System.EventHandler(this.PbxAddCustomer_click);
            // 
            // ttpRemoveCustomer
            // 
            this.ttpRemoveCustomer.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpRemoveCustomer.ToolTipTitle = "Information:";
            // 
            // pbxRemoveCustomer
            // 
            this.pbxRemoveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbxRemoveCustomer.Image")));
            this.pbxRemoveCustomer.Location = new System.Drawing.Point(340, 274);
            this.pbxRemoveCustomer.Name = "pbxRemoveCustomer";
            this.pbxRemoveCustomer.Size = new System.Drawing.Size(64, 64);
            this.pbxRemoveCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxRemoveCustomer.TabIndex = 3;
            this.pbxRemoveCustomer.TabStop = false;
            this.ttpRemoveCustomer.SetToolTip(this.pbxRemoveCustomer, "Removes customer from selected customers list");
            this.pbxRemoveCustomer.Click += new System.EventHandler(this.PbxRemoveCustomer_click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // ttpRemove
            // 
            this.ttpRemove.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpRemove.ToolTipTitle = "Information:";
            // 
            // pbxRemove
            // 
            this.pbxRemove.Image = global::WindowsFormsApp.Properties.Resources.delete_dark_32;
            this.pbxRemove.Location = new System.Drawing.Point(55, 465);
            this.pbxRemove.Name = "pbxRemove";
            this.pbxRemove.Size = new System.Drawing.Size(32, 32);
            this.pbxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxRemove.TabIndex = 11;
            this.pbxRemove.TabStop = false;
            this.ttpRemove.SetToolTip(this.pbxRemove, "Deletes selected customer from customer list.");
            this.pbxRemove.Click += new System.EventHandler(this.PbxRemove_click);
            this.pbxRemove.MouseLeave += new System.EventHandler(this.PbxRemove_mouseLeave);
            this.pbxRemove.MouseHover += new System.EventHandler(this.PbxRemove_mouseHover);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 509);
            this.Controls.Add(this.pbxRemove);
            this.Controls.Add(this.pbxAddCustomer);
            this.Controls.Add(this.lblCustomersSelected);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.pbxPrint);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.lbxCustomersSelected);
            this.Controls.Add(this.pbxRemoveCustomer);
            this.Controls.Add(this.lbxCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer-manager";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.PictureBox pbxRemoveCustomer;
        private System.Windows.Forms.ListBox lbxCustomersSelected;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxPrint;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblCustomersSelected;
        private System.Windows.Forms.ToolTip ttpAdd;
        private System.Windows.Forms.ToolTip ttpSave;
        private System.Windows.Forms.ToolTip ttpPrint;
        private System.Windows.Forms.ToolTip ttpAddCustomer;
        private System.Windows.Forms.ToolTip ttpRemoveCustomer;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PictureBox pbxAddCustomer;
        private System.Windows.Forms.PictureBox pbxRemove;
        private System.Windows.Forms.ToolTip ttpRemove;
    }
}
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
            this.ttpAdd = new System.Windows.Forms.ToolTip(this.components);
            this.ttpSave = new System.Windows.Forms.ToolTip(this.components);
            this.ttpPrint = new System.Windows.Forms.ToolTip(this.components);
            this.ttpAddCustomer = new System.Windows.Forms.ToolTip(this.components);
            this.ttpRemoveCustomer = new System.Windows.Forms.ToolTip(this.components);
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.ttpRemove = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCustomers = new System.Windows.Forms.GroupBox();
            this.gbxCustomersSelected = new System.Windows.Forms.GroupBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxPrint = new System.Windows.Forms.PictureBox();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxRemove = new System.Windows.Forms.PictureBox();
            this.pbxAddCustomer = new System.Windows.Forms.PictureBox();
            this.pbxRemoveCustomer = new System.Windows.Forms.PictureBox();
            this.gbxCustomers.SuspendLayout();
            this.gbxCustomersSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.ItemHeight = 20;
            this.lbxCustomers.Location = new System.Drawing.Point(6, 21);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(316, 424);
            this.lbxCustomers.TabIndex = 0;
            // 
            // lbxCustomersSelected
            // 
            this.lbxCustomersSelected.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCustomersSelected.FormattingEnabled = true;
            this.lbxCustomersSelected.ItemHeight = 20;
            this.lbxCustomersSelected.Location = new System.Drawing.Point(6, 21);
            this.lbxCustomersSelected.Name = "lbxCustomersSelected";
            this.lbxCustomersSelected.Size = new System.Drawing.Size(310, 424);
            this.lbxCustomersSelected.TabIndex = 4;
            // 
            // ttpAdd
            // 
            this.ttpAdd.Active = false;
            this.ttpAdd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpAdd.ToolTipTitle = "Information:";
            // 
            // ttpSave
            // 
            this.ttpSave.Active = false;
            this.ttpSave.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpSave.ToolTipTitle = "Information:";
            // 
            // ttpPrint
            // 
            this.ttpPrint.Active = false;
            this.ttpPrint.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpPrint.ToolTipTitle = "Information:";
            // 
            // ttpAddCustomer
            // 
            this.ttpAddCustomer.Active = false;
            this.ttpAddCustomer.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpAddCustomer.ToolTipTitle = "Information:";
            // 
            // ttpRemoveCustomer
            // 
            this.ttpRemoveCustomer.Active = false;
            this.ttpRemoveCustomer.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpRemoveCustomer.ToolTipTitle = "Information:";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // ttpRemove
            // 
            this.ttpRemove.Active = false;
            this.ttpRemove.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpRemove.ToolTipTitle = "Information:";
            // 
            // gbxCustomers
            // 
            this.gbxCustomers.Controls.Add(this.lbxCustomers);
            this.gbxCustomers.Controls.Add(this.pbxAdd);
            this.gbxCustomers.Controls.Add(this.pbxRemove);
            this.gbxCustomers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomers.Location = new System.Drawing.Point(12, 12);
            this.gbxCustomers.Name = "gbxCustomers";
            this.gbxCustomers.Size = new System.Drawing.Size(328, 490);
            this.gbxCustomers.TabIndex = 12;
            this.gbxCustomers.TabStop = false;
            this.gbxCustomers.Text = "Customers list";
            // 
            // gbxCustomersSelected
            // 
            this.gbxCustomersSelected.Controls.Add(this.lbxCustomersSelected);
            this.gbxCustomersSelected.Controls.Add(this.pbxSave);
            this.gbxCustomersSelected.Controls.Add(this.pbxPrint);
            this.gbxCustomersSelected.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomersSelected.Location = new System.Drawing.Point(445, 12);
            this.gbxCustomersSelected.Name = "gbxCustomersSelected";
            this.gbxCustomersSelected.Size = new System.Drawing.Size(322, 490);
            this.gbxCustomersSelected.TabIndex = 13;
            this.gbxCustomersSelected.TabStop = false;
            this.gbxCustomersSelected.Text = "Selected customers";
            // 
            // pbxSave
            // 
            this.pbxSave.Image = global::WindowsFormsApp.Properties.Resources.save_dark_32;
            this.pbxSave.Location = new System.Drawing.Point(136, 447);
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
            // pbxPrint
            // 
            this.pbxPrint.Image = global::WindowsFormsApp.Properties.Resources.print_dark_32;
            this.pbxPrint.Location = new System.Drawing.Point(181, 447);
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
            // pbxAdd
            // 
            this.pbxAdd.Image = global::WindowsFormsApp.Properties.Resources.add_dark_32;
            this.pbxAdd.Location = new System.Drawing.Point(124, 447);
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
            // pbxRemove
            // 
            this.pbxRemove.Image = global::WindowsFormsApp.Properties.Resources.delete_dark_32;
            this.pbxRemove.Location = new System.Drawing.Point(167, 447);
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
            // pbxAddCustomer
            // 
            this.pbxAddCustomer.Image = global::WindowsFormsApp.Properties.Resources.right_arrow_green_dark;
            this.pbxAddCustomer.Location = new System.Drawing.Point(346, 160);
            this.pbxAddCustomer.Name = "pbxAddCustomer";
            this.pbxAddCustomer.Size = new System.Drawing.Size(64, 64);
            this.pbxAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAddCustomer.TabIndex = 10;
            this.pbxAddCustomer.TabStop = false;
            this.ttpAddCustomer.SetToolTip(this.pbxAddCustomer, "Adds customer in selected customers list.");
            this.pbxAddCustomer.Click += new System.EventHandler(this.PbxAddCustomer_click);
            this.pbxAddCustomer.MouseLeave += new System.EventHandler(this.PbxAddCustomer_mouseLeave);
            this.pbxAddCustomer.MouseHover += new System.EventHandler(this.PbxAddCustomer_mouseHover);
            // 
            // pbxRemoveCustomer
            // 
            this.pbxRemoveCustomer.Image = global::WindowsFormsApp.Properties.Resources.left_arrow_red_dark;
            this.pbxRemoveCustomer.Location = new System.Drawing.Point(354, 274);
            this.pbxRemoveCustomer.Name = "pbxRemoveCustomer";
            this.pbxRemoveCustomer.Size = new System.Drawing.Size(64, 64);
            this.pbxRemoveCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxRemoveCustomer.TabIndex = 3;
            this.pbxRemoveCustomer.TabStop = false;
            this.ttpRemoveCustomer.SetToolTip(this.pbxRemoveCustomer, "Removes customer from selected customers list");
            this.pbxRemoveCustomer.Click += new System.EventHandler(this.PbxRemoveCustomer_click);
            this.pbxRemoveCustomer.MouseLeave += new System.EventHandler(this.PbxRemoveCustomer_mouseLeave);
            this.pbxRemoveCustomer.MouseHover += new System.EventHandler(this.PbxRemoveCustomer_mouseHover);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 513);
            this.Controls.Add(this.gbxCustomersSelected);
            this.Controls.Add(this.gbxCustomers);
            this.Controls.Add(this.pbxAddCustomer);
            this.Controls.Add(this.pbxRemoveCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer-Manager";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbxCustomers.ResumeLayout(false);
            this.gbxCustomers.PerformLayout();
            this.gbxCustomersSelected.ResumeLayout(false);
            this.gbxCustomersSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxRemoveCustomer;
        private System.Windows.Forms.ListBox lbxCustomersSelected;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxPrint;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip ttpAdd;
        private System.Windows.Forms.ToolTip ttpSave;
        private System.Windows.Forms.ToolTip ttpPrint;
        private System.Windows.Forms.ToolTip ttpAddCustomer;
        private System.Windows.Forms.ToolTip ttpRemoveCustomer;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PictureBox pbxAddCustomer;
        private System.Windows.Forms.PictureBox pbxRemove;
        private System.Windows.Forms.ToolTip ttpRemove;
        private System.Windows.Forms.GroupBox gbxCustomers;
        private System.Windows.Forms.GroupBox gbxCustomersSelected;
        public System.Windows.Forms.ListBox lbxCustomers;
    }
}
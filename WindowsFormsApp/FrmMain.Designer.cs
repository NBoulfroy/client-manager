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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.lbxCustomersSelected = new System.Windows.Forms.ListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxPrint = new System.Windows.Forms.PictureBox();
            this.pbxAddCustomer = new System.Windows.Forms.PictureBox();
            this.pbxRemoveCustomer = new System.Windows.Forms.PictureBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pbxRemove = new System.Windows.Forms.PictureBox();
            this.gbxCustomers = new System.Windows.Forms.GroupBox();
            this.gbxCustomersSelected = new System.Windows.Forms.GroupBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).BeginInit();
            this.gbxCustomers.SuspendLayout();
            this.gbxCustomersSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.ItemHeight = 17;
            this.lbxCustomers.Location = new System.Drawing.Point(4, 17);
            this.lbxCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(238, 344);
            this.lbxCustomers.TabIndex = 0;
            this.lbxCustomers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbxCustomers_mouseDoubleClick);
            // 
            // lbxCustomersSelected
            // 
            this.lbxCustomersSelected.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCustomersSelected.FormattingEnabled = true;
            this.lbxCustomersSelected.ItemHeight = 17;
            this.lbxCustomersSelected.Location = new System.Drawing.Point(4, 17);
            this.lbxCustomersSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxCustomersSelected.Name = "lbxCustomersSelected";
            this.lbxCustomersSelected.Size = new System.Drawing.Size(234, 344);
            this.lbxCustomersSelected.TabIndex = 4;
            this.lbxCustomersSelected.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbxCustomersSelected_mouseDoubleClick);
            // 
            // pbxAdd
            // 
            this.pbxAdd.Image = global::WindowsFormsApp.Properties.Resources.add_dark_32;
            this.pbxAdd.Location = new System.Drawing.Point(93, 363);
            this.pbxAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(32, 32);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAdd.TabIndex = 5;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.PbxAdd_click);
            this.pbxAdd.MouseLeave += new System.EventHandler(this.PbxAdd_mouseLeave);
            this.pbxAdd.MouseHover += new System.EventHandler(this.PbxAdd_mouseHover);
            // 
            // pbxSave
            // 
            this.pbxSave.Image = global::WindowsFormsApp.Properties.Resources.save_dark_32;
            this.pbxSave.Location = new System.Drawing.Point(102, 363);
            this.pbxSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(32, 32);
            this.pbxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxSave.TabIndex = 7;
            this.pbxSave.TabStop = false;
            this.pbxSave.Click += new System.EventHandler(this.PbxSave_click);
            this.pbxSave.MouseLeave += new System.EventHandler(this.PbxSave_mouseLeave);
            this.pbxSave.MouseHover += new System.EventHandler(this.PbxSave_mouseHover);
            // 
            // pbxPrint
            // 
            this.pbxPrint.Image = global::WindowsFormsApp.Properties.Resources.print_dark_32;
            this.pbxPrint.Location = new System.Drawing.Point(136, 363);
            this.pbxPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxPrint.Name = "pbxPrint";
            this.pbxPrint.Size = new System.Drawing.Size(32, 32);
            this.pbxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPrint.TabIndex = 6;
            this.pbxPrint.TabStop = false;
            this.pbxPrint.Click += new System.EventHandler(this.PbxPrint_click);
            this.pbxPrint.MouseLeave += new System.EventHandler(this.PbxPrint_mouseLeave);
            this.pbxPrint.MouseHover += new System.EventHandler(this.PbxPrint_mouseHover);
            // 
            // pbxAddCustomer
            // 
            this.pbxAddCustomer.Image = global::WindowsFormsApp.Properties.Resources.right_arrow_green_dark;
            this.pbxAddCustomer.Location = new System.Drawing.Point(260, 130);
            this.pbxAddCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxAddCustomer.Name = "pbxAddCustomer";
            this.pbxAddCustomer.Size = new System.Drawing.Size(64, 64);
            this.pbxAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAddCustomer.TabIndex = 10;
            this.pbxAddCustomer.TabStop = false;
            this.pbxAddCustomer.Click += new System.EventHandler(this.PbxAddCustomer_click);
            this.pbxAddCustomer.MouseLeave += new System.EventHandler(this.PbxAddCustomer_mouseLeave);
            this.pbxAddCustomer.MouseHover += new System.EventHandler(this.PbxAddCustomer_mouseHover);
            // 
            // pbxRemoveCustomer
            // 
            this.pbxRemoveCustomer.Image = global::WindowsFormsApp.Properties.Resources.left_arrow_red_dark;
            this.pbxRemoveCustomer.Location = new System.Drawing.Point(266, 223);
            this.pbxRemoveCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxRemoveCustomer.Name = "pbxRemoveCustomer";
            this.pbxRemoveCustomer.Size = new System.Drawing.Size(64, 64);
            this.pbxRemoveCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxRemoveCustomer.TabIndex = 3;
            this.pbxRemoveCustomer.TabStop = false;
            this.pbxRemoveCustomer.Click += new System.EventHandler(this.PbxRemoveCustomer_click);
            this.pbxRemoveCustomer.MouseLeave += new System.EventHandler(this.PbxRemoveCustomer_mouseLeave);
            this.pbxRemoveCustomer.MouseHover += new System.EventHandler(this.PbxRemoveCustomer_mouseHover);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // pbxRemove
            // 
            this.pbxRemove.Image = global::WindowsFormsApp.Properties.Resources.delete_dark_32;
            this.pbxRemove.Location = new System.Drawing.Point(125, 363);
            this.pbxRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxRemove.Name = "pbxRemove";
            this.pbxRemove.Size = new System.Drawing.Size(32, 32);
            this.pbxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxRemove.TabIndex = 11;
            this.pbxRemove.TabStop = false;
            this.pbxRemove.Click += new System.EventHandler(this.PbxRemove_click);
            this.pbxRemove.MouseLeave += new System.EventHandler(this.PbxRemove_mouseLeave);
            this.pbxRemove.MouseHover += new System.EventHandler(this.PbxRemove_mouseHover);
            // 
            // gbxCustomers
            // 
            this.gbxCustomers.Controls.Add(this.lbxCustomers);
            this.gbxCustomers.Controls.Add(this.pbxAdd);
            this.gbxCustomers.Controls.Add(this.pbxRemove);
            this.gbxCustomers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCustomers.Location = new System.Drawing.Point(9, 10);
            this.gbxCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCustomers.Name = "gbxCustomers";
            this.gbxCustomers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCustomers.Size = new System.Drawing.Size(246, 398);
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
            this.gbxCustomersSelected.Location = new System.Drawing.Point(334, 10);
            this.gbxCustomersSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCustomersSelected.Name = "gbxCustomersSelected";
            this.gbxCustomersSelected.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCustomersSelected.Size = new System.Drawing.Size(242, 398);
            this.gbxCustomersSelected.TabIndex = 13;
            this.gbxCustomersSelected.TabStop = false;
            this.gbxCustomersSelected.Text = "Selected customers";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 417);
            this.Controls.Add(this.gbxCustomersSelected);
            this.Controls.Add(this.gbxCustomers);
            this.Controls.Add(this.pbxAddCustomer);
            this.Controls.Add(this.pbxRemoveCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer-Manager";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).EndInit();
            this.gbxCustomers.ResumeLayout(false);
            this.gbxCustomers.PerformLayout();
            this.gbxCustomersSelected.ResumeLayout(false);
            this.gbxCustomersSelected.PerformLayout();
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
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PictureBox pbxAddCustomer;
        private System.Windows.Forms.PictureBox pbxRemove;
        private System.Windows.Forms.GroupBox gbxCustomers;
        private System.Windows.Forms.GroupBox gbxCustomersSelected;
        public System.Windows.Forms.ListBox lbxCustomers;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}
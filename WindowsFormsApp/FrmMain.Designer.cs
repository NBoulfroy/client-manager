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
            this.pbxAddCustomer = new System.Windows.Forms.PictureBox();
            this.pbxRemoveCustomer = new System.Windows.Forms.PictureBox();
            this.lbxCustomersSelected = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.ItemHeight = 16;
            this.lbxCustomers.Location = new System.Drawing.Point(12, 12);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(316, 420);
            this.lbxCustomers.TabIndex = 0;
            // 
            // pbxAddCustomer
            // 
            this.pbxAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbxAddCustomer.Image")));
            this.pbxAddCustomer.Location = new System.Drawing.Point(422, 111);
            this.pbxAddCustomer.Name = "pbxAddCustomer";
            this.pbxAddCustomer.Size = new System.Drawing.Size(100, 50);
            this.pbxAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAddCustomer.TabIndex = 2;
            this.pbxAddCustomer.TabStop = false;
            // 
            // pbxRemoveCustomer
            // 
            this.pbxRemoveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbxRemoveCustomer.Image")));
            this.pbxRemoveCustomer.Location = new System.Drawing.Point(422, 303);
            this.pbxRemoveCustomer.Name = "pbxRemoveCustomer";
            this.pbxRemoveCustomer.Size = new System.Drawing.Size(100, 50);
            this.pbxRemoveCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRemoveCustomer.TabIndex = 3;
            this.pbxRemoveCustomer.TabStop = false;
            // 
            // lbxCustomersSelected
            // 
            this.lbxCustomersSelected.FormattingEnabled = true;
            this.lbxCustomersSelected.ItemHeight = 16;
            this.lbxCustomersSelected.Location = new System.Drawing.Point(606, 12);
            this.lbxCustomersSelected.Name = "lbxCustomersSelected";
            this.lbxCustomersSelected.Size = new System.Drawing.Size(316, 420);
            this.lbxCustomersSelected.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 498);
            this.Controls.Add(this.lbxCustomersSelected);
            this.Controls.Add(this.pbxRemoveCustomer);
            this.Controls.Add(this.pbxAddCustomer);
            this.Controls.Add(this.lbxCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.PictureBox pbxAddCustomer;
        private System.Windows.Forms.PictureBox pbxRemoveCustomer;
        private System.Windows.Forms.ListBox lbxCustomersSelected;
    }
}
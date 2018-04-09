namespace WindowsFormsApp
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pbxAccept = new System.Windows.Forms.PictureBox();
            this.pbxCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(9, 28);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(400, 22);
            this.tbxLastName.TabIndex = 0;
            this.tbxLastName.TextChanged += new System.EventHandler(this.TbxVerification);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(9, 72);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(400, 22);
            this.tbxFirstName.TabIndex = 1;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.TbxVerification);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(7, 11);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(7, 54);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First name:";
            // 
            // pbxAccept
            // 
            this.pbxAccept.Image = global::WindowsFormsApp.Properties.Resources.accept_disabled_32;
            this.pbxAccept.Location = new System.Drawing.Point(354, 99);
            this.pbxAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxAccept.Name = "pbxAccept";
            this.pbxAccept.Size = new System.Drawing.Size(32, 32);
            this.pbxAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAccept.TabIndex = 5;
            this.pbxAccept.TabStop = false;
            this.pbxAccept.Click += new System.EventHandler(this.PbxAccept_click);
            this.pbxAccept.MouseLeave += new System.EventHandler(this.PbxAccept_mouseLeave);
            this.pbxAccept.MouseHover += new System.EventHandler(this.PbxAccept_mouseHover);
            // 
            // pbxCancel
            // 
            this.pbxCancel.Image = global::WindowsFormsApp.Properties.Resources.cancel_dark_32;
            this.pbxCancel.Location = new System.Drawing.Point(388, 99);
            this.pbxCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxCancel.Name = "pbxCancel";
            this.pbxCancel.Size = new System.Drawing.Size(32, 32);
            this.pbxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCancel.TabIndex = 4;
            this.pbxCancel.TabStop = false;
            this.pbxCancel.Click += new System.EventHandler(this.PbxCancel_click);
            this.pbxCancel.MouseLeave += new System.EventHandler(this.PbxCancel_mouseLeave);
            this.pbxCancel.MouseHover += new System.EventHandler(this.PbxCancel_mouseHover);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 132);
            this.Controls.Add(this.pbxAccept);
            this.Controls.Add(this.pbxCancel);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxLastName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer-Manager";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.PictureBox pbxCancel;
        private System.Windows.Forms.PictureBox pbxAccept;
    }
}
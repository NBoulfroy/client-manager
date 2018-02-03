﻿namespace WindowsFormsApp
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
            this.tbxLastName.Location = new System.Drawing.Point(12, 33);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(300, 22);
            this.tbxLastName.TabIndex = 0;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(12, 87);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(300, 22);
            this.tbxFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 13);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 17);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First name:";
            // 
            // pbxAccept
            // 
            this.pbxAccept.Location = new System.Drawing.Point(280, 115);
            this.pbxAccept.Name = "pbxAccept";
            this.pbxAccept.Size = new System.Drawing.Size(32, 32);
            this.pbxAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAccept.TabIndex = 4;
            this.pbxAccept.TabStop = false;
            this.pbxAccept.Click += new System.EventHandler(this.PbxAccept_click);
            // 
            // pbxCancel
            // 
            this.pbxCancel.Location = new System.Drawing.Point(235, 115);
            this.pbxCancel.Name = "pbxCancel";
            this.pbxCancel.Size = new System.Drawing.Size(32, 32);
            this.pbxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCancel.TabIndex = 5;
            this.pbxCancel.TabStop = false;
            this.pbxCancel.Click += new System.EventHandler(this.PbxCancel_click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 158);
            this.Controls.Add(this.pbxCancel);
            this.Controls.Add(this.pbxAccept);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxLastName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "customer-manager";
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
        private System.Windows.Forms.PictureBox pbxAccept;
        private System.Windows.Forms.PictureBox pbxCancel;
    }
}
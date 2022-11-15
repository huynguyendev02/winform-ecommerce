using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace WinFormsApp2
{
    partial class Register
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp122.Properties.Resources.hinhNen2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1027, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTelephone);
            this.panel1.Controls.Add(this.tbConfirmPass);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(246, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(555, 411);
            this.panel1.MinimumSize = new System.Drawing.Size(555, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 411);
            this.panel1.TabIndex = 1;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTelephone.Location = new System.Drawing.Point(95, 170);
            this.tbTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(378, 34);
            this.tbTelephone.TabIndex = 13;
            this.tbTelephone.Enter += new System.EventHandler(this.tbTelephone_Enter);
            this.tbTelephone.Leave += new System.EventHandler(this.tbTelephone_Leave);
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbConfirmPass.Location = new System.Drawing.Point(95, 296);
            this.tbConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.Size = new System.Drawing.Size(378, 34);
            this.tbConfirmPass.TabIndex = 12;
            this.tbConfirmPass.Enter += new System.EventHandler(this.tbConfirmPass_Enter);
            this.tbConfirmPass.Leave += new System.EventHandler(this.tbConfirmPass_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPassword.Location = new System.Drawing.Point(95, 255);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(378, 34);
            this.tbPassword.TabIndex = 11;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbUserName.Location = new System.Drawing.Point(95, 214);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(378, 34);
            this.tbUserName.TabIndex = 10;
            this.tbUserName.Enter += new System.EventHandler(this.tbUserName_Enter);
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbLastName.Location = new System.Drawing.Point(95, 130);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(378, 34);
            this.tbLastName.TabIndex = 6;
            this.tbLastName.Enter += new System.EventHandler(this.tbLastName_Enter);
            this.tbLastName.Leave += new System.EventHandler(this.tbLastName_Leave);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btLogin.ForeColor = System.Drawing.Color.Black;
            this.btLogin.Location = new System.Drawing.Point(95, 350);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(378, 35);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Register";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbFirstName.Location = new System.Drawing.Point(95, 91);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(378, 34);
            this.tbFirstName.TabIndex = 3;
            this.tbFirstName.Enter += new System.EventHandler(this.tbFirstName_Enter);
            this.tbFirstName.Leave += new System.EventHandler(this.tbFirstName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(181, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox tbFirstName;
        private TextBox tbConfirmPass;
        private TextBox tbPassword;
        private TextBox tbUserName;
        private TextBox tbLastName;
        private Button btLogin;
        private TextBox tbTelephone;
    }
}
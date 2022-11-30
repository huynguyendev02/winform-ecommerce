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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lb4 = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lb5 = new System.Windows.Forms.Label();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lb6 = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbUserName.Location = new System.Drawing.Point(23, 35);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(548, 27);
            this.tbUserName.TabIndex = 12;
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave_1);
            // 
            // tbFirstname
            // 
            this.tbFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbFirstname.Location = new System.Drawing.Point(23, 35);
            this.tbFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(548, 27);
            this.tbFirstname.TabIndex = 11;
            this.tbFirstname.Enter += new System.EventHandler(this.tbFirstname_Enter_1);
            this.tbFirstname.Leave += new System.EventHandler(this.tbFirstname_Leave_1);
            // 
            // tbLastName
            // 
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbLastName.Location = new System.Drawing.Point(23, 35);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(548, 27);
            this.tbLastName.TabIndex = 10;
            this.tbLastName.Leave += new System.EventHandler(this.tbLastName_Leave_1);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPassword.Location = new System.Drawing.Point(23, 35);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(548, 27);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave_1);
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbConfirmPass.Location = new System.Drawing.Point(23, 35);
            this.tbConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.PasswordChar = '*';
            this.tbConfirmPass.Size = new System.Drawing.Size(548, 27);
            this.tbConfirmPass.TabIndex = 3;
            this.tbConfirmPass.Leave += new System.EventHandler(this.tbConfirmPass_Leave_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb1);
            this.panel2.Controls.Add(this.lbFirstName);
            this.panel2.Controls.Add(this.tbFirstname);
            this.panel2.Location = new System.Drawing.Point(477, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 79);
            this.panel2.TabIndex = 20;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lb1.ForeColor = System.Drawing.Color.Red;
            this.lb1.Location = new System.Drawing.Point(499, 12);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 21);
            this.lb1.TabIndex = 15;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lbFirstName.ForeColor = System.Drawing.Color.Black;
            this.lbFirstName.Location = new System.Drawing.Point(19, 12);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(85, 21);
            this.lbFirstName.TabIndex = 14;
            this.lbFirstName.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(1414, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sign up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(41, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 1);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apple ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp122.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(652, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lbUsername.ForeColor = System.Drawing.Color.Black;
            this.lbUsername.Location = new System.Drawing.Point(19, 12);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(80, 21);
            this.lbUsername.TabIndex = 14;
            this.lbUsername.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lb3);
            this.panel3.Controls.Add(this.lbUsername);
            this.panel3.Controls.Add(this.tbUserName);
            this.panel3.Location = new System.Drawing.Point(477, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 79);
            this.panel3.TabIndex = 21;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lb3.ForeColor = System.Drawing.Color.Red;
            this.lb3.Location = new System.Drawing.Point(499, 12);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(0, 21);
            this.lb3.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lb4);
            this.panel6.Controls.Add(this.lbPassword);
            this.panel6.Controls.Add(this.tbPassword);
            this.panel6.Location = new System.Drawing.Point(477, 525);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(596, 79);
            this.panel6.TabIndex = 23;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lb4.ForeColor = System.Drawing.Color.Red;
            this.lb4.Location = new System.Drawing.Point(499, 12);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(0, 21);
            this.lb4.TabIndex = 27;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lbPassword.ForeColor = System.Drawing.Color.Black;
            this.lbPassword.Location = new System.Drawing.Point(19, 12);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 21);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "Password";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lb5);
            this.panel7.Controls.Add(this.lbConfirm);
            this.panel7.Controls.Add(this.tbConfirmPass);
            this.panel7.Location = new System.Drawing.Point(477, 603);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(596, 79);
            this.panel7.TabIndex = 24;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lb5.ForeColor = System.Drawing.Color.Red;
            this.lb5.Location = new System.Drawing.Point(499, 12);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(0, 21);
            this.lb5.TabIndex = 27;
            // 
            // lbConfirm
            // 
            this.lbConfirm.AutoSize = true;
            this.lbConfirm.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lbConfirm.ForeColor = System.Drawing.Color.Black;
            this.lbConfirm.Location = new System.Drawing.Point(19, 12);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(136, 21);
            this.lbConfirm.TabIndex = 14;
            this.lbConfirm.Text = "Confirm password";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lb6);
            this.panel8.Controls.Add(this.lbTelephone);
            this.panel8.Controls.Add(this.tbTelephone);
            this.panel8.Location = new System.Drawing.Point(477, 681);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(596, 79);
            this.panel8.TabIndex = 25;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lb6.ForeColor = System.Drawing.Color.Red;
            this.lb6.Location = new System.Drawing.Point(499, 12);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(14, 21);
            this.lb6.TabIndex = 27;
            this.lb6.Text = " ";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lbTelephone.ForeColor = System.Drawing.Color.Black;
            this.lbTelephone.Location = new System.Drawing.Point(19, 12);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(140, 21);
            this.lbTelephone.TabIndex = 14;
            this.lbTelephone.Text = "Telephone Number";
            // 
            // tbTelephone
            // 
            this.tbTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelephone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTelephone.Location = new System.Drawing.Point(23, 35);
            this.tbTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(548, 27);
            this.tbTelephone.TabIndex = 13;
            this.tbTelephone.Leave += new System.EventHandler(this.tbTelephone_Leave_1);
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lbLastName.ForeColor = System.Drawing.Color.Black;
            this.lbLastName.Location = new System.Drawing.Point(19, 12);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(82, 21);
            this.lbLastName.TabIndex = 14;
            this.lbLastName.Text = "Last Name";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lb2);
            this.panel5.Controls.Add(this.lbLastName);
            this.panel5.Controls.Add(this.tbLastName);
            this.panel5.Location = new System.Drawing.Point(477, 369);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(596, 79);
            this.panel5.TabIndex = 21;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lb2.ForeColor = System.Drawing.Color.Red;
            this.lb2.Location = new System.Drawing.Point(499, 12);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(0, 21);
            this.lb2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(618, 792);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Already have an account? Sign in";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbConfirmPass;
        private TextBox tbUserName;
        private TextBox tbFirstname;
        private TextBox tbLastName;
        private TextBox tbPassword;
        private Panel panel2;
        private Label lbFirstName;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lbUsername;
        private Panel panel3;
        private Panel panel6;
        private Label lbPassword;
        private Panel panel7;
        private Label lbConfirm;
        private Panel panel8;
        private Label lbTelephone;
        private TextBox tbTelephone;
        private Label lbLastName;
        private Panel panel5;
        private Label label6;
        private Label lb1;
        private Label lb3;
        private Label lb4;
        private Label lb5;
        private Label lb6;
        private Label lb2;
    }
}
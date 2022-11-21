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
using WindowsFormsApp122;
using WindowsFormsApp122.FormFunction;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form fr = new Register();
            fr.ShowDialog();
        }

        private void sparklineEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkGray;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (tbUser.Text == "")
            {
                lb1.Text = "Required";
                check = false;
            } 
            else 
            {
                lb1.Text = "";
                check = true;
            }
            if (tbPass.Text == "") 
            {
                lb2.Text = "Required";
                check = false;
            }
            else
            {
                lb2.Text = "";
                check = true;
            }
            if (check)
            {
                if (LoginFunction.checkLoginCredential(tbUser.Text, tbPass.Text) == 0)
                    MessageBox.Show("Invalid Credential, Please Corret", "Error");
                if (LoginFunction.checkLoginCredential(tbUser.Text, tbPass.Text) == 1)
                {
                    Form form = new Admin();
                    this.Hide();
                    form.Show();
                }
                if (LoginFunction.checkLoginCredential(tbUser.Text, tbPass.Text) == 2)
                {
                    Form form = new UserForm();
                    form.Show();
                    tbUser.Clear();
                    tbPass.Clear();
                  
                }
            }
        }
    }
}
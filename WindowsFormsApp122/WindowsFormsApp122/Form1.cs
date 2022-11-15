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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbUser.Focus();
            tbPass.Text = "Please Enter Password";
            tbPass.ForeColor = Color.Gray;
            tbPass.PasswordChar = '\0';
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
            {
                tbUser.Text = "Please Enter Name";
                tbUser.ForeColor = Color.Gray;
            }
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            if (tbUser.Text == "Please Enter Name")
            {
                tbUser.Text = "";
                tbUser.ForeColor = Color.Black;
            }
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.PasswordChar = '\0';
                tbPass.Text = "Please Enter Password";
                tbPass.ForeColor = Color.Gray;     
            }
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == "Please Enter Password")
            {
                tbPass.PasswordChar = '*';
                tbPass.Text = "";
                tbPass.ForeColor = Color.Black;
            }
        }
    }
}
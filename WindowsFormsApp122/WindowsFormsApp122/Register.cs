using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            tbFirstName.Focus();
            tbLastName.Text = "Please Enter Your Last Name";
            tbLastName.ForeColor = Color.Gray;
            tbTelephone.Text = "Please Enter Your Telephone Number";
            tbTelephone.ForeColor = Color.Gray;
            tbUserName.Text = "Please Enter Your UserName";
            tbUserName.ForeColor = Color.Gray;
            tbPassword.Text = "Please Enter Your Password";
            tbPassword.ForeColor = Color.Gray;
            tbConfirmPass.Text = "Please Confirm Your Password";
            tbConfirmPass.ForeColor = Color.Gray;
        }

        private void tbFirstName_Leave(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "")
            {
                tbFirstName.Text = "Please Enter Your First Name";
                tbFirstName.ForeColor = Color.Gray;
            }
        }

        private void tbFirstName_Enter(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "Please Enter Your First Name")
            {
                tbFirstName.Text = "";
                tbFirstName.ForeColor = Color.Black;
            }
        }

        private void tbLastName_Leave(object sender, EventArgs e)
        {
            if (tbLastName.Text == "")
            {
                tbLastName.Text = "Please Enter Your Last Name";
                tbLastName.ForeColor = Color.Gray;
            }
        }

        private void tbLastName_Enter(object sender, EventArgs e)
        {
            if (tbLastName.Text == "Please Enter Your Last Name")
            {
                tbLastName.Text = "";
                tbLastName.ForeColor = Color.Black;
            }
        }

        private void tbTelephone_Leave(object sender, EventArgs e)
        {
            if (tbTelephone.Text == "")
            {
                tbTelephone.Text = "Please Enter Your Telephone Number";
                tbTelephone.ForeColor = Color.Gray;
            }
        }

        private void tbTelephone_Enter(object sender, EventArgs e)
        {
            if (tbTelephone.Text == "Please Enter Your Telephone Number")
            {
                tbTelephone.Text = "";
                tbTelephone.ForeColor = Color.Black;
            }
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                tbUserName.Text = "Please Enter Your UserName";
                tbUserName.ForeColor = Color.Gray;
            }
        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "Please Enter Your UserName")
            {
                tbUserName.Text = "";
                tbUserName.ForeColor = Color.Black;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if(tbPassword.Text == "")
            {
                tbPassword.PasswordChar = '\0';
                tbPassword.Text = "Please Enter Your Password";
                tbPassword.ForeColor = Color.Gray;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Please Enter Your Password")
            {
                tbPassword.PasswordChar = '*';
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
            }
        }

        private void tbConfirmPass_Leave(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text == "")
            {
                tbConfirmPass.PasswordChar = '\0';
                tbConfirmPass.Text = "Please Confirm Your Password";
                tbConfirmPass.ForeColor = Color.Gray;
            }
        }

        private void tbConfirmPass_Enter(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text == "Please Confirm Your Password")
            {
                tbConfirmPass.PasswordChar = '*';
                tbConfirmPass.Text = "";
                tbConfirmPass.ForeColor = Color.Black;
            }
        }
    }
}

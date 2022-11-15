using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;

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
           tbConfirmPass.Focus();
        }

        private void tbFirstName_Leave(object sender, EventArgs e)
        {
        }

        private void tbFirstName_Enter(object sender, EventArgs e)
        {
        }

        private void tbLastName_Leave(object sender, EventArgs e)
        {
        }

        private void tbLastName_Enter(object sender, EventArgs e)
        {         
        }

        private void tbTelephone_Leave(object sender, EventArgs e)
        {
        }

        private void tbTelephone_Enter(object sender, EventArgs e)
        {
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
        }

        private void tbConfirmPass_Leave(object sender, EventArgs e)
        {
        }

        private void tbConfirmPass_Enter(object sender, EventArgs e)
        {
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            lbTelephone.ForeColor = Color.Black;
            
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            lbTelephone.ForeColor = Color.DarkGray;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (tbFirstname.Text == "")
            {
                lb1.Text = "Required";
                check = false;
            }
            else
            {
                lb1.Text = "";
                check = true;
            }
            if (tbLastName.Text == "")
            {
                lb2.Text = "Required";
                check = false;
            }
            else
            {
                lb2.Text = "";
                check = true;
            }
            if (tbUserName.Text == "")
            {
                lb3.Text = "Required";
                check = false;
            }
            else
            {
                lb3.Text = "";
                check = true;
            }
            if (tbPassword.Text == "")
            {
                lb4.Text = "Required";
                check = false;
            }
            else
            {
                lb4.Text = "";
                check = true;
            }
            if (tbConfirmPass.Text == "")
            {
                lb5.Text = "Required";
                check = false;
            }
            else
            {
                lb5.Text = "";
                check = true;
                if (tbPassword.Text!=tbConfirmPass.Text)
                {
                    lb5.Text = "Incorrect";
                    check=false;
                }
            }
            int telephone = 0;
            if (tbTelephone.Text == "")
            {
                lb6.Text = "Required";
                check = false;
                
            }
            else
            {
                lb6.Text = "";
                try
                {
                    telephone = Int32.Parse(tbTelephone.Text);
                    check = true;
                }
                catch
                {
                    lb6.Text = "Invalid Tel";
                    check = false;
                };
            }
        
            if (check)
            {
                RegisterFunction.Register(tbFirstname.Text, tbLastName.Text, tbUserName.Text, tbPassword.Text, telephone);
                MessageBox.Show("Congratulations, your account has been successfully created.", "Notify");
                this.Close();
            }
            
        }

        private void tbFirstname_Enter_1(object sender, EventArgs e)
        {

        }

        private void tbFirstname_Leave_1(object sender, EventArgs e)
        {

        }

        private void tbLastName_Leave_1(object sender, EventArgs e)
        {
           
        }

        private void tbUserName_Leave_1(object sender, EventArgs e)
        {
           
        }

        private void tbPassword_Leave_1(object sender, EventArgs e)
        {
          
        }

        private void tbConfirmPass_Leave_1(object sender, EventArgs e)
        {
          
        }

        private void tbTelephone_Leave_1(object sender, EventArgs e)
        {
           
        }
    }
}

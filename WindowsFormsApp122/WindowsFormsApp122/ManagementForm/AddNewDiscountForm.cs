using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp122.ManagementForm
{
    public partial class AddNewDiscountForm : Form
    {
        public AddNewDiscountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            if (button1.Text == "On")
            {
                button1.BackColor = Color.Red;
                button1.Text = "Off";
            } 
            else
            {
                button1.BackColor = Color.Green;
                button1.Text = "On";
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseProductForDiscount yeah = new ChooseProductForDiscount();
            yeah.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewDiscountForm_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.Text = "Off";
        }
    }
}

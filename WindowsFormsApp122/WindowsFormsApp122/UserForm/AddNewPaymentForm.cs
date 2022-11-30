using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.Controllers.Draw;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.UserForm
{
    public partial class AddNewPaymentForm : Form
    {
        public AddNewPaymentForm()
        {
            InitializeComponent();
        }

        private void AddNewPaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserFunction.addUserPaymentInfo(MainForm.getUserID(), tbType.Text, tbProvider.Text, Int32.Parse(tbAccount.Text), DateTime.Parse(tbExp.Text));
            MessageBox.Show("Your payment will be added in the next time", "Add successfully");
            this.Close();
        }   
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.Controllers.DrawManagement;

namespace WindowsFormsApp122.ManagementForm
{
    public partial class ChooseProductForDiscount : Form
    {
        public ChooseProductForDiscount()
        {
            InitializeComponent();
        }
        public void GetData(int proID, string name, string cost, int status, int discountID)
        {
            ListProdcutsInDiscount yeah = new ListProdcutsInDiscount(proID,name, cost, status, discountID);
            yeah.Draw(panel2);
        }

        private void ChooseProductForDiscount_Load(object sender, EventArgs e)
        {

        }

        private void lbCost_Click(object sender, EventArgs e)
        {

        }
    }
}

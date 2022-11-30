using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp122.FormFunction;
using WindowsFormsApp122.UserForm;

namespace WindowsFormsApp122.Controllers.DrawManagement
{
    internal class ListProdcutsInDiscount
    {
        Label lbName = new Label(), lbCost = new Label();
        Label[] allLabel;
        Button btStatus = new Button();
        int status;
        int proID;
        int discountID;
        public ListProdcutsInDiscount(int proID, string name, string cost, int status, int discountID)
        {
            this.proID = proID;
            this.discountID = discountID;
            this.lbName.Text = name;
            this.lbCost.Text = "$"+cost;
            this.status = status;
        }
        public void Draw(Panel parent)
        {
            Panel pn = new Panel();
            parent.Controls.Add(pn);
            pn.Size = new Size(866, 100);
            pn.Dock = DockStyle.Top;
            pn.Location = new Point(0, 0);
            pn.BackColor = Color.White;
            pn.BorderStyle = BorderStyle.FixedSingle;


            allLabel = new Label[] { lbName, lbCost };
            int count = 0;
            foreach (var lb in allLabel)
            {
                pn.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
                count++;
            }
            lbName.Size = new Size(200, 24);
            lbName.Location = new Point(45, 24);
            lbCost.Location = new Point(330, 24);


            pn.Controls.Add(btStatus);
            btStatus.Size = new Size(50, 30);
            btStatus.Font = new Font("Calibri Light", 12, FontStyle.Bold);
            btStatus.ForeColor = Color.White;
            btStatus.Location = new Point(595, 24);
            if (status == 0)
            {
                btStatus.Text = "Off";
                btStatus.BackColor = Color.Red;
            }
            else
            {
                btStatus.Text = "On";
                btStatus.BackColor = Color.Green;
            }
            btStatus.Click += BtStatus_Click;
        }

        private void BtStatus_Click(object sender, EventArgs e)
        {
            Button bt = (sender as Button);
            if (bt.Text == "On")
            {
                btStatus.Text = "Off";
                btStatus.BackColor = Color.Red;
                status = 0;
                DiscountFunction.alterProductToDiscount(discountID, proID, 0);
            }
            else
            {
                btStatus.Text = "On";
                btStatus.BackColor = Color.Green;
                status = 1;
                DiscountFunction.alterProductToDiscount(discountID, proID, 1);

            }
        }
    }
}

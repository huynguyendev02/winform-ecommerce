using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.Controllers.Draw
{
    internal class DrawCartController
    {
        string name;
        int id, price, count;

        MainForm parent;
        public DrawCartController(string name, int price, int id, int count, MainForm parent)
        {
            this.parent = parent;
            this.count = count;
            Name = name;
            Price = price;
            Id = id;
        }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Id { get => id; set => id = value; }

        public void Draw(Panel parent)
        {

            Panel pn = new Panel();
            pn.Size = new Size(866, 100);
            pn.Dock = DockStyle.Top;
            pn.Location = new Point(0, Price * 100);
            pn.BackColor = Color.White;
            pn.BorderStyle = BorderStyle.FixedSingle;
            parent.Controls.Add(pn);


            Label lbNameProduct = new Label();
            Button btIncrease = new Button();
            Label lbCount = new Label();
            Button btDecrease = new Button();
            Label lbPrice = new Label();
            Label lbRemove = new Label();

            pn.Controls.Add(lbNameProduct);
            pn.Controls.Add(btIncrease);
            pn.Controls.Add(lbCount);
            pn.Controls.Add(btDecrease);
            pn.Controls.Add(lbPrice);
            pn.Controls.Add(lbRemove);

            lbNameProduct.Text = Name;
            btIncrease.Text = "+";
            lbCount.Text = count.ToString();
            btDecrease.Text = "-";
            lbPrice.Text = "$" + Price.ToString();
            lbRemove.Text = "Remove";

            lbNameProduct.Size = new Size(400, 30);
            btIncrease.Size = new Size(30, 30);
            lbCount.Size = new Size(40, 30);
            btDecrease.Size = new Size(30, 30);

            btIncrease.FlatStyle = FlatStyle.Flat;
            btIncrease.FlatAppearance.BorderSize = 0;
            btDecrease.FlatStyle = FlatStyle.Flat;
            btDecrease.FlatAppearance.BorderSize = 0;

            btIncrease.TextAlign = ContentAlignment.TopCenter;
            btDecrease.TextAlign = ContentAlignment.TopCenter;

            lbNameProduct.Font = new Font("Calibri Light", 17, FontStyle.Bold);
            btIncrease.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            lbCount.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            btDecrease.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            lbPrice.Font = new Font("Calibri Light", 17, FontStyle.Bold);
            lbRemove.Font = new Font("Calibri Light", 10, FontStyle.Bold);
            lbRemove.ForeColor = Color.Red;


            lbNameProduct.Location = new Point(30, 38);
            btIncrease.Location = new Point(500, lbNameProduct.Location.Y - 5);
            lbCount.Location = new Point(540, lbNameProduct.Location.Y);
            btDecrease.Location = new Point(580, lbNameProduct.Location.Y - 5);
            lbPrice.Location = new Point(750, 25);
            lbRemove.Location = new Point(750, 55);

            btDecrease.Click += BtDecrease_Click;
            btIncrease.Click += BtIncrease_Click;
            lbRemove.Click += LbRemove_Click;
        }

        private void LbRemove_Click(object sender, EventArgs e)
        {
            CartFunction.removeItem(this.id,this.count, SessionFunction.getIdCurrentSession(MainForm.getUserID()));
            parent.panelClick(sender, e, 2);
        }

        private void BtIncrease_Click(object sender, EventArgs e)
        {
            CartFunction.alterQuantityItem(this.id, this.count+1,SessionFunction.getIdCurrentSession(MainForm.getUserID()));
            parent.panelClick(sender, e, 2);
        }

        private void BtDecrease_Click(object sender, EventArgs e)
        {
            if (count == 1)
                LbRemove_Click(sender, e);
            else
            {
                CartFunction.alterQuantityItem(this.id, this.count - 1, SessionFunction.getIdCurrentSession(MainForm.getUserID()));
                parent.panelClick(sender, e, 2);
            }
          
        }
    }
}

using DevExpress.XtraEditors.Senders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp122.FormFunction;
using WindowsFormsApp122.ManagementForm;
using WindowsFormsApp122.UserForm;

namespace WindowsFormsApp122.Controllers.DrawManagement
{
    internal class DrawDiscount
    {
        TextBox tbName = new TextBox(), tbDesc = new TextBox(), tbPercent = new TextBox();
        TextBox[] allTextBox;
        Button edit = new Button(), add = new Button();

        int index, ID, state, idDiscount;
        public DrawDiscount(string name, string desc, decimal? percent, int state, int idDiscount)
        {
            tbName.Text = name;
            tbDesc.Text = desc;
            tbPercent.Text = (percent).ToString() + "%";
            this.state = state;

            this.idDiscount = idDiscount;
        }
        public void Draw(Panel parent)
        {
            Panel pn = new Panel();
            parent.Controls.Add(pn);

            pn.Size = new Size(866, 100);
            pn.Dock = DockStyle.Top;
            pn.Location = new Point(0, index * 100);
            pn.BackColor = Color.White;
            pn.BorderStyle = BorderStyle.FixedSingle;


            allTextBox = new TextBox[] { tbName, tbDesc, tbPercent };
            int count = 0;
            foreach (var lb in allTextBox)
            {
                pn.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
                lb.Size = new Size(150, 30);
                lb.Location = new Point(20 + count * 190, 30);
                lb.ReadOnly = true;
                lb.BorderStyle = BorderStyle.None;
                lb.BackColor = Color.White;
                count++;
            }
            tbName.Size = new Size(180, 30);
            tbDesc.Size = new Size(200, 30);
            tbPercent.Location = new Point(480, 30);
            tbPercent.Size = new Size(40, 20);
            Button btSate = new Button();
            pn.Controls.Add(btSate);
            btSate.Visible = true;
            btSate.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            btSate.ForeColor = Color.White;
            btSate.Size = new Size(60, 35);
            btSate.Location = new Point(590, 30);
            if (state == 0)
            {
                btSate.Text = "Off";
                btSate.BackColor = Color.Red;
            }
            else
            {
                btSate.Text = "On";
                btSate.BackColor = Color.Green;
            }
            btSate.Click += BtSate_Click;

            pn.Controls.Add(add);
            add.Size = new Size(110, 35);
            add.Text = "AddProduct";
            add.Font = new Font("Calibri Light", 12, FontStyle.Bold);
            add.Location = new Point(720, 15);
            add.Click += Add_Click;

            pn.Controls.Add(edit);
            edit.Size = new Size(110, 35);
            edit.Text = "Edit";
            edit.Font = new Font("Calibri Light", 12, FontStyle.Bold);
            edit.ForeColor = Color.White;
            edit.BackColor = Color.Blue;
            edit.Location = new Point(720, 55);
            edit.Click += Edit_Click;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Button bt = (sender as Button);
            if (bt.Text == "Edit")
            {
                foreach (TextBox tb in allTextBox)
                {
                    tb.ReadOnly = false;
                    tb.BorderStyle = BorderStyle.FixedSingle;
                }
                bt.Text = "Save";
                bt.BackColor = Color.Green;
            }
            else
            {
                DiscountFunction.alterDiscount(this.idDiscount, tbName.Text, tbDesc.Text, Decimal.Parse(tbPercent.Text.Split('%')[0]));
                foreach (TextBox tb in allTextBox)
                {
                    tb.ReadOnly = true;
                    tb.BorderStyle = BorderStyle.None;
                }
                bt.Text = "Edit";
                bt.BackColor = Color.Blue;
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            ChooseProductForDiscount yeah = new ChooseProductForDiscount();
            yeah.Show();
            var products = ProductFunction.listAllProducts();
            foreach(var pro in products)
            {
                yeah.GetData(pro.id, pro.name_product, pro.price.ToString(), pro.discountState, this.idDiscount);

            }
        }

        private void BtSate_Click(object sender, EventArgs e)
        {
            Button bt = (sender as Button);
            if (state == 0)
            {
                bt.Text = "On";
                bt.BackColor = Color.Green;
                state = 1;
                DiscountFunction.changeStateDiscount(this.idDiscount, 1);
            }
            else
            {
                bt.Text = "Off";
                bt.BackColor = Color.Red;
                state = 0;
                DiscountFunction.changeStateDiscount(this.idDiscount, 0);
            }
        }

        public void View_Click(object sender, EventArgs e)
        {
            ID = 0;
            FormDetailMyOrder yeah = new FormDetailMyOrder(ID);
            yeah.Show();
        }
    }
}

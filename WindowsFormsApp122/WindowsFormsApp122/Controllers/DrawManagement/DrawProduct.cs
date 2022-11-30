using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.Controllers.DrawManagement
{
    public class DrawProduct
    {
        private PictureBox pic;
        private ManagementForm.ManagerForm parent;
        Label lbName = new Label(), lbDesc = new Label(), lbCategory = new Label(), lbInvestory = new Label(), lbCost = new Label(), lbImg = new Label(), lbState = new Label();
        Label[] allLabel;
        TextBox tbName = new TextBox(), tbDesc = new TextBox(), tbCategory = new TextBox(), tbInvestory = new TextBox(), tbCost = new TextBox(), tbImg = new TextBox();
        TextBox[] allTb;
        Button btEdit = new Button();
        Button btSate = new Button();
        int id, state,invenID;

        public DrawProduct(PictureBox itemPic, string tbName, string tbDesc, string tbCategory, string tbInvestory, string tbCost, string url, int State, int id,int invenID, ManagementForm.ManagerForm parent)
        {
            this.pic = itemPic;
            this.tbName.Text = tbName;
            this.tbDesc.Text = tbDesc;
            this.tbCategory.Text = tbCategory;
            this.tbInvestory.Text = tbInvestory;
            this.tbCost.Text = "$" + tbCost;
            this.tbImg.Text = url;
            this.state = State;

            this.id = id;
            this.invenID = invenID;
            this.parent = parent;
        }
        public void DrawProducts(Panel parent, int index)
        {
            Panel itemPanel = new Panel();
            itemPanel.Size = new Size(845, 495);
            int toaDoY = 1;

            lbName.Text = "Name:";
            lbDesc.Text = "Desc:";
            lbCategory.Text = "Category:";
            lbInvestory.Text = "Quantity:";
            lbCost.Text = "Cost:";
            lbImg.Text = "URL:";
            lbState.Text = "State:";
            allLabel = new Label[] { lbName, lbDesc, lbCategory, lbInvestory, lbCost, lbImg, lbState };
            foreach (Label lb in allLabel)
            {
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.BackColor = Color.White;
                lb.Parent = pic;
                pic.Controls.Add(lb);
                lb.Location = new Point(20, 20 + toaDoY * 50);
                toaDoY++;
            }

            allTb = new TextBox[] { tbName, tbDesc, tbCategory, tbInvestory, tbCost, tbImg };
            toaDoY = 1;
            foreach (TextBox tb in allTb)
            {
                tb.BackColor = Color.White;
                tb.Size = new Size(200, 50);
                tb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                tb.Parent = pic;
                pic.Controls.Add(tb);
                tb.ReadOnly = true;
                tb.BorderStyle = BorderStyle.None;
                tb.Location = new Point(130, 20 + toaDoY * 50);
                toaDoY++;
            }

            btEdit.BackColor = Color.Blue;
            btEdit.Size = new Size(90, 30);
            btEdit.Text = "Edit";
            btEdit.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            btEdit.ForeColor = Color.White;
            btEdit.Location = new Point(20, 430);
            btEdit.Parent = pic;
            btEdit.FlatStyle = FlatStyle.Flat;
            btEdit.FlatAppearance.BorderSize = 0;
            btEdit.Click += BtEdit_Click;

            btSate.Size = new Size(60, 28);

            if (state == 1)
            {
                btSate.Text = "On";
                btSate.BackColor = Color.Green;

            }
            else
            {
                btSate.Text = "Off";
                btSate.BackColor = Color.Red;
            }
            btSate.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            btSate.ForeColor = Color.White;
            btSate.Location = new Point(127, 370);
            btSate.Parent = pic;
            btSate.FlatStyle = FlatStyle.Flat;
            btSate.FlatAppearance.BorderSize = 0;
            btSate.Click += BtSate_Click;

            itemPanel.Controls.Add(pic);
            pic.Size = new Size(itemPanel.Size.Width, itemPanel.Size.Height);
            pic.Dock = DockStyle.Fill;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Controls.Add(btEdit);

            parent.Controls.Add(itemPanel);
            itemPanel.BackColor = Color.DarkGray;
            itemPanel.Location = new Point(0, (index - 1) * 495);

        }

        private void BtSate_Click(object sender, EventArgs e)
        {
            Button bt = (sender as Button);
            if (bt.Text == "On")
            {
                state = 0;
                ProductFunction.changeStateProduct(this.id, state);
                bt.Text = "Off";
                bt.BackColor = Color.Red;
                return;
            }
            else
            {
                state = 1;
                ProductFunction.changeStateProduct(this.id, state);
                bt.Text = "On";
                bt.BackColor = Color.Green;
                return;
            }
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            Button bt = (sender as Button);
            if (bt.Text == "Edit")
            {
                bt.Text = "Save";
                bt.BackColor = Color.Green;
                foreach (TextBox tb in allTb)
                {
                    if (tb != tbCategory)
                    {
                        tb.ReadOnly = false;
                        tb.BorderStyle = BorderStyle.FixedSingle;
                    }

                }
                return;
            }
            else
            {
                foreach (TextBox tb in allTb)
                {
                    tb.ReadOnly = true;
                    bt.Text = "Edit";
                    bt.BackColor = Color.Blue;
                    tb.BorderStyle = BorderStyle.None;
                }
                ProductFunction.alterProduct(this.id, tbName.Text, tbDesc.Text, invenID, Int32.Parse(tbInvestory.Text), decimal.Parse(tbCost.Text.Split('$')[1]), tbImg.Text);
                return;
            }
        }
    }
}

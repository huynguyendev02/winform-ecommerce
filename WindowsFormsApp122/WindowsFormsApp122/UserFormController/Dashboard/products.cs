using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp122.UserFormController.Dashboard
{
    internal class products
    {
        private PictureBox pic;
        private string itemName;
        private string itemCost;
        private string itemDesc;
        private int count;
        public products()
        {
        }
        public products(PictureBox itemPic, string itemName, string itemCost, string itemDesc)
        {
            this.Pic = itemPic;
            this.ItemName = itemName;
            this.ItemCost = itemCost;
            this.itemDesc= itemDesc;
        }

        public PictureBox Pic { get => pic; set => pic = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public string ItemCost { get => itemCost; set => itemCost = value; }

        public void DrawProducts(Panel parent, int index)
        {
            Panel itemPanel = new Panel();
            itemPanel.Size = new Size(845, 495);

            Label labelName = new Label();
            Label labelCost = new Label();
            Label labelDesc= new Label();
            Label labelNew = new Label();
            labelName.Text = ItemName;
            labelCost.Text = "  From $"+ItemCost;
            labelDesc.Text = " "+itemDesc;
            labelNew.Text = " New";
            labelNew.ForeColor= Color.Orange;
            labelName.BackColor = Color.Transparent;
            labelCost.BackColor = Color.Transparent;
            labelDesc.BackColor = Color.Transparent;
            labelNew.BackColor = Color.Transparent;
            labelName.Size = new Size(200, 50);
            labelCost.Size = new Size(200, 50);
            labelDesc.Size = new Size(400, 100);
            labelNew.Size = new Size(200, 50);
            labelNew.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            labelName.Font = new Font("Calibri Light", 27, FontStyle.Bold);
            labelDesc.Font = new Font("Calibri Light", 17, FontStyle.Bold);
            labelCost.Font = new Font("Calibri Light", 15, FontStyle.Regular);
            labelName.Parent = pic;
            labelCost.Parent = pic;
            labelDesc.Parent = pic;
            labelNew.Parent = pic;
            //itemPanel.Controls.Add(labelName);
            //itemPanel.Controls.Add(labelCost);
            labelNew.Location = new Point(30, 150);
            labelName.Location = new Point(labelNew.Location.X, labelNew.Location.Y + 30);
            labelDesc.Location = new Point(labelNew.Location.X, labelNew.Location.Y + 80);
            labelCost.Location = new Point(labelNew.Location.X, labelNew.Location.Y + 150);

            itemPanel.Controls.Add(pic);
            Pic.Size = new Size(itemPanel.Size.Width, itemPanel.Size.Height);
            pic.Dock = DockStyle.Fill;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Controls.Add(labelName);
            pic.Controls.Add(labelCost);
            pic.Controls.Add(labelDesc);
            pic.Controls.Add(labelNew);



            parent.Controls.Add(itemPanel);
            itemPanel.BackColor = Color.DarkGray;
            itemPanel.Location = new Point(0, (index - 1) * 495);

            itemPanel.Click += ItemPanel_Click;

            //1136, 665
            //itemPanel.Click += ItemPanel_Click1;
            //labelName.Click += LabelName_Click1;
            //labelCost.Click += LabelCost_Click1;
            //pic.Click += Pic_Click;
            //this.count = index;
        }

        private void ItemPanel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

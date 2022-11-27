using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp122.Controllers.Draw
{
    internal class DrawProductController
    {
        private PictureBox pic;
        private string itemName;
        private string itemCost;
        private string itemDesc;
        private int count, id;
        private MainForm parent;
        private int user_id;
        public DrawProductController()
        {
        }
        public DrawProductController(PictureBox itemPic, string itemName, string itemCost, string itemDesc, int id, int user_id, MainForm parent)
        {
            this.user_id = user_id;
            this.parent = parent;


            this.id = id;
            this.Pic = itemPic;
            this.ItemName = itemName;
            this.ItemCost = itemCost;
            this.itemDesc = itemDesc;
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
            Label labelDesc = new Label();
            Label labelNew = new Label();
            Button btBuyNow = new Button();
            Button btAddToCard = new Button();

            labelName.Text = ItemName;
            labelCost.Text = "  From $" + ItemCost;
            labelDesc.Text = " " + itemDesc;
            labelNew.Text = " New";
            btBuyNow.Text = "Buy now";
            btAddToCard.Text = "Add to card";

            labelNew.ForeColor = Color.Orange;
            labelName.BackColor = Color.Transparent;
            labelCost.BackColor = Color.Transparent;
            labelDesc.BackColor = Color.Transparent;
            labelNew.BackColor = Color.Transparent;
            btBuyNow.BackColor = Color.Blue;
            btAddToCard.BackColor = Color.Orange;

            labelName.Size = new Size(500, 50);
            labelCost.Size = new Size(200, 50);
            labelDesc.Size = new Size(400, 100);
            labelNew.Size = new Size(200, 50);
            btBuyNow.Size = new Size(130, 40);
            btAddToCard.Size = new Size(130, 40);

            labelNew.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            labelName.Font = new Font("Calibri Light", 27, FontStyle.Bold);
            labelDesc.Font = new Font("Calibri Light", 17, FontStyle.Bold);
            labelCost.Font = new Font("Calibri Light", 15, FontStyle.Regular);
            btBuyNow.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            btAddToCard.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            btBuyNow.ForeColor = Color.White;
            btAddToCard.ForeColor = Color.White;
            btBuyNow.TextAlign = ContentAlignment.MiddleLeft;
            btAddToCard.TextAlign = ContentAlignment.MiddleLeft;

            labelName.Parent = pic;
            labelCost.Parent = pic;
            labelDesc.Parent = pic;
            labelNew.Parent = pic;
            btBuyNow.Parent = pic;
            btAddToCard.Parent = pic;

            labelNew.Location = new Point(30, 150);
            labelName.Location = new Point(labelNew.Location.X, labelNew.Location.Y + 30);
            labelDesc.Location = new Point(labelNew.Location.X, labelNew.Location.Y + 80);
            labelCost.Location = new Point(labelNew.Location.X, labelNew.Location.Y + 150);
            btBuyNow.Location = new Point(labelNew.Location.X + 10, labelNew.Location.Y + 200);
            btAddToCard.Location = new Point(labelNew.Location.X + 10, labelNew.Location.Y + 250);
            btBuyNow.FlatStyle = FlatStyle.Flat;
            btBuyNow.FlatAppearance.BorderSize = 0;
            btAddToCard.FlatStyle = FlatStyle.Flat;
            btAddToCard.FlatAppearance.BorderSize = 0;

            itemPanel.Controls.Add(pic);
            Pic.Size = new Size(itemPanel.Size.Width, itemPanel.Size.Height);
            pic.Dock = DockStyle.Fill;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Controls.Add(labelName);
            pic.Controls.Add(labelCost);
            pic.Controls.Add(labelDesc);
            pic.Controls.Add(labelNew);
            pic.Controls.Add(btBuyNow);
            pic.Controls.Add(btAddToCard);

            parent.Controls.Add(itemPanel);
            itemPanel.BackColor = Color.DarkGray;
            itemPanel.Location = new Point(0, (index - 1) * 495);

            btBuyNow.Click += BtBuyNow_Click;
            btAddToCard.Click += BtAddToCard_Click;

        }

        private void BtAddToCard_Click(object sender, EventArgs e)
        {
            CartFunction.addToCart(SessionFunction.getIdCurrentSession(this.user_id), id);
            MessageBox.Show("Add item sucessfully to your Cart");
        }

        private void BtBuyNow_Click(object sender, EventArgs e)
        {
            CartFunction.addToCart(SessionFunction.getIdCurrentSession(this.user_id), id);
            parent.panelClick(sender, e, 2);
        }
    }
}

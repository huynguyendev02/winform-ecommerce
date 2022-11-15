using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.FormOfNguoiDung.GioHang
{
    internal class class_item
    {
        private PictureBox pic;
        private string itemName;
        private string itemCost;
        private int count;
        public class_item()
        {
        }
        public class_item(PictureBox itemPic, string itemName, string itemCost)
        {
            this.Pic = itemPic; 
            this.ItemName = itemName;
            this.ItemCost = itemCost;
        }

        public PictureBox Pic { get => pic; set => pic = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public string ItemCost { get => itemCost; set => itemCost = value; }

        public void DrawItem(Panel parent, int index)
        {
            Panel itemPanel = new Panel();
            itemPanel.Size = new Size(200, 200);
            itemPanel.Controls.Add(pic);
            Pic.Size = new Size(200, 140);
            pic.Dock = DockStyle.Top;
            pic.SizeMode = PictureBoxSizeMode.Zoom;


            Label labelName = new Label();
            Label labelCost = new Label();
            labelName.Text = ItemName;
            labelCost.Text = ItemCost;
            itemPanel.Controls.Add(labelName);
            itemPanel.Controls.Add(labelCost);
            labelName.Location = new Point((200 - labelName.Width) / 2, 142);
            labelCost.Location = new Point(labelName.Location.X, 172);

            parent.Controls.Add(itemPanel);
            itemPanel.BackColor = Color.DarkGray;
            itemPanel.Location = new Point(index % 4 * 205, index / 4 * 205);

            itemPanel.Click += ItemPanel_Click1;
            labelName.Click += LabelName_Click1;
            labelCost.Click += LabelCost_Click1;
            pic.Click += Pic_Click;
            this.count= index;
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            showThongBao();
        }

        private void LabelCost_Click1(object sender, EventArgs e)
        {
            showThongBao();
        }

        private void LabelName_Click1(object sender, EventArgs e)
        {
            showThongBao();
        }

        private void ItemPanel_Click1(object sender, EventArgs e)
        {
            showThongBao();
        }

        private static void showThongBao()
        {
            Form thongBao = new Mua();
            thongBao.ShowDialog();
        }
    }

}

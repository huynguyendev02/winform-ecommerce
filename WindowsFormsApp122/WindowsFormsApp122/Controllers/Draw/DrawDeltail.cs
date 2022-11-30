using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp122.Controllers.Draw
{
    public class DrawDeltail
    {
        string name;
        int soLuong = 1;
        decimal price;
        public DrawDeltail(string name, int soLuong, decimal price)
        {
            Name = name;
            Price = price;
            this.soLuong = soLuong;
        }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }

        public void Draw(Panel parent)
        {

            Panel pn = new Panel();
            pn.Size = new Size(866, 100);
            pn.Dock = DockStyle.Top;
            pn.Location = new Point(0, 0);
            pn.BackColor = Color.White;
            pn.BorderStyle = BorderStyle.FixedSingle;
            parent.Controls.Add(pn);


            Label lbNameProduct = new Label();
            Label lbCount = new Label();
            Label lbPrice = new Label();

            pn.Controls.Add(lbNameProduct);
            pn.Controls.Add(lbCount);
            pn.Controls.Add(lbPrice);

            lbNameProduct.Text = Name;
            lbCount.Text = soLuong.ToString();
            lbPrice.Text = "$" + Price.ToString();

            lbNameProduct.Size = new Size(200, 30);
            lbCount.Size = new Size(30, 30);

            lbNameProduct.Font = new Font("Calibri Light", 17, FontStyle.Bold);
            lbCount.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            lbPrice.Font = new Font("Calibri Light", 17, FontStyle.Bold);

            lbNameProduct.Location = new Point(30, 38);
            lbCount.Location = new Point(400, 38);
            lbPrice.Location = new Point(700, 38);
        }
    }
}

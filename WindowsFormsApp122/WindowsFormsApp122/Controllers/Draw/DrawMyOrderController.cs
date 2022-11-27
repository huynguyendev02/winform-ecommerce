using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp122.Controllers.Draw
{
    public class DrawMyOrderController
    {
        Label stt = new Label(), date = new Label(), address = new Label(), supplier = new Label(), totalPrice = new Label(), status = new Label();
        Label[] allLabel;
        int index;
        public DrawMyOrderController(int index, string stt, string date, string address, string supplier, string totalPrice, string status) {
            this.index = index;
            this.stt.Text = stt;
            this.date.Text = date;
            this.address.Text = address;
            this.supplier.Text = supplier;
            this.totalPrice.Text = totalPrice;
            this.status.Text = status;
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


            allLabel = new Label[] {  stt,  date,  address,  supplier,  totalPrice,  status };
            int count = 0;
            foreach (var lb in allLabel)
            {
                pn.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
                count ++;
            }
            stt.Location = new Point(10, 35);
            stt.Size = new Size(20,20);
            date.Location = new Point(60, 35);
            date.Size = new Size(110, 20);
            address.Location = new Point(200, 35);
            supplier.Location = new Point(350, 35);
            totalPrice.Location = new Point(500, 35);
            status.Location = new Point(600, 35);

            status.ForeColor= Color.Red;

            Button view = new Button();
            pn.Controls.Add(view);
            view.Size = new Size(80, 30);
            view.Text = "Details";
            view.Font = new Font("Calibri Light", 12, FontStyle.Bold);
            view.Location = new Point(750, 35);
        }
    }
}

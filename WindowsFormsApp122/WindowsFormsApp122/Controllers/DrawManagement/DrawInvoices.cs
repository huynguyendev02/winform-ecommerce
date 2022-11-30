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
    internal class DrawInvoices
    {
        Label stt = new Label(), buyDate = new Label(), checkOutDate = new Label(), supplier = new Label(), status = new Label(), totalPrice = new Label();
        Label[] allLabel;
        Button complete = new Button();
        int index;
        int id;
        public DrawInvoices(int index, string stt, string buyDate, string checkOutDate, string supplier, string status, string totalPrice, int id)
        {
            this.index = index;
            this.stt.Text = stt;
            this.buyDate.Text = buyDate.Split(' ')[0];
            this.checkOutDate.Text = checkOutDate.Split(' ')[0];
            this.supplier.Text = supplier;
            this.totalPrice.Text = totalPrice;
            this.status.Text = status;
            this.id = id;
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


            allLabel = new Label[] { stt, buyDate, checkOutDate, supplier, status, totalPrice };
            int count = 0;
            foreach (var lb in allLabel)
            {
                pn.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
                stt.Location = new Point(10+count*10, 35);
                count++;
            }

            stt.Location = new Point(2, 30);
            buyDate.Location = new Point(80, 30);
            checkOutDate.Location = new Point(230, 30);
            supplier.Location = new Point(390, 30);
            status.Location = new Point(525, 30);
            totalPrice.Location = new Point(650, 30);


            stt.Size = new Size(30, 40);
            buyDate.Size = new Size(150, 40);
            checkOutDate.Size = new Size(150,40);
            supplier.Size = new Size(130, 40);
            status.Size = new Size(140, 40);
            totalPrice.Size = new Size(80, 40);

            status.ForeColor = status.Text == "Complete" ? Color.Green : Color.Red;
            complete.Visible = status.Text == "Complete" ? false : true;

            pn.Controls.Add(complete);
            complete.Text = "Complete";
            complete.Font =  new Font("Calibri Light", 15, FontStyle.Bold);
            complete.ForeColor = Color.White;
            complete.BackColor= Color.Green;
            complete.Location = new Point(730, 25);
            complete.Size = new Size(110, 40);
            complete.Click += Complete_Click;
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            checkOutDate.Text = DateTime.Now.ToString();
            status.Text = "Complete";
            status.ForeColor = Color.Green;
            complete.Visible = false;
            OrderFunction.orderToInvoice(id);
        }
    }
}

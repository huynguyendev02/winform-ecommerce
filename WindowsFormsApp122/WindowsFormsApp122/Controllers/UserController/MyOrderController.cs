using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.Controllers.Draw;
using WindowsFormsApp122.FormFunction;
using static DevExpress.XtraEditors.RoundedSkinPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp122.Controllers.UserController
{
    public class MyOrderController
    {
        Panel MyOrder = new Panel(), pnHeader = new Panel(), pnTitelItem = new Panel(), pnContent = new Panel();
        Label lbTitle = new Label(), stt = new Label(), date = new Label(), address = new Label(), supplier = new Label(), totalPrice = new Label(), status = new Label();
        Label[] allLabel;

        public MyOrderController(Panel MyOrder, Panel pnHeader, Panel pnContent)
        {
            this.MyOrder = MyOrder;
            this.MyOrder.Controls.Add(this.pnHeader);
            this.MyOrder.Controls.Add(this.pnTitelItem);
            this.pnTitelItem.BringToFront();
            this.MyOrder.Controls.Add(this.pnContent);
            this.pnContent.BringToFront();

            pnContent.Visible = false;

            this.pnHeader.Size = pnHeader.Size;
            this.pnHeader.Location = pnHeader.Location;
            this.pnHeader.BackColor = pnHeader.BackColor;

            this.pnTitelItem.Location = pnContent.Location;
            this.pnTitelItem.Size = new Size(pnContent.Size.Width, 45);
            this.pnTitelItem.BorderStyle= BorderStyle.FixedSingle;

            this.pnContent.Location = new Point(pnContent.Location.X, pnContent.Location.Y + 45);
            this.pnContent.Size = new Size(pnContent.Size.Width, pnContent.Size.Height - 45); 
            this.pnContent.AutoScroll = true;

            MyOrderHeader();
            MyOrderTitle();
            MyOrderContent();
        }

        public void MyOrderHeader()
        {
            lbTitle.Text = "My order";
            pnHeader.Controls.Add(lbTitle);
            lbTitle.Visible = true;
            lbTitle.Size = new Size(200, 25);
            lbTitle.Font = new Font("Calibri Light", 14, FontStyle.Bold);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(100, 23);

        }

        public void MyOrderTitle()
        {
            allLabel = new Label[]
            {
                stt, date, address, supplier, totalPrice, status,
            };
            foreach (var lb in allLabel)
            {
                pnTitelItem.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
            }


            stt.Text = "STT";
            stt.Location = new Point(2, 10);
            stt.Size = new Size(50, 20);

            date.Text = "Date";
            date.Location = new Point(60, 10);
            date.Size = new Size(110, 20);

            address.Text = "Name";
            address.Location = new Point(200, 10);

            supplier.Text = "Supplier";
            supplier.Location = new Point(350, 10);

            totalPrice.Text = "Total price";
            totalPrice.Location = new Point(500, 10);

            status.Text = "Status";
            status.Location = new Point(600, 10);
        }

        public void MyOrderContent()
        {
            int index = 0;
            List<dynamic> orders = OrderFunction.ordersInfo(MainForm.getUserID());
            foreach(var order in orders)
            {
                DrawMyOrderController item = new DrawMyOrderController(index, (index+1).ToString(), order.created_at.ToString(), order.first_name, order.providers, order.total.ToString(), order.statuss, order.id);
                item.Draw(pnContent);
                index++;
 
            }
            
        }
    }
}

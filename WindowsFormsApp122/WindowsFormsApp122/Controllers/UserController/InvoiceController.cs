using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.Controllers.Draw;

namespace WindowsFormsApp122.Controllers.UserController
{
    public class InvoiceController
    {
        Panel Invoice = new Panel(), pnHeader = new Panel(), pnTitelItem = new Panel(), pnContent = new Panel();
        Label lbTitle = new Label(), stt = new Label(), buyDate = new Label(), checkOutDate = new Label(), supplier = new Label(), status = new Label(), totalPrice = new Label();
        Label[] allLabel;

        public InvoiceController(Panel Invoice, Panel pnHeader, Panel pnContent)
        {
            this.Invoice = Invoice;
            this.Invoice.Controls.Add(this.pnHeader);
            this.Invoice.Controls.Add(this.pnTitelItem);
            this.Invoice.Controls.Add(this.pnContent);

            pnContent.Visible = false;

            this.pnHeader.Size = pnHeader.Size;
            this.pnHeader.Location = pnHeader.Location;
            this.pnHeader.BackColor = pnHeader.BackColor;

            this.pnTitelItem.Location = pnContent.Location;
            this.pnTitelItem.Size = new Size(pnContent.Size.Width, 45);
            this.pnTitelItem.BorderStyle = BorderStyle.FixedSingle;

            this.pnContent.Location = new Point(pnContent.Location.X, pnContent.Location.Y + 45);
            this.pnContent.Size = new Size(pnContent.Size.Width, pnContent.Size.Height - 45);
            this.pnContent.AutoScroll = true;

            InvoiceHeader();
            InvoiceTitle();
            InvoiceContent();
        }

        public void InvoiceHeader()
        {
            lbTitle.Text = "Invoice";
            pnHeader.Controls.Add(lbTitle);
            lbTitle.Visible = true;
            lbTitle.Size = new Size(200, 25);
            lbTitle.Font = new Font("Calibri Light", 14, FontStyle.Bold);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(100, 23);

        }

        public void InvoiceTitle()
        {
            allLabel = new Label[]
            {
                stt, buyDate, checkOutDate, supplier, status, totalPrice,
            };
            foreach (var lb in allLabel)
            {
                pnTitelItem.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
            }           

            stt.Text = "STT";
            stt.Location = new Point(2, 10);
            stt.Size = new Size(50, 30);

            buyDate.Text = "Bought";
            buyDate.Location = new Point(100, 10);
            buyDate.Size = new Size(110, 30);

            checkOutDate.Text = "Payment";
            checkOutDate.Location = new Point(270, 10);

            supplier.Text = "Provider";
            supplier.Location = new Point(440, 10);

            status.Text = "Status";
            status.Location = new Point(600, 10);

            totalPrice.Text = "Price";
            totalPrice.Location = new Point(750, 10);
        }

        public void InvoiceContent()
        {
            int index = 0;
            for (int i = 0; i < 15; i++)
            {
                //(int index, string stt, string buyDate, string checkOutDate, string supplier, string status, string totalPrice)
                DrawInvoice item = new DrawInvoice(index, i.ToString(), "11-2-2002", "13-3-2002", "Long Long", "Hoàn thành", "1200");
                item.Draw(pnContent);
                index++;
            }
        }
    }
}

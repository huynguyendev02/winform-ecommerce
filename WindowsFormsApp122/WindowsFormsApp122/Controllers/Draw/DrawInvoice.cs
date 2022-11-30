using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp122.Controllers.Draw
{
    public class DrawInvoice
    {
        Label stt = new Label(), buyDate = new Label(), checkOutDate = new Label(), supplier = new Label(), status = new Label(), totalPrice = new Label();
        Label[] allLabel;
        int index;
        public DrawInvoice(int index, string stt, string buyDate, string checkOutDate, string supplier, string status, string totalPrice)
        {
            this.index = index;
            this.stt.Text = stt;
            this.buyDate.Text = buyDate.Split(' ')[0];
            this.checkOutDate.Text = checkOutDate.Split(' ')[0];
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


            allLabel = new Label[] { stt, buyDate, checkOutDate, supplier, status, totalPrice };
            int count = 0;
            foreach (var lb in allLabel)
            {
                pn.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
                count++;
            }
            stt.Location = new Point(10, 35);
            stt.Size = new Size(20, 20);
            buyDate.Location = new Point(100, 35);
            buyDate.Size = new Size(110, 20);
            checkOutDate.Location = new Point(270, 35);
            checkOutDate.Size = new Size(110, 20);
            supplier.Location = new Point(440, 35);
            status.Location = new Point(600, 35);
            status.Size = new Size(140,40);
            totalPrice.Location = new Point(750, 35);

            status.ForeColor = Color.Green;

        }
    }
}

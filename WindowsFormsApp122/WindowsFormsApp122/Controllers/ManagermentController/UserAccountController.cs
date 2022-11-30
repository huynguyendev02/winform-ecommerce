using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.Controllers.DrawManagement;
using WindowsFormsApp122.FormFunction;
using WinFormsApp2;

namespace WindowsFormsApp122.Controllers.ManagermentController
{
    internal class UserAccountController
    {
        Panel Invoice = new Panel(), pnHeader = new Panel(), pnTitelItem = new Panel(), pnContent = new Panel();
        Label lbTitle = new Label(), AddUser = new Label(), stt = new Label(), username = new Label(), pass = new Label();
        Label[] allLabel;

        public UserAccountController(Panel Invoice, Panel pnHeader, Panel pnContent)
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
            lbTitle.Text = "User Account";
            pnHeader.Controls.Add(lbTitle);
            lbTitle.Visible = true;
            lbTitle.Size = new Size(200, 25);
            lbTitle.Font = new Font("Calibri Light", 14, FontStyle.Bold);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(100, 23);

            AddUser.Text = "Add new User";
            pnHeader.Controls.Add(AddUser);
            AddUser.Visible = true;
            AddUser.Size = new Size(200, 25);
            AddUser.Font = new Font("Calibri Light", 14, FontStyle.Bold);
            AddUser.ForeColor = Color.White;
            AddUser.Location = new Point(680, 23);
            AddUser.Click += AddUser_Click;

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            Register yeah = new Register();
            yeah.Show();
        }

        public void InvoiceTitle()
        {
            allLabel = new Label[]
            {
                stt, username, pass,
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

            username.Text = "Username";
            username.Location = new Point(200, 10);
            username.Size = new Size(200, 30);

            pass.Text = "Password";
            pass.Location = new Point(440, 10);
            pass.Size = new Size(200, 30);

        }

        public void InvoiceContent()
        {
            int index = 0;
            //var invoices = OrderFunction.invoicesInfo(MainForm.getUserID());
            //foreach (var inv in invoices)
            //{
            //    DrawInvoice item = new DrawInvoice(index, (index + 1).ToString(), inv.created_at.ToString(), inv.payTime.ToString(), inv.providers, inv.statuss, inv.total.ToString());
            //    item.Draw(pnContent);
            //    index++;
            //}
            var listUser = UserFunction.listUser();
            foreach(var u in listUser)
            {
                Controllers.DrawManagement.DrawUserAccount item = new DrawUserAccount(index, (index + 1).ToString(), u.username, u.passwords,u.id);
                item.Draw(pnContent);
                index++;

            }
            
        }
    }
}

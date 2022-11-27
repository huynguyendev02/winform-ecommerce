using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.Controllers.Draw
{
    public class DrawAccount
    {
        Panel Account = new Panel(), pnHeader = new Panel(), pnContent = new Panel(), panel1 = new Panel(), panel2 = new Panel(), panel3 = new Panel();
        Label Information = new Label(), PassWord = new Label(), Payment = new Label();
        Label[] allLabel;
        Panel[] allPanel;

        public DrawAccount(Panel Account, Panel pnHeader, Panel pnContent, string firstName, string lastName, string telephone, string mobilePhone, string city, string contry, string address1, string address2, string postalCode, string createdDay, string oldPass, string paymentType, string provider, string accountNumber, string expDay)
        {
            this.Account = Account;
            this.Account.Controls.Add(this.pnHeader);
            this.Account.Controls.Add(this.pnContent);

            this.pnHeader.Size = pnHeader.Size;
            this.pnHeader.Location = pnHeader.Location;
            this.pnHeader.BackColor = pnHeader.BackColor;


            this.pnContent = pnContent;
            this.pnContent.BackColor = Color.Red;

            this.pnContent.Visible = true;
            this.pnHeader.Visible = true;

            DashboardHeader();
            //DashboardContent();
        }
        public void DashboardHeader()
        {

            allLabel = new Label[] {
                Information, PassWord, Payment,
            };
            int count = 1;
            Information.Text = "Information";
            PassWord.Text = "Password";
            Payment.Text = "Payment";

            foreach (var lb in allLabel)
            {
                pnHeader.Controls.Add(lb);
                pnHeader.Controls.SetChildIndex(lb, 0);
                lb.Visible = true;
                lb.Font = new Font("Calibri Light", 14, FontStyle.Bold);
                lb.ForeColor = Color.White;
                lb.Location = new Point(count * 95, 23);
                count++;
            }
        }
        //public void DashboardContent()
        //{

        //    allPanel = new Panel[]
        //    {
        //        panel1,panel2, panel3,
        //    };
        //    pnContent.Visible = false;
        //    for (int i = 0; i < 3; i++)
        //    {

        //        Account.Controls.Add(allPanel[i]);
        //        allPanel[i].Size = pnContent.Size;
        //        allPanel[i].Location = pnContent.Location;
        //        allPanel[i].BackColor = Color.Transparent;
        //        allPanel[i].AutoScroll = true;

        //        var count = 1;
        //        var product = ProductFunction.listProduct(i + 1, 0);
        //        foreach (var p in product)
        //        {
        //            PictureBox productPic = new PictureBox();
        //            productPic.LoadAsync(p.image_url);
        //            Controllers.Draw.DrawProductController products = new Controllers.Draw.DrawProductController(productPic, p.name_product.ToString(), p.price.ToString(), p.desc_product.ToString(), p.id);

        //            products.DrawProducts(allPanel[i], count++);

        //        }
        //        allPanel[i].Visible = false;
        //    }
        //    allPanel[0].Visible = true;
        //}
    }
}

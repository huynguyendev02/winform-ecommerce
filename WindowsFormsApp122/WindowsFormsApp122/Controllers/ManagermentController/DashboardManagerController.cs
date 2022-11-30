using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp122.Controllers.ManagermentController
{
    internal class DashboardManagerController
    {
        Panel aboutUs = new Panel(), pnHeader = new Panel(), pnContent = new Panel();
        Label label1 = new Label(), label2 = new Label(), label3 = new Label(), label4 = new Label(), label5 = new Label(), label6 = new Label(), label7 = new Label();
        Label[] allLaber;
        public DashboardManagerController(Panel aboutUs, Panel pnHeader, Panel pnContent)
        {
            this.aboutUs = aboutUs;
            this.pnHeader.Size = pnHeader.Size;
            this.pnHeader.BackColor = pnHeader.BackColor;
            this.pnHeader.Location = pnHeader.Location;

            this.pnContent.Size = pnContent.Size;
            this.pnContent.Location = pnContent.Location;

            this.pnContent.Visible = true;
            this.pnHeader.Visible = true;
            this.aboutUs.Controls.Add(this.pnContent);
            this.aboutUs.Controls.Add(this.pnHeader);

            DashboardHeader();
            DashboardContent();
        }

        public void DashboardHeader()
        {
            Label title = new Label();
            pnHeader.Controls.Add(title);
            title.Text = "Dashboard";
            title.Location = new Point(80, 15);
            title.Font = new Font("Calibri Light", 18, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Size = new Size(400, 40);


        }
        public void DashboardContent()
        {
            allLaber = new Label[] { label1, label2, label3 , label4, label5, label6, label7 };
            int count = 0;
            foreach (var lb in allLaber)
            {
                pnContent.Controls.Add(lb);
                lb.Visible = true;
                lb.Size = new Size(450, 50);
                lb.Font = new Font("Calibri Light", 18, FontStyle.Bold);
                lb.Location = new Point(20, 50 + 70*count);
                count++;
            }
            
            label1.Text = "Total products were sold: 210";
            label2.Text = "Total products were sold today: 13";
            label3.Text = "Top selling products: Xì teen";
            label4.Text = "Total users in our services: 13";
            label5.Text = "Total invoices have done: 14";
            label6.Text = "The average money has spent in one session: $9999";
            label6.Size = new Size(600,50);
            label7.Text = "Total money: $999999";
            label7.ForeColor = Color.Green;

            PictureBox yeah = new PictureBox();
            this.pnContent.Controls.Add(yeah); 
            yeah.Image = global::WindowsFormsApp122.Properties.Resources.logoAppleColor;
            yeah.Location = new Point(500,50);
            yeah.Size = new Size(300,300);
            yeah.SizeMode = PictureBoxSizeMode.Zoom;

        }
    }
}

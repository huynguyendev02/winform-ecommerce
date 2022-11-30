using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp122.Controllers.UserController
{
    public class AboutUsController
    {
        Panel aboutUs = new Panel(), pnHeader = new Panel(), pnContent = new Panel();
        Label nameDoAn = new Label(),nhom = new Label(), member1 = new Label(), member2 = new Label(), member3 = new Label();
        Label[] allLaber;
        public AboutUsController(Panel aboutUs, Panel pnHeader, Panel pnContent)
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

            AboutHeader();
            AboutContent();
        }

        public void AboutHeader()
        {
            Label title = new Label ();
            pnHeader.Controls.Add(title);
            title.Text = "About us";
            title.Location = new Point(80, 13);
            title.Font = new Font("Calibri Light", 18, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Size = new Size(400,40);
                      
            
        }
        public void AboutContent()
        {
            allLaber = new Label[] { nameDoAn, nhom, member1, member2, member3 };
            int count = 0;
            foreach (var lb in allLaber)
            {
                pnContent.Controls.Add(lb);
                lb.Visible = true;
                lb.Size = new Size(600, 50);
                lb.Font = new Font("Calibri Light", 18, FontStyle.Bold);
                lb.Location = new Point(40, 100 + 50 * count);
                count++;
            }
            nameDoAn.Text = "Đồ án công nghệ thông tin";
            nameDoAn.Font = new Font("Calibri Light", 30, FontStyle.Bold);
            nameDoAn.Location = new Point(20, 50);

            nhom.Text = "Các thành viên:";
            nhom.Location = new Point(20, 150);
            member1.Text = "Vũ Trung Hiếu - 201110482";
            member2.Text = "Da Quy - one two three";
            member3.Text = "Dương Quá";
        }

    }
}

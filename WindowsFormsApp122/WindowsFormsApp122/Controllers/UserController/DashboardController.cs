using DevExpress.Utils.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.UserForm
{
    public class DashboardController
    {
        Panel Dashboard = new Panel() , pnHeader = new Panel(), pnContent = new Panel(), panel1 = new Panel(), panel2 = new Panel(), panel3 = new Panel(), panel4 = new Panel(), panel5 = new Panel(), panel6 = new Panel(), panel7 = new Panel(), panel8 = new Panel();
        Label Mac = new Label(), Ipad = new Label(), Iphone = new Label(), Watch = new Label(), AirPods = new Label(), Tv = new Label(), Access = new Label();
        Label[] allLabel;
        Panel[] allPanel;

        private int user_id;
        private MainForm parent;

        public DashboardController(Panel Dashboard, Panel pnHeader, Panel pnContent, int user_id, MainForm parent)
        {
            this.parent = parent;
            this.user_id = user_id;

            this.Dashboard = Dashboard;
            this.Dashboard.Controls.Add(this.pnHeader);
            this.Dashboard.Controls.Add(this.pnContent);

            this.pnHeader.Size = pnHeader.Size;
            this.pnHeader.Location = pnHeader.Location;
            this.pnHeader.BackColor = pnHeader.BackColor;


            this.pnContent = pnContent;
            this.pnContent.BackColor = Color.Red;
            
            this.pnContent.Visible= true;
            this.pnHeader.Visible= true;

            DashboardHeader(); 
            DashboardContent();
        }
        public void DashboardHeader()
        {

            allLabel = new Label[] {
                Mac, Ipad, Iphone, Watch, AirPods, Tv, Access
            };
            int count = 1;
            Mac.Text = "Mac";
            Ipad.Text = "iPad";
            Iphone.Text = "iPhone";
            Watch.Text = "Watch";
            AirPods.Text = "AirPods";
            Tv.Text = "Home";
            Access.Text = "Accessories";
            Access.Size = new Size(150,23);
            foreach(var lb in allLabel)
            {
                pnHeader.Controls.Add(lb);
                pnHeader.Controls.SetChildIndex(lb, 0);
                lb.Visible = true;
                lb.Font = new Font("Calibri Light", 14, FontStyle.Bold);
                lb.ForeColor = Color.White;
                lb.Location= new Point(count*95,23);
                count++; 
                lb.Click += delegate (object sender, EventArgs e)
                {
                    Lb_Click(sender,e);
                };
            }
        }
        public void DashboardContent()
        {
            
            allPanel = new Panel[]
            {
                panel1,panel2, panel3, panel4, panel5, panel6, panel7,
            };
            pnContent.Visible = false;
            for (int i = 0; i < 7; i++)
            {
                Dashboard.Controls.Add(allPanel[i]);
                allPanel[i].Size = pnContent.Size;
                allPanel[i].Location = pnContent.Location;
                allPanel[i].BackColor = Color.Transparent;
                allPanel[i].AutoScroll = true;

                var count = 1;
                var product = ProductFunction.listProduct(i + 1, 0);
                foreach (var p in product)
                {
                    PictureBox productPic = new PictureBox();
                    productPic.LoadAsync(p.image_url);
                    Controllers.Draw.DrawProductController products = new Controllers.Draw.DrawProductController(productPic, p.name_product.ToString(), p.price.ToString(), p.desc_product.ToString(), p.id,this.user_id, this.parent);

                    products.DrawProducts(allPanel[i], count++);

                }
                allPanel[i].Visible = false;
            }
            allPanel[0].Visible = true;
        }
        private void Lb_Click(object sender, EventArgs e)
        {
            Label lb = (sender as Label);
            foreach (var temp in allPanel) temp.Visible = false;
            switch (lb.Text)
            {
                case "Mac":
                    allPanel[0].Visible = true;
                    break;
                case "iPad":
                    allPanel[1].Visible = true;
                    break;
                case "iPhone":
                    allPanel[2].Visible = true;
                    break;
                case "Watch":
                    allPanel[3].Visible = true;
                    break;
                case "AirPods":
                    allPanel[4].Visible = true;
                    break;
                case "Home":
                    allPanel[5].Visible = true;
                    break;
                case "Accessories":
                    allPanel[6].Visible = true;
                    break;
            };
        }
    }
}

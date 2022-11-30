using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;
using WindowsFormsApp122.UserForm;

namespace WindowsFormsApp122.ManagementForm
{
    public partial class ManagerForm : Form
    {
        Form login;
        Panel Dashboard = new Panel(), Cart = new Panel(), Orders = new Panel(), Invoices = new Panel(), Account = new Panel(), AboutUs = new Panel();
        Panel[] allPanels;

        private static int user_id;


        

        private void pnDashboard_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 1);
        }

        private void lbDashboard_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 1);

        }

        private void picDashboard_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 1);
        }

        private void pnShoppingCart_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 2);
        }

        private void lbShoppingCart_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 2);
        }

        private void picShoppingCart_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 2);
        }

        private void pnMyOrders_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 3);
        }

        private void lbMyOrders_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 3);
        }

        private void picMyOrders_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 3);
        }

        private void pnInvoice_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 4);
        }

        private void lbInvoice_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 4);
        }

        private void picInvoice_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 4);
        }

        private void pnAccount_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 5);
        }

        private void lbAccount_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 5);
        }

        private void picAccount_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 5);
        }

        private void pnAboutUs_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 6);
        }

        private void lbAboutUs_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 6);
        }

        private void picAboutUs_Click(object sender, EventArgs e)
        {
            panelClick(sender, e, 6);
        }

        private void pnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void lbSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void picSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.Controls.Add(pictureBox2);
            pictureBox2.BringToFront();
            pictureBox2.Location = new Point(300, 35);
            pictureBox2.BackColor = Color.DimGray;
            this.picAboutUs.Image = global::WindowsFormsApp122.Properties.Resources.Apple_logo_white;


            allPanels = new Panel[]
            {
                Dashboard, Cart, Orders, Invoices, Account, AboutUs
            };
            foreach (var pn in allPanels)
            {
                this.Controls.Add(pn);
                pn.Location = pnDesign.Location;
                pn.Size = pnDesign.Size;
                pn.Visible = false;
            }
            var test = new Controllers.ManagermentController.DashboardManagerController(Dashboard, pnHeader, pnContent);
            panelClick(sender, e, 1);

        }

        public static int getUserID()
        {
            return user_id;
        }
        private static void turnOn(PictureBox pic, Label lb, Panel pn, Panel Content)
        {
            lb.ForeColor = Color.Black;
            pn.BackColor = Color.White;
            Content.Visible = true;
            //pic.Image = invertPicture(new Bitmap(pic.Image));
        }
        private static void panelUnClick(PictureBox pic, Label lb, Panel pn, Panel Content)
        {
            lb.ForeColor = Color.White;
            pn.BackColor = Color.Black;
            Content.Visible = false;

            //pic.Image = invertPicture(new Bitmap(pic.Image));
        }
        public void panelClick(object sender, EventArgs e, int num)
        {
            panelUnClick(picDashboard, lbDashboard, pnDashboard, Dashboard);
            panelUnClick(picShoppingCart, lbShoppingCart, pnShoppingCart, Cart);
            panelUnClick(picMyOrders, lbMyOrders, pnMyOrders, Orders);
            panelUnClick(picInvoice, lbInvoice, pnInvoice, Invoices);
            panelUnClick(picAccount, lbAccount, pnAccount, Account);
            panelUnClick(picAboutUs, lbAboutUs, pnAboutUs, AboutUs);
            panelUnClick(picSignOut, lbSignOut, pnSignOut, AboutUs);
            this.picDashboard.Image = global::WindowsFormsApp122.Properties.Resources.iconDashboardOff;
            this.picShoppingCart.Image = global::WindowsFormsApp122.Properties.Resources.iconShoppingCartOff;
            this.picMyOrders.Image = global::WindowsFormsApp122.Properties.Resources.IconMyOrdersOff;
            this.picInvoice.Image = global::WindowsFormsApp122.Properties.Resources.iconInvoiceOff;
            this.picAccount.Image = global::WindowsFormsApp122.Properties.Resources.iconAccountOff;
            this.picAboutUs.Image = global::WindowsFormsApp122.Properties.Resources.iconAboutUsOff;
            switch (num)
            {
                case 1:
                    turnOn(picDashboard, lbDashboard, pnDashboard, Dashboard);
                    this.picDashboard.Image = global::WindowsFormsApp122.Properties.Resources.iconDashboardOn;
                    break;
                case 2:
                    //new Controllers.UserController.CartController(Cart, pnHeader, pnContent, user_id, new MainForm(new Form(), 1));
                    new Controllers.ManagermentController.AllProductController(Cart, pnHeader, pnContent, user_id, this);
                    turnOn(picShoppingCart, lbShoppingCart, pnShoppingCart, Cart);
                    this.picShoppingCart.Image = global::WindowsFormsApp122.Properties.Resources.iconShoppingCartOn;
                    break;
                case 3:
                    turnOn(picMyOrders, lbMyOrders, pnMyOrders, Orders);
                    var test2 = new Controllers.ManagermentController.DiscountController(Orders, pnHeader, pnContent);
                    this.picMyOrders.Image = global::WindowsFormsApp122.Properties.Resources.IconMyOrdersOn;
                    break;
                case 4:
                    turnOn(picInvoice, lbInvoice, pnInvoice, Invoices);
                    var test3 = new Controllers.ManagermentController.InvoicesController(Invoices, pnHeader, pnContent);
                    this.picInvoice.Image = global::WindowsFormsApp122.Properties.Resources.iconInvoiceOn;
                    break;
                case 5:
                    turnOn(picAccount, lbAccount, pnAccount, Account);
                    var test4 = new Controllers.ManagermentController.UserAccountController(Account, pnHeader, pnContent);
                    this.picAccount.Image = global::WindowsFormsApp122.Properties.Resources.iconAccountOn;
                    break;
                case 6:
                    turnOn(picAboutUs, lbAboutUs, pnAboutUs, AboutUs);
                    var test5 = new Controllers.UserController.AboutUsController(AboutUs, pnHeader, pnContent);
                    this.picAboutUs.Image = global::WindowsFormsApp122.Properties.Resources.iconAboutUsOn;
                    break;
                default: break;
            }
        }
        public ManagerForm(Form login, int user_idd)
        {
            this.login = login;
            user_id = user_idd;
            InitializeComponent();
        }

    }
}

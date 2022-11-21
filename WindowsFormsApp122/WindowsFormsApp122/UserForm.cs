using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.UserFormController.Dashboard;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp122
{
    public partial class UserForm : Form
    {
        Form activeForm;
        private void OpenChildForm(Form ChildForm, Panel pn)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pn.Controls.Add(ChildForm);
            pn.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }
        private static Bitmap invertPicture(Bitmap b)
        {
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                int nOffset = stride - b.Width * 3;
                int nWidth = b.Width * 3;
                for (int y = 0; y < b.Height; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        p[0] = (byte)(255 - p[0]);
                        ++p;
                    }
                    p += nOffset;
                }
            }

            b.UnlockBits(bmData);
            return b;
        }
        private static void panelClick(PictureBox pic, Label lb, Panel pn)
        {
            lb.ForeColor = Color.Black;
            pn.BackColor = Color.White;
         
            pic.Image = invertPicture(new Bitmap(pic.Image));
        }
        private static void panelUnClick(PictureBox pic, Label lb, Panel pn)
        {
            lb.ForeColor = Color.White; 
            pn.BackColor = Color.Black;
            
            pic.Image = invertPicture(new Bitmap(pic.Image));
        }
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnDashboard_Click(object sender, EventArgs e)
        {
            panelClick(picDashboard,lbDashboard,pnDashboard);
            panelUnClick(picShoppingCart,lbShoppingCart,pnShoppingCart);
            panelUnClick(picMyOrders, lbMyOrders, pnMyOrders);
            panelUnClick(picInvoice, lbInvoice, pnInvoice);
            panelUnClick(picAccount, lbAccount, pnAccount);
            panelUnClick(picAboutUs, lbAboutUs, pnAboutUs);
            panelUnClick(picSignOut, lbSignOut, pnSignOut);
            OpenChildForm(new UserFormController.Dashboard.DashboardContent(1), pnContent);
            //OpenChildForm(new UserFormController.Dashboard.DashboardHeader(), pnHeader);

        }

        private void pnShoppingCart_Click(object sender, EventArgs e)
        {
            panelUnClick(picDashboard, lbDashboard, pnDashboard);
            panelClick(picShoppingCart, lbShoppingCart, pnShoppingCart);
            panelUnClick(picMyOrders, lbMyOrders, pnMyOrders);
            panelUnClick(picInvoice, lbInvoice, pnInvoice);
            panelUnClick(picAccount, lbAccount, pnAccount);
            panelUnClick(picAboutUs, lbAboutUs, pnAboutUs);
            panelUnClick(picSignOut, lbSignOut, pnSignOut);
        }

        private void pnMyOrders_Click(object sender, EventArgs e)
        {
            panelUnClick(picDashboard, lbDashboard, pnDashboard);
            panelUnClick(picShoppingCart, lbShoppingCart, pnShoppingCart);
            panelClick(picMyOrders, lbMyOrders, pnMyOrders);
            panelUnClick(picInvoice, lbInvoice, pnInvoice);
            panelUnClick(picAccount, lbAccount, pnAccount);
            panelUnClick(picAboutUs, lbAboutUs, pnAboutUs);
            panelUnClick(picSignOut, lbSignOut, pnSignOut);
        }

        private void pnInvoice_Click(object sender, EventArgs e)
        {
            panelUnClick(picDashboard, lbDashboard, pnDashboard);
            panelUnClick(picShoppingCart, lbShoppingCart, pnShoppingCart);
            panelUnClick(picMyOrders, lbMyOrders, pnMyOrders);
            panelClick(picInvoice, lbInvoice, pnInvoice);
            panelUnClick(picAccount, lbAccount, pnAccount);
            panelUnClick(picAboutUs, lbAboutUs, pnAboutUs);
            panelUnClick(picSignOut, lbSignOut, pnSignOut);
        }

        private void pnAccount_Click(object sender, EventArgs e)
        {
            panelUnClick(picDashboard, lbDashboard, pnDashboard);
            panelUnClick(picShoppingCart, lbShoppingCart, pnShoppingCart);
            panelUnClick(picMyOrders, lbMyOrders, pnMyOrders);
            panelUnClick(picInvoice, lbInvoice, pnInvoice);
            panelClick(picAccount, lbAccount, pnAccount);
            panelUnClick(picAboutUs, lbAboutUs, pnAboutUs);
            panelUnClick(picSignOut, lbSignOut, pnSignOut);
        }

        private void pnAboutUs_Click(object sender, EventArgs e)
        {
            panelUnClick(picDashboard, lbDashboard, pnDashboard);
            panelUnClick(picShoppingCart, lbShoppingCart, pnShoppingCart);
            panelUnClick(picMyOrders, lbMyOrders, pnMyOrders);
            panelUnClick(picInvoice, lbInvoice, pnInvoice);
            panelUnClick(picAccount, lbAccount, pnAccount);
            panelClick(picAboutUs, lbAboutUs, pnAboutUs);
            panelUnClick(picSignOut, lbSignOut, pnSignOut);
        }

        private void pnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            panelClick(picDashboard, lbDashboard, pnDashboard);
            panelUnClick(picShoppingCart, lbShoppingCart, pnShoppingCart);
            panelUnClick(picMyOrders, lbMyOrders, pnMyOrders);
            panelUnClick(picInvoice, lbInvoice, pnInvoice);
            panelUnClick(picAccount, lbAccount, pnAccount);
            panelUnClick(picAboutUs, lbAboutUs, pnAboutUs);
            panelUnClick(picSignOut, lbSignOut, pnSignOut);
            OpenChildForm(new UserFormController.Dashboard.DashboardContent(1), pnContent);
        }

        private void lbDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lbShoppingCart_Click(object sender, EventArgs e)
        {

        }

        private void lbMyOrders_Click(object sender, EventArgs e)
        {

        }

        private void lbInvoice_Click(object sender, EventArgs e)
        {

        }

        private void lbAccount_Click(object sender, EventArgs e)
        {

        }

        private void lbAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void lbSignOut_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserFormController.Dashboard.DashboardContent(1), pnContent);
        }

        private void pnDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserFormController.Dashboard.DashboardContent(2), pnContent);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserFormController.Dashboard.DashboardContent(3), pnContent);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserFormController.Dashboard.DashboardContent(4), pnContent);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserFormController.Dashboard.DashboardContent(5), pnContent);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserFormController.Dashboard.DashboardContent(6), pnContent);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserFormController.Dashboard.DashboardContent(7), pnContent);
        }
    }
}

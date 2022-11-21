using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Admin : Form
    {
        private Form activeForm;
        public Admin()
        {
            InitializeComponent();
        }

        private void customForm()
        {
            panelSanPham.Visible = false;
            panelHoaDon.Visible = false;
            panelKhachHang.Visible = false;
        }
        private void hidePanel()
        {
            if (panelKhachHang.Visible == true)
                panelKhachHang.Visible = false;
            if (panelHoaDon.Visible == true)
                panelHoaDon.Visible = false;
            if (panelSanPham.Visible == true)
                panelSanPham.Visible = false;
        }
        private void showMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hidePanel();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.panelNoiDung.Controls.Add(ChildForm);
            this.panelNoiDung.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            customForm();
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            showMenu(panelKhachHang);
        }

        private void btSanPham_Click(object sender, EventArgs e)
        {
            showMenu(panelSanPham);
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            showMenu(panelHoaDon);
        }

        private void btThemKhachHang_Click(object sender, EventArgs e)
        {
        }

        private void btXoaKhachHang_Click(object sender, EventArgs e)
        {
        }

        private void btSuaKhachHang_Click(object sender, EventArgs e)
        {
        }
        private void btXoaSanPham_Click(object sender, EventArgs e)
        {
        }

        private void btThemSanPham_Click(object sender, EventArgs e)
        {
        }

        private void btChinhSuaSanPham_Click(object sender, EventArgs e)
        {
        }

        private void btThemHoaDon_Click(object sender, EventArgs e)
        {
        }

        private void btSuaHoaDon_Click(object sender, EventArgs e)
        {
        }

        private void btXoaHoaDon_Click(object sender, EventArgs e)
        {
        }
    }
}

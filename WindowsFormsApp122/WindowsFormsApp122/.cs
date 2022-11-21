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
    public partial class NguoiDung : Form
    {
        private Form activeForm;
        public NguoiDung()
        {
            InitializeComponent();
        }
        private void customForm()
        {
            panelGioHang.Visible = false;
            panelHoaDon.Visible = false;
            panelThongTin.Visible = false;
        }
        private void hidePanel()
        {
            if (panelThongTin.Visible == true)
                panelThongTin.Visible = false;
            if (panelHoaDon.Visible == true)
                panelHoaDon.Visible = false;
            if (panelGioHang.Visible == true)
                panelGioHang.Visible = false;
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

        private void btThongTin_Click(object sender, EventArgs e)
        {
            showMenu(panelThongTin);
        }

        private void btGioHang_Click(object sender, EventArgs e)
        {
            showMenu(panelGioHang);
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            showMenu(panelHoaDon);
        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            customForm();
        }

        private void btThemThongTinCaNhan_Click(object sender, EventArgs e)
        {
           
        }

        private void btXoaThongTInCaNhan_Click(object sender, EventArgs e)
        {
            
        }

        private void btSuaThongTinCaNha_Click(object sender, EventArgs e)
        {
            
        }

        private void btThemVaoGio_Click(object sender, EventArgs e)
        {
            
        }

        private void btChinhSua_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            
        }

        private void btChoXacNhan_Click(object sender, EventArgs e)
        {
            
        }

        private void btDangGiao_Click(object sender, EventArgs e)
        {
            
        }

        private void btDaGiao_Click(object sender, EventArgs e)
        {
            
        }
    }
}

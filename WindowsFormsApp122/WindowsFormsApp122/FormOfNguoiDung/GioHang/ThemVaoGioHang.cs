using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2.FormOfNguoiDung.GioHang
{
    public partial class ThemVaoGioHang : Form
    {
        public ThemVaoGioHang()
        {
            InitializeComponent();
        }

        private void ThemVaoGioHang_Load(object sender, EventArgs e)
        {
            for (int i = 0;i<15;i++)
            {
                PictureBox nancyPic = new PictureBox();
                var request = WebRequest.Create("https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2020/6/9/811197/Nancy-Momoland-1.jpg");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    nancyPic.Image = Bitmap.FromStream(stream);
                }
                string name = "Nancy " + i.ToString();
                string cost = "$" + i.ToString() + "000";
                class_item item = new class_item(nancyPic, name, cost);
                item.DrawItem(panel1, i);
            }
        }
    }
}

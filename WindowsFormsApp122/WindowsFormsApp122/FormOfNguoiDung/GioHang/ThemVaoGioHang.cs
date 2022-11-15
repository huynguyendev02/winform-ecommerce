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
using WindowsFormsApp122.FormFunction;

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
            var count = 0;
            var product = ProductFunction.listProduct();
            foreach (var p in product)
            {
                PictureBox productPic = new PictureBox();
                productPic.LoadAsync(p.image_url);
                class_item item = new class_item(productPic, p.name_product.ToString(), p.price.ToString());
                item.DrawItem(panel1, count++);
            }
        }
    }
}

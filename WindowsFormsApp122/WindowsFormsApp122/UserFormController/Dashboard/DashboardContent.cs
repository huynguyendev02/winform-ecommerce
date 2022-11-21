using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.UserFormController.Dashboard
{
    public partial class DashboardContent : Form
    {
        int cateID;
        public DashboardContent(int cateID)
        {
            this.cateID = cateID;
            InitializeComponent();
        }

        private void DashboardContent_Load(object sender, EventArgs e)
        {
            var count = 1;
            var product = ProductFunction.listProduct(cateID,0);
            foreach (var p in product)
            {
                PictureBox productPic = new PictureBox();
                productPic.LoadAsync(p.image_url);
                UserFormController.Dashboard.products products = new UserFormController.Dashboard.products(productPic, p.name_product.ToString(), p.price.ToString(), p.desc_product.ToString());
                products.DrawProducts(panel1, count++);

                //class_item hello = new class_item(productPic, p.name_product.ToString(), p.price.ToString());
                //hello.DrawItem(panel1, count++);
            }
            //for (int i=1;i<5;i++)
            //{
            //    PictureBox productPic = new PictureBox();
            //    productPic.LoadAsync("D:\\photos\\anhTest.png");//https://iili.io/H9zTyLG.png");//p.image_url);
            //    UserFormController.Dashboard.products products = new UserFormController.Dashboard.products(productPic, "Mac Book Pro", "1200","Magic");
            //    products.DrawProducts(panel1, i);

            //    //class_item hello = new class_item(productPic, p.name_product.ToString(), p.price.ToString());
            //    //hello.DrawItem(panel1, count++);
            //}
        }
    }
}

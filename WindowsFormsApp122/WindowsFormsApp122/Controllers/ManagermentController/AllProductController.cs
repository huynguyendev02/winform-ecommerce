using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.Controllers.DrawManagement;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.Controllers.ManagermentController
{
    public class AllProductController
    {
        Panel allProducts = new Panel(), pnHeader = new Panel(), pnContent = new Panel(), pnProduct = new Panel();
        Label AddProduct = new Label();
        Label[] allLabel;
        Panel[] allPanel;

        private int user_id;
        private ManagementForm.ManagerForm parent;

        public AllProductController(Panel allProducts, Panel pnHeader, Panel pnContent, int user_id, ManagementForm.ManagerForm parent)
        {
            this.parent = parent;
            this.user_id = user_id;

            this.allProducts = allProducts;
            this.allProducts.Controls.Add(this.pnHeader);
            this.allProducts.Controls.Add(this.pnContent);

            this.pnHeader.Size = pnHeader.Size;
            this.pnHeader.Location = pnHeader.Location;
            this.pnHeader.BackColor = pnHeader.BackColor;

            this.pnContent = pnContent;
            //this.pnContent.Location = pnContent.Location;
            //this.pnContent.BackColor = pnContent.BackColor;
            this.pnContent.BackColor = Color.Red;

            this.pnContent.Visible = true;
            this.pnHeader.Visible = true;
            AllProductsHeader();
            AllProductsContent();
        }
        public void AllProductsHeader()
        {
            pnHeader.Controls.Add(AddProduct);

            AddProduct.Text = "Add new product";
            AddProduct.Size = new Size(200, 23);
            pnHeader.Controls.SetChildIndex(AddProduct, 0);
            AddProduct.Visible = true;
            AddProduct.Font = new Font("Calibri Light", 14, FontStyle.Bold);
            AddProduct.ForeColor = Color.White;
            AddProduct.Location = new Point(650, 23);
            AddProduct.Click += AddProduct_Click;
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ManagementForm.AddProductsFormcs yeah = new ManagementForm.AddProductsFormcs(parent);
            yeah.Show();
        }

        public void AllProductsContent()
        {
            pnContent.Visible = false;

            allProducts.Controls.Add(pnProduct);
            pnProduct.Size = pnContent.Size;
            pnProduct.Location = pnContent.Location;
            pnProduct.BackColor = Color.Transparent;
            pnProduct.AutoScroll = true;
            var count = 1;
            var product = ProductFunction.listAllProducts();
            foreach (var p in product)
            {
                PictureBox productPic = new PictureBox();
                productPic.LoadAsync(p.image_url);
                DrawProduct products = new DrawProduct(productPic, p.name_product.ToString(), p.desc_product.ToString(), p.name_category, p.quantity.ToString(), p.price.ToString(), p.image_url, p.state, p.id, p.invenID, this.parent);
                products.DrawProducts(pnProduct, count++);
            }
            pnProduct.Visible = true;
        }
    }
}

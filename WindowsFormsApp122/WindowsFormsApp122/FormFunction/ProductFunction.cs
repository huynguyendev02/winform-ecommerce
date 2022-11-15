using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WindowsFormsApp122.Models;

namespace WindowsFormsApp122.FormFunction
{
    public class ProductFunction
    {
        public static List<dynamic> listProduct()
        {
            using (var context = new DatabaseEC())
            {
                return context.products.Select(p => new {p.name_product, p.image_url, p.price}).ToList<dynamic>();
            }
        }
        public static List<dynamic> detailProduct(int id)
        {
            using (var context = new DatabaseEC())
            {
                return context.products.Where(p => p.id==id).Select(p => new { p.name_product,p.desc_product, p.product_category.name_category,p.product_inventory.quantity ,p.image_url, p.price }).ToList<dynamic>();
            }
        }
        public static List<dynamic> categoryProduct()
        {
            using (var context = new DatabaseEC())
            {
                return context.product_category.Select(pc => pc).ToList<dynamic>();
            }
        }
    }
}

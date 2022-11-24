using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp122.Models;

namespace WindowsFormsApp122.FormFunction
{
    public class ProductFunction
    {
        public static List<dynamic> listProduct(int category, int orderBy)
        {
            using (var context = new DatabaseEC())
            {
                if (orderBy == 1)
                    return context.products.Where(p => p.category_id == category).OrderBy(p => p.price).Select(p => new { p.id, p.name_product, p.image_url, p.price,p.desc_product }).ToList<dynamic>();
                if (orderBy == 2)
                    return context.products.Where(p => p.category_id == category).OrderByDescending(p => p.price).Select(p => new { p.id, p.name_product, p.image_url, p.price, p.desc_product }).ToList<dynamic>();
                return context.products.Where(p => p.category_id == category).Select(p => new { p.name_product, p.image_url, p.price , p.desc_product, p.id }).ToList<dynamic>();

            }
        }
        public static List<dynamic> detailProduct(int id)
        {
            using (var context = new DatabaseEC())
            {
                return context.products.Where(p => p.id == id).Select(p => new { p.name_product, p.desc_product, p.product_category.name_category, p.product_inventory.quantity, p.image_url, p.price }).ToList<dynamic>();
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

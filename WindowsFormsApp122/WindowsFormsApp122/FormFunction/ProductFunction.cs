using DevExpress.XtraEditors.Internal;
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
        public static void addProduct(String name_product, String desc_product, int category_id, int quantity, decimal price, String image_url)
        {
            using (var context = new DatabaseEC())
            {
                var newInven = new product_inventory
                {
                    quantity = quantity,
                    created_at = DateTime.Now,
                };
                context.product_inventory.Add(newInven);
                context.SaveChanges();
                var newProduct = new product
                {
                    name_product = name_product,
                    desc_product = desc_product,
                    inventory_id = context.product_inventory.Max(i => i.id),
                    category_id = category_id,
                    price = price,
                    image_url = image_url,
                    created_at = DateTime.Now
                };
                context.products.Add(newProduct);
                context.SaveChanges();
            }
        }
        public static void alterProduct(int productId, String name_product, String desc_product,int inventory_id, int category_id, int quantity, decimal price, String image_url)
        {
            using (var context = new DatabaseEC())
            {
                var inven = context.product_inventory.Find(inventory_id).quantity = quantity;
                var product = context.products.Find(productId);
                product.name_product = name_product;
                product.desc_product = desc_product;
                product.price = price;
                product.category_id = category_id;
                product.image_url = image_url;
                context.SaveChanges();
            }
        }
        public static void deleteProduct(int productID)
        {
            using (var context = new DatabaseEC())
            {
                var product = context.products.Find(productID);
                product.deleted_at = DateTime.Now;
                context.SaveChanges();
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

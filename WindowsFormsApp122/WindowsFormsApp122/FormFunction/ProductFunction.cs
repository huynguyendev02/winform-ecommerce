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
                    return context.products.Where(p => p.category_id == category && !p.deleted_at.HasValue).OrderBy(p => p.price).Select(p => new { p.id, p.name_product, p.image_url, price = !p.discount_id.HasValue ? p.price : p.price*((100-p.discount.discount_percent)/100),p.desc_product }).ToList<dynamic>();
                if (orderBy == 2)
                    return context.products.Where(p => p.category_id == category && !p.deleted_at.HasValue).OrderByDescending(p => p.price).Select(p => new { p.id, p.name_product, p.image_url, price = !p.discount_id.HasValue ? p.price : p.price * ((100 - p.discount.discount_percent) / 100), p.desc_product }).ToList<dynamic>();
                return context.products.Where(p => p.category_id == category && !p.deleted_at.HasValue).Select(p => new { p.name_product, p.image_url, price = !p.discount_id.HasValue ? p.price : p.price * ((100 - p.discount.discount_percent) / 100), p.desc_product, p.id }).ToList<dynamic>();

            }
        }
        public static List<dynamic> listAllProducts()
        {
            using (var context = new DatabaseEC())
            {
                return context.products.Select(p => new { p.name_product, p.image_url, p.price, p.desc_product, p.id, state = p.deleted_at.HasValue ? 0:1 ,p.product_category.name_category, p.product_inventory.quantity , invenID = p.inventory_id, discountState = p.discount_id.HasValue ? 1:0 }).ToList<dynamic>();
            }
        }
        public static void changeStateProduct(int product_id, int state)
        {
            using (var context = new DatabaseEC())
            {
                var product = context.products.Find(product_id);
                if (state == 0)
                    product.deleted_at = DateTime.Now;
                else
                    product.deleted_at = null;
                context.SaveChanges();
            }
        }
        public static product getProduct(int product_id)
        {
            using (var context = new DatabaseEC())
            {
                return context.products.Find(product_id);
            }
        }
        public static void addProduct(string name_product, string desc_product, int category_id, int quantity, decimal price, string image_url)
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
                    product_inventory = context.product_inventory.Find(context.product_inventory.Max(p => p.id)),
                    product_category = context.product_category.Find(category_id),
                    price = price,
                    image_url = image_url,
                    created_at = DateTime.Now
                };
                context.products.Add(newProduct);
                context.SaveChanges();
            }
        }
        public static void alterProduct(int productId, string name_product, string desc_product,int inventory_id, int quantity, decimal price, string image_url)
        {
            using (var context = new DatabaseEC())
            {
                var inven = context.product_inventory.Find(inventory_id).quantity = quantity;
                var product = context.products.Find(productId);
                product.name_product = name_product;
                product.desc_product = desc_product;
                product.price = price;
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

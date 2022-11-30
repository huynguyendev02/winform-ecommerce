using DevExpress.Utils.About;
using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp122.Models;

namespace WindowsFormsApp122.FormFunction
{
    public class CartFunction
    {
        public static List<dynamic> cartItemsInfo(int session_id)
        {
            using (var context = new DatabaseEC())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var proID = context.cart_item.Where(c => c.session_id == session_id).Select(c => c.product_id).ToList();
                List<decimal> prices = new List<decimal>();
                foreach (var p in proID)
                {
                    var product = context.products.Find(p);
                    decimal price=0;
                    if (product.discount_id.HasValue)
                    {
                        var percent = context.products.Where(a => a.id == p).Select(a => a.discount.discount_percent).First();
                        price = (decimal)(product.price * ((100 - percent) / 100));
                    }
                    else
                    {
                        price = (decimal)product.price;
                    }
                    prices.Add(price);
                }
                var count = 0;
                var listCart = context.cart_item.Where(c => c.session_id == session_id).Select(c => new { c.quanlity, c.id, price = 0, nameProduct = c.product.name_product }).ToList<dynamic>();
                List<dynamic> copy = new List<dynamic>();
                foreach (var cart in listCart)
                {
                    copy.Add( new { cart.quanlity, cart.id, price = prices[count++], cart.nameProduct });

                }
                return copy;
            }
        }
        public static int quantityCart(int session_id)
        {
            using (var context = new DatabaseEC())
            {
                var quantity = context.cart_item.Where(c => c.session_id == session_id).Sum(c => c.quanlity);
                return (int)(quantity.HasValue ?  quantity : 0);
            }
        }
        public static decimal totalCartInfo(int session_id)
        {
            using (var context = new DatabaseEC())
            {
                return (decimal)context.shopping_session.Find(session_id).total;
            }
        }
        public static void addToCart(int session_id, int product_id)
        {
            using (var context = new DatabaseEC())
            {
               
                var check = context.cart_item.Where(c => c.session_id == session_id && c.product_id == product_id).Any();
                if (check == true)
                {
                    var cartID = context.cart_item.Where(c => c.session_id == session_id && c.product_id == product_id).Select(c => c.id);
                    var cartItem = context.cart_item.Find(cartID.First());
                    cartItem.quanlity += 1;
                }
                else
                {
                    var newItem = new cart_item
                    {
                        product = context.products.Find(product_id),
                        shopping_session = context.shopping_session.Find(session_id),
                        quanlity = 1,
                        created_at = DateTime.Now,
                    };
                    context.cart_item.Add(newItem);
                }
                context.SaveChanges();
                var session = context.shopping_session.Find(session_id);
                var product = context.products.Find(product_id);
                var price = !product.discount_id.HasValue ? product.price : product.price * ((100 - product.discount.discount_percent) / 100);
                session.total += price;
                context.SaveChanges();
            }
        }
        public static void alterQuantityItem(int id, int quantity, int session_id)
        {
            using (var context = new DatabaseEC())
            {
                var cartItem = context.cart_item.Find(id);
                var oldQuantity = cartItem.quanlity;
                cartItem.quanlity = quantity;
                context.SaveChanges();
                var session = context.shopping_session.Find(session_id);
                var product = context.products.Find(cartItem.product.id);
                var productPrice = !product.discount_id.HasValue ? product.price : product.price * ((100 - product.discount.discount_percent) / 100);
                session.total -= productPrice * oldQuantity;
                session.total += productPrice * quantity;
                context.SaveChanges();
            }
        }
        public static void removeItem(int id, int quantity, int session_id)
        {
            using (var context = new DatabaseEC())
            {
                var cartItem = context.cart_item.Find(id);
                var product = context.products.Find(cartItem.product.id);

                var productPrice = !product.discount_id.HasValue ? product.price : product.price * ((100 - product.discount.discount_percent) / 100);


                context.cart_item.Remove(cartItem);
                context.SaveChanges();
                var session = context.shopping_session.Find(session_id);
                session.total -= productPrice * quantity;
                context.SaveChanges();
            }
        }
    }
}

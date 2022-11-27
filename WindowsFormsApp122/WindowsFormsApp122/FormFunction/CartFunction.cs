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
                return context.cart_item.Where(c => c.session_id == session_id).Select(c => new { c.quanlity, c.id ,price = c.product.price, nameProduct =  c.product.name_product}).ToList<dynamic>();
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
                session.total += product.price;
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
                var productPrice = cartItem.product.price;
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
                var productPrice = cartItem.product.price;

                context.cart_item.Remove(cartItem);
                context.SaveChanges();
                var session = context.shopping_session.Find(session_id);
                session.total -= productPrice * quantity;
                context.SaveChanges();
            }
        }
    }
}

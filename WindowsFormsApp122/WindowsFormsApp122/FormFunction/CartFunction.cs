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
        public static List<cart_item> cartItemsInfo(int session_id)
        {
            using (var context = new DatabaseEC())
            {
                return context.cart_item.Where(c => c.session_id == session_id).Select(c => c).ToList<cart_item>();
            }
        }

        public static decimal totalCartInfo(int session_id)
        {
            using (var context = new DatabaseEC())
            {
                return context.shopping_session.Find(session_id).id;
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
                    var cartItem = context.cart_item.Find(cartID);
                    cartItem.quanlity += 1;
                }
                else
                {
                    var newItem = new cart_item
                    {
                        session_id = session_id,
                        product_id = product_id,
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
    }
}

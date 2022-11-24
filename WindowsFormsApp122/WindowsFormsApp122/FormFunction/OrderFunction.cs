using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp122.Models;

namespace WindowsFormsApp122.FormFunction
{
    public class OrderFunction
    {
        public static List<dynamic> ordersInfo(int user_id)
        {
            using (var context = new DatabaseEC())
            {
                var query = context.order_details.Where(o => o.users_id == user_id && o.payment_details.statuss == "Processing").Select(o => new {o.id, o.total, o.payment_details.statuss, o.created_at, o.payment_details.providers });
                return query.ToList<dynamic>();
            }
        }
        public static List<order_items> orderItemsInfo(int order_id)
        {
            using (var context = new DatabaseEC())
            {
                var query = context.order_items.Where(o => o.order_id == order_id).Select(o => o);
                return query.ToList<order_items>();
            }
        }
        public static void checkOut(int user_id, int session_id, int user_payment_id)
        {
            using (var context = new DatabaseEC())
            {
                var paymentInfo = context.user_payment.Find(user_payment_id);
                var newPaymentDetail = new payment_details
                {
                    amount = 1,
                    providers = paymentInfo.providers,
                    statuss = "Processing",
                    created_at = DateTime.Now,
                };
                context.payment_details.Add(newPaymentDetail);
                context.SaveChanges();
                var session = context.shopping_session.Find(session_id);
                var newOrderDetail = new order_details
                {
                    total = session.total,
                    payment_id = context.payment_details.Max(pd => pd.id),
                    created_at = DateTime.Now,
                };
                context.order_details.Add(newOrderDetail);
                context.SaveChanges();
                var paymentDetailID = context.payment_details.Max(p => p.id);
                var paymentDetail = context.payment_details.Find(paymentDetailID);
                paymentDetail.order_id = context.order_details.Max(o => o.id);
                context.SaveChanges();
                var cartItems = context.cart_item.Where(c => c.session_id == session_id);
                foreach (var c in cartItems)
                {
                    var newOrderItem = new order_items
                    {
                        order_id = context.order_details.Max(od => od.id),
                        product_id = c.product_id,
                        quanlity = c.quanlity,
                        created_at = DateTime.Now,
                    };
                    context.order_items.Add(newOrderItem);
                    context.SaveChanges();
                }
            }
        }
    }
}

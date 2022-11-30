using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp122.Models;

namespace WindowsFormsApp122.FormFunction
{
    public class DiscountFunction
    {
        public static List<discount> listDiscount()
        {
            using (var context = new DatabaseEC())
            {
                return context.discounts.Select(d=>d).ToList<discount>();
            }
        }
        public static void addDiscount(string name, string desc, decimal percent, int state)
        {
            using (var context = new DatabaseEC())
            {
                var discount = new discount
                {
                    name_discount = name,
                    desc_discount = desc,
                    discount_percent = percent,
                    active = state == 1 ? true:false,
                    created_at = DateTime.Now,
                };
                context.discounts.Add(discount);
                context.SaveChanges();
            }
        }
        public static void changeStateDiscount(int id, int state)
        {
            using (var context = new DatabaseEC())
            {
                var dis =context.discounts.Find(id);
                dis.active = state == 1 ? true:false;
                context.SaveChanges();
            }
        }
        public static void alterProductToDiscount(int discountID, int productID, int turn)
        {
            using (var context = new DatabaseEC())
            {
                var pro = context.products.Find(productID);

                if (turn ==1)
                {
                    pro.discount = context.discounts.Find(discountID);
                    context.SaveChanges();
                } else
                {
                    pro.discount = null;
                    pro.discount_id = null;

                    context.SaveChanges();
                }
               
            }
        }
        public static void alterDiscount(int id, string name, string desc, decimal percent)
        {
            using (var context = new DatabaseEC())
            {
                var dis = context.discounts.Find(id);
                dis.name_discount = name;
                dis.desc_discount = desc;
                dis.discount_percent = percent;
                context.SaveChanges();
            }
        }
    }
}

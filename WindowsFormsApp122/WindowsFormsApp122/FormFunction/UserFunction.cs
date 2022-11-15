using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp122.Models;

namespace WindowsFormsApp122.FormFunction
{
    public class UserFunction
    {
        public static List<dynamic> displayInfo(int userId)
        {
            using (var context = new DatabaseEC())
            {
                var queryUser = context.users.Where(u => u.id == userId).Select(u => new { u.first_name, u.last_name, u.telephone, u.created_at }).ToList<dynamic>();
                var queryUserAddress = context.user_address.Where(u => u.id == userId).Select(u => new { u.address_line1, u.address_line2, u.city, u.country }).ToList<dynamic>();
                var queryUserPayment = context.user_payment.Where(u => u.id == userId).Select(u => new { u.payment_type, u.expiry, u.providers }).ToList<dynamic>();
                var info = queryUser.Concat(queryUserAddress).Concat(queryUserPayment);
                return info.ToList<dynamic>();
            }
        }
    }
}

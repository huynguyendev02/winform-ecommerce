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
        public static user displayUserInfo(int userId)
        {
            using (var context = new DatabaseEC())
            {
                var queryUser = context.users.Find(userId);
                return queryUser;
            }
        }
        public static List<user> listUser()
        {
            using (var context = new DatabaseEC())
            {
                return context.users.Select(u => u).ToList<user>();
            }
        }
        public static user_address displayUserAddressInfo(int userId)
        {
            using (var context = new DatabaseEC())
            {
                var check = context.user_address.Where(u => u.users_id == userId).Any();
                if (check)
                {
                    var queryUserAddress = context.user_address.Where(u => u.users_id == userId).First();

                    return queryUserAddress;
                }
                return null;
            }
        }
        public static List<user_payment> displayUserPaymentInfo(int userId)
        {
            using (var context = new DatabaseEC())
            {
                var queryUserPayment = context.user_payment.Where(u => u.users_id == userId).Select(u =>u );
                return queryUserPayment.ToList<user_payment>();
            }
        }
        public static void removeUser(int userId)
        {
            using (var context = new DatabaseEC())
            {
                var user = context.users.Find(userId);
                context.users.Remove(user);
                context.SaveChanges();
            }
        }
        public static void alterUserPassword(int userId, String password)
        {
            using (var context = new DatabaseEC())
            {
                var user = context.users.Find(userId);
                user.passwords = password;
                context.SaveChanges();
            }
        }
        public static void alterUserInfo(int userId, String firstName, String lastName, int telephone)
        {
            using (var context = new DatabaseEC())
            {
                var user = context.users.Find(userId);
                user.first_name = firstName;
                user.last_name = lastName;
                user.telephone = telephone;
                context.SaveChanges();
            }
        }
        public static void alterUserAddressInfo(int userId, String address_1, String address_2, String city, String postal_code, String country, String telephone, String mobile)
        {
            using (var context = new DatabaseEC())
            {
                var check = context.user_address.Where(ua => ua.users_id == userId).Any();
                if (!check)
                {
                    var usaddr = new user_address
                    {
                        user = context.users.Find(userId)
                    };
                    context.user_address.Add(usaddr);
                    context.SaveChanges();
                }
                var userAddress = context.user_address.Where(ua => ua.users_id == userId).First();

                userAddress.address_line1=address_1;
                userAddress.address_line2 = address_2;
                userAddress.city=city; 
                userAddress.country=country;
                userAddress.postal_code=postal_code;
                userAddress.mobile=mobile;
                userAddress.telephone=telephone;
                context.SaveChanges();
            }
        }
        public static void alterUserPaymentInfo(int id, String payment_type, String providers, int account_no, DateTime expiry)
        {
            using (var context = new DatabaseEC())
            {
                var userPayment = context.user_payment.Find(id);
                userPayment.payment_type = payment_type;
                userPayment.providers = providers;
                userPayment.account_no = account_no;
                userPayment.expiry=expiry;
                context.SaveChanges();
            }
        }
        public static void removeUserPaymentInfo(int id)
        {
            using (var context = new DatabaseEC())
            {
                var userPayment = context.user_payment.Find(id);
                context.user_payment.Remove(userPayment);
                context.SaveChanges(); 
            }
        }
        public static int totalUser()
        {
            using (var context = new DatabaseEC())
            {
                return context.users.Count()-1;
            }
        }
        public static void addUserPaymentInfo(int userId, String payment_type, String providers, int account_no, DateTime expiry)
        {
            using (var context = new DatabaseEC())
            {
                var newUserPayment = new user_payment
                {
                    user = context.users.Find(userId),
                    payment_type = payment_type,
                    providers = providers,
                    account_no = account_no,
                    expiry = expiry,
                };
                context.user_payment.Add(newUserPayment);
                context.SaveChanges();
        }

    }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp122.Models;

namespace WindowsFormsApp122.FormFunction
{
    public class RegisterFunction
    {
        public static void Register(String username, String passwords, String firstName, String lastName, int telephone)
        {
            using (var context = new DatabaseEC())
            {
                var user = new user
                {
                    username = username,
                    passwords = passwords,
                    first_name = firstName,
                    last_name = lastName,
                    telephone = telephone,
                    created_at = DateTime.Now,
                };
                context.users.Add(user);
                context.SaveChanges();
            }
        }
    }
}

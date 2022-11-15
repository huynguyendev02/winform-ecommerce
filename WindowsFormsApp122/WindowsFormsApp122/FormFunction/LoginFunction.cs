using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp122.Models;

namespace WindowsFormsApp122.FormFunction
{
    public class LoginFunction
    {
        public static bool checkLoginCredential(String username, String password)
        {
            using (var context = new DatabaseEC())
            {
                var query = context.users.Where(u => u.username == username && u.passwords == password).Count();
                if (query > 0)
                    return true;
                return false;
            }
        }
    }
}

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
        public static int checkLoginCredential(String username, String password)
        {
            using (var context = new DatabaseEC())
            {
                var query = context.users.Where(u => u.username == username && u.passwords == password).Count();
                var id = context.users.Where(u => u.username == username && u.passwords == password).Select(u => u.id);
                if (query > 0)
                {
                    if (id.First() == 1)
                        return 1;
                    return id.First();
                }
                return 0;   
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WindowsFormsApp122.Models;

namespace WindowsFormsApp122.FormFunction
{
    public class SessionFunction
    {
        public static void createSession(int user_id)
        {
            using (var context = new DatabaseEC())
            {
                var newSession = new shopping_session
                {
                    user = context.users.Find(user_id),
                    total = 0,
                    created_at = DateTime.Now,
                };
                context.shopping_session.Add(newSession);
                context.SaveChanges();
            }
        }
        public static int getIdCurrentSession(int user_id)
        {
            using (var context = new DatabaseEC())
            {
                var query = context.shopping_session.Where(s => s.users_id==user_id).Max(s => s.id);
                return query;
            }
        }
    }
}

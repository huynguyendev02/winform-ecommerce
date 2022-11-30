using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.Controllers.Draw;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.Controllers.UserController
{
    public class AcountController
    {
        DrawAccount yeah;
        MainForm parent;
        public AcountController(Panel Account, Panel pnHeader, Panel pnContent, MainForm parent)
        {
            this.parent = parent;
            yeah = new DrawAccount(Account, pnHeader, pnContent, parent);
            GetDataForInformation();
        }

        public void GetDataForInformation()
        {
            var user = UserFunction.displayUserInfo(MainForm.getUserID());
            var userAddress = UserFunction.displayUserAddressInfo(MainForm.getUserID());
            yeah.getDataForInformation(user.first_name, user.last_name, userAddress.telephone.ToString(), userAddress.mobile, userAddress.city, userAddress.country, userAddress.address_line1, userAddress.address_line2, userAddress.postal_code, user.created_at.ToString());
        }
    }
}

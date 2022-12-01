using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            if (userAddress != null)
            {
                var telephone = userAddress.telephone != null ? userAddress.telephone.ToString() : "";
                var mobile = userAddress.mobile != null ? userAddress.mobile.ToString() : "";
                var city = userAddress.city != null ? userAddress.city.ToString() : "";
                var country = userAddress.country != null ? userAddress.country : "";
                var address_line1 = userAddress.address_line1 != null ? userAddress.address_line1 : "";
                var address_line2 = userAddress.address_line2 != null ? userAddress.address_line2 : "";
                var postal_code = userAddress.postal_code != null ? userAddress.postal_code : "";
                yeah.getDataForInformation(user.first_name, user.last_name, telephone.ToString(), mobile, city, country, address_line1, address_line2, postal_code, user.created_at.ToString());

            }
            else
            {
                yeah.getDataForInformation(user.first_name, user.last_name, "", "", "", "", "","","", user.created_at.ToString());


            }

        }
    }
}

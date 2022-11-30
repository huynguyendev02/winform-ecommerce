using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;
using WindowsFormsApp122.UserForm;

namespace WindowsFormsApp122.Controllers.Draw
{
    public class DrawPayInShoppingCart1
    {
        Label id = new Label();
        TextBox typeAccount = new TextBox(), provider = new TextBox(), AccountNum = new TextBox(), Exp = new TextBox();
        TextBox[] allTB;
        FormPayInShoppingCart yeah;
        MainForm parent;
        int idPay;
        public DrawPayInShoppingCart1(MainForm parent, FormPayInShoppingCart form, string id, string typeAccount, string provider, string AccountNum, string Exp, int idPay)
        {
            this.parent = parent;
            yeah = form;
            this.id.Text = id;
            this.typeAccount.Text = typeAccount;

            this.provider.Text = provider;
            this.AccountNum.Text = AccountNum;
            this.Exp.Text = Exp;
            this.idPay = idPay;
        }
        public void Draw(Panel parent)
        {
            Panel pn = new Panel();
            parent.Controls.Add(pn);
            pn.Size = new Size(866, 100);
            pn.Dock = DockStyle.Top;
            pn.Location = new Point(0, 0);
            pn.BackColor = Color.White;
            pn.BorderStyle = BorderStyle.FixedSingle;

            allTB = new TextBox[] { typeAccount, provider, AccountNum, Exp };
            int count = 0;
            foreach (var lb in allTB)
            {
                pn.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
                lb.ReadOnly = true;
                lb.BorderStyle = BorderStyle.None;
                lb.BackColor = Color.White;
                count++;
            }
            pn.Controls.Add(id);
            id.Location = new Point(10, 35);
            id.Size = new Size(20, 20);
            id.Font = new Font("Calibri Light", 15, FontStyle.Bold);



            typeAccount.Location = new Point(70, 35);
            typeAccount.Size = new Size(100, 20);
            //contry.Location = new Point(200, 35);
            provider.Location = new Point(230, 35);
            AccountNum.Location = new Point(400, 35);
            Exp.Location = new Point(580, 35);

            Button view = new Button();
            pn.Controls.Add(view);
            view.Size = new Size(80, 30);
            view.Text = "Choose";
            view.Font = new Font("Calibri Light", 12, FontStyle.Bold);
            view.Location = new Point(750, 35);
            view.BackColor = Color.Green;
            view.ForeColor = Color.White;
            view.Click += View_Click;
        }

        private void View_Click(object sender, EventArgs e)
        {
            OrderFunction.checkOut(MainForm.getUserID(), SessionFunction.getIdCurrentSession(MainForm.getUserID()), idPay);
            MessageBox.Show("Your order has been checked out, check it in My Orders", "Successfully");
            yeah.Close();
            parent.pnDashboard_Click(sender, e);
        }

    }
}

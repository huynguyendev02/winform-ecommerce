using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.Controllers.Draw
{
    public class DrawPaymentItemController
    {
        Label stt = new Label();
        TextBox typeAccount = new TextBox(), provider = new TextBox(), AccountNum = new TextBox(), Exp = new TextBox();
        TextBox[] allTB;
        int id;
        Panel pn = new Panel();

        public DrawPaymentItemController(int id, string stt, string typeAccount, string provider, string AccountNum, string Exp)
        {
            this.id = id;
            this.stt.Text = stt;
            this.typeAccount.Text = typeAccount;

            this.provider.Text = provider;
            this.AccountNum.Text = AccountNum;
            this.Exp.Text = Exp.Split(' ')[0];
        }
        public void Draw(Panel parent)
        {
            parent.Controls.Add(pn);
            pn.Size = new Size(866, 100);
            pn.Dock = DockStyle.Top;
            pn.Location = new Point(0, 0 * 100);
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
            typeAccount.Size = new Size(250, 20);
            provider.Size = new Size(150, 20);
            Exp.Size = new Size(150, 20);
            pn.Controls.Add(stt);
            stt.Location = new Point(10, 35);
            stt.Size = new Size(20, 20);
            stt.Font = new Font("Calibri Light", 15, FontStyle.Bold);



            typeAccount.Location = new Point(70, 35);
            typeAccount.Size = new Size(100, 20);
            provider.Location = new Point(230, 35);
            AccountNum.Location = new Point(400, 35);
            Exp.Location = new Point(580, 35);

            Button view = new Button();
            pn.Controls.Add(view);
            view.Size = new Size(80, 30);
            view.Text = "Edit";
            view.Font = new Font("Calibri Light", 12, FontStyle.Bold);
            view.Location = new Point(750, 35);
            view.BackColor = Color.Blue;
            view.ForeColor = Color.White;
            view.Click += View_Click;

            Label removePay = new Label();
            pn.Controls.Add(removePay);
            removePay.Size = new Size(80, 30);
            removePay.Text = "Remove";
            removePay.Font = new Font("Calibri Light", 12, FontStyle.Bold);
            removePay.Location = new Point(755, 65);
            removePay.ForeColor = Color.Red;
            removePay.Click += RemovePay_Click;
        }

        private void RemovePay_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove this one?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UserFunction.removeUserPaymentInfo(this.id);
                this.pn.Dispose();

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            Button bt = (sender as Button);
            if (bt.Text == "Edit")
            {
                foreach (var lb in allTB)
                {
                    lb.ReadOnly = false;
                    bt.Text = "Save";
                    lb.BorderStyle = BorderStyle.FixedSingle;
                    bt.BackColor = Color.Green;
                }
                return;

            }

            if (bt.Text == "Save")
            {
                foreach (var lb in allTB)
                {
                    lb.ReadOnly = true;
                    bt.Text = "Edit";
                    lb.BorderStyle = BorderStyle.None;
                    bt.BackColor = Color.Blue;
                }
                UserFunction.alterUserPaymentInfo(this.id, typeAccount.Text, provider.Text, Int32.Parse(AccountNum.Text), DateTime.Parse(Exp.Text));
                return;
            }
        }
    }
}

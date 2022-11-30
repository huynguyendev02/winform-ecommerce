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
    public class DrawPaymentListController
    {
        Panel Account = new Panel(), pnTitelItem = new Panel(), pnContent = new Panel();
        Label lbStt = new Label(), lbTypeAccount = new Label(), lbContry = new Label(), lbProvider = new Label(), lbAccountNum = new Label(), lbExp = new Label(), lbAddPay = new Label();
        Label[] allLabel;

      
        public DrawPaymentListController(Panel Account)
        {
            this.Account = Account;
            this.Account.Controls.Add(this.pnTitelItem);
            this.Account.Controls.Add(this.pnContent);
            this.pnTitelItem.Location = new Point(0, 0);
            this.pnTitelItem.Size = new Size(Account.Size.Width, 45);
            this.pnTitelItem.BorderStyle = BorderStyle.FixedSingle;

            this.pnContent.Location = new Point(0, 45);
            this.pnContent.Size = new Size(Account.Size.Width, Account.Size.Height - 45);
            this.pnContent.AutoScroll = true;

            AccountTitle();
            AccountContent();

        }

        public void AccountTitle()
        {
            allLabel = new Label[] {
                lbStt, lbTypeAccount, lbContry, lbProvider, lbAccountNum, lbExp, lbAddPay
            };
            foreach (var lb in allLabel)
            {
                pnTitelItem.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
                lb.Size = new Size(100, 40);

            }

            lbStt.Text = "STT";
            lbStt.Location = new Point(2, 10);
            lbStt.Size = new Size(50, 20);

            lbTypeAccount.Text = "Type";
            lbTypeAccount.Location = new Point(70, 10);

            lbProvider.Text = "Provider";
            lbProvider.Location = new Point(230, 10);

            lbAccountNum.Text = "AccountNum";
            lbAccountNum.Location = new Point(400, 10);
            lbAccountNum.Size = new Size(150, 40);

            lbExp.Text = "Exp";
            lbExp.Location = new Point(580, 10);

            lbAddPay.Text = "Add Payment";
            lbAddPay.Location = new Point(760, 10);
            lbAddPay.ForeColor = Color.Green;
            lbAddPay.Click += LbAddPay_Click;
        }

        private void LbAddPay_Click(object sender, EventArgs e)
        {
            UserForm.AddNewPaymentForm yeah = new AddNewPaymentForm();
            yeah.Show();
        }

        public void AccountContent()
        {
            var paymentInfos = UserFunction.displayUserPaymentInfo(MainForm.getUserID());
            int index = 0, length = paymentInfos.Count;
            foreach(var payment in paymentInfos)
            {
                DrawPaymentItemController item = new DrawPaymentItemController(payment.id, (length-index).ToString(), payment.payment_type, payment.providers, payment.account_no.ToString(), payment.expiry.ToString());
                item.Draw(pnContent);
                index++;
            }
        }
    }
}

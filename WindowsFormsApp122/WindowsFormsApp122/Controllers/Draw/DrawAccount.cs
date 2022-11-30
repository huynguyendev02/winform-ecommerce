using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp122.Controllers.Draw
{
    public class DrawAccount
    {
        Panel Account = new Panel(), pnHeader = new Panel(), pnContent = new Panel(), panel1 = new Panel(), panel2 = new Panel(), panel3 = new Panel();
        Label UserName = new Label(), lbInformation = new Label(), lbPassword = new Label(), lbPayment = new Label();

        Label firstName = new Label(), lastName = new Label(), telephone = new Label(), mobile = new Label(), city = new Label(), contry = new Label(), address1 = new Label(), address2 = new Label(), postal = new Label(), createDay = new Label();
        Label oldPass = new Label(), newPass = new Label(), confirmPass = new Label();
        Label provider = new Label(), accountNum = new Label(), exp = new Label();
        CheckBox visa = new CheckBox(), masterCard = new CheckBox(), order = new CheckBox();
        CheckBox[] listCheckBox;

        Label[] lbHeader, lbInfor, lbPass, lbPay, all;
        TextBox tbFirstName = new TextBox(), tbLastName = new TextBox(), tbTelephone = new TextBox(), tbMobile = new TextBox(), tbCity = new TextBox(), tbContry = new TextBox(), tbAddress1 = new TextBox(), tbAddress2 = new TextBox(), tbPostal = new TextBox(), tbCreateDay = new TextBox();
        TextBox[] tbInfor, tbPassWord, tbPay;
        TextBox tbOldPass = new TextBox(), tbNewPass = new TextBox(), tbConfirmPass = new TextBox();
        TextBox tbProvider = new TextBox(), tbAccountNum = new TextBox(), tbExp = new TextBox();
        Panel[] allPanel;
        Button EditInfor = new Button(), EditPayment = new Button(), SaveInfor = new Button(), SavePayment = new Button(), Ok = new Button(), cancelInfor = new Button(), cancelPass = new Button(), cancelPay = new Button();

        MainForm parent;
        string[] saveTextUserInfo = new string[12];
        public DrawAccount(Panel Account, Panel pnHeader, Panel pnContent, MainForm parent)
        {
            this.parent = parent;
            this.Account = Account;
            this.Account.Controls.Add(this.pnHeader);
            this.Account.Controls.Add(this.pnContent);

            this.pnHeader.Size = pnHeader.Size;
            this.pnHeader.Location = pnHeader.Location;
            this.pnHeader.BackColor = pnHeader.BackColor;


            this.pnContent.Size = pnContent.Size;
            this.pnContent.Location = pnContent.Location;
            this.pnContent.BackColor = Color.Red;

            this.pnContent.Visible = true;
            this.pnHeader.Visible = true;

            AccountHeader();
            AccountContent();
            InFor(allPanel[0]);
            Password(allPanel[1]);
            Payment(allPanel[2]);
            panel1.Visible = true;
            this.parent = parent;
        }
        public void AccountHeader()
        {

            lbHeader = new Label[] {
                UserName, lbInformation, lbPassword, lbPayment,
            };
            int count = 0;
            var userInfo = UserFunction.displayUserInfo(MainForm.getUserID());
            UserName.Text = userInfo.first_name +" " + userInfo.last_name;
            UserName.Size = new Size(120, 120);
            lbInformation.Text = "Information";
            lbInformation.Size = new Size(120, 40);
            lbPassword.Text = "Password";
            lbPayment.Text = "Payment";

            foreach (var lb in lbHeader)
            {
                pnHeader.Controls.Add(lb);
                pnHeader.Controls.SetChildIndex(lb, 0);
                lb.Visible = true;
                lb.Font = new Font("Calibri Light", 14, FontStyle.Bold);
                lb.ForeColor = Color.White;
                lb.Location = new Point(count * 150 + 300, 23);
                count++;
            }
            UserName.Location = new Point(100, 23);

            lbInformation.Click += LbInformation_Click;
            lbPassword.Click += LbPassword_Click;
            lbPayment.Click += LbPayment_Click;
        }

        private void LbPayment_Click(object sender, EventArgs e)
        {
            foreach (Panel pn in allPanel) pn.Visible = false;
            panel3.Visible = true;
        }

        private void LbPassword_Click(object sender, EventArgs e)
        {
            foreach (Panel pn in allPanel) pn.Visible = false;
            panel2.Visible = true;
        }

        private void LbInformation_Click(object sender, EventArgs e)
        {
            foreach (Panel pn in allPanel) pn.Visible = false;
            panel1.Visible = true;
        }

        public void AccountContent()
        {

            allPanel = new Panel[]
            {
                panel1,panel2, panel3,
            };
            pnContent.Visible = false;
            for (int i = 0; i < 3; i++)
            {

                Account.Controls.Add(allPanel[i]);
                allPanel[i].Size = pnContent.Size;
                allPanel[i].Location = pnContent.Location;
                allPanel[i].BackColor = Color.Transparent;
                allPanel[i].AutoScroll = true;
                allPanel[i].Visible = false;
            }
            allPanel[2].Visible = true;
        }

        public void InFor(Panel parent)
        {
            Label setting = new Label();
            parent.Controls.Add(setting);
            setting.Text = "Settings Account";
            setting.Font = new Font("Calibri Light", 30, FontStyle.Bold);
            setting.Location = new Point(43, 40);
            setting.Size = new Size(600, 50);


            lbInfor = new Label[] { firstName, lastName, telephone, mobile, city, contry, address1, address2, postal, createDay, };
            foreach (Label lb in lbInfor)
            {
                parent.Controls.Add(lb);
                lb.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Size = new System.Drawing.Size(128, 31);
            }
            firstName.Location = new System.Drawing.Point(43, 124);
            lastName.Location = new System.Drawing.Point(470, 124);
            telephone.Location = new System.Drawing.Point(43, 204);
            mobile.Location = new System.Drawing.Point(470, 204);
            city.Location = new System.Drawing.Point(43, 274);
            contry.Location = new System.Drawing.Point(470, 274);
            address1.Location = new System.Drawing.Point(43, 344);
            address2.Location = new System.Drawing.Point(470, 344);
            postal.Location = new System.Drawing.Point(43, 414);
            createDay.Location = new System.Drawing.Point(470, 414);

            firstName.Text = "FirstName";
            lastName.Text = "LastName";
            telephone.Text = "Telephone";
            mobile.Text = "Mobile";
            city.Text = "City";
            contry.Text = "Contry";
            address1.Text = "AddressOne";
            address2.Text = "AddressTwo";
            postal.Text = "Postal";
            createDay.Text = "Created day";

            tbInfor = new TextBox[] { tbFirstName, tbLastName, tbTelephone, tbMobile, tbCity, tbContry, tbAddress1, tbAddress2, tbPostal, tbCreateDay, };
            foreach (TextBox tb in tbInfor)
            {
                parent.Controls.Add(tb);
                tb.AutoSize = false;
                tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tb.Size = new System.Drawing.Size(330, 30);
                tb.ReadOnly = true;
            }

            tbFirstName.Location = new System.Drawing.Point(43, 155);
            tbLastName.Location = new System.Drawing.Point(470, 155);
            tbTelephone.Location = new System.Drawing.Point(43, 235);
            tbMobile.Location = new System.Drawing.Point(470, 235);
            tbCity.Location = new System.Drawing.Point(43, 305);
            tbContry.Location = new System.Drawing.Point(470, 305);
            tbAddress1.Location = new System.Drawing.Point(43, 375);
            tbAddress2.Location = new System.Drawing.Point(470, 375);
            tbPostal.Location = new System.Drawing.Point(43, 445);
            tbCreateDay.Location = new System.Drawing.Point(470, 445);


            parent.Controls.Add(EditInfor);
            parent.Controls.Add(cancelInfor);
            parent.Controls.Add(SaveInfor);
            SaveInfor.Visible = false;


            EditInfor.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            cancelInfor.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            SaveInfor.Font = new Font("Calibri Light", 15, FontStyle.Bold);

            EditInfor.Text = "Edit";
            cancelInfor.Text = "Cancel";
            cancelInfor.Visible = false;
            SaveInfor.Text = "Save";

            EditInfor.BackColor = Color.Blue;
            EditInfor.ForeColor = Color.White;
            SaveInfor.BackColor = Color.Green;

            EditInfor.Size = new Size(120, 40);
            cancelInfor.Size = new Size(120, 40);
            SaveInfor.Size = new Size(120, 40);

            EditInfor.Location = new Point(43, 540);
            cancelInfor.Location = new Point(200, 540);
            SaveInfor.Location = new Point(680, 540);

            EditInfor.Click += EditInfor_Click;
            cancelInfor.Click += CancelInfor_Click;
            SaveInfor.Click += Save_Click;
        }

        private void CancelInfor_Click(object sender, EventArgs e)
        {
            cancelInfor.Visible = false;
            SaveInfor.Visible = false;
            int countTb = 0;
            foreach (TextBox tb in tbInfor)
            {
                tb.Text = saveTextUserInfo[countTb++];
                tb.ReadOnly = true;
            }
        }

        private void EditInfor_Click(object sender, EventArgs e)
        {
            cancelInfor.Visible = true;
            int countTb = 0;
            foreach (TextBox tb in tbInfor)
            {
                saveTextUserInfo[countTb++] = tb.Text;
                tb.ReadOnly = false;
            }
            tbCreateDay.ReadOnly = true;
            SaveInfor.Visible = true;
        }

        public void Password(Panel parent)
        {
            Label setting = new Label();
            parent.Controls.Add(setting);
            setting.Text = "Settings Account";
            setting.Font = new Font("Calibri Light", 30, FontStyle.Bold);
            setting.Location = new Point(43, 40);
            setting.Size = new Size(600, 50);

            lbPass = new Label[] { oldPass, newPass, confirmPass, };
            foreach (Label lb in lbPass)
            {
                parent.Controls.Add(lb);
                lb.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Size = new System.Drawing.Size(300, 31);
            }

            oldPass.Location = new System.Drawing.Point(43, 124);
            newPass.Location = new System.Drawing.Point(43, 204);
            confirmPass.Location = new System.Drawing.Point(43, 274);


            oldPass.Text = "Old password";
            newPass.Text = "New password";
            confirmPass.Text = "Confirm password";


            tbPassWord = new TextBox[] { tbOldPass, tbNewPass, tbConfirmPass, };
            foreach (TextBox tb in tbPassWord)
            {
                parent.Controls.Add(tb);
                tb.AutoSize = false;
                tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tb.Size = new System.Drawing.Size(330, 30);
                tb.PasswordChar = '*';
            }

            tbOldPass.Location = new System.Drawing.Point(43, 155);
            tbNewPass.Location = new System.Drawing.Point(43, 235);
            tbConfirmPass.Location = new System.Drawing.Point(43, 305);


            parent.Controls.Add(Ok);
            parent.Controls.Add(cancelPass);
            SaveInfor.Visible = false;


            Ok.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            cancelPass.Font = new Font("Calibri Light", 15, FontStyle.Bold);

            Ok.Text = "OK";
            cancelPass.Text = "Cancel";
            cancelPass.Visible = false;

            Ok.BackColor = Color.Blue;
            Ok.ForeColor = Color.White;

            Ok.Size = new Size(120, 40);
            cancelPass.Size = new Size(120, 40);

            Ok.Location = new Point(43, 540);
            cancelPass.Location = new Point(200, 540);

            Ok.Click += Ok_Click;
            cancelPass.Click += CancelPass_Click; ;
        }

        private void CancelPass_Click(object sender, EventArgs e)
        {
            tbOldPass.Text = "";
            tbNewPass.Text = "";
            tbConfirmPass.Text = "";
        }

        public void Payment(Panel parent)
        {
            DrawPaymentListController yeah = new DrawPaymentListController(parent);
        }

        private void Order_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in listCheckBox) cb.Checked = false;
            order.Checked = true;
        }

        private void MasterCard_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in listCheckBox) cb.Checked = false;
            masterCard.Checked = true;
        }

        private void Visa_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in listCheckBox) cb.Checked = false;
            visa.Checked = true;
            return;
        }

        private void EditPayment_Click(object sender, EventArgs e)
        {
            SavePayment.Visible = true;
            foreach (TextBox tb in tbPay)
            {
                tb.ReadOnly = false;
            }
        }

        private void SavePayment_Click(object sender, EventArgs e)
        {
            SavePayment.Visible = false;
            foreach (TextBox tb in tbPay)
            {
                tb.ReadOnly = true;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            cancelPass.Visible = true;
            var userPsw = UserFunction.displayUserInfo(MainForm.getUserID()).passwords;
            if (tbOldPass.Text != userPsw)
            {
                MessageBox.Show("Your current password is not valid!", "Something goes wrong");
                return;
            }
            if (tbNewPass.Text != tbConfirmPass.Text)
            {
                MessageBox.Show("Your confirm password is not correct", "Something goes wrong");
                return;
            }
            UserFunction.alterUserPassword(MainForm.getUserID(), tbNewPass.Text);
            MessageBox.Show("Change password successfully", "Success");
            tbOldPass.Text = "";
            tbNewPass.Text = "";
            tbConfirmPass.Text = "";

        }

        public void getDataForInformation(string a, string b, string c, string d, string e, string f, string g, string h, string j, string k)
        {
            tbFirstName.Text = a;
            tbLastName.Text = b;
            tbTelephone.Text = c;
            tbMobile.Text = d;
            tbCity.Text = e;
            tbContry.Text = f;
            tbAddress1.Text = g;
            tbAddress2.Text = h;
            tbPostal.Text = j;
            tbCreateDay.Text = k;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            UserFunction.alterUserInfo(MainForm.getUserID(), tbFirstName.Text, tbLastName.Text, Int32.Parse(tbTelephone.Text));
            UserFunction.alterUserAddressInfo(MainForm.getUserID(), tbAddress1.Text, tbAddress1.Text, tbCity.Text, tbPostal.Text, tbContry.Text, tbTelephone.Text,tbMobile.Text); 
            SaveInfor.Visible = false;
            foreach (TextBox tb in tbInfor)
            {
                tb.ReadOnly = true;
            }
            cancelInfor.Visible = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("canCel", "Thong bao");
        }
    }
}

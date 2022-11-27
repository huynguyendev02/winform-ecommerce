using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.Controllers.UserController
{
    public class AcountController
    {
        Panel Account = new Panel(), pnHeader = new Panel(), pnContent = new Panel(), panel1 = new Panel(), panel2 = new Panel(), panel3 = new Panel();
        Label UserName = new Label(),Information = new Label(), PassWord = new Label(), Payment = new Label();
        Label firstName = new Label(), lastName = new Label(), telephone = new Label(), mobile = new Label(), city = new Label(), contry = new Label(), address1 = new Label(), address2 = new Label(), postal = new Label(), createDay = new Label(); 
        Label[] lbInfor;
        TextBox tbFirstName = new TextBox(), tbLastName = new TextBox(), tbTelephone = new TextBox(), tbMobile = new TextBox(), tbCity = new TextBox(), tbContry = new TextBox(), tbAddress1 = new TextBox(), tbAddress2 = new TextBox(), tbPostal = new TextBox(), tbCreateDay = new TextBox();
        TextBox[] tbInfor;
        Panel[] allPanel;

        public AcountController(Panel Account, Panel pnHeader, Panel pnContent)
        {
            this.Account = Account;
            this.Account.Controls.Add(this.pnHeader);
            this.Account.Controls.Add(this.pnContent);

            this.pnHeader.Size = pnHeader.Size;
            this.pnHeader.Location = pnHeader.Location;
            this.pnHeader.BackColor = pnHeader.BackColor;


            this.pnContent = pnContent;
            this.pnContent.BackColor = Color.Red;

            this.pnContent.Visible = true;
            this.pnHeader.Visible = true;

            AccountHeader();
            AccountContent();
            InFor(allPanel[0]);
        }
        public void AccountHeader()
        {

            //allLabel = new Label[] {
            //    UserName, Information, PassWord, Payment,
            //};
            //int count = 0;
            //UserName.Text = "SonGoKu";
            //Information.Text = "Information"; 
            //Information.Size = new Size(120, 40);
            //PassWord.Text = "Password";
            //Payment.Text = "Payment";
            
            //foreach (var lb in allLabel)
            //{
            //    pnHeader.Controls.Add(lb);
            //    pnHeader.Controls.SetChildIndex(lb, 0);
            //    lb.Visible = true;
            //    lb.Font = new Font("Calibri Light", 14, FontStyle.Bold);
            //    lb.ForeColor = Color.White;
            //    lb.Location = new Point(count * 150 + 300, 23);
            //    count++;
            //}
            //UserName.Location = new Point(100,23);
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
            allPanel[0].Visible = true;
        }

        public void InFor(Panel parent)
        {
            lbInfor = new Label[] { firstName, lastName, telephone, mobile, city, contry, address1, address2, postal, createDay,};
            foreach (Label lb in lbInfor)
            {
                parent.Controls.Add(lb);
                lb.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));              
                lb.Size = new System.Drawing.Size(128, 31);
                lb.Text = "Hello cuoojc dodiwf";
            }
            firstName.Location = new System.Drawing.Point(43, 119);
            lastName.Location = new System.Drawing.Point(614, 119);
            telephone.Location = new System.Drawing.Point(43, 231);
            mobile.Location = new System.Drawing.Point(646, 231);
            city.Location = new System.Drawing.Point(43, 325);
            contry.Location = new System.Drawing.Point(646, 325);
            address1.Location = new System.Drawing.Point(43, 427);
            address2.Location = new System.Drawing.Point(646, 427);
            postal.Location = new System.Drawing.Point(43, 521);
            createDay.Location = new System.Drawing.Point(614, 521);



            tbInfor = new TextBox[] { tbFirstName, tbLastName, tbTelephone, tbMobile, tbCity, tbContry, tbAddress1, tbAddress2, tbPostal, tbCreateDay,};
            foreach (TextBox tb in tbInfor)
            {
                tb.AutoSize = false;
                tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tb.Size = new System.Drawing.Size(489, 48);
                parent.Controls.Add(tb);
            }
            tbFirstName.Location = new System.Drawing.Point(43, 153);
            tbLastName.Location = new System.Drawing.Point(614, 153);
            tbTelephone.Location = new System.Drawing.Point(43, 265);
            tbMobile.Location = new System.Drawing.Point(614, 265);
            tbCity.Location = new System.Drawing.Point(43, 360);
            tbContry.Location = new System.Drawing.Point(614, 360);
            tbAddress1.Location = new System.Drawing.Point(43, 461);
            tbAddress2.Location = new System.Drawing.Point(614, 461);
            tbPostal.Location = new System.Drawing.Point(43, 555);
            tbCreateDay.Location = new System.Drawing.Point(614, 555);
        }
    }
}

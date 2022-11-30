using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp122.Controllers.DrawManagement
{
    internal class DrawUserAccount
    {
        Label stt = new Label();
        TextBox username = new TextBox(), pass = new TextBox();
        TextBox[] allTb;
        Button edit = new Button(), remove = new Button();
        Panel pn = new Panel();
        int index;
        public DrawUserAccount(int index, string stt, string username, string pass)
        {
            this.index = index;
            this.stt.Text = stt;
            this.username.Text = username;
            this.pass.Text = pass;
        }

        public void Draw(Panel parent)
        {
            
            parent.Controls.Add(pn);
            pn.Size = new Size(866, 100);
            pn.Dock = DockStyle.Top;
            pn.Location = new Point(0, index * 100);
            pn.BackColor = Color.White;
            pn.BorderStyle = BorderStyle.FixedSingle;


            allTb = new TextBox[] { username, pass, };
            int count = 0;
            foreach (var lb in allTb)
            {
                pn.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
                stt.Location = new Point(10 + count * 10, 35);
                lb.BorderStyle= BorderStyle.None;
                lb.BackColor = Color.White;
                lb.ReadOnly = true;
                count++;
            }

            pn.Controls.Add(stt);
            stt.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            stt.Location = new Point(2,30);
            stt.Size = new Size(50, 30);

            username.Location = new Point(200, 30);
            username.Size = new Size(200, 30);

            pass.Location = new Point(440, 30);
            pass.Size = new Size(200, 30);


            pn.Controls.Add(edit);
            edit.Text = "Edit";
            edit.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            edit.ForeColor = Color.White;
            edit.BackColor = Color.Blue;
            edit.Location = new Point(670, 10);
            edit.Size = new Size(110, 35);
            edit.Click += Edit_Click;

            pn.Controls.Add(remove);
            remove.Text = "Remove";
            remove.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            remove.ForeColor = Color.White;
            remove.BackColor = Color.Red;
            remove.Location = new Point(670, 50);
            remove.Size = new Size(110, 35);
            remove.Click += Remove_Click;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            pn.Dispose();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Button bt = (sender as Button);
            if (bt.Text == "Edit")
            {
                bt.Text = "Save";
                bt.BackColor = Color.Green;
                foreach (var tb in allTb)
                {
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tb.ReadOnly = false;
                }
            }
            else
            {
                bt.Text = "Edit";
                bt.BackColor = Color.Blue;
                foreach (var tb in allTb)
                {
                    tb.BorderStyle = BorderStyle.None;
                    tb.ReadOnly= true;
                }
            }
        }
    }
}

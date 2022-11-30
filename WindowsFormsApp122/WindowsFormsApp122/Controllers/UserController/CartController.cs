using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.Controllers.Draw;
using WindowsFormsApp122.FormFunction;
using WindowsFormsApp122.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp122.Controllers.UserController
{
    public class CartController
    {
        Panel Cart = new Panel() , pnHeader = new Panel(), pnContent = new Panel(), pnTotal = new Panel();
        Label lbTitle = new Label(), lbCheckOut = new Label(), lbSubTotal = new Label(), lbCountItem = new Label(), lbToTalPrice = new Label();
        Label[] allLabel;

        MainForm parent;
        private int user_id;
        
      
        public CartController(Panel Cart, Panel pnHeader, Panel pnContent, int user_id, MainForm parent)
        {
            this.user_id = user_id;
            this.parent = parent;
            this.Cart = Cart;

            this.Cart.Controls.Add(this.pnHeader);
            this.Cart.Controls.Add(this.pnContent);
            this.pnContent.BringToFront();
            this.Cart.Controls.Add(this.pnTotal);
            this.pnTotal.BringToFront();



            pnContent.Visible = false;

            this.pnHeader.Size = pnHeader.Size;
            this.pnHeader.Location = pnHeader.Location;
            this.pnHeader.BackColor = pnHeader.BackColor;

            this.pnContent.Location = pnContent.Location;
            this.pnContent.Size = new Size(pnContent.Size.Width, pnHeader.Size.Height + pnContent.Size.Height - 150);
            this.pnContent.AutoScroll = true;

            this.pnTotal.Location = new Point(0, this.pnContent.Size.Height+this.pnHeader.Size.Height);
            this.pnTotal.Size = new Size(pnContent.Size.Width,150);
            this.pnTotal.Visible = true;
            this.pnTotal.BackColor = pnHeader.BackColor;
            CartHeader();
            CartContent();
            CartTotal();
        }

    

        public void CartHeader()
        {
            allLabel = new Label[] { lbTitle, lbCheckOut };
            int count = 0;
            lbTitle.Text = "Shopping Cart";
            lbCheckOut.Text = "Check out";
            foreach (var lb in allLabel)
            {
                pnHeader.Controls.Add(lb);
                lb.Visible = true;
                lb.Size = new Size(200, 25);
                lb.Font = new Font("Calibri Light", 14, FontStyle.Bold);
                lb.ForeColor = Color.White;
                lb.Location = new Point(count * 630 + 100, 23);
                count++;
            }
            lbCheckOut.Click += LbCheckOut_Click;
        }

        private void LbCheckOut_Click(object sender, EventArgs e)
        {
            if (CartFunction.totalCartInfo(SessionFunction.getIdCurrentSession(this.user_id))==0)
            {
                MessageBox.Show("You don't any item in your cart", "Can't checkout");
                return;
            }    
            Form yeah = new UserForm.FormPayInShoppingCart(parent);
            yeah.ShowDialog();
            int id;
        }

        public void CartContent()
        {
            int currentSessionId = SessionFunction.getIdCurrentSession(this.user_id);
            List<dynamic> item = CartFunction.cartItemsInfo(currentSessionId);
            foreach(var it in item)
            {
                DrawCartController next = new DrawCartController(it.nameProduct, (int)it.price, it.id, it.quanlity,parent);
                next.Draw(pnContent);
            }
        }
        public void CartTotal()
        {
            this.pnTotal.Controls.Add(lbSubTotal);
                
            this.pnTotal.Controls.Add(lbCountItem);
            this.pnTotal.Controls.Add(lbToTalPrice);

            lbSubTotal.Visible = true;
            lbCountItem.Visible = true;
            lbToTalPrice.Visible = true;

            lbSubTotal.Text = "Sub-Total";
            lbCountItem.Text = CartFunction.quantityCart(SessionFunction.getIdCurrentSession(this.user_id)).ToString() +  " Items";
            lbToTalPrice.Text ="$"+ CartFunction.totalCartInfo(SessionFunction.getIdCurrentSession(this.user_id)).ToString();

            lbToTalPrice.Size = new Size(200, 30);

            lbSubTotal.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            lbCountItem.Font = new Font("Calibri Light", 15, FontStyle.Bold);
            lbToTalPrice.Font = new Font("Calibri Light", 20, FontStyle.Bold);

            lbSubTotal.ForeColor = Color.White;
            lbCountItem.ForeColor = Color.White;
            lbToTalPrice.ForeColor = Color.White;

            lbSubTotal.Location = new Point(505, 10);
            lbCountItem.Location = new Point(520, 40);
            lbToTalPrice.Location = new Point(700, 20);
        }
    }
}

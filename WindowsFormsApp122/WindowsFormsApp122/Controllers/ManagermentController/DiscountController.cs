using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.Controllers.Draw;
using WindowsFormsApp122.Controllers.DrawManagement;
using WindowsFormsApp122.FormFunction;
using WindowsFormsApp122.ManagementForm;

namespace WindowsFormsApp122.Controllers.ManagermentController
{
    internal class DiscountController
    {
        Panel Discount = new Panel(), pnHeader = new Panel(), pnTitelItem = new Panel(), pnContent = new Panel();
        Label lbTitle = new Label(), AddDiscount = new Label(), lbName = new Label(), lbDesc = new Label(), lbPercent = new Label(), lbSate = new Label();
        Label[] allLabel;
        public DiscountController()
        {

        }

        public DiscountController(Panel Discount, Panel pnHeader, Panel pnContent)
        {
            this.Discount = Discount;
            this.Discount.Controls.Add(this.pnHeader);
            this.Discount.Controls.Add(this.pnTitelItem);
            this.pnTitelItem.BringToFront();
            this.Discount.Controls.Add(this.pnContent);
            this.pnContent.BringToFront();

            pnContent.Visible = false;

            this.pnHeader.Size = pnHeader.Size;
            this.pnHeader.Location = pnHeader.Location;
            this.pnHeader.BackColor = pnHeader.BackColor;

            this.pnTitelItem.Location = pnContent.Location;
            this.pnTitelItem.Size = new Size(pnContent.Size.Width, 45);
            this.pnTitelItem.BorderStyle = BorderStyle.FixedSingle;

            this.pnContent.Location = new Point(pnContent.Location.X, pnContent.Location.Y + 45);
            this.pnContent.Size = new Size(pnContent.Size.Width, pnContent.Size.Height - 45);
            this.pnContent.AutoScroll = true;

            DiscountHeader();
            DiscountTitle();
            DiscountContent();
        }

        public void DiscountHeader()
        {
            lbTitle.Text = "Discounts";
            pnHeader.Controls.Add(lbTitle);
            lbTitle.Visible = true;
            lbTitle.Size = new Size(200, 25);
            lbTitle.Font = new Font("Calibri Light", 14, FontStyle.Bold);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(100, 23);

            AddDiscount.Text = "Add Discount";
            pnHeader.Controls.Add(AddDiscount);
            AddDiscount.Visible = true;
            AddDiscount.Size = new Size(200, 25);
            AddDiscount.Font = new Font("Calibri Light", 14, FontStyle.Bold);
            AddDiscount.ForeColor = Color.White;
            AddDiscount.Location = new Point(680, 23);

            AddDiscount.Click += AddDiscount_Click;

        }
 

        private void AddDiscount_Click(object sender, EventArgs e)
        {
            
            AddNewDiscountForm yeah = new AddNewDiscountForm();
            
            yeah.Show();
        }

        public void DiscountTitle()
        {
            allLabel = new Label[]
            {
                lbName , lbDesc , lbPercent, lbSate
            };
            int count = 0;
            foreach (var lb in allLabel)
            {
                pnTitelItem.Controls.Add(lb);
                lb.Font = new Font("Calibri Light", 15, FontStyle.Bold);
                lb.ForeColor = Color.Black;
                lb.Size = new Size(100, 20);
                lb.Location = new Point(20 + count * 190, 10);
                count++;
            }
            lbPercent.Location = new Point(450, 10);
            lbName.Text = "Name";
            lbDesc.Text = "Desc";
            lbPercent.Text = "Percent";
            lbSate.Text = "State";
        }

        public void DiscountContent()
        {
            //int index = 0;
            //List<dynamic> orders = OrderFunction.ordersInfo(MainForm.getUserID());
            //foreach (var order in orders)
            //{
            //    DrawMyOrderController item = new DrawMyOrderController(index, (index + 1).ToString(), order.created_at.ToString(), order.first_name, order.providers, order.total.ToString(), order.payment_details.statuss);
            //    item.Draw(pnContent);
            //    index++;

            //}
            var listDiscounts = DiscountFunction.listDiscount();
            foreach (var dis in listDiscounts)
            {
                DrawDiscount item = new DrawDiscount(dis.name_discount, dis.desc_discount, dis.discount_percent, dis.active==true ? 1:0, dis.id);
                item.Draw(pnContent);
            }
        }
    }
}

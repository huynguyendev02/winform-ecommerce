using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.Controllers.Draw;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.UserForm
{
    public partial class FormPayInShoppingCart : Form
    {
        MainForm parent;
        public FormPayInShoppingCart(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FormPayInShoppingCart_Load(object sender, EventArgs e)
        {
            var paymentInfos = UserFunction.displayUserPaymentInfo(MainForm.getUserID());
            int index = 0, length = paymentInfos.Count;
            foreach (var payment in paymentInfos)
            {
                DrawPayInShoppingCart1 item = new DrawPayInShoppingCart1(parent, this, index.ToString(), payment.payment_type, payment.providers, payment.account_no.ToString(), payment.expiry.ToString(), payment.id);
                item.Draw(panel1);
                index++;
            }
           
        }

       
    }
}

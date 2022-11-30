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
    public partial class FormDetailMyOrder : Form
    {
        int id;
        public FormDetailMyOrder(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        public void FormDetailMyOrder_Load(object sender, EventArgs e)
        {
            var listItemInOrder = OrderFunction.orderItemsInfo(id);
            foreach (var item in listItemInOrder)
            {
                DrawDeltail itemL = new DrawDeltail(item.name_product, item.quanlity, item.price);
                itemL.Draw(panel1);
            }
            
        }
    }
}

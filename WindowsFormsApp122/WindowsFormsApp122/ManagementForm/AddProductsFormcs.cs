using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp122.FormFunction;

namespace WindowsFormsApp122.ManagementForm
{
    public partial class AddProductsFormcs : Form
    {
        ManagementForm.ManagerForm parent;
        public AddProductsFormcs(ManagementForm.ManagerForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void AddProductsFormcs_Load(object sender, EventArgs e)
        {
            var listCate = ProductFunction.categoryProduct();
            foreach(var cate in listCate)
            {
                cbCategory.Items.Add(cate.name_category);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            
            if (cbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("You must select category", "Error");
                return;
            }
            ProductFunction.addProduct(tbName.Text, tbDesc.Text, cbCategory.SelectedIndex+1, Int32.Parse(tbInvestory.Text), Decimal.Parse(tbPrice.Text), tbUrl.Text);
            this.Hide();

            parent.Show();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

    }
}

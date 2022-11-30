using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cbCategory.Items.Add("Jav");
            cbCategory.Items.Add("Tokuda");
            cbCategory.Items.Add("Hello");
            cbCategory.Items.Add("Hello");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            
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

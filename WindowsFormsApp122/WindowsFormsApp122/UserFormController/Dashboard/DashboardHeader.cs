using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp122.UserFormController.Dashboard
{
    public partial class DashboardHeader : Form
    {
        public DashboardHeader()
        {
            InitializeComponent();
        }

        private void DashboardHeader_Load(object sender, EventArgs e)
        {
            for (int i=1;i<6;i++)
            {
                Label document = new Label();
                Panel pn = new Panel();
                document.Text = "Item so: " + i.ToString();
                panel1.Controls.Add(document);
                document.Location = new Point(i*50,15);
                document.ForeColor = Color.Red;
            }
        }
    }
}

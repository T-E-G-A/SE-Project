using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDashboard.UserControls
{
    public partial class ucVendors : UserControl
    {
        public ucVendors()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // opens the vendorAdd form
        private void button1_Click(object sender, EventArgs e)
        {
            vendorAdd vendor = new vendorAdd();
            vendor.TopLevel = false;
            panel2.Controls.Add(vendor);
            vendor.BringToFront();
            vendor.Show();
        }
        
        // opens the vendorManage form
        private void button2_Click(object sender, EventArgs e)
        {
            vendorManage vendor = new vendorManage();
            vendor.TopLevel = false;
            panel2.Controls.Add(vendor);
            vendor.BringToFront();
            vendor.Show();
        }
    }
}

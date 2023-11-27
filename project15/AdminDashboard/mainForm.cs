using AdminDashboard.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminDashboard
{
    public partial class mainForm : Form
    {
        // Opens on home page user control
        public mainForm()
        {
            InitializeComponent();
            ucOverview uc = new ucOverview();
            addUserControl(uc);
        }
        // saw this online somewhere not sure how it is working in the program right now, i dont think it is
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\tadas\\source\repos\\ADMINDASDHASDHA\\AdminDashboard\\Database21.mdf;Integrated Security=True");

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        // these buttons open the form inside current form for better user experience
        private void button1_Click(object sender, EventArgs e)
        {
            ucOverview uc = new ucOverview();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
          ucEmployees ucEmployees = new ucEmployees();
            addUserControl(ucEmployees);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucVendors ucVendors = new ucVendors();
            addUserControl(ucVendors);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucLogout ucLogout = new ucLogout();
            addUserControl(ucLogout);
        }
        // closes application
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

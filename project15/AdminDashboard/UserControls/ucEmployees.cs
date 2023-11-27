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
    public partial class ucEmployees : UserControl
    {
        public ucEmployees()
        {
            InitializeComponent();
        }

      
        // opens employeeAdd form inside the current form
        private void button1_Click(object sender, EventArgs e)
        {
            employeeAdd employee = new employeeAdd();
            employee.TopLevel = false;
            panel2.Controls.Add(employee);
            employee.BringToFront();
            employee.Show();
        }

        // opens employeeManage form inside the current form
        private void button2_Click(object sender, EventArgs e)
        {
            employeeManage employee = new employeeManage();
            employee.TopLevel = false;
            panel2.Controls.Add(employee);
            employee.BringToFront();
            employee.Show();
        }

     
    }
}

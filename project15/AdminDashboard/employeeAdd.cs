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
    public partial class employeeAdd : Form
    {
        public employeeAdd()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database21DataSet);

        }

        private void employeeAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database21DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database21DataSet.Table);

        }

       private void button1_Click_1(object sender, EventArgs e)
        {
            /* tried making this update db but not working, will mess around later unless someone wants to fix
             
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\tadas\\Source\\Repos\\SE-Project34e\\project15\\AdminDashboard\\Database21.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into employee database values (@Id,:employeeID,@employeeFirstName,@employeeLastName,@dateOfBirth,@role)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(idTextBox.Text));
            cmd.Parameters.AddWithValue("@employeeID", int.Parse(idTextBox.Text));
            cmd.Parameters.AddWithValue("@employeeFirstName",idTextBox.Text);
            cmd.Parameters.AddWithValue("@employeeLastName", idTextBox.Text);
            cmd.Parameters.AddWithValue("@dateOfBirth", idTextBox.Text);
            cmd.Parameters.AddWithValue("@role", idTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success!");

            */
        }
    }
}

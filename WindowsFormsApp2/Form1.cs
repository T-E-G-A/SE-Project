using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.database1DataSet.Customers);

        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void internalProfessionalServicesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (internalProfessionalServicesCheckBox.CheckState == CheckState.Checked)
                internalProfessionalServicesCheckBox.Text = "Yes";
            else if (internalProfessionalServicesCheckBox.CheckState == CheckState.Unchecked)
                internalProfessionalServicesCheckBox.Text = "No";
            else internalProfessionalServicesCheckBox.Text = "??";
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void softwareTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm2 f2 = new RegistrationForm2();
            f2.Show();

        }
    }
}
// anmdoasindioasnionafod
// i am not stupid
// i am stupid
// lol
//ffff
//final test
//more testwd
//kai test
//lsjkdnjkldfnbdf
//asdasfas
//gbhnnj
//account test

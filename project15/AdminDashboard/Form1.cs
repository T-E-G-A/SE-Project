using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace AdminDashboard
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var skinManager=MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultantDBDataSet.Consult' table. You can move, or remove it, as needed.
            this.consultTableAdapter.Fill(this.consultantDBDataSet.Consult);
            Edit(false);

        }
        private void Edit(bool value)
        {
            txtPhoneNumber.Enabled = value;
            txtFullName.Enabled = value;
            txtEmail.Enabled = value;
            txtAddress.Enabled = value;        }
        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminDashboard.ConsultantDBDataSetTableAdapters;
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
            try
            {
                Edit(false);
                consultBindingSource.EndEdit();
                consultTableAdapter.Update(consultantDBDataSet.Consult);
                dataGridView.Refresh();
                txtPhoneNumber.Focus();
                MessageBox.Show("Data successfully saved","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                consultantDBDataSet.Consult.RejectChanges();

            }
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
            try
            {
                Edit(true);
                consultantDBDataSet.Consult.AddConsultRow(consultantDBDataSet.Consult.NewConsultRow());
                consultBindingSource.MoveLast();
                txtPhoneNumber.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                consultantDBDataSet.Consult.RejectChanges();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtPhoneNumber.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            consultBindingSource.ResetBindings(false);
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)//enter
            {
                if (MessageBox.Show("Would you like to delete this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    consultBindingSource.RemoveCurrent();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                    consultBindingSource.Filter = string.Format("PhoneNumber = '{0}' OR FullName LIKE '*{1}*' OR Email = '{2}' OR Address LIKE '*{3}*'", txtPhoneNumber.Text, txtFullName.Text, txtEmail.Text, txtAddress.Text);
                else
                    consultBindingSource.Filter = string.Empty;
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Would you like to delete this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    consultBindingSource.RemoveCurrent();
            }

        }
    }
}

using AdminDashboard;
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
    public partial class RegistrationForm2 : Form
    {
        public RegistrationForm2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text))
            {
                MessageBox.Show("Enter Username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userName.Focus();
                return;
            }
            if (passWord.Text != confirmPassword.Text)
            {
                MessageBox.Show("Passwords don't match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IregisterRepo repo = new registerRepo();
            bool result = await repo.Insert(new Reg() { Username = userName.Text, Password = passWord.Text, Email = eMail.Text });
            if (result)
                MessageBox.Show("Registration Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Registration Failed, Please try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm f1 = new mainForm();
            f1.Show();
        }

        private void RegistrationForm2_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        // The constructor initializes the UI components
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
        // This event handler is called when the "Registration" button is clicked
        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            // Check if the username, password, email, and confirm password fields are empty
            if (string.IsNullOrEmpty(userName.Text))
            {
                MessageBox.Show("Enter Username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(passWord.Text))
            {
                MessageBox.Show("Enter Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passWord.Focus();
                return;
            }
            if (string.IsNullOrEmpty(eMail.Text))
            {
                MessageBox.Show("Enter Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                eMail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(confirmPassword.Text))
            {
                MessageBox.Show("Enter confirm password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                confirmPassword.Focus();
                return;
            }
            // Check if the username, password, and email length exceeds the maximum limit of 16 characters
            if (userName.Text.Length > 16)
            {
                userName.Text = userName.Text.Substring(0, 16);
                MessageBox.Show("The text entered exceeds the maximum limit of 16 characters.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userName.Focus();
                return;
            }
            if (eMail.Text.Length > 16)
            {
                eMail.Text = eMail.Text.Substring(0, 16);
                MessageBox.Show("The text entered exceeds the maximum limit of 16 characters.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                eMail.Focus();
                return;
            }
            if (passWord.Text.Length > 16)
            {
                passWord.Text = passWord.Text.Substring(0, 16);
                MessageBox.Show("The text entered exceeds the maximum limit of 16 characters.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passWord.Focus();
                return;
            }
            if (confirmPassword.Text.Length > 16)
            {
                confirmPassword.Text = confirmPassword.Text.Substring(0, 16);
                MessageBox.Show("The text entered exceeds the maximum limit of 16 characters.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            confirmPassword.Focus();
                return;
            }
            // Check if the passwords match
            if (passWord.Text != confirmPassword.Text)
            {
                MessageBox.Show("Passwords don't match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IregisterRepo repo = new registerRepo();
            // Attempt to register the new user in the database
            bool result = await repo.Insert(new Reg() { Username = userName.Text, Password = passWord.Text, Email = eMail.Text });
            // If registration is successful, display a message
            if (result)
                MessageBox.Show("Registration Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // If registration fails, display a message
            else
                MessageBox.Show("Registration Failed, Please try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Display the main form
            mainForm f1 = new mainForm();
            f1.Show();
            this.Hide();
        }

        private void RegistrationForm2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create a new instance of the login form
            LoginForm loginForm = new LoginForm();

            // Show the login form
            loginForm.Show();

            // Hide the registration form
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

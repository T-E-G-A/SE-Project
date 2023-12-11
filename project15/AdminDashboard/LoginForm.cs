using AdminDashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  

    public partial class LoginForm : Form
    {

       

        private SqlConnection connection;

        private string userName;
        private string password;

        private TextBox userNameTextbox;
        private TextBox passwordTextbox;

        public LoginForm()
        {
            InitializeComponent();
            // Create a new SqlConnection object
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RegDB.mdf;Integrated Security=True");
        


        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the user name and password from the text boxes
                userName = textBox1.Text;
                password = pswdt.Text;
                connection.Open();
                // Validate the user name and password from the Users table
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", connection);
                command.Parameters.AddWithValue("@Username", userName);
                command.Parameters.AddWithValue("@Password", password);

                // Execute the query
                SqlDataReader reader = command.ExecuteReader();

                // Check if there is a row in the result set
                if (reader.Read())
                {
                    // Login successful
                    MessageBox.Show("Login successful");
                    mainForm f1 = new mainForm();
                    f1.Show();

                    // Close the data reader
                    reader.Close();

                    // Close the database connection
                    connection.Close();

                    // Close this form
                    this.Hide();
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

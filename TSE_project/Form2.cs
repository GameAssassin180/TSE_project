using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TSE_project
{
    public partial class Form2 : Form
    {
        SqlConnection connection;
        string connectionString;
        public Form2()
        {
            InitializeComponent();
            connectionString = "Data Source = LocalHost\\SQLEXPRESS; Integrated Security = True";
        }

        private void createAccountButton2_Click(object sender, EventArgs e)
        {
            string email = Convert.ToString(emailBox.Text);
            string username = Convert.ToString(usernameBox.Text);
            string password = Convert.ToString(passwordBox.Text);
            string Query = ("INSERT INTO Login (Email,Username,Password) VALUES ('" + email + "','" + username + "','" + password + "')"); // creates SQL querey
            connection = new SqlConnection(connectionString); // makes connection
            SqlCommand command = new SqlCommand(Query, connection); // creates a query on the database
            connection.Open(); //opens a connection
            command.ExecuteNonQuery(); // runs teh query
            connection.Close(); //  closes the connections
            MessageBox.Show("Account Created"); // informs user an account has been created. 
            this.Hide(); // closes the window
            new Form1().Show(); // opens the login window
        }

        private void setButtonVisibility()
        {
            if ((usernameBox.Text != String.Empty) && (emailBox.Text != String.Empty) && (passwordBox.Text != String.Empty)) // checks if all the text boxes have text in them.
            {
                createAccountButton2.Enabled = true; // enables the save button
            }
            else
            {
                createAccountButton2.Enabled = false;// disables the save button 
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            createAccountButton2.Enabled = false;
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

    }
}

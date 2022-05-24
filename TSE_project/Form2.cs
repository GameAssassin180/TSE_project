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
            connectionString = ConfigurationManager.ConnectionStrings["TSE_project.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            string email = Convert.ToString(Email.Text);
            string username = Convert.ToString(Username.Text);
            string password = Convert.ToString(Password.Text);
            connection = new SqlConnection(connectionString); // making connection   
            string Query = ("INSERT INTO Login (Email,Username,Password) VALUES ('" + email + "','" + username + "','" + password + "')"); // creates SQL querey
            SqlCommand command = new SqlCommand(Query, connection); // creates a query on the database
            connection.Open(); //opens a connection
            command.ExecuteNonQuery(); // runs teh query
            connection.Close(); //  closes the connections
            MessageBox.Show("Account Created"); // informs user an account has been created. 
            this.Hide(); // closes the window
            new Form1().Show(); // opens the login window
        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TSE_project
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TSE_project.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Login WHERE username='" + usernameBox.Text + "' AND password='" + passwordBox.Text + "'", connection);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable login = new DataTable(); //this is creating a virtual table  
            sda.Fill(login);
            if (login.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                connection.Close(); //  closes the connections
                new home().Show(); // opens home screen
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void createAccountButton_Click_1(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}

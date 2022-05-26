using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TSE_project
{
    public partial class entry : Form
    {
        SqlConnection connection; // this represents the connection to the database and is given the name connection.
        string connectionString; // decleration of the connection string.
        public entry()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TSE_project.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        }

        private void entry_Load(object sender, EventArgs e)
        {
            MoodDropdown();
            LocationDropdown();
            ActivityDropdown();
        }
        private void MoodDropdown()//populates a drop down menu with the permits Title.
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Mood", connection))
            {
                DataTable Mood = new DataTable();
                adapter.Fill(Mood);

                MoodDrop.DisplayMember = "MoodName";
                MoodDrop.ValueMember = "MoodId";
                MoodDrop.DataSource = Mood;
            }
        }
        private void ActivityDropdown()//populates a drop down menu with the permits Title.
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Activity", connection))
            {
                DataTable Activity = new DataTable();
                adapter.Fill(Activity);

                ActivityDrop.DisplayMember = "ActivityName";
                ActivityDrop.ValueMember = "ActivityId";
                ActivityDrop.DataSource = Activity;
            }
        }
        private void LocationDropdown()//populates a drop down menu with the permits Title.
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Location", connection))
            {
                DataTable Location = new DataTable();
                adapter.Fill(Location);

                LocationDrop.DisplayMember = "LocationName";
                LocationDrop.ValueMember = "LocationId";
                LocationDrop.DataSource = Location;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string username = Form1.userSelect;
            string diaryEntry = Convert.ToString(DiaryTextBox.Text);
            int Mood = Convert.ToInt16(MoodDrop.SelectedValue);
            int Activity = Convert.ToInt16(ActivityDrop.SelectedValue);
            int Location = Convert.ToInt16(LocationDrop.SelectedValue);
            string Query = ("INSERT INTO Entry (LocationId,ActivityId,Mood,DiaryEntry,Username,DateTime) VALUES ('" + Location + "','" + Activity + "','" + Mood + "','" + diaryEntry + "','" + username + "','" + DateTime.Now.ToString() + "')");
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(Query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Uploaded"); // shows a message box telling the user the entry has been uploaded 
            this.Close(); // closes the add from and the message box.
        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TSE_project
{
    public partial class home : Form
    {
        SqlConnection connection; // this represents the connection to the database and is given the name connection.
        string connectionString; // decleration of the connection string.
        public home()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TSE_project.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        }

        private void EntryLoad()// declares a public void called Entryload.
        {
            string username = Form1.userSelect;
            DateTime date = dateTimePicker1.Value.Date;
            string Query = ("SELECT * FROM Entry WHERE Username = @username AND Date = @date");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(Query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            { 
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@date", date);
                DataTable Entry = new DataTable(); // declares a new datatable called entry 
                adapter.Fill(Entry); // fills the new data table with the infromation grabed from the ran query

                EntryBox.DisplayMember = "Time";// sets the listbox querybox to dispaly the time column from the data table.  
                EntryBox.ValueMember = "Time";// sets the listbox querybox to have the value of the time column from the data table.
                EntryBox.DataSource = Entry;// sets the listbox querybox datasourse to the data table entry declared earlier.
            }
        }
        private void DiaryLoad()// declares a public void called Entryload.
        {
            string username = Form1.userSelect;
            DateTime date = dateTimePicker1.Value.Date;
            string Query = ("SELECT * FROM Entry WHERE Username = @username AND Date = @date AND Time = @time");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(Query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", EntryBox.SelectedValue);
                DataTable diary = new DataTable(); // declares a new datatable called diary 
                adapter.Fill(diary); // fills the new data table with the infromation grabed from the ran query

                DiaryBox.DisplayMember = "DiaryEntry";// sets the listbox querybox to dispaly the DiaryEntry column from the data table.  
                DiaryBox.ValueMember = "DiaryEntry";// sets the listbox querybox to have the value of the DiaryEntry column from the data table.
                DiaryBox.DataSource = diary;// sets the listbox querybox datasourse to the data table diary declared earlier.
            }
        }
        private void LocationLoad()// declares a public void called Locationload.
        {
            string username = Form1.userSelect;
            DateTime date = dateTimePicker1.Value.Date;
            string Query = ("SELECT Entry.LocationId, Location.LocationName FROM Entry INNER JOIN Location ON Entry.LocationId = Location.LocationId WHERE Username = @username AND Date = @date AND Time = @time");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(Query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", EntryBox.SelectedValue);
                DataTable location = new DataTable(); // declares a new datatable called Location 
                adapter.Fill(location); // fills the new data table with the infromation grabed from the ran query

                LocationBox.DisplayMember = "LocationName";// sets the listbox Locationbox to dispaly the LocationName column from the data table.  
                LocationBox.ValueMember = "LocationName";// sets the listbox Locationbox to have the value of the LocationName column from the data table.
                LocationBox.DataSource = location;// sets the listbox Locationbox datasourse to the data table Location declared earlier.
            }
        }
        private void ActivityLoad()// declares a public void called ActivityLoad.
        {
            string username = Form1.userSelect;
            DateTime date = dateTimePicker1.Value.Date;
            string Query = ("SELECT Entry.LocationId, Activity.ActivityName FROM Entry INNER JOIN Activity ON Entry.ActivityId = Activity.ActivityId WHERE Username = @username AND Date = @date AND Time = @time");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(Query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", EntryBox.SelectedValue);
                DataTable activity = new DataTable(); // declares a new datatable called activity 
                adapter.Fill(activity); // fills the new data table with the infromation grabed from the ran query

                ActivityBox.DisplayMember = "ActivityName";// sets the listbox ActivityBox to dispaly the ActivityName column from the data table.  
                ActivityBox.ValueMember = "ActivityName";// sets the listbox ActivityBox to have the value of the ActivityName column from the data table.
                ActivityBox.DataSource = activity;// sets the listbox ActivityBox datasourse to the data table activity declared earlier.
            }
        }
        private void MoodLoad()// declares a public void called Moodload.
        {
            string username = Form1.userSelect;
            DateTime date = dateTimePicker1.Value.Date;
            string Query = ("SELECT Entry.Mood, Mood.MoodName FROM Entry INNER JOIN Mood ON Entry.Mood = Mood.MoodId WHERE Username = @username AND Date = @date AND Time = @time");
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(Query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", EntryBox.SelectedValue);
                DataTable Mood = new DataTable(); // declares a new datatable called activity 
                adapter.Fill(Mood); // fills the new data table with the infromation grabed from the ran query

                MoodBox.DisplayMember = "MoodName";// sets the listbox ActivityBox to dispaly the ActivityName column from the data table.  
                MoodBox.ValueMember = "MoodName";// sets the listbox ActivityBox to have the value of the ActivityName column from the data table.
                MoodBox.DataSource = Mood;// sets the listbox ActivityBox datasourse to the data table activity declared earlier.
            }
        }
        private void label1_Click(object sender, EventArgs e){}

        private void home_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = Convert.ToString(DateTime.Now);
            EntryLoad();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            EntryLoad();
        }

        private void EntryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiaryLoad();
            LocationLoad();
            ActivityLoad();
            MoodLoad();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            EntryLoad();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            new entry().Show();
        }
    }
}

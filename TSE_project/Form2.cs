using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSE_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void createAccountButton2_Click(object sender, EventArgs e)
        {
            string email = "";
            string username = "";
            string password = "";

            emailBox.Text = email.ToString();
            usernameBox.Text = username.ToString();
            passwordBox.Text = password.ToString();

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}

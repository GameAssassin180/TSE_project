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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            if (usernameBox.Text == username && passwordBox.Text == password)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username of Password you entered is incorrect, please try again.");
            }
        }

        private void createAccountButton_Click_1(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}

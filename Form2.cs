using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Form2 : Form
    {
        private string username = "daniel";
        private string password = "poquet";
        private int loginAttempts = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if (UsernameTextBox.Text == username & passwordTextBox.Text == password)
            {
                this.Hide();
                // Create a new instance of the Form2 class
                Form1 settingsForm = new Form1();

                // Show the settings form
                settingsForm.Show();
            }
            else
            {
                loginAttempts++;
                if (loginAttempts == 3)
                {
                    MessageBox.Show("You failed login 3 times, app is closing");
                    this.Close();
                }
                MessageBox.Show("Username or password error");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

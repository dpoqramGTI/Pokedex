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
        private string username1 = "daniel";
        private string password1 = "poquet";
        private string password2 = "burruchaga";
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
            if (UsernameTextBox.Text == username1 & (passwordTextBox.Text == password1)||(passwordTextBox.Text == password2))
            {
                this.Hide();

                Form1 settingsForm = new Form1();
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

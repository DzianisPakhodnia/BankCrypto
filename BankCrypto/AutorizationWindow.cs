using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankCrypto
{
    public partial class AutorizationWindow : Form
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        
        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void UserNameTextBox_Enter(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "UserName")
            {
                UserNameTextBox.Text = "";
                UserNameTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            
            if (PasswordTextBox.Text == "Password")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.UseSystemPasswordChar = true;
            }
            
        }

        private void UserNameTextBox_Leave(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
            {
                UserNameTextBox.Text = "UserName";
                UserNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "Password";
                PasswordTextBox.ForeColor = Color.Gray;
                PasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationWindow registrationWindow = new RegistrationWindow(this);
            registrationWindow.Show();
        }
    }
}

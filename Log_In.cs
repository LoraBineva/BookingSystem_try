using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using static Flights_Agency_App.Authenticate;

namespace Flights_Agency_App
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void log_in_btn_Click(object sender, EventArgs e)
        {
            string username_inp = username.Text;
            string password_inp = password.Text;

            if (!string.IsNullOrWhiteSpace(username_inp) && !string.IsNullOrWhiteSpace(password_inp))
            {
                Authenticate.User authenticatedUser = DatabaseManager.AuthenticateUser(username_inp, password_inp);

                if (authenticatedUser != null)
                {
                    //Display the username on Form5
                    Booking book = new Booking();
                    book.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Register register = new Register();
            register.ShowDialog();
        }
    }
}

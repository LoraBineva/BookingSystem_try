using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flights_Agency_App
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection sql;


        private void Register_Load(object sender, EventArgs e)
        {
            first_name.Focus();
            username_lbl.Hide();
            password_lbl.Hide();
            lenght.Hide();
            capital.Hide();
            lower.Hide();
            number.Hide();
            try
            {
                sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=Flight_Agency; Integrated Security=True;");
                sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void first_name_Validating(object sender, CancelEventArgs e)
        {
            if (first_name.Text == string.Empty)
            {
                MessageBox.Show("Please enter your first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                first_name.SelectAll();
                e.Cancel = true;
            }
        }

        private void last_name_Validating(object sender, CancelEventArgs e)
        {
            if (last_name.Text == string.Empty)
            {
                MessageBox.Show("Please enter your first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                last_name.SelectAll();
                e.Cancel = true;
            }
        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            if (email.Text != string.Empty)
            {
                if (!Email_Valid(email.Text))
                {
                    MessageBox.Show("Your email is not in the correct form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email.SelectAll();
                    e.Cancel = true;
                }
            }
        }
        private bool Email_Valid(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }
        private void username_Validating(object sender, CancelEventArgs e)
        {
            if (username.Text.Length < 8)
            {
                MessageBox.Show("Your username has to be at least 8 characters", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.SelectAll();
                e.Cancel = true;
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

            if (username.Text.Length < 8)
            {
                username_lbl.Show();
            }
            else
            {
                username_lbl.Hide();
            }
        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            if (!(password.Text.Length >= 8 && password.Text.Any(char.IsUpper) && password.Text.Any(char.IsLower) && password.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more conditions for the password haven't been met.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.SelectAll();
                e.Cancel = true;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password_lbl.Show();
            lenght.Show();
            capital.Show();
            lower.Show();
            number.Show();

            bool lenght_bool;
            bool capital_bool;
            bool lower_bool;
            bool number_bool;

            //length
            if (password.Text.Length < 8)
            {
                lenght_bool = false;
            }
            else
            {
                lenght.ForeColor = Color.LimeGreen;
                lenght_bool = true;
            }
            //capital
            if (!password.Text.Any(char.IsUpper))
            {
                capital_bool = false;
            }
            else
            {
                capital.ForeColor = Color.LimeGreen;
                capital_bool = true;
            }
            //lower
            if (!password.Text.Any(char.IsLower))
            {
                lower_bool = false;
            }
            else
            {
                lower.ForeColor = Color.LimeGreen;
                lower_bool = true;
            }
            //number
            if (!password.Text.Any(char.IsDigit))
            {
                number_bool = false;
            }
            else
            {
                number.ForeColor = Color.LimeGreen;
                number_bool = true;
            }
            //All
            if (lenght_bool == true && capital_bool == true && lower_bool == true && number_bool == true)
            {
                password_lbl.Hide();
                lenght.Hide();
                capital.Hide();
                lower.Hide();
                number.Hide();
            }


        }

        private void DOB_Validating(object sender, CancelEventArgs e)
        {
            if (DOB.Text != string.Empty)
            {
                if (!DOB_Valid(DOB.Text))
                {
                    MessageBox.Show("Invalid Date of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DOB.SelectAll();
                    e.Cancel = true;
                }
            }
        }
        private bool DOB_Valid(string DOB)
        {
            string dobPattern = @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$";

            if (string.IsNullOrEmpty(DOB))
                return false;

            Regex regex = new Regex(dobPattern);
            return regex.IsMatch(DOB);
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();
                if (sql.State == ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand("Select username From Users where username=@username", sql);
                    command.Parameters.AddWithValue("@username", username.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            string Query = "Insert Into Users Values (@username, @password, @email, @first_name, @last_name, @DOB, @gender)";
                            SqlCommand cmd = new SqlCommand(Query, sql);
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@username", username.Text);
                            cmd.Parameters.AddWithValue("@email", email.Text);
                            cmd.Parameters.AddWithValue("@password", password.Text);
                            cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                            cmd.Parameters.AddWithValue("@last_name", last_name.Text);
                            cmd.Parameters.AddWithValue("@DOB", DOB.Text);
                            cmd.Parameters.AddWithValue("@gender", genderBox.Text);

                            Convert.ToInt32(cmd.ExecuteScalar());
                            MessageBox.Show("Your account has been created! Please login!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Log_In log_In = new Log_In();
                            log_In.ShowDialog();
                        }
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

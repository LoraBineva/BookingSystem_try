using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights_Agency_App
{
    public class Authenticate
    {
        public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string DOB { get; set; }
    public string Gender { get; set; }


}
public class DatabaseManager
{
    public static User AuthenticateUser(string username, string password)
    {
        User user = RetrieveInfo(username, password);
        return user;
    }

    private static User RetrieveInfo(string username, string password)
    {

        using (SqlConnection sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=Flight_Agency; Integrated Security=True;"))
        {
            sql.Open();

            string Query = "SELECT COUNT(1) FROM Users Where username=@Username AND password=@Password";
            SqlCommand cmd = new SqlCommand(Query, sql);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                string Data_query = "Select * FROM Records where username=@Username AND password=@Password";
                SqlCommand cmd2 = new SqlCommand(Data_query, sql);
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@Username", username);
                cmd2.Parameters.AddWithValue("@Password", password);
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string email = reader["email"].ToString();
                        string first_name = reader["first_name"].ToString();
                        string last_name = reader["last_name"].ToString();
                        string DOB = reader["DOB"].ToString();
                        string gender = reader["gender"].ToString();
                        return new User { Username = username, Email = email,First_Name = first_name, Last_Name = last_name, DOB = DOB, Gender = gender };
                    }
                }
            }
            else
            {
                MessageBox.Show("Password or username is incorrect. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return null;
        }
    }
}

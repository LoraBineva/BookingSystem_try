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

            public string ID { get; set; }
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

                using (SqlConnection sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=User_records; Integrated Security=True;"))
                {
                    sql.Open();

                    string Query = "SELECT COUNT(1) FROM Records Where username=@Username AND password=@Password";
                    SqlCommand cmd = new SqlCommand(Query, sql);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {

                            return new User {Username = username, Password = password};

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
    }
}

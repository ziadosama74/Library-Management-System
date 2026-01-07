using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
public class UserDAL
{
    private string connectionString ="Data Source=ZIADOSAMA;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True";
    // Check Existing User
    public bool UserExists(string userName, string password, string userType)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = @"SELECT COUNT(*) 
                         FROM dbo.[Users]
                         WHERE UserName = @UserName
                         AND UserPassword = @UserPassword
                         AND UserType = @UserType";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 255).Value = userName;
                cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar, 255).Value = password;
                cmd.Parameters.Add("@UserType", SqlDbType.NVarChar, 50).Value = userType;

                con.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
    }
    public User GetUserIfExists(string userName, string password, string userType)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = @"SELECT UserID, UserName, UserType,Name
                         FROM dbo.[Users]
                         WHERE UserName = @UserName
                         AND UserPassword = @UserPassword
                         AND UserType = @UserType";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 255).Value = userName;
                cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar, 255).Value = password;
                cmd.Parameters.Add("@UserType", SqlDbType.NVarChar, 50).Value = userType;

                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return new User
                        {
                            UserID = dr.GetInt32(0),
                            UserName = dr.GetString(1),
                            UserType = dr.GetString(2),
                            Name = dr.GetString(3)
                        };
                    }
                }
            }
        }
        return null; // user not found
    }
    public string GetUserMembereNameByID(int id) 
    {
        string UserName = "";
        using (SqlConnection con = new SqlConnection(connectionString)) 
        {
            string Query = "select Name from Users where UserID =@ID and UserType ='Membere'";
            using(SqlCommand cmd = new SqlCommand(Query, con)) 
            {
                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader()) 
                {
                    if (dr.Read()) 
                    {
                        UserName = dr.GetString(0);
                    }
                }
            }
        }
        return (UserName);
    }

    // INSERT
    public bool AddUser(User user)
    {
        if (UserExists(user.UserName, user.UserPassword, user.UserType)) 
        {
            return false;
        }
            
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO Users 
                             (UserName, UserPassword, UserType,Name)
                             VALUES (@UserName, @UserPassword, @UserType,@Name)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                cmd.Parameters.AddWithValue("@UserType", user.UserType);
                cmd.Parameters.AddWithValue("@Name", user.Name);

                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }
    }

    // SELECT
    public DataTable GetAllUsers()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Users";

            using (SqlDataAdapter da = new SqlDataAdapter(query, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
    // Delete
    public bool DeleteUser(string userName, string password, string userType)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = @"DELETE FROM Users
                         WHERE UserName = @UserName
                         AND UserPassword = @UserPassword
                         AND UserType = @UserType";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 255).Value = userName;
                cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar, 255).Value = password;
                cmd.Parameters.Add("@UserType", SqlDbType.NVarChar, 50).Value = userType;
                con.Open();
                int rows = cmd.ExecuteNonQuery();

                return rows > 0;
            }
        }
    }

}

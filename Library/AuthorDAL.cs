using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

public class AuthorDAL
{
    private string connectionString = "Data Source=ZIADOSAMA;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True";

    // Get All Authors
    public List<Author> GetAllAuthors()
    {
        List<Author> authors = new List<Author>();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "select AuthorID, AuthorName from Authors";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        authors.Add(new Author
                        {
                            AuthorID = reader.GetInt32(0),
                            AuthorName = reader.GetString(1)
                        });
                    }
                }
            }
        }
        return authors;
    }
}

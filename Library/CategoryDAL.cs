using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CategoryDAL
{
    private string connectionString = "Data Source=ZIADOSAMA;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True";

    // Get All Categories
    public List<Categorie> GetAllCategories()
    {
        List<Categorie> Categories = new List<Categorie>();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "select CategorID, CategorName from Categories";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categories.Add(new Categorie
                        {
                            CategorID = reader.GetInt32(0),
                            CategorName = reader.GetString(1)
                        });
                    }
                }
            }
        }
        return Categories;
    }
}
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class FinesDAL
{
    private string connectionString = "Data Source=ZIADOSAMA;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True";
    public void AddFineToBorowing(int BowID) 
    { 
        using(SqlConnection conn = new SqlConnection(connectionString)) 
        {
            conn.Open();
            string Query = @"
                insert into Fines (borrow_id,amount,paid) values (@ID,50.00,'Not Yet')
            ";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@ID", BowID);
            cmd.ExecuteNonQuery();
        }
    }
}


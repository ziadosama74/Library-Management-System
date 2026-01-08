using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
public class BorrowingDAL
{
    private string connectionString = "Data Source=ZIADOSAMA;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True";

    public void AddBorowingBook(Borrowing borrowing) 
    {
        using (SqlConnection conn = new SqlConnection(connectionString)) 
        {
            try
            {
                conn.Open();
                string Query = @"
                insert into Borrowings (UserID,ISBNBook,borrow_date,due_date,status) 
                values (@UserID,@ISBNBook,@borrow_date,@due_date,'Borrowed')";

                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@UserID", borrowing.UserID);
                cmd.Parameters.AddWithValue("@ISBNBook", borrowing.ISBNBook);
                cmd.Parameters.AddWithValue("@borrow_date", borrowing.borrow_date);
                cmd.Parameters.AddWithValue("@due_date", borrowing.due_date);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error : " + ex.Message.ToString());
            }
        }
    }
    public int CheckBorrowingExitedToUser(int UsrId) 
    {
        using (SqlConnection conn = new SqlConnection(connectionString)) 
        {
            string Query = @"select count(*) as No_BowUser from Borrowings where UserID=@id and return_date is null";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@id", UsrId);
            conn.Open();
            return (int)cmd.ExecuteScalar();
        }
    }
    public DataTable GetBorrowingBooksByUserID(int userId)
    {
        DataTable dt = new DataTable();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"
            SELECT 
            BOW.ISBNBook,
            BOK.Title,
            BOW.borrow_date,
            BOW.due_date,
            BOW.return_date,
            BOW.status,
            BOW.borrow_id
            FROM Borrowings BOW
            JOIN Books BOK ON BOW.ISBNBook = BOK.ISBN
            WHERE BOW.UserID = @ID order by BOW.ISBNBook";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", userId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
        }
        return dt;
    }
    public void UpdateChangingToReturnBook(Borrowing BOW)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = @"
            update Borrowings 
            set return_date = getdate() , [status] = @Status
            where UserID = @UID and ISBNBook = @BID and borrow_date = @BowDate and due_date = @DueDate";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Status", BOW.status);
                cmd.Parameters.AddWithValue("@UID", BOW.UserID);
                cmd.Parameters.AddWithValue("@BID", BOW.ISBNBook);
                cmd.Parameters.AddWithValue("@BowDate", BOW.borrow_date);
                cmd.Parameters.AddWithValue("@DueDate", BOW.due_date);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

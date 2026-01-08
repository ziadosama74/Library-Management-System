using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BookDAL
{
    private string connectionString = "Data Source=ZIADOSAMA;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True";

    public bool BookExists(int isbn)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string q = "SELECT COUNT(*) FROM Books WHERE ISBN=@ISBN";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@ISBN", isbn);

            con.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }
    }

    public void AddBook(Book book)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                // 1️⃣ Insert Book
                string bookQuery = @"INSERT INTO Books
                (ISBN, Title, CategoryID, TotalCopies,AvaliableCopies)
                VALUES (@ISBN,@Title,@CategoryID,@Total,@AvaliableCopies)";

                SqlCommand cmd = new SqlCommand(bookQuery, con, tran);
                cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@CategoryID", book.CategoryID);
                cmd.Parameters.AddWithValue("@Total", book.TotalCopies);
                cmd.Parameters.AddWithValue("@AvaliableCopies", book.AvaliableCopies);
                cmd.ExecuteNonQuery();

                // 2️⃣ Insert Relation
                string relQuery = @"IF NOT EXISTS
                (SELECT 1 FROM Book_Authors 
                 WHERE ISBN_Book=@ISBN AND AuthorID=@AuthorID)
                 INSERT INTO Book_Authors VALUES (@ISBN,@AuthorID)";

                SqlCommand relCmd = new SqlCommand(relQuery, con, tran);
                relCmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                relCmd.Parameters.AddWithValue("@AuthorID", book.AuthorID);
                relCmd.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
    }

    public void UpdateBook(Book book)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                // Update book
                string q1 = @"UPDATE Books SET
                Title=@Title,
                CategoryID=@CategoryID,
                TotalCopies=@Total,
                AvaliableCopies=@AvaliableCopies
                WHERE ISBN=@ISBN";

                SqlCommand cmd = new SqlCommand(q1, con, tran);
                cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@CategoryID", book.CategoryID);
                cmd.Parameters.AddWithValue("@Total", book.TotalCopies);
                cmd.Parameters.AddWithValue("@AvaliableCopies", book.AvaliableCopies);
                cmd.ExecuteNonQuery();

                // Update relation
                SqlCommand del = new SqlCommand(
                    "DELETE FROM Book_Authors WHERE ISBN_Book=@ISBN", con, tran);
                del.Parameters.AddWithValue("@ISBN", book.ISBN);
                del.ExecuteNonQuery();

                SqlCommand ins = new SqlCommand(
                    "INSERT INTO Book_Authors VALUES (@ISBN,@AuthorID)", con, tran);
                ins.Parameters.AddWithValue("@ISBN", book.ISBN);
                ins.Parameters.AddWithValue("@AuthorID", book.AuthorID);
                ins.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
    }
    public void UpdateAvalibleCopiesByISBN(int isbn,int NewUpdateAvaliableCopies)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            try 
            {
                con.Open();
                string Query = @"update Books set AvaliableCopies=@AvaliableCopies where ISBN=@ISBN";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@AvaliableCopies", NewUpdateAvaliableCopies);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString());
            }
        }
    }
    //public bool BookExists(int isbn)
    public void IncrementAvalibleCopiesByISBNAtBorrowing(int isbn)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            try
            {
                con.Open();
                string Query = @"update Books set AvaliableCopies=AvaliableCopies+1 where ISBN=@ISBN";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString());
            }
        }
    }
    public void IncreaseAvailableCopiesByISBN(int isbn)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = @"
            UPDATE Books
            SET AvaliableCopies = AvaliableCopies + 1
            WHERE ISBN = @ISBN";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void DeleteBook(int isbn)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                new SqlCommand(
                    "DELETE FROM Book_Authors WHERE ISBN_Book=@ISBN", con, tran)
                { Parameters = { new SqlParameter("@ISBN", isbn) } }
                .ExecuteNonQuery();

                new SqlCommand(
                    "DELETE FROM Books WHERE ISBN=@ISBN", con, tran)
                { Parameters = { new SqlParameter("@ISBN", isbn) } }
                .ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
    }

    public Book GetBookByISBN(int isbn)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = @"
            SELECT 
                b.ISBN,
                b.Title,
                b.CategoryID,
                b.TotalCopies,
                ba.AuthorID,
                b.AvaliableCopies
            FROM Books b
            LEFT JOIN Book_Authors ba ON b.ISBN = ba.ISBN_Book
            WHERE b.ISBN = @ISBN";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ISBN", isbn);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                return new Book
                {
                    ISBN = dr.GetInt32(0),
                    Title = dr.GetString(1),
                    CategoryID = dr.GetInt32(2),
                    TotalCopies = dr.GetInt32(3),
                    AuthorID = dr.IsDBNull(4) ? 0 : dr.GetInt32(4),
                    AvaliableCopies = dr.GetInt32(5)
                };
            }
            return (null);
        }
    }
    public DataTable SearchBooksByOneField(string searchBy, object value)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "";

            switch (searchBy)
            {
                case "ISBN":
                    query = @"SELECT b.ISBN, b.Title, c.CategorName, a.AuthorName, b.TotalCopies , b.AvaliableCopies
                          FROM Books b
                          JOIN Categories c ON b.CategoryID = c.CategorID
                          JOIN Book_Authors ba ON b.ISBN = ba.ISBN_Book
                          JOIN Authors a ON ba.AuthorID = a.AuthorID
                          WHERE b.ISBN = @value";
                    break;

                case "Title":
                    query = @"SELECT b.ISBN, b.Title, c.CategorName, a.AuthorName, b.TotalCopies , b.AvaliableCopies
                          FROM Books b
                          JOIN Categories c ON b.CategoryID = c.CategorID
                          JOIN Book_Authors ba ON b.ISBN = ba.ISBN_Book
                          JOIN Authors a ON ba.AuthorID = a.AuthorID
                          WHERE b.Title LIKE '%' + @value + '%'";
                    break;

                case "Author":
                    query = @"SELECT b.ISBN, b.Title, c.CategorName, a.AuthorName, b.TotalCopies , b.AvaliableCopies
                          FROM Books b
                          JOIN Categories c ON b.CategoryID = c.CategorID
                          JOIN Book_Authors ba ON b.ISBN = ba.ISBN_Book
                          JOIN Authors a ON ba.AuthorID = a.AuthorID
                          WHERE a.AuthorID = @value";
                    break;

                case "Category":
                    query = @"SELECT b.ISBN, b.Title, c.CategorName, a.AuthorName, b.TotalCopies , b.AvaliableCopies
                          FROM Books b
                          JOIN Categories c ON b.CategoryID = c.CategorID
                          JOIN Book_Authors ba ON b.ISBN = ba.ISBN_Book
                          JOIN Authors a ON ba.AuthorID = a.AuthorID
                          WHERE c.CategorID = @value";
                    break;
            }

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@value", value);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }



}
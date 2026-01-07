using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibrarianForm : Form
    {
        private string _userName;
        private string _ID;
        private int oldTotalCopies = 0;
        private int oldAvailableCopies = 0;
        private int borrowedCopies = 0;
        public LibrarianForm(string userName, string id)
        {
            InitializeComponent();
            _userName = userName;
            _ID = id;
        }
        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            try
            {
                UserPageLab.Text = "Librarian Page 📗​ : " + _userName + " - ID : " + _ID;
                LoadAuthors();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString());
            }

        }


        private void RestBoxes()
        {
            TxtISBN.Value = 0;
            TxtCopies.Value = 0;
            TxtCategory.SelectedIndex = -1;
            TxtTitlle.Text = "";
            TxtAuthor.SelectedIndex = -1;
            AddCheckBox.Checked = false;
            EditCheckBox.Checked = false;
            DeleteCheckBox.Checked = false;
        }
        private void LoadAuthors()
        {
            AuthorDAL dal = new AuthorDAL();
            List<Author> authors = dal.GetAllAuthors();

            TxtAuthor.DataSource = authors;
            TxtAuthor.DisplayMember = "AuthorName";
            TxtAuthor.ValueMember = "AuthorID";
            TxtAuthor.SelectedIndex = -1;
        }
        private void LoadCategories()
        {
            CategoryDAL dal = new CategoryDAL();
            List<Categorie> Categories = dal.GetAllCategories();

            TxtCategory.DataSource = Categories;
            TxtCategory.DisplayMember = "CategorName";
            TxtCategory.ValueMember = "CategorID";
            TxtCategory.SelectedIndex = -1;

        }
        private void BackBtn_Click(object sender, EventArgs e)
        {

            MainPage MP = new MainPage();
            this.Close();
            MP.Show();
        }


        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            string ActionType = "";
            int CountAction = 0;
            if (TxtISBN.Value == 0 || TxtCopies.Value == 0 || TxtCategory.Text.Trim() == "" || TxtTitlle.Text.Trim() == "" || TxtAuthor.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Processs ❌");
            }
            else
            {
                if (AddCheckBox.Checked)
                {
                    CountAction++;
                    ActionType = "Add";
                }
                if (EditCheckBox.Checked)
                {
                    CountAction++;
                    ActionType = "Edit";
                }
                if (DeleteCheckBox.Checked)
                {
                    CountAction++;
                    ActionType = "Delete";
                }
                if (CountAction != 1)
                {
                    MessageBox.Show("Invalid Processs ❌");
                }
                else
                {
                    if (ActionType == "Add")
                    {
                        try
                        {
                            int isbn = int.Parse(TxtISBN.Text);
                            BookDAL dal = new BookDAL();

                            if (dal.BookExists(isbn))
                            {
                                MessageBox.Show("ISBN already exists ❌");
                                return;
                            }

                            if (TxtCategory.SelectedValue == null || TxtAuthor.SelectedValue == null)
                            {
                                MessageBox.Show("Select Category and Author ❌");
                                return;
                            }

                            Book book = new Book
                            {
                                ISBN = isbn,
                                Title = TxtTitlle.Text,
                                CategoryID = Convert.ToInt32(TxtCategory.SelectedValue),
                                TotalCopies = int.Parse(TxtCopies.Text),
                                AvaliableCopies = int.Parse(TxtAvalible.Text),
                                AuthorID = Convert.ToInt32(TxtAuthor.SelectedValue)
                            };

                            dal.AddBook(book);
                            MessageBox.Show("Book Added Successfully ✔️");
                            RestBoxes();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error : " + ex.Message);
                        }
                    }
                    else if (ActionType == "Edit")
                    {
                        try
                        {
                            BookDAL dal = new BookDAL();
                            int isbn = int.Parse(TxtISBN.Text);


                            if (!dal.BookExists(isbn))
                            {
                                MessageBox.Show("Book does not exist ❌");
                                return;
                            }

                            if (TxtCategory.SelectedValue == null || TxtAuthor.SelectedValue == null)
                            {
                                MessageBox.Show("Category or Author not selected ❌");
                                return;
                            }

                            Book book = new Book
                            {
                                ISBN = isbn,
                                Title = TxtTitlle.Text,
                                CategoryID = Convert.ToInt32(TxtCategory.SelectedValue),
                                TotalCopies = int.Parse(TxtCopies.Text),
                                AuthorID = Convert.ToInt32(TxtAuthor.SelectedValue),
                                AvaliableCopies = int.Parse(TxtAvalible.Text)
                            };

                            dal.UpdateBook(book);
                            MessageBox.Show("Book Updated Successfully ✔️");
                            RestBoxes();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error : " + ex.Message);
                        }
                    }
                    else if (ActionType == "Delete")
                    {
                        try
                        {
                            if (string.IsNullOrWhiteSpace(TxtISBN.Text))
                            {
                                MessageBox.Show("Enter ISBN first ❌");
                                return;
                            }

                            int isbn = int.Parse(TxtISBN.Text);
                            BookDAL dal = new BookDAL();
                            if (!dal.BookExists(isbn))
                            {
                                MessageBox.Show("Book does NOT exist ❌");
                                return;
                            }

                            DialogResult r = MessageBox.Show(
                                "Are you sure you want to delete this book?",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

                            if (r == DialogResult.Yes)
                            {
                                dal.DeleteBook(isbn);
                                MessageBox.Show("Book Deleted Successfully ✔️");
                                RestBoxes();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error : " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Processs ❌");
                    }
                }
            }
        }

        private void GetBookBtn_Click(object sender, EventArgs e)
        {
            if (TxtSearchISBN.Value == 0)
            {
                MessageBox.Show("Enter ISBN ❌");
                RestBoxes();
                return;
            }

            int isbn = int.Parse(TxtSearchISBN.Text);
            BookDAL dal = new BookDAL();

            Book book = dal.GetBookByISBN(isbn);

            if (book == null)
            {
                MessageBox.Show("Book Not Found ❌");
                RestBoxes();
                return;
            }
            oldTotalCopies = book.TotalCopies;
            oldAvailableCopies = book.AvaliableCopies;
            borrowedCopies = oldTotalCopies - oldAvailableCopies;
            TxtISBN.Value = book.ISBN;
            TxtTitlle.Text = book.Title;
            TxtCopies.Value = oldTotalCopies;
            TxtAvalible.Text = oldAvailableCopies.ToString();
            TxtCategory.SelectedValue = book.CategoryID;
            TxtAvalible.ReadOnly = true;


            if (book.AuthorID != 0)
            {
                TxtAuthor.SelectedValue = book.AuthorID;
            }

        }
        private void TxtCopies_ValueChanged(object sender, EventArgs e)
        {
            int newTotal = (int)TxtCopies.Value;
            int newAvailable = newTotal - borrowedCopies;

            if (newAvailable < 0)
            {
                TxtCopies.Value = borrowedCopies;
                return;
            }
            TxtAvalible.Text = newAvailable.ToString();
        }

        private void SearchUsserBtn_Click(object sender, EventArgs e)
        {
            UserDAL userDAL = new UserDAL();
            string NameOfUser = userDAL.GetUserMembereNameByID(Convert.ToInt32(TxtUserId.Value));
            if (!string.IsNullOrEmpty(NameOfUser))
            {
                TxtUNameBySearch.Text = NameOfUser + " 😃";
            }
            else
            {
                TxtUNameBySearch.Text = "No User With this ID 😕";
                DGVRetBooks.Rows.Clear();
                return;
            }
            BorrowingDAL borrowing = new BorrowingDAL();
            DataTable dataTable = borrowing.GetBorrowingBooksByUserID(Convert.ToInt32(TxtUserId.Value));
            DGVRetBooks.Rows.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idx = DGVRetBooks.Rows.Add();
                DGVRetBooks.Rows[idx].Cells[0].Value = row[0]; // ISBN
                DGVRetBooks.Rows[idx].Cells[1].Value = row[1]; // Title
                DGVRetBooks.Rows[idx].Cells[2].Value = row[2]; // Borrowing Date
                DGVRetBooks.Columns["BowDateCol"].DefaultCellStyle.Format = "dd MMM yyyy";
                DGVRetBooks.Rows[idx].Cells[3].Value = row[3]; // Due Date
                DGVRetBooks.Columns["DueDateCol"].DefaultCellStyle.Format = "dd MMM yyyy";
                DGVRetBooks.Rows[idx].Cells[4].Value = row[4]; // Return Date
                DGVRetBooks.Columns["ReturnDateCol"].DefaultCellStyle.Format = "dd MMM yyyy";
                DGVRetBooks.Rows[idx].Cells[5].Value = row[5]; // Status
                string StatusBorrow = DGVRetBooks.Rows[idx].Cells[5].Value.ToString();
                if(StatusBorrow == "Late") 
                {
                    DGVRetBooks.Rows[idx].Cells[5].Style.ForeColor = System.Drawing.Color.Red;
                    DGVRetBooks.Rows[idx].Cells[6].Value = "✔️";
                    DGVRetBooks.Rows[idx].Cells[6].ReadOnly = true;
                }
                else if (StatusBorrow == "Returned") 
                {
                    DGVRetBooks.Rows[idx].Cells[5].Style.ForeColor = System.Drawing.Color.Green;
                    DGVRetBooks.Rows[idx].Cells[6].Value = "✔️";
                    DGVRetBooks.Rows[idx].Cells[6].ReadOnly = true;
                }
                else 
                {
                    DGVRetBooks.Rows[idx].Cells[6].Value = "💾"; // Save Btn
                    DGVRetBooks.Rows[idx].Cells[6].ReadOnly = false;
                }
                DGVRetBooks.Rows[idx].Cells[7].Value = row[6]; // Bow ID
            }
            DGVRetBooks.ClearSelection();
        }

        private void DGVRetBooks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DGVRetBooks.Columns[e.ColumnIndex].Name == "SaveCol")
            {
                DGVRetBooks.Cursor = Cursors.Hand;
            }
        }

        private void DGVRetBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DGVRetBooks.Columns[e.ColumnIndex].Name != "SaveCol")
                return;

            DataGridViewRow row = DGVRetBooks.Rows[e.RowIndex];
            string Status = row.Cells["StatusCol"].Value.ToString();
            if(Status == "Returned" || Status == "Late") 
            {
                DGVRetBooks.Cursor = Cursors.No;
                return;
            }
            row.Cells["ReturnDateCol"].Value = DateTime.Now.ToString("dd MMM yyyy");
            DateTime dueDate = Convert.ToDateTime(row.Cells["DueDateCol"].Value);
            string GetStatus = "";
            if (dueDate < DateTime.Now.Date)
            {
                row.Cells["StatusCol"].Value = "Late";
                row.Cells["StatusCol"].Style.ForeColor = Color.Red;
                GetStatus = "Late";
                int FineBowId = Convert.ToInt32(row.Cells["BoeIDCol"].Value);
                FinesDAL finesDAL = new FinesDAL();
                finesDAL.AddFineToBorowing(FineBowId);
            }
            else 
            {
                row.Cells["StatusCol"].Value = "Returned";
                row.Cells["StatusCol"].Style.ForeColor = Color.Green;
                GetStatus = "Returned";
            }
            int BookIsbn = Convert.ToInt32(row.Cells["ISBNCol"].Value);
            BookDAL  RetBook = new BookDAL();
            RetBook.IncrementAvalibleCopiesByISBNAtBorrowing(BookIsbn);
            Borrowing Bow = new Borrowing
            {
                status = GetStatus,
                UserID = Convert.ToInt32(TxtUserId.Value),
                ISBNBook = BookIsbn,
                due_date = dueDate,
                borrow_date = Convert.ToDateTime(row.Cells["BowDateCol"].Value)
            };
            BorrowingDAL borrowingDAL = new BorrowingDAL();
            borrowingDAL.UpdateChangingToReturnBook(Bow);
            row.Cells["SaveCol"].ReadOnly = true;
            row.Cells["SaveCol"].Value = "✔️";
            DGVRetBooks.Cursor = Cursors.No;
        }

    }
}

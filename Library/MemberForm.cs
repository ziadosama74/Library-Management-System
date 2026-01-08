using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MemberForm : Form
    {
        private string _userName;
        private string _ID;
        public MemberForm(string userName, string id)
        {
            InitializeComponent();
            _userName = userName;
            _ID = id;

        }
        private void MemberForm_Load(object sender, EventArgs e)
        {
            try
            {
                UserPageLab.Text = "Member Page 🧑🏻‍🏫 : " + _userName + " - ID : " + _ID;
                LoadAuthors();
                LoadCategories();
                TxtBowDate.Text = DateTime.Now.ToString("dddd, dd MMM yyyy");
                TxtDueDate.Text = DateTime.Today.AddDays(3).ToString("dddd, dd MMM yyyy");
                DGVSearchResult.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString());
            }
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
        private void DisableAllBoxes()
        {
            LabTargtSearch.Text = "";
            TxtCategory.Location = new Point(1026, 61);
            TxtCategory.Visible = false;
            TxtAuthor.Location = new Point(1026, 12);
            TxtAuthor.Visible = false;
            TxtTitile.Visible = false;
            TxtTitile.Location = new Point(148, 21);
            TxtISBN.Visible = false;
            TxtISBN.Location = new Point(899, 12);
            SearchBtn.Visible = false;
            SearchBtn.Location = new Point(181, 53);
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (DGVCart.Rows.Count > 0)
            {
                MessageBox.Show("Make Borrowing Or Remove All Cart 🛒");
                return;
            }
            else
            {
                MainPage MP = new MainPage();
                this.Close();
                MP.Show();
            }
        }

        private void TxtSsearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtSsearchBy.SelectedIndex == 0)
            {
                DisableAllBoxes();
                LabTargtSearch.Text = "ISBN";
                TxtISBN.Visible = true;
                TxtISBN.Location = new Point(413, 123);
                SearchBtn.Visible = true;
                SearchBtn.Location = new Point(530, 123);
            }
            else if (TxtSsearchBy.SelectedIndex == 1)
            {
                DisableAllBoxes();
                LabTargtSearch.Text = "Ttitle";
                TxtTitile.Location = new Point(420, 123);
                TxtTitile.Visible = true;
                SearchBtn.Visible = true;
                SearchBtn.Location = new Point(652, 123);
            }
            else if (TxtSsearchBy.SelectedIndex == 2)
            {
                DisableAllBoxes();
                LabTargtSearch.Text = "Author";
                TxtAuthor.Location = new Point(440, 123);
                TxtAuthor.Visible = true;
                SearchBtn.Visible = true;
                SearchBtn.Location = new Point(672, 123);
            }
            else if (TxtSsearchBy.SelectedIndex == 3)
            {
                DisableAllBoxes();
                LabTargtSearch.Text = "Category";
                TxtCategory.Location = new Point(460, 123);
                TxtCategory.Visible = true;
                SearchBtn.Visible = true;
                SearchBtn.Location = new Point(692, 123);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtSsearchBy.SelectedIndex == -1)
                {
                    MessageBox.Show("Choose search type ❌");
                    return;
                }

                string searchBy = TxtSsearchBy.Text;
                object value = null;

                if (searchBy == "ISBN")
                {
                    if (!int.TryParse(TxtISBN.Text, out int isbn))
                    {
                        MessageBox.Show("Enter valid ISBN ❌");
                        return;
                    }
                    value = isbn;
                }
                else if (searchBy == "Title")
                {
                    if (string.IsNullOrWhiteSpace(TxtTitile.Text))
                    {
                        MessageBox.Show("Enter title ❌");
                        return;
                    }
                    value = TxtTitile.Text.Trim();
                }
                else if (searchBy == "Author")
                {
                    if (TxtAuthor.SelectedIndex == -1)
                    {
                        MessageBox.Show("Select Author ❌");
                        return;
                    }
                    value = TxtAuthor.SelectedValue;
                }
                else if (searchBy == "Category")
                {
                    if (TxtCategory.SelectedIndex == -1)
                    {
                        MessageBox.Show("Select Category ❌");
                        return;
                    }
                    value = TxtCategory.SelectedValue;
                }

                BookDAL dal = new BookDAL();
                DataTable dt = dal.SearchBooksByOneField(searchBy, value);

                // 🧹 clear old rows
                DGVSearchResult.Rows.Clear();

                // 🧠 fill cells manually
                foreach (DataRow row in dt.Rows)
                {
                    int idx = DGVSearchResult.Rows.Add();

                    DGVSearchResult.Rows[idx].Cells[0].Value = row[0]; // ISBN
                    DGVSearchResult.Rows[idx].Cells[1].Value = row[1]; // Title
                    DGVSearchResult.Rows[idx].Cells[2].Value = row[2]; // Category
                    DGVSearchResult.Rows[idx].Cells[3].Value = row[3]; // Author
                    DGVSearchResult.Rows[idx].Cells[4].Value = row[4]; // Copies
                    DGVSearchResult.Rows[idx].Cells[5].Value = row[5]; // Avalible Copies
                    int availableCopies = Convert.ToInt32(DGVSearchResult.Rows[idx].Cells[5].Value);
                    if (availableCopies <= 0)
                    {
                        DGVSearchResult.Rows[idx].Cells[6].Value = "Not Avaliable";
                        DGVSearchResult.Rows[idx].Cells[6].Style.ForeColor = Color.Red;
                        DGVSearchResult.Rows[idx].Cells["AddCol"].ReadOnly = true;
                        DGVSearchResult.Rows[idx].Cells["AddCol"].Value = "✖️";
                    }
                    else
                    {
                        DGVSearchResult.Rows[idx].Cells[6].Value = "Avaliable";
                        DGVSearchResult.Rows[idx].Cells[6].Style.ForeColor = Color.Green;
                        DGVSearchResult.Rows[idx].Cells["AddCol"].ReadOnly = false;
                        DGVSearchResult.Rows[idx].Cells["AddCol"].Value = "🛒➕";
                    }
                }

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No results found ❌");
                DGVSearchResult.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void DGVSearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // تأكد إن الضغط على Row فعلي
            if (e.RowIndex < 0) return;

            // تأكد إن العمود هو زر Add
            if (DGVSearchResult.Columns[e.ColumnIndex].Name != "AddCol")
                return;

            try
            {
                BorrowingDAL borrowingDAL1 = new BorrowingDAL();
                int NoBow = borrowingDAL1.CheckBorrowingExitedToUser(Convert.ToInt32(_ID));
                if ( (NoBow == 3) || (NoBow == 2 && DGVCart.Rows.Count == 1) || (NoBow == 1 && DGVCart.Rows.Count == 2))
                {
                    MessageBox.Show("Maxumim 3 Books to Borrowing !!");
                    return;
                }
                DataGridViewRow sourceRow = DGVSearchResult.Rows[e.RowIndex];
                int availableCopies = Convert.ToInt32(sourceRow.Cells[5].Value);
                if (availableCopies <= 0)
                {
                    return;
                }
                if (DGVCart.Rows.Count >= 3)
                {
                    MessageBox.Show("Cannot add more than 3 books ❌");
                    return;
                }
                foreach (DataGridViewRow row in DGVCart.Rows)
                {
                    if (row.Cells[0].Value?.ToString() ==
                        sourceRow.Cells[0].Value?.ToString())
                    {
                        MessageBox.Show("This book is already added ❗");
                        return;
                    }
                }


                int newRowIndex = DGVCart.Rows.Add();
                DGVCart.Rows[newRowIndex].Cells[0].Value = sourceRow.Cells[0].Value; // ISBN
                DGVCart.Rows[newRowIndex].Cells[1].Value = sourceRow.Cells[1].Value; // Title
                DGVCart.Rows[newRowIndex].Cells["CancelCol"].Value = "🗑❌";

                availableCopies--;
                sourceRow.Cells[5].Value = availableCopies;

                if (availableCopies == 0)
                {
                    sourceRow.Cells[6].Value = "Not Available";
                    sourceRow.Cells[6].Style.ForeColor = Color.Red;

                    sourceRow.Cells["AddCol"].ReadOnly = true;
                    sourceRow.Cells["AddCol"].Value = "✖️";
                }
                else
                {
                    sourceRow.Cells[6].Value = "Available";
                    sourceRow.Cells[6].Style.ForeColor = Color.Green;

                    sourceRow.Cells["AddCol"].ReadOnly = false;
                    sourceRow.Cells["AddCol"].Value = "🛒➕";
                }

                DGVCart.ClearSelection();
                int isbn = Convert.ToInt32(sourceRow.Cells[0].Value);
                BookDAL BooKUpdateAvaliableCopies = new BookDAL();
                BooKUpdateAvaliableCopies.UpdateAvalibleCopiesByISBN(isbn, availableCopies);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unexpected error ❌\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void DGVSearchResult_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DGVSearchResult.Columns[e.ColumnIndex].Name == "AddCol")
            {
                int availableCopies = Convert.ToInt32(
                    DGVSearchResult.Rows[e.RowIndex].Cells[5].Value
                );

                if (availableCopies <= 0)
                {
                    DGVSearchResult.Cursor = Cursors.No;
                }
                else
                {
                    DGVSearchResult.Cursor = Cursors.Hand;
                }
            }
        }

        private void DGVCart_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DGVCart.Columns[e.ColumnIndex].Name == "CancelCol")
            {
                DGVCart.Cursor = Cursors.Hand;
            }
        }

        private void DGVCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DGVCart.Columns[e.ColumnIndex].Name != "CancelCol")
                return;

            try
            {
                DataGridViewRow cartRow = DGVCart.Rows[e.RowIndex];
                int isbn = Convert.ToInt32(cartRow.Cells[0].Value);

                BookDAL bookDAL = new BookDAL();
                bookDAL.IncreaseAvailableCopiesByISBN(isbn);

                foreach (DataGridViewRow searchRow in DGVSearchResult.Rows)
                {
                    if (searchRow.IsNewRow) continue;

                    int searchIsbn = Convert.ToInt32(searchRow.Cells[0].Value);

                    if (searchIsbn == isbn)
                    {
                        int availableCopies = Convert.ToInt32(searchRow.Cells[5].Value);
                        availableCopies++;

                        searchRow.Cells[5].Value = availableCopies;
                        searchRow.Cells[6].Value = "Avaliable";
                        searchRow.Cells[6].Style.ForeColor = Color.Green;
                        searchRow.Cells["AddCol"].ReadOnly = false;
                        searchRow.Cells["AddCol"].Value = "🛒➕";

                        break;
                    }
                }
                DGVCart.Rows.RemoveAt(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error ❌\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BorwoingBtn_Click(object sender, EventArgs e)
        {
            if(DGVCart.Rows.Count <= 0) 
            {
                MessageBox.Show("No Cart Yet ! 🛒❌");
                return;
            }
            foreach (DataGridViewRow row in DGVCart.Rows) 
            {
                if (row.IsNewRow) continue;
                Borrowing borrowing = new Borrowing();
                borrowing.UserID = int.Parse(_ID);
                borrowing.ISBNBook = Convert.ToInt32(row.Cells[0].Value);
                borrowing.borrow_date = DateTime.ParseExact(TxtBowDate.Text, "dddd, dd MMM yyyy", CultureInfo.InvariantCulture);
                borrowing.due_date = DateTime.ParseExact(TxtDueDate.Text, "dddd, dd MMM yyyy", CultureInfo.InvariantCulture);
                BorrowingDAL borrowingDAL = new BorrowingDAL();
                borrowingDAL.AddBorowingBook(borrowing);
            }
            DGVCart.Rows.Clear();
            MessageBox.Show("Cart Added successfully");

        }
    }
}

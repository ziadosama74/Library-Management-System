namespace Library
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void RestBoxex()
        {
            TxtUserName.Text = "";
            TxtUserPssword.Text = "";
            AdminCheckBox.Checked = false;
            LibrarianCheckBox.Checked = false;
            MeberCheckBox.Checked = false;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string UserType = "";
            int CountCheck = 0;
            if (AdminCheckBox.Checked)
            {
                UserType = "Admin";
                CountCheck++;
            }
            if (LibrarianCheckBox.Checked)
            {
                UserType = "Librarian";
                CountCheck++;
            }
            if (MeberCheckBox.Checked)
            {
                UserType = "Membere";
                CountCheck++;
            }
            if (CountCheck == 1)
            {
                UserDAL user = new UserDAL();
                bool IsFound = user.UserExists(TxtUserName.Text, TxtUserPssword.Text, UserType);

                if (UserType == "Admin")
                {
                    if (IsFound)
                    {
                        User UserData = user.GetUserIfExists(TxtUserName.Text, TxtUserPssword.Text, UserType);
                        AdminForm adminForm = new AdminForm(UserData.Name, UserData.UserID.ToString());
                        this.Hide();
                        adminForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User Not Found ❌");
                    }

                }
                else if (UserType == "Membere")
                {
                    if (IsFound)
                    {
                        User UserData = user.GetUserIfExists(TxtUserName.Text, TxtUserPssword.Text, UserType);
                        MemberForm MEBF = new MemberForm(UserData.Name, UserData.UserID.ToString());
                        this.Hide();
                        MEBF.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User Not Found ❌");
                    }

                }
                else if (UserType == "Librarian")
                {
                    if (IsFound)
                    {
                        User UserData = user.GetUserIfExists(TxtUserName.Text, TxtUserPssword.Text, UserType);
                        LibrarianForm LF = new LibrarianForm(UserData.Name, UserData.UserID.ToString());
                        this.Hide();
                        LF.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User Not Found ❌");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Login ❌");
                }
                RestBoxex();
            }
            else
            {
                MessageBox.Show("Invalid Login ❌");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

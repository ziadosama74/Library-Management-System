using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class AdminForm : Form
    {
        private string _userName;
        private string _ID;
        public AdminForm(string userName, string id)
        {
            InitializeComponent();
            _userName = userName;
            _ID = id;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            UserPageLab.Text = "Admin Page 👨🏻‍💼 : " + _userName + " - ID : " + _ID;
        }
        private void RestBoxex()
        {
            TxtUserName.Text = "";
            TxtUserPassword.Text = "";
            TxtName.Text = "";
            AdminCheckBox.Checked = false;
            LibrarianCheckBox.Checked = false;
            MemberCheckBox.Checked = false;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainPage MP = new MainPage();
            this.Close();
            MP.Show();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text.Trim() == "" || TxtUserPassword.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Process ❌");
            }
            else
            {
                string userType = "";
                int CountCheck = 0;
                if (AdminCheckBox.Checked)
                {
                    userType = "Admin";
                    CountCheck++;
                }
                if (LibrarianCheckBox.Checked)
                {
                    userType = "Librarian";
                    CountCheck++;
                }
                if (MemberCheckBox.Checked)
                {
                    userType = "Membere";
                    CountCheck++;
                }
                if (CountCheck == 1)
                {
                    try
                    {
                        User user = new User
                        {
                            UserName = TxtUserName.Text,
                            UserPassword = TxtUserPassword.Text,
                            UserType = userType,
                            Name = TxtName.Text
                        };
                        UserDAL userDAL = new UserDAL();
                        bool IsertUserStatus = userDAL.AddUser(user);
                        if (IsertUserStatus)
                        {
                            MessageBox.Show("User Added Successfully ✔️");
                        }
                        else
                        {
                            MessageBox.Show("Cannot Add More Than One Ueser With Same Data ❌");
                        }
                        RestBoxex();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Process ❌");
                }
            }
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text.Trim() == "" || TxtUserPassword.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Process ❌");
            }
            else
            {
                string userType = "";
                int CountCheck = 0;
                if (AdminCheckBox.Checked)
                {
                    userType = "Admin";
                    CountCheck++;
                }
                if (LibrarianCheckBox.Checked)
                {
                    userType = "Librarian";
                    CountCheck++;
                }
                if (MemberCheckBox.Checked)
                {
                    userType = "Membere";
                    CountCheck++;
                }
                if (CountCheck == 1)
                {
                    try
                    {
                        UserDAL user = new UserDAL();
                        bool StatusDeleteUser = user.DeleteUser(TxtUserName.Text, TxtUserPassword.Text, userType);
                        if (StatusDeleteUser)
                        {
                            MessageBox.Show("User Deleted Successfully ✔️");
                        }
                        else
                        {
                            MessageBox.Show("User Not Found ❌");
                        }

                        RestBoxex();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Process ❌");
                }
            }
        }


    }
}

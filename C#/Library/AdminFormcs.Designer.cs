namespace Library
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BackBtn = new Label();
            UserPageLab = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            TxtName = new TextBox();
            AddUserBtn = new Button();
            LibrarianCheckBox = new CheckBox();
            MemberCheckBox = new CheckBox();
            AdminCheckBox = new CheckBox();
            DeleteUserBtn = new Button();
            label12 = new Label();
            TxtUserPassword = new TextBox();
            TxtUserName = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            LoginBtn = new Button();
            label3 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.AutoSize = true;
            BackBtn.BackColor = Color.FromArgb(21, 53, 72);
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(20, 23);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(68, 48);
            BackBtn.TabIndex = 16;
            BackBtn.Text = "🔙";
            BackBtn.Click += BackBtn_Click;
            // 
            // UserPageLab
            // 
            UserPageLab.AutoSize = true;
            UserPageLab.BackColor = Color.White;
            UserPageLab.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserPageLab.ForeColor = Color.FromArgb(21, 53, 72);
            UserPageLab.Location = new Point(110, 9);
            UserPageLab.Name = "UserPageLab";
            UserPageLab.Size = new Size(0, 65);
            UserPageLab.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 53, 72);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-3, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 584);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(21, 53, 72);
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(145, 17);
            label1.Name = "label1";
            label1.Size = new Size(306, 55);
            label1.TabIndex = 18;
            label1.Text = "Add New User";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(TxtName);
            panel3.Controls.Add(AddUserBtn);
            panel3.Controls.Add(LibrarianCheckBox);
            panel3.Controls.Add(MemberCheckBox);
            panel3.Controls.Add(AdminCheckBox);
            panel3.Controls.Add(DeleteUserBtn);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(TxtUserPassword);
            panel3.Controls.Add(TxtUserName);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 481);
            panel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(21, 53, 72);
            label5.Location = new Point(16, 190);
            label5.Name = "label5";
            label5.Size = new Size(77, 32);
            label5.TabIndex = 34;
            label5.Text = "Name";
            // 
            // TxtName
            // 
            TxtName.BackColor = SystemColors.Menu;
            TxtName.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtName.Location = new Point(160, 187);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(360, 40);
            TxtName.TabIndex = 33;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = Color.FromArgb(21, 53, 72);
            AddUserBtn.Cursor = Cursors.Hand;
            AddUserBtn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            AddUserBtn.ForeColor = Color.White;
            AddUserBtn.Location = new Point(366, 408);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(154, 55);
            AddUserBtn.TabIndex = 32;
            AddUserBtn.Text = "Add   ✔️";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // LibrarianCheckBox
            // 
            LibrarianCheckBox.AutoSize = true;
            LibrarianCheckBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrarianCheckBox.Location = new Point(277, 352);
            LibrarianCheckBox.Name = "LibrarianCheckBox";
            LibrarianCheckBox.Size = new Size(106, 29);
            LibrarianCheckBox.TabIndex = 31;
            LibrarianCheckBox.Text = "Librarian";
            LibrarianCheckBox.UseVisualStyleBackColor = true;
            // 
            // MemberCheckBox
            // 
            MemberCheckBox.AutoSize = true;
            MemberCheckBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MemberCheckBox.Location = new Point(390, 352);
            MemberCheckBox.Name = "MemberCheckBox";
            MemberCheckBox.Size = new Size(100, 29);
            MemberCheckBox.TabIndex = 30;
            MemberCheckBox.Text = "Member";
            MemberCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminCheckBox
            // 
            AdminCheckBox.AutoSize = true;
            AdminCheckBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminCheckBox.Location = new Point(190, 352);
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.Size = new Size(83, 29);
            AdminCheckBox.TabIndex = 29;
            AdminCheckBox.Text = "Admin";
            AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeleteUserBtn
            // 
            DeleteUserBtn.BackColor = Color.FromArgb(21, 53, 72);
            DeleteUserBtn.Cursor = Cursors.Hand;
            DeleteUserBtn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            DeleteUserBtn.ForeColor = Color.White;
            DeleteUserBtn.Location = new Point(160, 408);
            DeleteUserBtn.Name = "DeleteUserBtn";
            DeleteUserBtn.Size = new Size(154, 55);
            DeleteUserBtn.TabIndex = 28;
            DeleteUserBtn.Text = "Delete ❌";
            DeleteUserBtn.UseVisualStyleBackColor = false;
            DeleteUserBtn.Click += DeleteUserBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(21, 53, 72);
            label12.Location = new Point(15, 349);
            label12.Name = "label12";
            label12.Size = new Size(130, 32);
            label12.TabIndex = 27;
            label12.Text = "User Type";
            // 
            // TxtUserPassword
            // 
            TxtUserPassword.BackColor = SystemColors.Menu;
            TxtUserPassword.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            TxtUserPassword.Location = new Point(160, 295);
            TxtUserPassword.Name = "TxtUserPassword";
            TxtUserPassword.PasswordChar = '*';
            TxtUserPassword.Size = new Size(360, 40);
            TxtUserPassword.TabIndex = 26;
            // 
            // TxtUserName
            // 
            TxtUserName.BackColor = SystemColors.Menu;
            TxtUserName.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtUserName.Location = new Point(160, 242);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(360, 40);
            TxtUserName.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(21, 53, 72);
            label11.Location = new Point(16, 302);
            label11.Name = "label11";
            label11.Size = new Size(114, 32);
            label11.TabIndex = 24;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(21, 53, 72);
            label10.Location = new Point(15, 244);
            label10.Name = "label10";
            label10.Size = new Size(139, 32);
            label10.TabIndex = 23;
            label10.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Comic Sans MS", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(21, 53, 72);
            label4.Location = new Point(197, -7);
            label4.Name = "label4";
            label4.Size = new Size(239, 168);
            label4.TabIndex = 22;
            label4.Text = "👤";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(21, 53, 72);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(655, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 584);
            panel2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(21, 53, 72);
            label2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(227, 17);
            label2.Name = "label2";
            label2.Size = new Size(190, 55);
            label2.TabIndex = 19;
            label2.Text = "Rreports";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(LoginBtn);
            panel4.Location = new Point(0, 103);
            panel4.Name = "panel4";
            panel4.Size = new Size(612, 481);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(21, 53, 72);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(129, 391);
            button1.Name = "button1";
            button1.Size = new Size(362, 72);
            button1.TabIndex = 13;
            button1.Text = "  Fines    💰";
            button1.UseVisualStyleBackColor = false;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(21, 53, 72);
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(129, 266);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(362, 72);
            LoginBtn.TabIndex = 12;
            LoginBtn.Text = "Borrowing Books 📖";
            LoginBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Comic Sans MS", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(21, 53, 72);
            label3.Location = new Point(836, 207);
            label3.Name = "label3";
            label3.Size = new Size(239, 168);
            label3.TabIndex = 21;
            label3.Text = "\U0001f9fe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Comic Sans MS", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(21, 53, 72);
            label8.Location = new Point(523, 317);
            label8.Name = "label8";
            label8.Size = new Size(239, 168);
            label8.TabIndex = 20;
            label8.Text = "📚";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1265, 686);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(UserPageLab);
            Controls.Add(BackBtn);
            MaximumSize = new Size(1283, 733);
            MinimumSize = new Size(1283, 733);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BackBtn;
        private Label UserPageLab;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label8;
        private Button button1;
        private Button LoginBtn;
        private Label label4;
        private Label label3;
        private CheckBox LibrarianCheckBox;
        private CheckBox MemberCheckBox;
        private CheckBox AdminCheckBox;
        private Button DeleteUserBtn;
        private Label label12;
        private TextBox TxtUserPassword;
        private TextBox TxtUserName;
        private Label label11;
        private Label label10;
        private Button AddUserBtn;
        private Label label5;
        private TextBox TxtName;
    }
}
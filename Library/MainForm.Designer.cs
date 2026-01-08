namespace Library
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            CloseBtn = new Label();
            label8 = new Label();
            LibrarianCheckBox = new CheckBox();
            MeberCheckBox = new CheckBox();
            AdminCheckBox = new CheckBox();
            LoginBtn = new Button();
            label12 = new Label();
            TxtUserPssword = new TextBox();
            TxtUserName = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(21, 53, 72);
            label1.Font = new Font("Comic Sans MS", 25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(603, 58);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(CloseBtn);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(LibrarianCheckBox);
            panel1.Controls.Add(MeberCheckBox);
            panel1.Controls.Add(AdminCheckBox);
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(TxtUserPssword);
            panel1.Controls.Add(TxtUserName);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(641, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 788);
            panel1.TabIndex = 1;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.BackColor = Color.FromArgb(21, 53, 72);
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            CloseBtn.ForeColor = Color.White;
            CloseBtn.Location = new Point(577, 0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(45, 48);
            CloseBtn.TabIndex = 15;
            CloseBtn.Text = "X";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Comic Sans MS", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(21, 53, 72);
            label8.Location = new Point(199, 541);
            label8.Name = "label8";
            label8.Size = new Size(239, 168);
            label8.TabIndex = 9;
            label8.Text = "📚";
            // 
            // LibrarianCheckBox
            // 
            LibrarianCheckBox.AutoSize = true;
            LibrarianCheckBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibrarianCheckBox.Location = new Point(348, 363);
            LibrarianCheckBox.Name = "LibrarianCheckBox";
            LibrarianCheckBox.Size = new Size(106, 29);
            LibrarianCheckBox.TabIndex = 14;
            LibrarianCheckBox.Text = "Librarian";
            LibrarianCheckBox.UseVisualStyleBackColor = true;
            // 
            // MeberCheckBox
            // 
            MeberCheckBox.AutoSize = true;
            MeberCheckBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MeberCheckBox.Location = new Point(499, 363);
            MeberCheckBox.Name = "MeberCheckBox";
            MeberCheckBox.Size = new Size(100, 29);
            MeberCheckBox.TabIndex = 13;
            MeberCheckBox.Text = "Member";
            MeberCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminCheckBox
            // 
            AdminCheckBox.AutoSize = true;
            AdminCheckBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminCheckBox.Location = new Point(228, 363);
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.Size = new Size(83, 29);
            AdminCheckBox.TabIndex = 12;
            AdminCheckBox.Text = "Admin";
            AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(21, 53, 72);
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(210, 451);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(206, 72);
            LoginBtn.TabIndex = 11;
            LoginBtn.Text = "Submit";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(21, 53, 72);
            label12.Location = new Point(18, 344);
            label12.Name = "label12";
            label12.Size = new Size(169, 48);
            label12.TabIndex = 9;
            label12.Text = "Login as ";
            // 
            // TxtUserPssword
            // 
            TxtUserPssword.BackColor = SystemColors.Menu;
            TxtUserPssword.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            TxtUserPssword.Location = new Point(228, 269);
            TxtUserPssword.Name = "TxtUserPssword";
            TxtUserPssword.PasswordChar = '*';
            TxtUserPssword.Size = new Size(371, 53);
            TxtUserPssword.TabIndex = 8;
            // 
            // TxtUserName
            // 
            TxtUserName.BackColor = SystemColors.Menu;
            TxtUserName.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            TxtUserName.Location = new Point(228, 193);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(371, 53);
            TxtUserName.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(21, 53, 72);
            label11.Location = new Point(18, 269);
            label11.Name = "label11";
            label11.Size = new Size(168, 48);
            label11.TabIndex = 6;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(21, 53, 72);
            label10.Location = new Point(18, 193);
            label10.Name = "label10";
            label10.Size = new Size(204, 48);
            label10.TabIndex = 5;
            label10.Text = "User Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(21, 53, 72);
            label9.Location = new Point(210, 25);
            label9.Name = "label9";
            label9.Size = new Size(228, 65);
            label9.TabIndex = 4;
            label9.Text = "Login 🔑";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(21, 53, 72);
            label2.Font = new Font("Comic Sans MS", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(123, 98);
            label2.Name = "label2";
            label2.Size = new Size(428, 58);
            label2.TabIndex = 2;
            label2.Text = "Implemented By \U0001f9d1🏻‍💻";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(21, 53, 72);
            label3.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(127, 202, 196);
            label3.Location = new Point(145, 200);
            label3.Name = "label3";
            label3.Size = new Size(357, 48);
            label3.TabIndex = 3;
            label3.Text = "👷🏻‍♂️ Mahmoud Osama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(21, 53, 72);
            label4.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(127, 202, 196);
            label4.Location = new Point(146, 265);
            label4.Name = "label4";
            label4.Size = new Size(316, 48);
            label4.TabIndex = 4;
            label4.Text = "👷🏻‍♂️ Yossef Amgad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(21, 53, 72);
            label5.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(127, 202, 196);
            label5.Location = new Point(146, 335);
            label5.Name = "label5";
            label5.Size = new Size(329, 48);
            label5.TabIndex = 5;
            label5.Text = "👷🏻‍♂️ Fady Mohamed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(21, 53, 72);
            label6.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(127, 202, 196);
            label6.Location = new Point(146, 396);
            label6.Name = "label6";
            label6.Size = new Size(293, 48);
            label6.TabIndex = 6;
            label6.Text = "👷🏻‍♂️ Ali Mahmoud";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(21, 53, 72);
            label7.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(127, 202, 196);
            label7.Location = new Point(146, 455);
            label7.Name = "label7";
            label7.Size = new Size(279, 48);
            label7.TabIndex = 7;
            label7.Text = "👷🏻‍♂️ Ziad Osama";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(21, 53, 72);
            label13.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(32, 660);
            label13.Name = "label13";
            label13.Size = new Size(564, 48);
            label13.TabIndex = 8;
            label13.Text = "Telecom Application Development";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(21, 53, 72);
            label14.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(210, 540);
            label14.Name = "label14";
            label14.Size = new Size(186, 96);
            label14.TabIndex = 9;
            label14.Text = "   ITI\r\nIntake 46";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 53, 72);
            ClientSize = new Size(1261, 738);
            ControlBox = false;
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MaximumSize = new Size(1283, 789);
            MinimumSize = new Size(1283, 789);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox TxtUserPssword;
        private TextBox TxtUserName;
        private Label label11;
        private Label label10;
        private Label label12;
        private Button LoginBtn;
        private CheckBox LibrarianCheckBox;
        private CheckBox MeberCheckBox;
        private CheckBox AdminCheckBox;
        private Label label13;
        private Label label14;
        private Label CloseBtn;
    }
}

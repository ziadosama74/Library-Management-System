namespace Library
{
    partial class LibrarianForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            UserPageLab = new Label();
            BackBtn = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            TxtUNameBySearch = new Label();
            label13 = new Label();
            label3 = new Label();
            DGVRetBooks = new DataGridView();
            ISBNCol = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            BowDateCol = new DataGridViewTextBoxColumn();
            DueDateCol = new DataGridViewTextBoxColumn();
            ReturnDateCol = new DataGridViewTextBoxColumn();
            StatusCol = new DataGridViewTextBoxColumn();
            SaveCol = new DataGridViewButtonColumn();
            label8 = new Label();
            SearchUsserBtn = new Button();
            TxtUserId = new NumericUpDown();
            label2 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label4 = new Label();
            GetBookBtn = new Button();
            panel3 = new Panel();
            TxtAvalible = new TextBox();
            label9 = new Label();
            TxtAuthor = new ComboBox();
            label7 = new Label();
            SaveChangesBtn = new Button();
            TxtISBN = new NumericUpDown();
            TxtCopies = new NumericUpDown();
            label5 = new Label();
            TxtCategory = new ComboBox();
            label1 = new Label();
            TxtTitlle = new TextBox();
            EditCheckBox = new CheckBox();
            DeleteCheckBox = new CheckBox();
            AddCheckBox = new CheckBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            TxtSearchISBN = new NumericUpDown();
            BoeIDCol = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVRetBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtUserId).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtISBN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtCopies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtSearchISBN).BeginInit();
            SuspendLayout();
            // 
            // UserPageLab
            // 
            UserPageLab.AutoSize = true;
            UserPageLab.BackColor = Color.White;
            UserPageLab.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserPageLab.ForeColor = Color.FromArgb(21, 53, 72);
            UserPageLab.Location = new Point(111, 9);
            UserPageLab.Name = "UserPageLab";
            UserPageLab.Size = new Size(0, 65);
            UserPageLab.TabIndex = 21;
            // 
            // BackBtn
            // 
            BackBtn.AutoSize = true;
            BackBtn.BackColor = Color.FromArgb(21, 53, 72);
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(32, 23);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(68, 48);
            BackBtn.TabIndex = 20;
            BackBtn.Text = "🔙";
            BackBtn.Click += BackBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(21, 53, 72);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(DGVRetBooks);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(SearchUsserBtn);
            panel2.Controls.Add(TxtUserId);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(664, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 584);
            panel2.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(TxtUNameBySearch);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(741, 54);
            panel4.TabIndex = 56;
            // 
            // TxtUNameBySearch
            // 
            TxtUNameBySearch.AutoSize = true;
            TxtUNameBySearch.BackColor = Color.White;
            TxtUNameBySearch.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            TxtUNameBySearch.ForeColor = Color.FromArgb(21, 53, 72);
            TxtUNameBySearch.Location = new Point(200, 10);
            TxtUNameBySearch.Name = "TxtUNameBySearch";
            TxtUNameBySearch.Size = new Size(47, 32);
            TxtUNameBySearch.TabIndex = 57;
            TxtUNameBySearch.Text = "🤔";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(21, 53, 72);
            label13.Location = new Point(45, 10);
            label13.Name = "label13";
            label13.Size = new Size(169, 32);
            label13.TabIndex = 56;
            label13.Text = "User Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(21, 53, 72);
            label3.Location = new Point(5, 10);
            label3.Name = "label3";
            label3.Size = new Size(47, 32);
            label3.TabIndex = 23;
            label3.Text = "👤";
            // 
            // DGVRetBooks
            // 
            DGVRetBooks.AllowUserToAddRows = false;
            DGVRetBooks.BackgroundColor = SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(21, 53, 72);
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVRetBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVRetBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRetBooks.Columns.AddRange(new DataGridViewColumn[] { ISBNCol, dataGridViewTextBoxColumn2, BowDateCol, DueDateCol, ReturnDateCol, StatusCol, SaveCol, BoeIDCol });
            DGVRetBooks.EnableHeadersVisualStyles = false;
            DGVRetBooks.Location = new Point(0, 228);
            DGVRetBooks.Name = "DGVRetBooks";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(21, 53, 72);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVRetBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVRetBooks.RowHeadersVisible = false;
            DGVRetBooks.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 8F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(21, 53, 72);
            DGVRetBooks.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGVRetBooks.ScrollBars = ScrollBars.None;
            DGVRetBooks.Size = new Size(741, 356);
            DGVRetBooks.TabIndex = 55;
            DGVRetBooks.CellContentClick += DGVRetBooks_CellContentClick;
            DGVRetBooks.CellMouseEnter += DGVRetBooks_CellMouseEnter;
            // 
            // ISBNCol
            // 
            ISBNCol.Frozen = true;
            ISBNCol.HeaderText = "ISBN";
            ISBNCol.MinimumWidth = 6;
            ISBNCol.Name = "ISBNCol";
            ISBNCol.ReadOnly = true;
            ISBNCol.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Frozen = true;
            dataGridViewTextBoxColumn2.HeaderText = "Book Title";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // BowDateCol
            // 
            BowDateCol.HeaderText = "Borrow Date";
            BowDateCol.MinimumWidth = 6;
            BowDateCol.Name = "BowDateCol";
            BowDateCol.Width = 125;
            // 
            // DueDateCol
            // 
            DueDateCol.HeaderText = "Due Date";
            DueDateCol.MinimumWidth = 6;
            DueDateCol.Name = "DueDateCol";
            DueDateCol.Width = 125;
            // 
            // ReturnDateCol
            // 
            ReturnDateCol.HeaderText = "Return Date";
            ReturnDateCol.MinimumWidth = 6;
            ReturnDateCol.Name = "ReturnDateCol";
            ReturnDateCol.Width = 125;
            // 
            // StatusCol
            // 
            StatusCol.HeaderText = "Status";
            StatusCol.MinimumWidth = 6;
            StatusCol.Name = "StatusCol";
            StatusCol.Resizable = DataGridViewTriState.True;
            StatusCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            StatusCol.Width = 125;
            // 
            // SaveCol
            // 
            SaveCol.HeaderText = "Save";
            SaveCol.MinimumWidth = 6;
            SaveCol.Name = "SaveCol";
            SaveCol.Width = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(21, 53, 72);
            label8.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(124, 97);
            label8.Name = "label8";
            label8.Size = new Size(156, 48);
            label8.TabIndex = 51;
            label8.Text = "User ID";
            // 
            // SearchUsserBtn
            // 
            SearchUsserBtn.BackColor = Color.FromArgb(21, 53, 72);
            SearchUsserBtn.Cursor = Cursors.Hand;
            SearchUsserBtn.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchUsserBtn.ForeColor = Color.White;
            SearchUsserBtn.Location = new Point(423, 94);
            SearchUsserBtn.Name = "SearchUsserBtn";
            SearchUsserBtn.Size = new Size(132, 55);
            SearchUsserBtn.TabIndex = 49;
            SearchUsserBtn.Text = "Search";
            SearchUsserBtn.UseVisualStyleBackColor = false;
            SearchUsserBtn.Click += SearchUsserBtn_Click;
            // 
            // TxtUserId
            // 
            TxtUserId.BackColor = SystemColors.Menu;
            TxtUserId.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            TxtUserId.Location = new Point(286, 95);
            TxtUserId.Name = "TxtUserId";
            TxtUserId.Size = new Size(126, 53);
            TxtUserId.TabIndex = 50;
            TxtUserId.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(21, 53, 72);
            label2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(183, 16);
            label2.Name = "label2";
            label2.Size = new Size(330, 55);
            label2.TabIndex = 19;
            label2.Text = "Returning Books";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 53, 72);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(GetBookBtn);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(TxtSearchISBN);
            panel1.Location = new Point(3, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 584);
            panel1.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(21, 53, 72);
            label6.Location = new Point(94, 95);
            label6.Name = "label6";
            label6.Size = new Size(135, 48);
            label6.TabIndex = 48;
            label6.Text = "Search";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(21, 53, 72);
            label4.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(86, 16);
            label4.Name = "label4";
            label4.Size = new Size(440, 55);
            label4.TabIndex = 19;
            label4.Text = "Book Modification 📖";
            // 
            // GetBookBtn
            // 
            GetBookBtn.BackColor = Color.FromArgb(21, 53, 72);
            GetBookBtn.Cursor = Cursors.Hand;
            GetBookBtn.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetBookBtn.ForeColor = Color.White;
            GetBookBtn.Location = new Point(248, 92);
            GetBookBtn.Name = "GetBookBtn";
            GetBookBtn.Size = new Size(167, 54);
            GetBookBtn.TabIndex = 47;
            GetBookBtn.Text = "Get By ID";
            GetBookBtn.UseVisualStyleBackColor = false;
            GetBookBtn.Click += GetBookBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(TxtAvalible);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(TxtAuthor);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(SaveChangesBtn);
            panel3.Controls.Add(TxtISBN);
            panel3.Controls.Add(TxtCopies);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(TxtCategory);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TxtTitlle);
            panel3.Controls.Add(EditCheckBox);
            panel3.Controls.Add(DeleteCheckBox);
            panel3.Controls.Add(AddCheckBox);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(0, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 408);
            panel3.TabIndex = 1;
            // 
            // TxtAvalible
            // 
            TxtAvalible.BackColor = SystemColors.Menu;
            TxtAvalible.Enabled = false;
            TxtAvalible.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            TxtAvalible.Location = new Point(474, 35);
            TxtAvalible.Name = "TxtAvalible";
            TxtAvalible.Size = new Size(76, 40);
            TxtAvalible.TabIndex = 51;
            TxtAvalible.Text = "0";
            TxtAvalible.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(21, 53, 72);
            label9.Location = new Point(376, 38);
            label9.Name = "label9";
            label9.Size = new Size(100, 32);
            label9.TabIndex = 50;
            label9.Text = "Avalible";
            // 
            // TxtAuthor
            // 
            TxtAuthor.BackColor = SystemColors.Menu;
            TxtAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            TxtAuthor.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            TxtAuthor.FormattingEnabled = true;
            TxtAuthor.Location = new Point(117, 206);
            TxtAuthor.Name = "TxtAuthor";
            TxtAuthor.Size = new Size(433, 40);
            TxtAuthor.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(21, 53, 72);
            label7.Location = new Point(9, 205);
            label7.Name = "label7";
            label7.Size = new Size(90, 32);
            label7.TabIndex = 48;
            label7.Text = "Author";
            // 
            // SaveChangesBtn
            // 
            SaveChangesBtn.BackColor = Color.FromArgb(21, 53, 72);
            SaveChangesBtn.Cursor = Cursors.Hand;
            SaveChangesBtn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            SaveChangesBtn.ForeColor = Color.White;
            SaveChangesBtn.Location = new Point(208, 322);
            SaveChangesBtn.Name = "SaveChangesBtn";
            SaveChangesBtn.Size = new Size(219, 67);
            SaveChangesBtn.TabIndex = 47;
            SaveChangesBtn.Text = "Save Changes ✔️";
            SaveChangesBtn.UseVisualStyleBackColor = false;
            SaveChangesBtn.Click += SaveChangesBtn_Click;
            // 
            // TxtISBN
            // 
            TxtISBN.BackColor = SystemColors.Menu;
            TxtISBN.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            TxtISBN.Location = new Point(117, 30);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(77, 40);
            TxtISBN.TabIndex = 46;
            TxtISBN.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtCopies
            // 
            TxtCopies.BackColor = SystemColors.Menu;
            TxtCopies.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            TxtCopies.Location = new Point(282, 32);
            TxtCopies.Name = "TxtCopies";
            TxtCopies.Size = new Size(77, 40);
            TxtCopies.TabIndex = 45;
            TxtCopies.TextAlign = HorizontalAlignment.Center;
            TxtCopies.ValueChanged += TxtCopies_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(21, 53, 72);
            label5.Location = new Point(196, 32);
            label5.Name = "label5";
            label5.Size = new Size(80, 32);
            label5.TabIndex = 43;
            label5.Text = "copies";
            // 
            // TxtCategory
            // 
            TxtCategory.BackColor = SystemColors.Menu;
            TxtCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            TxtCategory.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            TxtCategory.FormattingEnabled = true;
            TxtCategory.Location = new Point(117, 86);
            TxtCategory.Name = "TxtCategory";
            TxtCategory.Size = new Size(433, 40);
            TxtCategory.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(21, 53, 72);
            label1.Location = new Point(3, 88);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 41;
            label1.Text = "Category";
            // 
            // TxtTitlle
            // 
            TxtTitlle.BackColor = SystemColors.Menu;
            TxtTitlle.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            TxtTitlle.Location = new Point(117, 145);
            TxtTitlle.Name = "TxtTitlle";
            TxtTitlle.Size = new Size(433, 40);
            TxtTitlle.TabIndex = 40;
            // 
            // EditCheckBox
            // 
            EditCheckBox.AutoSize = true;
            EditCheckBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditCheckBox.Location = new Point(282, 267);
            EditCheckBox.Name = "EditCheckBox";
            EditCheckBox.Size = new Size(68, 29);
            EditCheckBox.TabIndex = 39;
            EditCheckBox.Text = "Edit";
            EditCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeleteCheckBox
            // 
            DeleteCheckBox.AutoSize = true;
            DeleteCheckBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteCheckBox.Location = new Point(371, 267);
            DeleteCheckBox.Name = "DeleteCheckBox";
            DeleteCheckBox.Size = new Size(89, 29);
            DeleteCheckBox.TabIndex = 38;
            DeleteCheckBox.Text = "Delete";
            DeleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddCheckBox
            // 
            AddCheckBox.AutoSize = true;
            AddCheckBox.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCheckBox.Location = new Point(199, 267);
            AddCheckBox.Name = "AddCheckBox";
            AddCheckBox.Size = new Size(66, 29);
            AddCheckBox.TabIndex = 37;
            AddCheckBox.Text = "Add";
            AddCheckBox.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(21, 53, 72);
            label12.Location = new Point(9, 259);
            label12.Name = "label12";
            label12.Size = new Size(148, 32);
            label12.TabIndex = 36;
            label12.Text = "Action Type";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(21, 53, 72);
            label11.Location = new Point(9, 148);
            label11.Name = "label11";
            label11.Size = new Size(66, 32);
            label11.TabIndex = 33;
            label11.Text = "Title";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(21, 53, 72);
            label10.Location = new Point(9, 32);
            label10.Name = "label10";
            label10.Size = new Size(77, 32);
            label10.TabIndex = 32;
            label10.Text = "ISBN";
            // 
            // TxtSearchISBN
            // 
            TxtSearchISBN.BackColor = SystemColors.Menu;
            TxtSearchISBN.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            TxtSearchISBN.Location = new Point(436, 93);
            TxtSearchISBN.Name = "TxtSearchISBN";
            TxtSearchISBN.Size = new Size(71, 53);
            TxtSearchISBN.TabIndex = 47;
            TxtSearchISBN.TextAlign = HorizontalAlignment.Center;
            // 
            // BoeIDCol
            // 
            BoeIDCol.HeaderText = "BowId";
            BoeIDCol.MinimumWidth = 6;
            BoeIDCol.Name = "BoeIDCol";
            BoeIDCol.Width = 125;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1411, 744);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(UserPageLab);
            Controls.Add(BackBtn);
            MinimumSize = new Size(1403, 762);
            Name = "LibrarianForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librarian";
            Load += LibrarianForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVRetBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtUserId).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtISBN).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtCopies).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtSearchISBN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserPageLab;
        private Label BackBtn;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Panel panel3;
        private CheckBox EditCheckBox;
        private CheckBox DeleteCheckBox;
        private CheckBox AddCheckBox;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label5;
        private ComboBox TxtCategory;
        private Label label1;
        private TextBox TxtTitlle;
        private Button GetBookBtn;
        private NumericUpDown TxtSearchISBN;
        private NumericUpDown TxtISBN;
        private NumericUpDown TxtCopies;
        private Label label6;
        private Button SaveChangesBtn;
        private Label label7;
        private ComboBox TxtAuthor;
        private Label label9;
        private TextBox TxtAvalible;
        private Button SearchUsserBtn;
        private NumericUpDown TxtUserId;
        private Label label3;
        private Label label8;
        private DataGridView DGVRetBooks;
        private Label label13;
        private Label TxtUNameBySearch;
        private Panel panel4;
        private DataGridViewTextBoxColumn ISBNCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn BowDateCol;
        private DataGridViewTextBoxColumn DueDateCol;
        private DataGridViewTextBoxColumn ReturnDateCol;
        private DataGridViewTextBoxColumn StatusCol;
        private DataGridViewButtonColumn SaveCol;
        private DataGridViewTextBoxColumn BoeIDCol;
    }
}
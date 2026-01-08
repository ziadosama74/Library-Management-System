namespace Library
{
    partial class MemberForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            UserPageLab = new Label();
            BackBtn = new Label();
            label1 = new Label();
            TxtSsearchBy = new ComboBox();
            panel1 = new Panel();
            LabTargtSearch = new Label();
            TxtISBN = new NumericUpDown();
            TxtCategory = new ComboBox();
            TxtAuthor = new ComboBox();
            TxtTitile = new TextBox();
            SearchBtn = new Button();
            DGVSearchResult = new DataGridView();
            ISBNCol = new DataGridViewTextBoxColumn();
            TitleCol = new DataGridViewTextBoxColumn();
            CategoryCol = new DataGridViewTextBoxColumn();
            AuthorCol = new DataGridViewTextBoxColumn();
            TotalCopiesCol = new DataGridViewTextBoxColumn();
            AvaliableCopiesCol = new DataGridViewTextBoxColumn();
            StatusCol = new DataGridViewTextBoxColumn();
            AddCol = new DataGridViewButtonColumn();
            label8 = new Label();
            label2 = new Label();
            DGVCart = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            CancelCol = new DataGridViewButtonColumn();
            BorwoingBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            TxtBowDate = new Label();
            TxtDueDate = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtISBN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVSearchResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVCart).BeginInit();
            SuspendLayout();
            // 
            // UserPageLab
            // 
            UserPageLab.AutoSize = true;
            UserPageLab.BackColor = Color.White;
            UserPageLab.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserPageLab.ForeColor = Color.FromArgb(21, 53, 72);
            UserPageLab.Location = new Point(96, 12);
            UserPageLab.Name = "UserPageLab";
            UserPageLab.Size = new Size(0, 65);
            UserPageLab.TabIndex = 19;
            // 
            // BackBtn
            // 
            BackBtn.AutoSize = true;
            BackBtn.BackColor = Color.FromArgb(21, 53, 72);
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(17, 26);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(68, 48);
            BackBtn.TabIndex = 18;
            BackBtn.Text = "🔙";
            BackBtn.Click += BackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(21, 53, 72);
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 43;
            label1.Text = "Search By";
            // 
            // TxtSsearchBy
            // 
            TxtSsearchBy.BackColor = SystemColors.Menu;
            TxtSsearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            TxtSsearchBy.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtSsearchBy.FormattingEnabled = true;
            TxtSsearchBy.Items.AddRange(new object[] { "ISBN", "Title", "Author", "Category" });
            TxtSsearchBy.Location = new Point(146, 16);
            TxtSsearchBy.Name = "TxtSsearchBy";
            TxtSsearchBy.Size = new Size(170, 40);
            TxtSsearchBy.TabIndex = 44;
            TxtSsearchBy.SelectedIndexChanged += TxtSsearchBy_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 53, 72);
            panel1.Controls.Add(LabTargtSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TxtSsearchBy);
            panel1.Location = new Point(2, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 75);
            panel1.TabIndex = 45;
            // 
            // LabTargtSearch
            // 
            LabTargtSearch.AutoSize = true;
            LabTargtSearch.BackColor = Color.FromArgb(21, 53, 72);
            LabTargtSearch.FlatStyle = FlatStyle.Flat;
            LabTargtSearch.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabTargtSearch.ForeColor = Color.White;
            LabTargtSearch.Location = new Point(322, 16);
            LabTargtSearch.Name = "LabTargtSearch";
            LabTargtSearch.Size = new Size(164, 32);
            LabTargtSearch.TabIndex = 46;
            LabTargtSearch.Text = "               ";
            LabTargtSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtISBN
            // 
            TxtISBN.BackColor = SystemColors.Menu;
            TxtISBN.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            TxtISBN.Location = new Point(908, 12);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(112, 40);
            TxtISBN.TabIndex = 49;
            TxtISBN.TextAlign = HorizontalAlignment.Center;
            TxtISBN.Visible = false;
            // 
            // TxtCategory
            // 
            TxtCategory.BackColor = SystemColors.Menu;
            TxtCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            TxtCategory.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtCategory.FormattingEnabled = true;
            TxtCategory.Items.AddRange(new object[] { "ISBN", "Title", "Author", "Category" });
            TxtCategory.Location = new Point(1026, 61);
            TxtCategory.Name = "TxtCategory";
            TxtCategory.Size = new Size(227, 40);
            TxtCategory.TabIndex = 46;
            TxtCategory.Visible = false;
            // 
            // TxtAuthor
            // 
            TxtAuthor.BackColor = SystemColors.Menu;
            TxtAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            TxtAuthor.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtAuthor.FormattingEnabled = true;
            TxtAuthor.Items.AddRange(new object[] { "ISBN", "Title", "Author", "Category" });
            TxtAuthor.Location = new Point(1026, 12);
            TxtAuthor.Name = "TxtAuthor";
            TxtAuthor.Size = new Size(227, 40);
            TxtAuthor.TabIndex = 47;
            TxtAuthor.Visible = false;
            // 
            // TxtTitile
            // 
            TxtTitile.BackColor = SystemColors.Menu;
            TxtTitile.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            TxtTitile.Location = new Point(148, 7);
            TxtTitile.Name = "TxtTitile";
            TxtTitile.Size = new Size(227, 40);
            TxtTitile.TabIndex = 48;
            TxtTitile.Visible = false;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(21, 53, 72);
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(181, 53);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(151, 41);
            SearchBtn.TabIndex = 50;
            SearchBtn.Text = "Search 🔍";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Visible = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // DGVSearchResult
            // 
            DGVSearchResult.AllowUserToAddRows = false;
            DGVSearchResult.BackgroundColor = Color.FromArgb(21, 53, 72);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(21, 53, 72);
            dataGridViewCellStyle7.Font = new Font("Comic Sans MS", 8F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DGVSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DGVSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVSearchResult.Columns.AddRange(new DataGridViewColumn[] { ISBNCol, TitleCol, CategoryCol, AuthorCol, TotalCopiesCol, AvaliableCopiesCol, StatusCol, AddCol });
            DGVSearchResult.EnableHeadersVisualStyles = false;
            DGVSearchResult.Location = new Point(2, 188);
            DGVSearchResult.Name = "DGVSearchResult";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle8.Font = new Font("Comic Sans MS", 8F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(21, 53, 72);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DGVSearchResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DGVSearchResult.RowHeadersVisible = false;
            DGVSearchResult.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Comic Sans MS", 8F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(21, 53, 72);
            DGVSearchResult.RowsDefaultCellStyle = dataGridViewCellStyle9;
            DGVSearchResult.ScrollBars = ScrollBars.Vertical;
            DGVSearchResult.Size = new Size(1027, 486);
            DGVSearchResult.TabIndex = 51;
            DGVSearchResult.CellContentClick += DGVSearchResult_CellContentClick;
            DGVSearchResult.CellMouseEnter += DGVSearchResult_CellMouseEnter;
            // 
            // ISBNCol
            // 
            ISBNCol.Frozen = true;
            ISBNCol.HeaderText = "ISBN";
            ISBNCol.MinimumWidth = 6;
            ISBNCol.Name = "ISBNCol";
            ISBNCol.ReadOnly = true;
            ISBNCol.Width = 125;
            // 
            // TitleCol
            // 
            TitleCol.Frozen = true;
            TitleCol.HeaderText = "Book Title";
            TitleCol.MinimumWidth = 6;
            TitleCol.Name = "TitleCol";
            TitleCol.ReadOnly = true;
            TitleCol.Width = 125;
            // 
            // CategoryCol
            // 
            CategoryCol.Frozen = true;
            CategoryCol.HeaderText = "Category";
            CategoryCol.MinimumWidth = 6;
            CategoryCol.Name = "CategoryCol";
            CategoryCol.ReadOnly = true;
            CategoryCol.Width = 125;
            // 
            // AuthorCol
            // 
            AuthorCol.HeaderText = "Author";
            AuthorCol.MinimumWidth = 6;
            AuthorCol.Name = "AuthorCol";
            AuthorCol.ReadOnly = true;
            AuthorCol.Width = 125;
            // 
            // TotalCopiesCol
            // 
            TotalCopiesCol.HeaderText = "Total Copies";
            TotalCopiesCol.MinimumWidth = 6;
            TotalCopiesCol.Name = "TotalCopiesCol";
            TotalCopiesCol.ReadOnly = true;
            TotalCopiesCol.Width = 125;
            // 
            // AvaliableCopiesCol
            // 
            AvaliableCopiesCol.HeaderText = "Avaliable Copies";
            AvaliableCopiesCol.MinimumWidth = 6;
            AvaliableCopiesCol.Name = "AvaliableCopiesCol";
            AvaliableCopiesCol.ReadOnly = true;
            AvaliableCopiesCol.Width = 150;
            // 
            // StatusCol
            // 
            StatusCol.HeaderText = "Status";
            StatusCol.MinimumWidth = 6;
            StatusCol.Name = "StatusCol";
            StatusCol.ReadOnly = true;
            StatusCol.Width = 125;
            // 
            // AddCol
            // 
            AddCol.HeaderText = "Add To Cart";
            AddCol.MinimumWidth = 6;
            AddCol.Name = "AddCol";
            AddCol.Text = "";
            AddCol.Width = 125;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Comic Sans MS", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(21, 53, 72);
            label8.Location = new Point(1107, 54);
            label8.Name = "label8";
            label8.Size = new Size(239, 168);
            label8.TabIndex = 52;
            label8.Text = "📚";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Comic Sans MS", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(21, 53, 72);
            label2.Location = new Point(1107, 209);
            label2.Name = "label2";
            label2.Size = new Size(239, 168);
            label2.TabIndex = 53;
            label2.Text = "\U0001f6d2";
            // 
            // DGVCart
            // 
            DGVCart.AllowUserToAddRows = false;
            DGVCart.BackgroundColor = SystemColors.Menu;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(21, 53, 72);
            dataGridViewCellStyle10.Font = new Font("Comic Sans MS", 8F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            DGVCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            DGVCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCart.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, CancelCol });
            DGVCart.EnableHeadersVisualStyles = false;
            DGVCart.Location = new Point(1046, 391);
            DGVCart.Name = "DGVCart";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle11.Font = new Font("Comic Sans MS", 8F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(21, 53, 72);
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            DGVCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            DGVCart.RowHeadersVisible = false;
            DGVCart.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Comic Sans MS", 8F, FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(21, 53, 72);
            DGVCart.RowsDefaultCellStyle = dataGridViewCellStyle12;
            DGVCart.ScrollBars = ScrollBars.None;
            DGVCart.Size = new Size(318, 113);
            DGVCart.TabIndex = 54;
            DGVCart.CellContentClick += DGVCart_CellContentClick;
            DGVCart.CellMouseEnter += DGVCart_CellMouseEnter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Frozen = true;
            dataGridViewTextBoxColumn2.HeaderText = "Book Title";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 190;
            // 
            // CancelCol
            // 
            CancelCol.HeaderText = "Remove";
            CancelCol.MinimumWidth = 6;
            CancelCol.Name = "CancelCol";
            CancelCol.Width = 65;
            // 
            // BorwoingBtn
            // 
            BorwoingBtn.BackColor = Color.FromArgb(21, 53, 72);
            BorwoingBtn.Cursor = Cursors.Hand;
            BorwoingBtn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            BorwoingBtn.ForeColor = Color.White;
            BorwoingBtn.Location = new Point(1137, 627);
            BorwoingBtn.Name = "BorwoingBtn";
            BorwoingBtn.Size = new Size(151, 47);
            BorwoingBtn.TabIndex = 55;
            BorwoingBtn.Text = "Borrow";
            BorwoingBtn.UseVisualStyleBackColor = false;
            BorwoingBtn.Click += BorwoingBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(21, 53, 72);
            label3.Location = new Point(1045, 540);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 56;
            label3.Text = "Borrow Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(21, 53, 72);
            label4.Location = new Point(1045, 571);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 57;
            label4.Text = "Due Date";
            // 
            // TxtBowDate
            // 
            TxtBowDate.AutoSize = true;
            TxtBowDate.BackColor = Color.White;
            TxtBowDate.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBowDate.ForeColor = Color.FromArgb(21, 53, 72);
            TxtBowDate.Location = new Point(1167, 540);
            TxtBowDate.Name = "TxtBowDate";
            TxtBowDate.Size = new Size(115, 25);
            TxtBowDate.TabIndex = 58;
            TxtBowDate.Text = "Borrow Date";
            // 
            // TxtDueDate
            // 
            TxtDueDate.AutoSize = true;
            TxtDueDate.BackColor = Color.White;
            TxtDueDate.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtDueDate.ForeColor = Color.FromArgb(21, 53, 72);
            TxtDueDate.Location = new Point(1167, 571);
            TxtDueDate.Name = "TxtDueDate";
            TxtDueDate.Size = new Size(89, 25);
            TxtDueDate.TabIndex = 59;
            TxtDueDate.Text = "Due Date";
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1399, 715);
            ControlBox = false;
            Controls.Add(TxtDueDate);
            Controls.Add(TxtBowDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BorwoingBtn);
            Controls.Add(DGVCart);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(DGVSearchResult);
            Controls.Add(SearchBtn);
            Controls.Add(TxtISBN);
            Controls.Add(TxtTitile);
            Controls.Add(TxtAuthor);
            Controls.Add(TxtCategory);
            Controls.Add(panel1);
            Controls.Add(UserPageLab);
            Controls.Add(BackBtn);
            MinimumSize = new Size(1283, 733);
            Name = "MemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member";
            Load += MemberForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtISBN).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVSearchResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserPageLab;
        private Label BackBtn;
        private Label label1;
        private ComboBox TxtSsearchBy;
        private Panel panel1;
        private Label LabTargtSearch;
        private ComboBox TxtCategory;
        private ComboBox TxtAuthor;
        private TextBox TxtTitile;
        private NumericUpDown TxtISBN;
        private Button SearchBtn;
        private DataGridView DGVSearchResult;
        private Label label8;
        private Label label2;
        private DataGridView DGVCart;
        private Button BorwoingBtn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn CancelCol;
        private Label label3;
        private Label label4;
        private Label TxtBowDate;
        private Label TxtDueDate;
        private DataGridViewTextBoxColumn ISBNCol;
        private DataGridViewTextBoxColumn TitleCol;
        private DataGridViewTextBoxColumn CategoryCol;
        private DataGridViewTextBoxColumn AuthorCol;
        private DataGridViewTextBoxColumn TotalCopiesCol;
        private DataGridViewTextBoxColumn AvaliableCopiesCol;
        private DataGridViewTextBoxColumn StatusCol;
        private DataGridViewButtonColumn AddCol;
    }
}
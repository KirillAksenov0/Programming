namespace Solution
{
    partial class Form1
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
            BooksListBox = new ListBox();
            BookGroupBox = new GroupBox();
            GenreComboBox = new ComboBox();
            GenreLabel = new Label();
            PageCountTextBox = new TextBox();
            PageCountLabel = new Label();
            AuthorTextBox = new TextBox();
            AuthorLabel = new Label();
            YearOfReleaseTextBox = new TextBox();
            YearOfReleaseLabel = new Label();
            BookTitleTextBox = new TextBox();
            BookTitleLabel = new Label();
            AddPictureBox = new PictureBox();
            DelPictureBox = new PictureBox();
            EditPictureBox = new PictureBox();
            BookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditPictureBox).BeginInit();
            SuspendLayout();
            // 
            // BooksListBox
            // 
            BooksListBox.FormattingEnabled = true;
            BooksListBox.ItemHeight = 20;
            BooksListBox.Location = new Point(12, 12);
            BooksListBox.Name = "BooksListBox";
            BooksListBox.Size = new Size(380, 344);
            BooksListBox.TabIndex = 0;
            BooksListBox.SelectedIndexChanged += BooksListBox_SelectedIndexChanged;
            // 
            // BookGroupBox
            // 
            BookGroupBox.Controls.Add(GenreComboBox);
            BookGroupBox.Controls.Add(GenreLabel);
            BookGroupBox.Controls.Add(PageCountTextBox);
            BookGroupBox.Controls.Add(PageCountLabel);
            BookGroupBox.Controls.Add(AuthorTextBox);
            BookGroupBox.Controls.Add(AuthorLabel);
            BookGroupBox.Controls.Add(YearOfReleaseTextBox);
            BookGroupBox.Controls.Add(YearOfReleaseLabel);
            BookGroupBox.Controls.Add(BookTitleTextBox);
            BookGroupBox.Controls.Add(BookTitleLabel);
            BookGroupBox.Location = new Point(412, 12);
            BookGroupBox.Name = "BookGroupBox";
            BookGroupBox.Size = new Size(366, 231);
            BookGroupBox.TabIndex = 3;
            BookGroupBox.TabStop = false;
            BookGroupBox.Text = "Selected Book";
            // 
            // GenreComboBox
            // 
            GenreComboBox.DropDownHeight = 80;
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.IntegralHeight = false;
            GenreComboBox.Location = new Point(125, 169);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(221, 28);
            GenreComboBox.TabIndex = 12;
            GenreComboBox.TextChanged += GenreComboBox_TextChanged;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(68, 169);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 11;
            GenreLabel.Text = "Genre:";
            // 
            // PageCountTextBox
            // 
            PageCountTextBox.Location = new Point(125, 133);
            PageCountTextBox.Name = "PageCountTextBox";
            PageCountTextBox.Size = new Size(221, 27);
            PageCountTextBox.TabIndex = 10;
            PageCountTextBox.TextChanged += PageCountTextBox_TextChanged;
            // 
            // PageCountLabel
            // 
            PageCountLabel.AutoSize = true;
            PageCountLabel.Location = new Point(32, 136);
            PageCountLabel.Name = "PageCountLabel";
            PageCountLabel.Size = new Size(87, 20);
            PageCountLabel.TabIndex = 9;
            PageCountLabel.Text = "Page Count:";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(125, 100);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(221, 27);
            AuthorTextBox.TabIndex = 8;
            AuthorTextBox.TextChanged += AuthorTextBox_TextChanged;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(62, 103);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(57, 20);
            AuthorLabel.TabIndex = 7;
            AuthorLabel.Text = "Author:";
            // 
            // YearOfReleaseTextBox
            // 
            YearOfReleaseTextBox.Location = new Point(125, 67);
            YearOfReleaseTextBox.Name = "YearOfReleaseTextBox";
            YearOfReleaseTextBox.Size = new Size(221, 27);
            YearOfReleaseTextBox.TabIndex = 6;
            YearOfReleaseTextBox.TextChanged += YearOfReleaseTextBox_TextChanged;
            // 
            // YearOfReleaseLabel
            // 
            YearOfReleaseLabel.AutoSize = true;
            YearOfReleaseLabel.Location = new Point(6, 70);
            YearOfReleaseLabel.Name = "YearOfReleaseLabel";
            YearOfReleaseLabel.Size = new Size(113, 20);
            YearOfReleaseLabel.TabIndex = 5;
            YearOfReleaseLabel.Text = "Year of Release:";
            // 
            // BookTitleTextBox
            // 
            BookTitleTextBox.Location = new Point(125, 34);
            BookTitleTextBox.Name = "BookTitleTextBox";
            BookTitleTextBox.Size = new Size(221, 27);
            BookTitleTextBox.TabIndex = 4;
            BookTitleTextBox.TextChanged += BookTitleTextBox_TextChanged;
            // 
            // BookTitleLabel
            // 
            BookTitleLabel.AutoSize = true;
            BookTitleLabel.Location = new Point(40, 37);
            BookTitleLabel.Name = "BookTitleLabel";
            BookTitleLabel.Size = new Size(79, 20);
            BookTitleLabel.TabIndex = 3;
            BookTitleLabel.Text = "Book Title:";
            // 
            // AddPictureBox
            // 
            AddPictureBox.Cursor = Cursors.Hand;
            AddPictureBox.Image = Properties.Resources.add_document1;
            AddPictureBox.Location = new Point(94, 377);
            AddPictureBox.Name = "AddPictureBox";
            AddPictureBox.Size = new Size(43, 45);
            AddPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AddPictureBox.TabIndex = 7;
            AddPictureBox.TabStop = false;
            AddPictureBox.Click += AddPictureBox_Click;
            // 
            // DelPictureBox
            // 
            DelPictureBox.Cursor = Cursors.Hand;
            DelPictureBox.Image = Properties.Resources.delete_document1;
            DelPictureBox.Location = new Point(179, 377);
            DelPictureBox.Name = "DelPictureBox";
            DelPictureBox.Size = new Size(43, 45);
            DelPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            DelPictureBox.TabIndex = 8;
            DelPictureBox.TabStop = false;
            DelPictureBox.Click += DelPictureBox_Click;
            // 
            // EditPictureBox
            // 
            EditPictureBox.Cursor = Cursors.Hand;
            EditPictureBox.Image = Properties.Resources.edit;
            EditPictureBox.Location = new Point(262, 377);
            EditPictureBox.Name = "EditPictureBox";
            EditPictureBox.Size = new Size(43, 45);
            EditPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            EditPictureBox.TabIndex = 9;
            EditPictureBox.TabStop = false;
            EditPictureBox.Click += EditPictureBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditPictureBox);
            Controls.Add(DelPictureBox);
            Controls.Add(AddPictureBox);
            Controls.Add(BooksListBox);
            Controls.Add(BookGroupBox);
            Name = "Form1";
            Text = "Form1";
            BookGroupBox.ResumeLayout(false);
            BookGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox BooksListBox;
        private GroupBox BookGroupBox;
        private TextBox BookTitleTextBox;
        private Label BookTitleLabel;
        private TextBox YearOfReleaseTextBox;
        private Label YearOfReleaseLabel;
        private TextBox PageCountTextBox;
        private Label PageCountLabel;
        private TextBox AuthorTextBox;
        private Label AuthorLabel;
        private ComboBox GenreComboBox;
        private Label GenreLabel;
        private PictureBox AddPictureBox;
        private PictureBox DelPictureBox;
        private PictureBox EditPictureBox;
    }
}
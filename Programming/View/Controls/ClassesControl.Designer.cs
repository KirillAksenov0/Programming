namespace Programming.View.Controls
{
    partial class ClassesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MoviesGroupBox = new GroupBox();
            FindMoviesButton = new Button();
            DurationTextBox = new TextBox();
            RatingTextBox = new TextBox();
            YearTextBox = new TextBox();
            GenreTextBox = new TextBox();
            DurationLabel = new Label();
            RatingLabel = new Label();
            YearLabel = new Label();
            GenreLabel = new Label();
            MoviesListBox = new ListBox();
            RectangleGroupBox = new GroupBox();
            IDLabel = new Label();
            IDTextBox = new TextBox();
            YLabel = new Label();
            XLabel = new Label();
            YTextBox = new TextBox();
            XTextBox = new TextBox();
            FindButton = new Button();
            ColorTextBox = new TextBox();
            WidthTextBox = new TextBox();
            LenghtTextBox = new TextBox();
            WidthLabel = new Label();
            ColorLabel = new Label();
            LenghtLabel = new Label();
            RectanglesListBox = new ListBox();
            MoviesGroupBox.SuspendLayout();
            RectangleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MoviesGroupBox
            // 
            MoviesGroupBox.Controls.Add(FindMoviesButton);
            MoviesGroupBox.Controls.Add(DurationTextBox);
            MoviesGroupBox.Controls.Add(RatingTextBox);
            MoviesGroupBox.Controls.Add(YearTextBox);
            MoviesGroupBox.Controls.Add(GenreTextBox);
            MoviesGroupBox.Controls.Add(DurationLabel);
            MoviesGroupBox.Controls.Add(RatingLabel);
            MoviesGroupBox.Controls.Add(YearLabel);
            MoviesGroupBox.Controls.Add(GenreLabel);
            MoviesGroupBox.Controls.Add(MoviesListBox);
            MoviesGroupBox.Location = new Point(357, 13);
            MoviesGroupBox.Name = "MoviesGroupBox";
            MoviesGroupBox.Size = new Size(354, 353);
            MoviesGroupBox.TabIndex = 3;
            MoviesGroupBox.TabStop = false;
            MoviesGroupBox.Text = "Movies";
            // 
            // FindMoviesButton
            // 
            FindMoviesButton.Location = new Point(225, 268);
            FindMoviesButton.Name = "FindMoviesButton";
            FindMoviesButton.Size = new Size(94, 29);
            FindMoviesButton.TabIndex = 9;
            FindMoviesButton.Text = "Find";
            FindMoviesButton.UseVisualStyleBackColor = true;
            FindMoviesButton.Click += FindMoviesButton_Click;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(208, 229);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.ReadOnly = true;
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 8;
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(208, 165);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 7;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(208, 97);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.ReadOnly = true;
            YearTextBox.Size = new Size(125, 27);
            YearTextBox.TabIndex = 6;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(208, 33);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.ReadOnly = true;
            GenreTextBox.Size = new Size(125, 27);
            GenreTextBox.TabIndex = 5;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(208, 206);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(70, 20);
            DurationLabel.TabIndex = 4;
            DurationLabel.Text = "Duration:";
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(208, 142);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(55, 20);
            RatingLabel.TabIndex = 3;
            RatingLabel.Text = "Rating:";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(208, 74);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(40, 20);
            YearLabel.TabIndex = 2;
            YearLabel.Text = "Year:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(208, 10);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 1;
            GenreLabel.Text = "Genre:";
            // 
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.ItemHeight = 20;
            MoviesListBox.Location = new Point(6, 26);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(196, 284);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // RectangleGroupBox
            // 
            RectangleGroupBox.Controls.Add(IDLabel);
            RectangleGroupBox.Controls.Add(IDTextBox);
            RectangleGroupBox.Controls.Add(YLabel);
            RectangleGroupBox.Controls.Add(XLabel);
            RectangleGroupBox.Controls.Add(YTextBox);
            RectangleGroupBox.Controls.Add(XTextBox);
            RectangleGroupBox.Controls.Add(FindButton);
            RectangleGroupBox.Controls.Add(ColorTextBox);
            RectangleGroupBox.Controls.Add(WidthTextBox);
            RectangleGroupBox.Controls.Add(LenghtTextBox);
            RectangleGroupBox.Controls.Add(WidthLabel);
            RectangleGroupBox.Controls.Add(ColorLabel);
            RectangleGroupBox.Controls.Add(LenghtLabel);
            RectangleGroupBox.Controls.Add(RectanglesListBox);
            RectangleGroupBox.Location = new Point(3, 13);
            RectangleGroupBox.Name = "RectangleGroupBox";
            RectangleGroupBox.Size = new Size(348, 353);
            RectangleGroupBox.TabIndex = 2;
            RectangleGroupBox.TabStop = false;
            RectangleGroupBox.Text = "Rectangles";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(208, 206);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 20);
            IDLabel.TabIndex = 13;
            IDLabel.Text = "ID:";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(208, 229);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(125, 27);
            IDTextBox.TabIndex = 12;
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            YLabel.Location = new Point(271, 268);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(18, 17);
            YLabel.TabIndex = 11;
            YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            XLabel.Location = new Point(208, 265);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(19, 17);
            XLabel.TabIndex = 10;
            XLabel.Text = "X:";
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(271, 285);
            YTextBox.Name = "YTextBox";
            YTextBox.ReadOnly = true;
            YTextBox.Size = new Size(57, 27);
            YTextBox.TabIndex = 9;
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(208, 285);
            XTextBox.Name = "XTextBox";
            XTextBox.ReadOnly = true;
            XTextBox.Size = new Size(57, 27);
            XTextBox.TabIndex = 8;
            // 
            // FindButton
            // 
            FindButton.Location = new Point(221, 318);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(94, 29);
            FindButton.TabIndex = 7;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(208, 165);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 6;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(208, 97);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 5;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LenghtTextBox
            // 
            LenghtTextBox.Location = new Point(208, 33);
            LenghtTextBox.Name = "LenghtTextBox";
            LenghtTextBox.Size = new Size(125, 27);
            LenghtTextBox.TabIndex = 4;
            LenghtTextBox.TextChanged += LenghtTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(208, 74);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(52, 20);
            WidthLabel.TabIndex = 3;
            WidthLabel.Text = "Width:";
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(208, 142);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(48, 20);
            ColorLabel.TabIndex = 2;
            ColorLabel.Text = "Color:";
            // 
            // LenghtLabel
            // 
            LenghtLabel.AutoSize = true;
            LenghtLabel.Location = new Point(208, 10);
            LenghtLabel.Name = "LenghtLabel";
            LenghtLabel.Size = new Size(57, 20);
            LenghtLabel.TabIndex = 1;
            LenghtLabel.Text = "Lenght:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 20;
            RectanglesListBox.Items.AddRange(new object[] { "Rectangle1", "Rectangle2", "Rectangle3", "Rectangle4", "Rectangle5" });
            RectanglesListBox.Location = new Point(6, 26);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(196, 284);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // ClassesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MoviesGroupBox);
            Controls.Add(RectangleGroupBox);
            Name = "ClassesControl";
            Size = new Size(716, 379);
            MoviesGroupBox.ResumeLayout(false);
            MoviesGroupBox.PerformLayout();
            RectangleGroupBox.ResumeLayout(false);
            RectangleGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MoviesGroupBox;
        private Button FindMoviesButton;
        private TextBox DurationTextBox;
        private TextBox RatingTextBox;
        private TextBox YearTextBox;
        private TextBox GenreTextBox;
        private Label DurationLabel;
        private Label RatingLabel;
        private Label YearLabel;
        private Label GenreLabel;
        private ListBox MoviesListBox;
        private GroupBox RectangleGroupBox;
        private Label IDLabel;
        private TextBox IDTextBox;
        private Label YLabel;
        private Label XLabel;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private Button FindButton;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LenghtTextBox;
        private Label WidthLabel;
        private Label ColorLabel;
        private Label LenghtLabel;
        private ListBox RectanglesListBox;
    }
}

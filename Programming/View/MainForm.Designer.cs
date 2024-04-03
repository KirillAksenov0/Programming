namespace Programming
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            SeasonGroupBox = new GroupBox();
            SeasonLabel = new Label();
            GoButton = new Button();
            ChooseSeasonLabel = new Label();
            SeasonComboBox = new ComboBox();
            parsingGroupBox = new GroupBox();
            ValueEquivalentLabel = new Label();
            parseButton = new Button();
            ParsingTextBox = new TextBox();
            ParsingLabel = new Label();
            EnumsGroupBox = new GroupBox();
            ValueLabel = new Label();
            ValuesTextBox = new TextBox();
            ValuesLabel = new Label();
            EnumLabel = new Label();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabPage2 = new TabPage();
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
            tabPage3 = new TabPage();
            MinusPictureBox = new PictureBox();
            PlusPictureBox = new PictureBox();
            RectanglesLabel2 = new Label();
            panel1 = new Panel();
            WidthTextBox2 = new TextBox();
            HeightTextBox2 = new TextBox();
            YTextBox2 = new TextBox();
            XTextBox2 = new TextBox();
            IDTextBox2 = new TextBox();
            HeightLabel = new Label();
            WidthLabel2 = new Label();
            IDLabel2 = new Label();
            YLabel2 = new Label();
            XLabel2 = new Label();
            SelectedRectangleLabel = new Label();
            RectanglesListBox2 = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            parsingGroupBox.SuspendLayout();
            EnumsGroupBox.SuspendLayout();
            tabPage2.SuspendLayout();
            MoviesGroupBox.SuspendLayout();
            RectangleGroupBox.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinusPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlusPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(725, 395);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SeasonGroupBox);
            tabPage1.Controls.Add(parsingGroupBox);
            tabPage1.Controls.Add(EnumsGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(717, 362);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(SeasonLabel);
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(ChooseSeasonLabel);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Location = new Point(362, 216);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(347, 138);
            SeasonGroupBox.TabIndex = 2;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season handle";
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(6, 96);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(0, 20);
            SeasonLabel.TabIndex = 6;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(247, 57);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 29);
            GoButton.TabIndex = 5;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // ChooseSeasonLabel
            // 
            ChooseSeasonLabel.AutoSize = true;
            ChooseSeasonLabel.Location = new Point(6, 34);
            ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            ChooseSeasonLabel.Size = new Size(107, 20);
            ChooseSeasonLabel.TabIndex = 4;
            ChooseSeasonLabel.Text = "Choose season";
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(6, 58);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(228, 28);
            SeasonComboBox.TabIndex = 0;
            // 
            // parsingGroupBox
            // 
            parsingGroupBox.Controls.Add(ValueEquivalentLabel);
            parsingGroupBox.Controls.Add(parseButton);
            parsingGroupBox.Controls.Add(ParsingTextBox);
            parsingGroupBox.Controls.Add(ParsingLabel);
            parsingGroupBox.Location = new Point(3, 216);
            parsingGroupBox.Name = "parsingGroupBox";
            parsingGroupBox.Size = new Size(353, 138);
            parsingGroupBox.TabIndex = 1;
            parsingGroupBox.TabStop = false;
            parsingGroupBox.Text = "Weekday/Parsing";
            // 
            // ValueEquivalentLabel
            // 
            ValueEquivalentLabel.AutoSize = true;
            ValueEquivalentLabel.Location = new Point(6, 96);
            ValueEquivalentLabel.Name = "ValueEquivalentLabel";
            ValueEquivalentLabel.Size = new Size(0, 20);
            ValueEquivalentLabel.TabIndex = 3;
            // 
            // parseButton
            // 
            parseButton.Location = new Point(253, 57);
            parseButton.Name = "parseButton";
            parseButton.Size = new Size(94, 29);
            parseButton.TabIndex = 2;
            parseButton.Text = "Parse";
            parseButton.UseVisualStyleBackColor = true;
            parseButton.Click += parseButton_Click;
            // 
            // ParsingTextBox
            // 
            ParsingTextBox.Location = new Point(6, 57);
            ParsingTextBox.Name = "ParsingTextBox";
            ParsingTextBox.Size = new Size(236, 27);
            ParsingTextBox.TabIndex = 1;
            // 
            // ParsingLabel
            // 
            ParsingLabel.AutoSize = true;
            ParsingLabel.Location = new Point(6, 34);
            ParsingLabel.Name = "ParsingLabel";
            ParsingLabel.Size = new Size(155, 20);
            ParsingLabel.TabIndex = 0;
            ParsingLabel.Text = "Type value for parsing";
            // 
            // EnumsGroupBox
            // 
            EnumsGroupBox.Controls.Add(ValueLabel);
            EnumsGroupBox.Controls.Add(ValuesTextBox);
            EnumsGroupBox.Controls.Add(ValuesLabel);
            EnumsGroupBox.Controls.Add(EnumLabel);
            EnumsGroupBox.Controls.Add(ValuesListBox);
            EnumsGroupBox.Controls.Add(EnumsListBox);
            EnumsGroupBox.Location = new Point(3, 3);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(706, 207);
            EnumsGroupBox.TabIndex = 0;
            EnumsGroupBox.TabStop = false;
            EnumsGroupBox.Text = "Enumerations";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(421, 51);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(68, 20);
            ValueLabel.TabIndex = 5;
            ValueLabel.Text = "Int value:";
            // 
            // ValuesTextBox
            // 
            ValuesTextBox.Location = new Point(421, 74);
            ValuesTextBox.Name = "ValuesTextBox";
            ValuesTextBox.Size = new Size(125, 27);
            ValuesTextBox.TabIndex = 4;
            // 
            // ValuesLabel
            // 
            ValuesLabel.AutoSize = true;
            ValuesLabel.Location = new Point(225, 32);
            ValuesLabel.Name = "ValuesLabel";
            ValuesLabel.Size = new Size(97, 20);
            ValuesLabel.TabIndex = 3;
            ValuesLabel.Text = "Choose value";
            // 
            // EnumLabel
            // 
            EnumLabel.AutoSize = true;
            EnumLabel.Location = new Point(31, 32);
            EnumLabel.Name = "EnumLabel";
            EnumLabel.Size = new Size(142, 20);
            EnumLabel.TabIndex = 2;
            EnumLabel.Text = "Choose enumiration";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 20;
            ValuesListBox.Location = new Point(225, 55);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(150, 104);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Location = new Point(31, 55);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(150, 104);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(MoviesGroupBox);
            tabPage2.Controls.Add(RectangleGroupBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(717, 362);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            tabPage2.UseVisualStyleBackColor = true;
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
            MoviesGroupBox.Location = new Point(357, 6);
            MoviesGroupBox.Name = "MoviesGroupBox";
            MoviesGroupBox.Size = new Size(354, 353);
            MoviesGroupBox.TabIndex = 1;
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
            RectangleGroupBox.Location = new Point(3, 6);
            RectangleGroupBox.Name = "RectangleGroupBox";
            RectangleGroupBox.Size = new Size(348, 353);
            RectangleGroupBox.TabIndex = 0;
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
            // tabPage3
            // 
            tabPage3.Controls.Add(MinusPictureBox);
            tabPage3.Controls.Add(PlusPictureBox);
            tabPage3.Controls.Add(RectanglesLabel2);
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(WidthTextBox2);
            tabPage3.Controls.Add(HeightTextBox2);
            tabPage3.Controls.Add(YTextBox2);
            tabPage3.Controls.Add(XTextBox2);
            tabPage3.Controls.Add(IDTextBox2);
            tabPage3.Controls.Add(HeightLabel);
            tabPage3.Controls.Add(WidthLabel2);
            tabPage3.Controls.Add(IDLabel2);
            tabPage3.Controls.Add(YLabel2);
            tabPage3.Controls.Add(XLabel2);
            tabPage3.Controls.Add(SelectedRectangleLabel);
            tabPage3.Controls.Add(RectanglesListBox2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(717, 362);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rectangles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MinusPictureBox
            // 
            MinusPictureBox.Cursor = Cursors.Hand;
            MinusPictureBox.Image = Properties.Resources.delete_rectangle_button;
            MinusPictureBox.Location = new Point(157, 130);
            MinusPictureBox.Name = "MinusPictureBox";
            MinusPictureBox.Size = new Size(56, 29);
            MinusPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            MinusPictureBox.TabIndex = 24;
            MinusPictureBox.TabStop = false;
            MinusPictureBox.Click += MinusPictureBox_Click;
            // 
            // PlusPictureBox
            // 
            PlusPictureBox.Cursor = Cursors.Hand;
            PlusPictureBox.Image = Properties.Resources.add_rectandle_button;
            PlusPictureBox.Location = new Point(63, 130);
            PlusPictureBox.Name = "PlusPictureBox";
            PlusPictureBox.Size = new Size(53, 29);
            PlusPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PlusPictureBox.TabIndex = 23;
            PlusPictureBox.TabStop = false;
            PlusPictureBox.Click += PlusPictureBox_Click;
            PlusPictureBox.Paint += PlusPictureBox_Paint;
            // 
            // RectanglesLabel2
            // 
            RectanglesLabel2.AutoSize = true;
            RectanglesLabel2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            RectanglesLabel2.Location = new Point(8, 0);
            RectanglesLabel2.Name = "RectanglesLabel2";
            RectanglesLabel2.Size = new Size(74, 17);
            RectanglesLabel2.TabIndex = 22;
            RectanglesLabel2.Text = "Rectangles:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(282, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 333);
            panel1.TabIndex = 21;
            // 
            // WidthTextBox2
            // 
            WidthTextBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            WidthTextBox2.Location = new Point(73, 292);
            WidthTextBox2.Name = "WidthTextBox2";
            WidthTextBox2.Size = new Size(125, 25);
            WidthTextBox2.TabIndex = 20;
            WidthTextBox2.TextChanged += WidthTextBox2_TextChanged;
            // 
            // HeightTextBox2
            // 
            HeightTextBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            HeightTextBox2.Location = new Point(73, 323);
            HeightTextBox2.Name = "HeightTextBox2";
            HeightTextBox2.Size = new Size(125, 25);
            HeightTextBox2.TabIndex = 19;
            HeightTextBox2.TextChanged += HeightTextBox2_TextChanged;
            // 
            // YTextBox2
            // 
            YTextBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            YTextBox2.Location = new Point(73, 261);
            YTextBox2.Name = "YTextBox2";
            YTextBox2.ReadOnly = true;
            YTextBox2.Size = new Size(125, 25);
            YTextBox2.TabIndex = 18;
            // 
            // XTextBox2
            // 
            XTextBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            XTextBox2.Location = new Point(74, 229);
            XTextBox2.Name = "XTextBox2";
            XTextBox2.ReadOnly = true;
            XTextBox2.Size = new Size(125, 25);
            XTextBox2.TabIndex = 17;
            // 
            // IDTextBox2
            // 
            IDTextBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            IDTextBox2.Location = new Point(74, 198);
            IDTextBox2.Name = "IDTextBox2";
            IDTextBox2.ReadOnly = true;
            IDTextBox2.Size = new Size(125, 25);
            IDTextBox2.TabIndex = 16;
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(11, 322);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(57, 20);
            HeightLabel.TabIndex = 15;
            HeightLabel.Text = "Height:";
            // 
            // WidthLabel2
            // 
            WidthLabel2.AutoSize = true;
            WidthLabel2.Location = new Point(16, 292);
            WidthLabel2.Name = "WidthLabel2";
            WidthLabel2.Size = new Size(52, 20);
            WidthLabel2.TabIndex = 14;
            WidthLabel2.Text = "Width:";
            // 
            // IDLabel2
            // 
            IDLabel2.AutoSize = true;
            IDLabel2.Location = new Point(47, 203);
            IDLabel2.Name = "IDLabel2";
            IDLabel2.Size = new Size(25, 20);
            IDLabel2.TabIndex = 13;
            IDLabel2.Text = "Id:";
            // 
            // YLabel2
            // 
            YLabel2.AutoSize = true;
            YLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            YLabel2.Location = new Point(47, 261);
            YLabel2.Name = "YLabel2";
            YLabel2.Size = new Size(20, 20);
            YLabel2.TabIndex = 12;
            YLabel2.Text = "Y:";
            // 
            // XLabel2
            // 
            XLabel2.AutoSize = true;
            XLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            XLabel2.Location = new Point(47, 232);
            XLabel2.Name = "XLabel2";
            XLabel2.Size = new Size(21, 20);
            XLabel2.TabIndex = 11;
            XLabel2.Text = "X:";
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(15, 171);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(139, 20);
            SelectedRectangleLabel.TabIndex = 3;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox2
            // 
            RectanglesListBox2.FormattingEnabled = true;
            RectanglesListBox2.ItemHeight = 20;
            RectanglesListBox2.Location = new Point(8, 20);
            RectanglesListBox2.Name = "RectanglesListBox2";
            RectanglesListBox2.Size = new Size(268, 104);
            RectanglesListBox2.TabIndex = 0;
            RectanglesListBox2.SelectedIndexChanged += RectanglesListBox2_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(725, 395);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            parsingGroupBox.ResumeLayout(false);
            parsingGroupBox.PerformLayout();
            EnumsGroupBox.ResumeLayout(false);
            EnumsGroupBox.PerformLayout();
            tabPage2.ResumeLayout(false);
            MoviesGroupBox.ResumeLayout(false);
            MoviesGroupBox.PerformLayout();
            RectangleGroupBox.ResumeLayout(false);
            RectangleGroupBox.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinusPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlusPictureBox).EndInit();
            ResumeLayout(false);
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox EnumsGroupBox;
        private ListBox EnumsListBox;
        private Label ValuesLabel;
        private Label EnumLabel;
        private ListBox ValuesListBox;
        private Label ValueLabel;
        private TextBox ValuesTextBox;
        private GroupBox parsingGroupBox;
        private Label ParsingLabel;
        private TextBox ParsingTextBox;
        private Label ValueEquivalentLabel;
        private Button parseButton;
        private GroupBox SeasonGroupBox;
        private ComboBox SeasonComboBox;
        private Label ChooseSeasonLabel;
        private Button GoButton;
        private Label SeasonLabel;
        private TabPage tabPage2;
        private GroupBox RectangleGroupBox;
        private ListBox RectanglesListBox;
        private Label LenghtLabel;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LenghtTextBox;
        private Label WidthLabel;
        private Label ColorLabel;
        private Button FindButton;
        private GroupBox MoviesGroupBox;
        private ListBox MoviesListBox;
        private Label GenreLabel;
        private Label YearLabel;
        private Label RatingLabel;
        private Label DurationLabel;
        private TextBox GenreTextBox;
        private TextBox DurationTextBox;
        private TextBox RatingTextBox;
        private TextBox YearTextBox;
        private Button FindMoviesButton;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private Label XLabel;
        private Label YLabel;
        private Label IDLabel;
        private TextBox IDTextBox;
        private TabPage tabPage3;
        private ListBox RectanglesListBox2;
        private Label SelectedRectangleLabel;
        private Label WidthLabel2;
        private Label IDLabel2;
        private Label YLabel2;
        private Label XLabel2;
        private TextBox YTextBox2;
        private TextBox XTextBox2;
        private TextBox IDTextBox2;
        private Label HeightLabel;
        private TextBox WidthTextBox2;
        private TextBox HeightTextBox2;
        private Label RectanglesLabel2;
        private Panel panel1;
        private PictureBox PlusPictureBox;
        private PictureBox MinusPictureBox;
    }
}
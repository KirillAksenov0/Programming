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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            parsingGroupBox.SuspendLayout();
            EnumsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(721, 395);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SeasonGroupBox);
            tabPage1.Controls.Add(parsingGroupBox);
            tabPage1.Controls.Add(EnumsGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(713, 362);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(721, 395);
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
            ResumeLayout(false);
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
    }
}
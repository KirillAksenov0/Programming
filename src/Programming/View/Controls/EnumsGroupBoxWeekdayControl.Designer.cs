namespace Programming.View.Controls
{
    partial class EnumsGroupBoxWeekdayControl
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
            parsingGroupBox = new GroupBox();
            ValueEquivalentLabel = new Label();
            parseButton = new Button();
            ParsingTextBox = new TextBox();
            ParsingLabel = new Label();
            parsingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // parsingGroupBox
            // 
            parsingGroupBox.Controls.Add(ValueEquivalentLabel);
            parsingGroupBox.Controls.Add(parseButton);
            parsingGroupBox.Controls.Add(ParsingTextBox);
            parsingGroupBox.Controls.Add(ParsingLabel);
            parsingGroupBox.Location = new Point(0, 0);
            parsingGroupBox.Name = "parsingGroupBox";
            parsingGroupBox.Size = new Size(353, 138);
            parsingGroupBox.TabIndex = 2;
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
            // EnumsGroupBoxWeekdayControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parsingGroupBox);
            Name = "EnumsGroupBoxWeekdayControl";
            Size = new Size(361, 154);
            parsingGroupBox.ResumeLayout(false);
            parsingGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox parsingGroupBox;
        private Label ValueEquivalentLabel;
        private Button parseButton;
        private TextBox ParsingTextBox;
        private Label ParsingLabel;
    }
}

namespace Programming.View.Controls
{
    partial class EnumsGroupBoxEnumerations
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
            EnumsGroupBox = new GroupBox();
            ValueLabel = new Label();
            ValuesTextBox = new TextBox();
            ValuesLabel = new Label();
            EnumLabel = new Label();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            EnumsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsGroupBox
            // 
            EnumsGroupBox.Controls.Add(ValueLabel);
            EnumsGroupBox.Controls.Add(ValuesTextBox);
            EnumsGroupBox.Controls.Add(ValuesLabel);
            EnumsGroupBox.Controls.Add(EnumLabel);
            EnumsGroupBox.Controls.Add(ValuesListBox);
            EnumsGroupBox.Controls.Add(EnumsListBox);
            EnumsGroupBox.Location = new Point(0, 0);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(706, 207);
            EnumsGroupBox.TabIndex = 1;
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
            // EnumsGroupBoxEnumerations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumsGroupBox);
            Name = "EnumsGroupBoxEnumerations";
            Size = new Size(710, 213);
            EnumsGroupBox.ResumeLayout(false);
            EnumsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumsGroupBox;
        private Label ValueLabel;
        private TextBox ValuesTextBox;
        private Label ValuesLabel;
        private Label EnumLabel;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
    }
}

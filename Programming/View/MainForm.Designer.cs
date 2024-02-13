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
            groupBox1 = new GroupBox();
            ValueLabel = new Label();
            ValuesTextBox = new TextBox();
            ValuesLabel = new Label();
            EnumLabel = new Label();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(720, 395);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(712, 362);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ValueLabel);
            groupBox1.Controls.Add(ValuesTextBox);
            groupBox1.Controls.Add(ValuesLabel);
            groupBox1.Controls.Add(EnumLabel);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 356);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new Point(478, 41);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(68, 20);
            ValueLabel.TabIndex = 5;
            ValueLabel.Text = "Int value;";
            // 
            // ValuesTextBox
            // 
            ValuesTextBox.Location = new Point(474, 76);
            ValuesTextBox.Name = "ValuesTextBox";
            ValuesTextBox.Size = new Size(125, 27);
            ValuesTextBox.TabIndex = 4;
            // 
            // ValuesLabel
            // 
            ValuesLabel.AutoSize = true;
            ValuesLabel.Location = new Point(254, 48);
            ValuesLabel.Name = "ValuesLabel";
            ValuesLabel.Size = new Size(97, 20);
            ValuesLabel.TabIndex = 3;
            ValuesLabel.Text = "Choose value";
            // 
            // EnumLabel
            // 
            EnumLabel.AutoSize = true;
            EnumLabel.Location = new Point(47, 48);
            EnumLabel.Name = "EnumLabel";
            EnumLabel.Size = new Size(142, 20);
            EnumLabel.TabIndex = 2;
            EnumLabel.Text = "Choose enumiration";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 20;
            ValuesListBox.Location = new Point(254, 76);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(150, 104);
            ValuesListBox.TabIndex = 1;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Location = new Point(47, 76);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(150, 104);
            EnumsListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 395);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private ListBox EnumsListBox;
        private Label ValuesLabel;
        private Label EnumLabel;
        private ListBox ValuesListBox;
        private Label ValueLabel;
        private TextBox ValuesTextBox;
    }
}
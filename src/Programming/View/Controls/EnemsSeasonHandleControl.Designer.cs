namespace Programming.View.Controls
{
    partial class EnumsSeasonHandleControl
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
            SeasonGroupBox = new GroupBox();
            SeasonLabel = new Label();
            GoButton = new Button();
            ChooseSeasonLabel = new Label();
            SeasonComboBox = new ComboBox();
            SeasonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(SeasonLabel);
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(ChooseSeasonLabel);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Location = new Point(3, 3);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(347, 138);
            SeasonGroupBox.TabIndex = 3;
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
            // EnumsSeasonHandleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonGroupBox);
            Name = "EnumsSeasonHandleControl";
            Size = new Size(354, 150);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasonGroupBox;
        private Label SeasonLabel;
        private Button GoButton;
        private Label ChooseSeasonLabel;
        private ComboBox SeasonComboBox;
    }
}

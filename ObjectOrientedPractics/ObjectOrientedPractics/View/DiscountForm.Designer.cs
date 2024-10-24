namespace ObjectOrientedPractics.View
{
    partial class DiscountForm
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
            PercentDiscountLabel = new Label();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            OKButton = new Button();
            CanelButton = new Button();
            SuspendLayout();
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Location = new Point(43, 64);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(122, 20);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(43, 109);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(121, 109);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(202, 28);
            CategoryComboBox.TabIndex = 2;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(104, 177);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(94, 29);
            OKButton.TabIndex = 3;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CanelButton
            // 
            CanelButton.Location = new Point(204, 177);
            CanelButton.Name = "CanelButton";
            CanelButton.Size = new Size(94, 29);
            CanelButton.TabIndex = 4;
            CanelButton.Text = "Canel";
            CanelButton.UseVisualStyleBackColor = true;
            CanelButton.Click += CanelButton_Click;
            // 
            // DiscountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 243);
            Controls.Add(CanelButton);
            Controls.Add(OKButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(PercentDiscountLabel);
            Name = "DiscountForm";
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PercentDiscountLabel;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Button OKButton;
        private Button CanelButton;
    }
}
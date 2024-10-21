namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            InfoLabel = new Label();
            CalculateButton = new Button();
            ApplyButton = new Button();
            UpdateButton = new Button();
            ProductsAmountLabel = new Label();
            AmountLabel = new Label();
            DisplayDiscountAmountLabel = new Label();
            DiscountAmountLabel = new Label();
            SuspendLayout();
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(43, 171);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(38, 20);
            InfoLabel.TabIndex = 0;
            InfoLabel.Text = "Info:";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(43, 226);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(94, 29);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(153, 226);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(94, 29);
            ApplyButton.TabIndex = 2;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(265, 226);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ProductsAmountLabel
            // 
            ProductsAmountLabel.AutoSize = true;
            ProductsAmountLabel.Location = new Point(406, 171);
            ProductsAmountLabel.Name = "ProductsAmountLabel";
            ProductsAmountLabel.Size = new Size(126, 20);
            ProductsAmountLabel.TabIndex = 4;
            ProductsAmountLabel.Text = "Products Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(406, 205);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(50, 20);
            AmountLabel.TabIndex = 5;
            AmountLabel.Text = "label1";
            // 
            // DisplayDiscountAmountLabel
            // 
            DisplayDiscountAmountLabel.AutoSize = true;
            DisplayDiscountAmountLabel.Location = new Point(406, 289);
            DisplayDiscountAmountLabel.Name = "DisplayDiscountAmountLabel";
            DisplayDiscountAmountLabel.Size = new Size(50, 20);
            DisplayDiscountAmountLabel.TabIndex = 7;
            DisplayDiscountAmountLabel.Text = "label1";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Location = new Point(406, 255);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(127, 20);
            DiscountAmountLabel.TabIndex = 6;
            DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DisplayDiscountAmountLabel);
            Controls.Add(DiscountAmountLabel);
            Controls.Add(AmountLabel);
            Controls.Add(ProductsAmountLabel);
            Controls.Add(UpdateButton);
            Controls.Add(ApplyButton);
            Controls.Add(CalculateButton);
            Controls.Add(InfoLabel);
            Name = "DiscountsTab";
            Size = new Size(580, 372);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InfoLabel;
        private Button CalculateButton;
        private Button ApplyButton;
        private Button UpdateButton;
        private Label ProductsAmountLabel;
        private Label AmountLabel;
        private Label DisplayDiscountAmountLabel;
        private Label DiscountAmountLabel;
    }
}

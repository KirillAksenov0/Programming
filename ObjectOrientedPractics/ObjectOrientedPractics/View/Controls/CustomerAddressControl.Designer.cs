namespace ObjectOrientedPractics.View.Controls
{
    partial class CustomerAddressControl
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
            DeliveryAddressLabel = new Label();
            StreetLabel = new Label();
            BuildingLabel = new Label();
            CityLabel = new Label();
            ApartmentLabel = new Label();
            CountryLabel = new Label();
            PostIndexLabel = new Label();
            PostIndexTextBox = new TextBox();
            StreetTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            CityTextBox = new TextBox();
            CountryTextBox = new TextBox();
            SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Location = new Point(3, 14);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(120, 20);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(15, 141);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(51, 20);
            StreetLabel.TabIndex = 1;
            StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(15, 182);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(67, 20);
            BuildingLabel.TabIndex = 2;
            BuildingLabel.Text = "Building:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(301, 107);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 20);
            CityLabel.TabIndex = 3;
            CityLabel.Text = "City:";
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(239, 185);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(83, 20);
            ApartmentLabel.TabIndex = 4;
            ApartmentLabel.Text = "Apartment:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(15, 100);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(63, 20);
            CountryLabel.TabIndex = 5;
            CountryLabel.Text = "Country:";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(15, 60);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(79, 20);
            PostIndexLabel.TabIndex = 6;
            PostIndexLabel.Text = "Post Index:";
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(112, 60);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(125, 27);
            PostIndexTextBox.TabIndex = 7;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(112, 141);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(404, 27);
            StreetTextBox.TabIndex = 8;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(112, 182);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(93, 27);
            BuildingTextBox.TabIndex = 9;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(328, 182);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(93, 27);
            ApartmentTextBox.TabIndex = 10;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(353, 100);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(163, 27);
            CityTextBox.TabIndex = 11;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(112, 100);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(172, 27);
            CountryTextBox.TabIndex = 12;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // CustomerAddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CountryTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(ApartmentTextBox);
            Controls.Add(BuildingTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(PostIndexTextBox);
            Controls.Add(PostIndexLabel);
            Controls.Add(CountryLabel);
            Controls.Add(ApartmentLabel);
            Controls.Add(CityLabel);
            Controls.Add(BuildingLabel);
            Controls.Add(StreetLabel);
            Controls.Add(DeliveryAddressLabel);
            Name = "CustomerAddressControl";
            Size = new Size(527, 316);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeliveryAddressLabel;
        private Label StreetLabel;
        private Label BuildingLabel;
        private Label CityLabel;
        private Label ApartmentLabel;
        private Label CountryLabel;
        private Label PostIndexLabel;
        private TextBox PostIndexTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox ApartmentTextBox;
        private TextBox CityTextBox;
        private TextBox CountryTextBox;
    }
}

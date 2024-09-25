namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            AddressGroupBox = new GroupBox();
            IndexLabel = new Label();
            BuildingLabel = new Label();
            CityLabel = new Label();
            ApartmentLabel = new Label();
            StreetLabel = new Label();
            CountryLabel = new Label();
            IndexTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CityTextBox = new TextBox();
            CountryTextBox = new TextBox();
            AddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddressGroupBox
            // 
            AddressGroupBox.Controls.Add(CountryTextBox);
            AddressGroupBox.Controls.Add(CityTextBox);
            AddressGroupBox.Controls.Add(StreetTextBox);
            AddressGroupBox.Controls.Add(ApartmentTextBox);
            AddressGroupBox.Controls.Add(BuildingTextBox);
            AddressGroupBox.Controls.Add(IndexTextBox);
            AddressGroupBox.Controls.Add(CountryLabel);
            AddressGroupBox.Controls.Add(StreetLabel);
            AddressGroupBox.Controls.Add(ApartmentLabel);
            AddressGroupBox.Controls.Add(CityLabel);
            AddressGroupBox.Controls.Add(BuildingLabel);
            AddressGroupBox.Controls.Add(IndexLabel);
            AddressGroupBox.Location = new Point(0, 0);
            AddressGroupBox.Name = "AddressGroupBox";
            AddressGroupBox.Size = new Size(611, 242);
            AddressGroupBox.TabIndex = 0;
            AddressGroupBox.TabStop = false;
            AddressGroupBox.Text = "Delivery Address";
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Location = new Point(26, 46);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(79, 20);
            IndexLabel.TabIndex = 0;
            IndexLabel.Text = "Post Index:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(26, 188);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(67, 20);
            BuildingLabel.TabIndex = 1;
            BuildingLabel.Text = "Building:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(393, 97);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 20);
            CityLabel.TabIndex = 2;
            CityLabel.Text = "City:";
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(282, 195);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(83, 20);
            ApartmentLabel.TabIndex = 3;
            ApartmentLabel.Text = "Apartment:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(26, 139);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(51, 20);
            StreetLabel.TabIndex = 4;
            StreetLabel.Text = "Street:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(26, 93);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(63, 20);
            CountryLabel.TabIndex = 5;
            CountryLabel.Text = "Country:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(120, 46);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(170, 27);
            IndexTextBox.TabIndex = 6;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(120, 188);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(118, 27);
            BuildingTextBox.TabIndex = 7;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(382, 192);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(118, 27);
            ApartmentTextBox.TabIndex = 8;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(120, 139);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(486, 27);
            StreetTextBox.TabIndex = 9;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(436, 93);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(170, 27);
            CityTextBox.TabIndex = 10;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(120, 90);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(245, 27);
            CountryTextBox.TabIndex = 11;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressGroupBox);
            Name = "AddressControl";
            Size = new Size(613, 240);
            AddressGroupBox.ResumeLayout(false);
            AddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddressGroupBox;
        private Label IndexLabel;
        private Label CountryLabel;
        private Label StreetLabel;
        private Label ApartmentLabel;
        private Label CityLabel;
        private Label BuildingLabel;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private TextBox StreetTextBox;
        private TextBox ApartmentTextBox;
        private TextBox BuildingTextBox;
        private TextBox IndexTextBox;
    }
}

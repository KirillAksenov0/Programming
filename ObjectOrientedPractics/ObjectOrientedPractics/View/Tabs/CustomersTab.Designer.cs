namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            EditButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            CustomersGroupBox = new GroupBox();
            panel1 = new Panel();
            SelectedItemGroupBox = new GroupBox();
            panel2 = new Panel();
            AddressTextBox = new RichTextBox();
            AddressLabel = new Label();
            FullNameTextBox = new TextBox();
            IDTextBox = new TextBox();
            FullNameLabel = new Label();
            IDLabel = new Label();
            CustomersGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(327, 528);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(124, 44);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.Location = new Point(176, 528);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(124, 44);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(22, 527);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(124, 45);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(6, 33);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(466, 464);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.BackColor = SystemColors.ControlLight;
            CustomersGroupBox.Controls.Add(panel1);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Controls.Add(EditButton);
            CustomersGroupBox.Controls.Add(AddButton);
            CustomersGroupBox.Controls.Add(RemoveButton);
            CustomersGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(478, 595);
            CustomersGroupBox.TabIndex = 4;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // panel1
            // 
            panel1.Location = new Point(478, 334);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 261);
            panel1.TabIndex = 6;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.BackColor = SystemColors.ButtonHighlight;
            SelectedItemGroupBox.Controls.Add(panel2);
            SelectedItemGroupBox.Controls.Add(AddressTextBox);
            SelectedItemGroupBox.Controls.Add(AddressLabel);
            SelectedItemGroupBox.Controls.Add(FullNameTextBox);
            SelectedItemGroupBox.Controls.Add(IDTextBox);
            SelectedItemGroupBox.Controls.Add(FullNameLabel);
            SelectedItemGroupBox.Controls.Add(IDLabel);
            SelectedItemGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SelectedItemGroupBox.Location = new Point(481, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(775, 313);
            SelectedItemGroupBox.TabIndex = 5;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 308);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 299);
            panel2.TabIndex = 6;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTextBox.Location = new Point(101, 126);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(479, 176);
            AddressTextBox.TabIndex = 5;
            AddressTextBox.Text = "";
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLabel.Location = new Point(16, 126);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(65, 20);
            AddressLabel.TabIndex = 4;
            AddressLabel.Text = "Address:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameTextBox.Location = new Point(101, 76);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(479, 27);
            FullNameTextBox.TabIndex = 3;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IDTextBox
            // 
            IDTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IDTextBox.Location = new Point(101, 43);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(179, 27);
            IDTextBox.TabIndex = 2;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameLabel.Location = new Point(16, 84);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(79, 20);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full Name:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(16, 46);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 20);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "CustomersTab";
            Size = new Size(1061, 596);
            CustomersGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button EditButton;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox CustomersListBox;
        private GroupBox CustomersGroupBox;
        private GroupBox SelectedItemGroupBox;
        private RichTextBox AddressTextBox;
        private Label AddressLabel;
        private TextBox FullNameTextBox;
        private TextBox IDTextBox;
        private Label FullNameLabel;
        private Label IDLabel;
        private Panel panel1;
        private Panel panel2;
    }
}

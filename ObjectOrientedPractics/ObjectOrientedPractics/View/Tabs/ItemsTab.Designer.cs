namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsGroupBox = new GroupBox();
            EditButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemGroupBox = new GroupBox();
            DescriptionTextBox = new RichTextBox();
            DescriptionLabel = new Label();
            NameTextBox = new RichTextBox();
            NameLabel = new Label();
            CostTextBox = new TextBox();
            IDTextBox = new TextBox();
            CostLabel = new Label();
            IDLabel = new Label();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.BackColor = SystemColors.ControlLight;
            ItemsGroupBox.Controls.Add(EditButton);
            ItemsGroupBox.Controls.Add(RemoveButton);
            ItemsGroupBox.Controls.Add(AddButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(478, 634);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(310, 524);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(146, 63);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.Location = new Point(158, 524);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(146, 63);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(6, 524);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(146, 63);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 28;
            ItemsListBox.Location = new Point(6, 33);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(466, 480);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.BackColor = SystemColors.ButtonHighlight;
            SelectedItemGroupBox.Controls.Add(DescriptionTextBox);
            SelectedItemGroupBox.Controls.Add(DescriptionLabel);
            SelectedItemGroupBox.Controls.Add(NameTextBox);
            SelectedItemGroupBox.Controls.Add(NameLabel);
            SelectedItemGroupBox.Controls.Add(CostTextBox);
            SelectedItemGroupBox.Controls.Add(IDTextBox);
            SelectedItemGroupBox.Controls.Add(CostLabel);
            SelectedItemGroupBox.Controls.Add(IDLabel);
            SelectedItemGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SelectedItemGroupBox.Location = new Point(478, 0);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(734, 631);
            SelectedItemGroupBox.TabIndex = 1;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(16, 343);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(712, 211);
            DescriptionTextBox.TabIndex = 7;
            DescriptionTextBox.Text = "";
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(16, 312);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(116, 28);
            DescriptionLabel.TabIndex = 6;
            DescriptionLabel.Text = "Description:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(16, 186);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(712, 108);
            NameTextBox.TabIndex = 5;
            NameTextBox.Text = "";
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(16, 155);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(68, 28);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name:";
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(93, 97);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(179, 34);
            CostTextBox.TabIndex = 3;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(93, 43);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(179, 34);
            IDTextBox.TabIndex = 2;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(16, 97);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(55, 28);
            CostLabel.TabIndex = 1;
            CostLabel.Text = "Cost:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(16, 46);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(35, 28);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(1218, 631);
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private GroupBox SelectedItemGroupBox;
        private TextBox CostTextBox;
        private TextBox IDTextBox;
        private Label CostLabel;
        private Label IDLabel;
        private Label DescriptionLabel;
        private RichTextBox NameTextBox;
        private Label NameLabel;
        private RichTextBox DescriptionTextBox;
        private Button EditButton;
    }
}

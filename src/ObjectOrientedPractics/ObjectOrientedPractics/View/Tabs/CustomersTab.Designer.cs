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
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            CustomersGroupBox = new GroupBox();
            SelectedItemGroupBox = new GroupBox();
            IsPriorityCheckBox = new CheckBox();
            panel1 = new Panel();
            FullNameTextBox = new TextBox();
            IDTextBox = new TextBox();
            FullNameLabel = new Label();
            IDLabel = new Label();
            customerAddressControl1 = new Controls.CustomerAddressControl();
            toolStripContainer1 = new ToolStripContainer();
            RemoveDiscountButton = new Button();
            AddDiscountButton = new Button();
            DiscountsListBox = new ListBox();
            DiscountsLabel = new Label();
            CustomersGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
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
            CustomersGroupBox.Controls.Add(CustomersListBox);
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
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.BackColor = SystemColors.ButtonHighlight;
            SelectedItemGroupBox.Controls.Add(IsPriorityCheckBox);
            SelectedItemGroupBox.Controls.Add(panel1);
            SelectedItemGroupBox.Controls.Add(FullNameTextBox);
            SelectedItemGroupBox.Controls.Add(IDTextBox);
            SelectedItemGroupBox.Controls.Add(FullNameLabel);
            SelectedItemGroupBox.Controls.Add(IDLabel);
            SelectedItemGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SelectedItemGroupBox.Location = new Point(481, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(589, 157);
            SelectedItemGroupBox.TabIndex = 5;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // IsPriorityCheckBox
            // 
            IsPriorityCheckBox.AutoSize = true;
            IsPriorityCheckBox.Location = new Point(101, 117);
            IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            IsPriorityCheckBox.Size = new Size(92, 24);
            IsPriorityCheckBox.TabIndex = 7;
            IsPriorityCheckBox.Text = "Is Priority";
            IsPriorityCheckBox.UseVisualStyleBackColor = true;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 313);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 280);
            panel1.TabIndex = 6;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameTextBox.Location = new Point(101, 81);
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
            // customerAddressControl1
            // 
            customerAddressControl1.Location = new Point(483, 166);
            customerAddressControl1.Name = "customerAddressControl1";
            customerAddressControl1.OurAddress = null;
            customerAddressControl1.Size = new Size(588, 395);
            customerAddressControl1.TabIndex = 6;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(RemoveDiscountButton);
            toolStripContainer1.ContentPanel.Controls.Add(AddDiscountButton);
            toolStripContainer1.ContentPanel.Controls.Add(DiscountsListBox);
            toolStripContainer1.ContentPanel.Controls.Add(DiscountsLabel);
            toolStripContainer1.ContentPanel.Size = new Size(564, 169);
            toolStripContainer1.Location = new Point(497, 403);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(564, 194);
            toolStripContainer1.TabIndex = 7;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveDiscountButton.Location = new Point(395, 114);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Size = new Size(124, 44);
            RemoveDiscountButton.TabIndex = 3;
            RemoveDiscountButton.Text = "Remove";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddDiscountButton.Location = new Point(395, 62);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(124, 45);
            AddDiscountButton.TabIndex = 2;
            AddDiscountButton.Text = "Add";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 20;
            DiscountsListBox.Location = new Point(6, 39);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(369, 144);
            DiscountsListBox.TabIndex = 1;
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Location = new Point(6, 16);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(73, 20);
            DiscountsLabel.TabIndex = 0;
            DiscountsLabel.Text = "Discounts";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStripContainer1);
            Controls.Add(customerAddressControl1);
            Controls.Add(CustomersGroupBox);
            Controls.Add(SelectedItemGroupBox);
            Name = "CustomersTab";
            Size = new Size(1072, 597);
            CustomersGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button RemoveButton;
        private Button AddButton;
        private ListBox CustomersListBox;
        private GroupBox CustomersGroupBox;
        private GroupBox SelectedItemGroupBox;
        private TextBox FullNameTextBox;
        private TextBox IDTextBox;
        private Label FullNameLabel;
        private Label IDLabel;
        private Panel panel1;
        private Controls.CustomerAddressControl addressControl1;
        private Controls.CustomerAddressControl customerAddressControl1;
        private CheckBox IsPriorityCheckBox;
        private ToolStripContainer toolStripContainer1;
        private ListBox DiscountsListBox;
        private Label DiscountsLabel;
        private Button RemoveDiscountButton;
        private Button AddDiscountButton;
    }
}

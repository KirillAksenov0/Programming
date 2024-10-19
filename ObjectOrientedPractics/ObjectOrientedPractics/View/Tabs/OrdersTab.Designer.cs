namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            Address address1 = new Address();
            splitContainer1 = new SplitContainer();
            OrdersLabel = new Label();
            OrdersDataGridView = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            CreatedColumn = new DataGridViewTextBoxColumn();
            OrderStatusColumn = new DataGridViewTextBoxColumn();
            CustomerFullNameColumn = new DataGridViewTextBoxColumn();
            DeliveryAddressColumn1 = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            PriorityOptionsPanel = new Panel();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            PriorityOptionsLabel = new Label();
            TotalCostLabel = new Label();
            AmountLabel = new Label();
            OrderItemsListBox = new ListBox();
            OrderItemsLabel = new Label();
            StatusComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            IDTextBox = new TextBox();
            IDLabel = new Label();
            CreatedLabel = new Label();
            StatusLabel = new Label();
            SelectedOrderLabel = new Label();
            customerAddressControl1 = new Controls.CustomerAddressControl();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            PriorityOptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(OrdersLabel);
            splitContainer1.Panel1.Controls.Add(OrdersDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(PriorityOptionsPanel);
            splitContainer1.Panel2.Controls.Add(TotalCostLabel);
            splitContainer1.Panel2.Controls.Add(AmountLabel);
            splitContainer1.Panel2.Controls.Add(OrderItemsListBox);
            splitContainer1.Panel2.Controls.Add(OrderItemsLabel);
            splitContainer1.Panel2.Controls.Add(StatusComboBox);
            splitContainer1.Panel2.Controls.Add(CreatedTextBox);
            splitContainer1.Panel2.Controls.Add(IDTextBox);
            splitContainer1.Panel2.Controls.Add(IDLabel);
            splitContainer1.Panel2.Controls.Add(CreatedLabel);
            splitContainer1.Panel2.Controls.Add(StatusLabel);
            splitContainer1.Panel2.Controls.Add(SelectedOrderLabel);
            splitContainer1.Panel2.Controls.Add(customerAddressControl1);
            splitContainer1.Size = new Size(1054, 642);
            splitContainer1.SplitterDistance = 447;
            splitContainer1.TabIndex = 0;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Location = new Point(17, 23);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(53, 20);
            OrdersLabel.TabIndex = 1;
            OrdersLabel.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { IDColumn, CreatedColumn, OrderStatusColumn, CustomerFullNameColumn, DeliveryAddressColumn1, AmountColumn });
            OrdersDataGridView.Location = new Point(17, 46);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.RowTemplate.Height = 29;
            OrdersDataGridView.Size = new Size(414, 537);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // IDColumn
            // 
            IDColumn.HeaderText = "ID";
            IDColumn.MinimumWidth = 6;
            IDColumn.Name = "IDColumn";
            IDColumn.ReadOnly = true;
            IDColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            IDColumn.Width = 125;
            // 
            // CreatedColumn
            // 
            CreatedColumn.HeaderText = "Created";
            CreatedColumn.MinimumWidth = 6;
            CreatedColumn.Name = "CreatedColumn";
            CreatedColumn.ReadOnly = true;
            CreatedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            CreatedColumn.Width = 125;
            // 
            // OrderStatusColumn
            // 
            OrderStatusColumn.HeaderText = "Order Status";
            OrderStatusColumn.MinimumWidth = 6;
            OrderStatusColumn.Name = "OrderStatusColumn";
            OrderStatusColumn.ReadOnly = true;
            OrderStatusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            OrderStatusColumn.Width = 125;
            // 
            // CustomerFullNameColumn
            // 
            CustomerFullNameColumn.HeaderText = "Customer Full Name";
            CustomerFullNameColumn.MinimumWidth = 6;
            CustomerFullNameColumn.Name = "CustomerFullNameColumn";
            CustomerFullNameColumn.ReadOnly = true;
            CustomerFullNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            CustomerFullNameColumn.Width = 125;
            // 
            // DeliveryAddressColumn1
            // 
            DeliveryAddressColumn1.HeaderText = "Delivery Address";
            DeliveryAddressColumn1.MinimumWidth = 6;
            DeliveryAddressColumn1.Name = "DeliveryAddressColumn1";
            DeliveryAddressColumn1.ReadOnly = true;
            DeliveryAddressColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            DeliveryAddressColumn1.Width = 125;
            // 
            // AmountColumn
            // 
            AmountColumn.HeaderText = "Amount";
            AmountColumn.MinimumWidth = 6;
            AmountColumn.Name = "AmountColumn";
            AmountColumn.ReadOnly = true;
            AmountColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            AmountColumn.Width = 125;
            // 
            // PriorityOptionsPanel
            // 
            PriorityOptionsPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsPanel.Controls.Add(DeliveryTimeLabel);
            PriorityOptionsPanel.Controls.Add(PriorityOptionsLabel);
            PriorityOptionsPanel.Location = new Point(278, 3);
            PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            PriorityOptionsPanel.Size = new Size(297, 153);
            PriorityOptionsPanel.TabIndex = 13;
            PriorityOptionsPanel.Visible = false;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Items.AddRange(new object[] { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" });
            DeliveryTimeComboBox.Location = new Point(143, 48);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(151, 28);
            DeliveryTimeComboBox.TabIndex = 2;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(17, 52);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(103, 20);
            DeliveryTimeLabel.TabIndex = 1;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Location = new Point(17, 20);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(112, 20);
            PriorityOptionsLabel.TabIndex = 0;
            PriorityOptionsLabel.Text = "Priority Options";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Location = new Point(522, 596);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(53, 20);
            TotalCostLabel.TabIndex = 12;
            TotalCostLabel.Text = "Label1";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(522, 563);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(65, 20);
            AmountLabel.TabIndex = 11;
            AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 20;
            OrderItemsListBox.Location = new Point(13, 420);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(574, 124);
            OrderItemsListBox.TabIndex = 10;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Location = new Point(13, 397);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(87, 20);
            OrderItemsLabel.TabIndex = 9;
            OrderItemsLabel.Text = "Order Items";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(88, 123);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(184, 28);
            StatusComboBox.TabIndex = 8;
            StatusComboBox.SelectedValueChanged += StatusComboBox_SelectedValueChanged;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(88, 88);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(184, 27);
            CreatedTextBox.TabIndex = 7;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(88, 52);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(184, 27);
            IDTextBox.TabIndex = 6;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(13, 55);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(27, 20);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "ID:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(13, 88);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(64, 20);
            CreatedLabel.TabIndex = 4;
            CreatedLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(13, 126);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(52, 20);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Location = new Point(13, 23);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(108, 20);
            SelectedOrderLabel.TabIndex = 2;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // customerAddressControl1
            // 
            customerAddressControl1.Location = new Point(13, 162);
            customerAddressControl1.Name = "customerAddressControl1";
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 123456;
            address1.Street = "";
            customerAddressControl1.OurAddress = address1;
            customerAddressControl1.Size = new Size(587, 217);
            customerAddressControl1.TabIndex = 0;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "OrdersTab";
            Size = new Size(1054, 642);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            PriorityOptionsPanel.ResumeLayout(false);
            PriorityOptionsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label OrdersLabel;
        private DataGridView OrdersDataGridView;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private TextBox IDTextBox;
        private Label IDLabel;
        private Label CreatedLabel;
        private Label StatusLabel;
        private Label SelectedOrderLabel;
        private Controls.CustomerAddressControl customerAddressControl1;
        private ListBox OrderItemsListBox;
        private Label OrderItemsLabel;
        private Label TotalCostLabel;
        private Label AmountLabel;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn CreatedColumn;
        private DataGridViewTextBoxColumn OrderStatusColumn;
        private DataGridViewTextBoxColumn CustomerFullNameColumn;
        private DataGridViewTextBoxColumn DeliveryAddressColumn1;
        private DataGridViewTextBoxColumn AmountColumn;
        private Panel PriorityOptionsPanel;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private Label PriorityOptionsLabel;
    }
}

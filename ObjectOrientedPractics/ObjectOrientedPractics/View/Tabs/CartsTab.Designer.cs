namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            CartSplitContainer = new SplitContainer();
            CartItemsListBox = new ListBox();
            ItemsLabel = new Label();
            AddToCartButton = new Button();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            CustomerLabel = new Label();
            CustomerComboBox = new ComboBox();
            CartLabel = new Label();
            richTextBox1 = new RichTextBox();
            AmountLabel = new Label();
            TotalCostLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CartSplitContainer).BeginInit();
            CartSplitContainer.Panel1.SuspendLayout();
            CartSplitContainer.Panel2.SuspendLayout();
            CartSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // CartSplitContainer
            // 
            CartSplitContainer.Dock = DockStyle.Fill;
            CartSplitContainer.Location = new Point(0, 0);
            CartSplitContainer.Name = "CartSplitContainer";
            // 
            // CartSplitContainer.Panel1
            // 
            CartSplitContainer.Panel1.Controls.Add(AddToCartButton);
            CartSplitContainer.Panel1.Controls.Add(ItemsLabel);
            CartSplitContainer.Panel1.Controls.Add(CartItemsListBox);
            // 
            // CartSplitContainer.Panel2
            // 
            CartSplitContainer.Panel2.Controls.Add(TotalCostLabel);
            CartSplitContainer.Panel2.Controls.Add(AmountLabel);
            CartSplitContainer.Panel2.Controls.Add(richTextBox1);
            CartSplitContainer.Panel2.Controls.Add(CartLabel);
            CartSplitContainer.Panel2.Controls.Add(CustomerComboBox);
            CartSplitContainer.Panel2.Controls.Add(CustomerLabel);
            CartSplitContainer.Panel2.Controls.Add(ClearCartButton);
            CartSplitContainer.Panel2.Controls.Add(RemoveItemButton);
            CartSplitContainer.Panel2.Controls.Add(CreateOrderButton);
            CartSplitContainer.Size = new Size(1072, 597);
            CartSplitContainer.SplitterDistance = 411;
            CartSplitContainer.TabIndex = 0;
            // 
            // CartItemsListBox
            // 
            CartItemsListBox.FormattingEnabled = true;
            CartItemsListBox.ItemHeight = 20;
            CartItemsListBox.Location = new Point(20, 36);
            CartItemsListBox.Name = "CartItemsListBox";
            CartItemsListBox.Size = new Size(368, 484);
            CartItemsListBox.TabIndex = 0;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Location = new Point(20, 13);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(45, 20);
            ItemsLabel.TabIndex = 1;
            ItemsLabel.Text = "Items";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(35, 539);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(106, 39);
            AddToCartButton.TabIndex = 2;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(19, 414);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(106, 39);
            CreateOrderButton.TabIndex = 3;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(414, 414);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(106, 39);
            RemoveItemButton.TabIndex = 4;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(526, 414);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(106, 39);
            ClearCartButton.TabIndex = 5;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(19, 36);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(75, 20);
            CustomerLabel.TabIndex = 6;
            CustomerLabel.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(100, 33);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(532, 28);
            CustomerComboBox.TabIndex = 7;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(19, 98);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(39, 20);
            CartLabel.TabIndex = 8;
            CartLabel.Text = "Cart:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(19, 121);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(613, 200);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(567, 337);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(65, 20);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "Amount:";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Location = new Point(582, 375);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(50, 20);
            TotalCostLabel.TabIndex = 11;
            TotalCostLabel.Text = "label1";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartSplitContainer);
            Name = "CartsTab";
            Size = new Size(1072, 597);
            CartSplitContainer.Panel1.ResumeLayout(false);
            CartSplitContainer.Panel1.PerformLayout();
            CartSplitContainer.Panel2.ResumeLayout(false);
            CartSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CartSplitContainer).EndInit();
            CartSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer CartSplitContainer;
        private Button AddToCartButton;
        private Label ItemsLabel;
        private ListBox CartItemsListBox;
        private Label TotalCostLabel;
        private Label AmountLabel;
        private RichTextBox richTextBox1;
        private Label CartLabel;
        private ComboBox CustomerComboBox;
        private Label CustomerLabel;
        private Button ClearCartButton;
        private Button RemoveItemButton;
        private Button CreateOrderButton;
    }
}

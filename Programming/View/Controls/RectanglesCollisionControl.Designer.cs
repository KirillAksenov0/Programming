namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            MinusPictureBox = new PictureBox();
            PlusPictureBox = new PictureBox();
            RectanglesLabel2 = new Label();
            panel1 = new Panel();
            WidthTextBox2 = new TextBox();
            HeightTextBox2 = new TextBox();
            YTextBox2 = new TextBox();
            XTextBox2 = new TextBox();
            IDTextBox2 = new TextBox();
            HeightLabel = new Label();
            WidthLabel2 = new Label();
            IDLabel2 = new Label();
            YLabel2 = new Label();
            XLabel2 = new Label();
            SelectedRectangleLabel = new Label();
            RectanglesListBox2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)MinusPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlusPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MinusPictureBox
            // 
            MinusPictureBox.Cursor = Cursors.Hand;
            MinusPictureBox.Image = Properties.Resources.delete_rectangle_button;
            MinusPictureBox.Location = new Point(162, 137);
            MinusPictureBox.Name = "MinusPictureBox";
            MinusPictureBox.Size = new Size(56, 29);
            MinusPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            MinusPictureBox.TabIndex = 40;
            MinusPictureBox.TabStop = false;
            MinusPictureBox.Click += MinusPictureBox_Click;
            // 
            // PlusPictureBox
            // 
            PlusPictureBox.Cursor = Cursors.Hand;
            PlusPictureBox.Image = Properties.Resources.add_rectandle_button;
            PlusPictureBox.Location = new Point(68, 137);
            PlusPictureBox.Name = "PlusPictureBox";
            PlusPictureBox.Size = new Size(53, 29);
            PlusPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PlusPictureBox.TabIndex = 39;
            PlusPictureBox.TabStop = false;
            PlusPictureBox.Click += PlusPictureBox_Click;
            PlusPictureBox.Paint += PlusPictureBox_Paint;
            // 
            // RectanglesLabel2
            // 
            RectanglesLabel2.AutoSize = true;
            RectanglesLabel2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            RectanglesLabel2.Location = new Point(13, 7);
            RectanglesLabel2.Name = "RectanglesLabel2";
            RectanglesLabel2.Size = new Size(74, 17);
            RectanglesLabel2.TabIndex = 38;
            RectanglesLabel2.Text = "Rectangles:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(287, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 333);
            panel1.TabIndex = 37;
            // 
            // WidthTextBox2
            // 
            WidthTextBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            WidthTextBox2.Location = new Point(78, 299);
            WidthTextBox2.Name = "WidthTextBox2";
            WidthTextBox2.Size = new Size(125, 25);
            WidthTextBox2.TabIndex = 36;
            WidthTextBox2.TextChanged += WidthTextBox2_TextChanged;
            // 
            // HeightTextBox2
            // 
            HeightTextBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            HeightTextBox2.Location = new Point(78, 330);
            HeightTextBox2.Name = "HeightTextBox2";
            HeightTextBox2.Size = new Size(125, 25);
            HeightTextBox2.TabIndex = 35;
            HeightTextBox2.TextChanged += HeightTextBox2_TextChanged;
            // 
            // YTextBox2
            // 
            YTextBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            YTextBox2.Location = new Point(78, 268);
            YTextBox2.Name = "YTextBox2";
            YTextBox2.ReadOnly = true;
            YTextBox2.Size = new Size(125, 25);
            YTextBox2.TabIndex = 34;
            // 
            // XTextBox2
            // 
            XTextBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            XTextBox2.Location = new Point(79, 236);
            XTextBox2.Name = "XTextBox2";
            XTextBox2.ReadOnly = true;
            XTextBox2.Size = new Size(125, 25);
            XTextBox2.TabIndex = 33;
            // 
            // IDTextBox2
            // 
            IDTextBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            IDTextBox2.Location = new Point(79, 205);
            IDTextBox2.Name = "IDTextBox2";
            IDTextBox2.ReadOnly = true;
            IDTextBox2.Size = new Size(125, 25);
            IDTextBox2.TabIndex = 32;
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(16, 329);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(57, 20);
            HeightLabel.TabIndex = 31;
            HeightLabel.Text = "Height:";
            // 
            // WidthLabel2
            // 
            WidthLabel2.AutoSize = true;
            WidthLabel2.Location = new Point(21, 299);
            WidthLabel2.Name = "WidthLabel2";
            WidthLabel2.Size = new Size(52, 20);
            WidthLabel2.TabIndex = 30;
            WidthLabel2.Text = "Width:";
            // 
            // IDLabel2
            // 
            IDLabel2.AutoSize = true;
            IDLabel2.Location = new Point(52, 210);
            IDLabel2.Name = "IDLabel2";
            IDLabel2.Size = new Size(25, 20);
            IDLabel2.TabIndex = 29;
            IDLabel2.Text = "Id:";
            // 
            // YLabel2
            // 
            YLabel2.AutoSize = true;
            YLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            YLabel2.Location = new Point(52, 268);
            YLabel2.Name = "YLabel2";
            YLabel2.Size = new Size(20, 20);
            YLabel2.TabIndex = 28;
            YLabel2.Text = "Y:";
            // 
            // XLabel2
            // 
            XLabel2.AutoSize = true;
            XLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            XLabel2.Location = new Point(52, 239);
            XLabel2.Name = "XLabel2";
            XLabel2.Size = new Size(21, 20);
            XLabel2.TabIndex = 27;
            XLabel2.Text = "X:";
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(20, 178);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(139, 20);
            SelectedRectangleLabel.TabIndex = 26;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox2
            // 
            RectanglesListBox2.FormattingEnabled = true;
            RectanglesListBox2.ItemHeight = 20;
            RectanglesListBox2.Location = new Point(13, 27);
            RectanglesListBox2.Name = "RectanglesListBox2";
            RectanglesListBox2.Size = new Size(268, 104);
            RectanglesListBox2.TabIndex = 25;
            RectanglesListBox2.SelectedIndexChanged += RectanglesListBox2_SelectedIndexChanged;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MinusPictureBox);
            Controls.Add(PlusPictureBox);
            Controls.Add(RectanglesLabel2);
            Controls.Add(panel1);
            Controls.Add(WidthTextBox2);
            Controls.Add(HeightTextBox2);
            Controls.Add(YTextBox2);
            Controls.Add(XTextBox2);
            Controls.Add(IDTextBox2);
            Controls.Add(HeightLabel);
            Controls.Add(WidthLabel2);
            Controls.Add(IDLabel2);
            Controls.Add(YLabel2);
            Controls.Add(XLabel2);
            Controls.Add(SelectedRectangleLabel);
            Controls.Add(RectanglesListBox2);
            Name = "RectanglesCollisionControl";
            Size = new Size(721, 374);
            ((System.ComponentModel.ISupportInitialize)MinusPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlusPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MinusPictureBox;
        private PictureBox PlusPictureBox;
        private Label RectanglesLabel2;
        private Panel panel1;
        private TextBox WidthTextBox2;
        private TextBox HeightTextBox2;
        private TextBox YTextBox2;
        private TextBox XTextBox2;
        private TextBox IDTextBox2;
        private Label HeightLabel;
        private Label WidthLabel2;
        private Label IDLabel2;
        private Label YLabel2;
        private Label XLabel2;
        private Label SelectedRectangleLabel;
        private ListBox RectanglesListBox2;
    }
}

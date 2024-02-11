namespace Programming.View;

public partial class Form1 : System.Windows.Forms.Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        tabPage1 = new TabPage();
        textBox1 = new TextBox();
        ValuesListBox = new ListBox();
        EnumsListBox = new ListBox();
        tabControl1 = new TabControl();
        tabPage1.SuspendLayout();
        tabControl1.SuspendLayout();
        SuspendLayout();
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(textBox1);
        tabPage1.Controls.Add(ValuesListBox);
        tabPage1.Controls.Add(EnumsListBox);
        tabPage1.Location = new Point(4, 29);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(956, 394);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Enums";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(566, 55);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 2;
        // 
        // ValuesListBox
        // 
        ValuesListBox.FormattingEnabled = true;
        ValuesListBox.ItemHeight = 20;
        ValuesListBox.Location = new Point(310, 55);
        ValuesListBox.Name = "ValuesListBox";
        ValuesListBox.Size = new Size(150, 104);
        ValuesListBox.TabIndex = 1;
        // 
        // EnumsListBox
        // 
        EnumsListBox.FormattingEnabled = true;
        EnumsListBox.ItemHeight = 20;
        EnumsListBox.Items.AddRange(new object[] { "Colour" });
        EnumsListBox.Location = new Point(78, 55);
        EnumsListBox.Name = "EnumsListBox";
        EnumsListBox.Size = new Size(150, 104);
        EnumsListBox.TabIndex = 0;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(964, 427);
        tabControl1.TabIndex = 0;
        // 
        // Form1
        // 
        ClientSize = new Size(964, 427);
        Controls.Add(tabControl1);
        Name = "Form1";
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        tabControl1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private TabPage tabPage1;
    private ListBox ValuesListBox;
    private ListBox EnumsListBox;
    private TextBox textBox1;
    private TabControl tabControl1;
}
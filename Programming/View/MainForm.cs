namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PopulateEnumsListBox();
        }

        private void PopulateEnumsListBox()
        {
            //��������� ���� ����� � ������
            Type[] types = typeof(Program).Assembly.GetTypes();

            //��������� ������ ������������
            var enumTypes = Array.FindAll(types, t => t.IsEnum);

            //���������� ���� ������������ � EnumsListBox

            foreach (var enumType in enumTypes)
            {
                EnumsListBox.Items.Add(enumType.Name);
            }


        }

    }
}
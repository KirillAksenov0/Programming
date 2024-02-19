using System.IO;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PopulateEnumsListBox();
            FillingSeasonComboBox();
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

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox EnumListBox = (ListBox)sender;

            //��������� ����� ���� ������ � EnumsListBox
            switch (EnumsListBox.SelectedItem.ToString())
            {
                //������ "Color"
                case "Color":

                    //������� �� ���������
                    ValuesListBox.Items.Clear();

                    //���������� ��������������� �������� � ValuesListBox
                    foreach (Color colorName in Enum.GetValues(typeof(Color)))

                        ValuesListBox.Items.Add(colorName);
                    break;
                //������ "FormOfEducation"
                case "FormOfEducation":

                    //������� �� ���������
                    ValuesListBox.Items.Clear();

                    //���������� ��������������� �������� � ValuesListBox
                    foreach (FormOfEducation formName in Enum.GetValues(typeof(FormOfEducation)))

                        ValuesListBox.Items.Add(formName);
                    break;
                //������ "Genre"
                case "Genre":
                    //������� �� ���������
                    ValuesListBox.Items.Clear();

                    //���������� ��������������� �������� � ValuesListBox
                    foreach (Genre genreName in Enum.GetValues(typeof(Genre)))

                        ValuesListBox.Items.Add(genreName);
                    break;
                //������ "Manufactories"
                case "Manufactures":
                    //������� �� ���������
                    ValuesListBox.Items.Clear();

                    //���������� ��������������� �������� � ValuesListBox
                    foreach (Manufactures smartphoneName in Enum.GetValues(typeof(Manufactures)))

                        ValuesListBox.Items.Add(smartphoneName);
                    break;
                //������ "TimeOfYear"
                case "TimeOfYear":
                    //������� �� ���������
                    ValuesListBox.Items.Clear();

                    //���������� ��������������� �������� � ValuesListBox
                    foreach (TimeOfYear seasonName in Enum.GetValues(typeof(TimeOfYear)))

                        ValuesListBox.Items.Add(seasonName);
                    break;
                //������ "Weekday"
                case "Weekday":
                    //������� �� ���������
                    ValuesListBox.Items.Clear();

                    //���������� ��������������� �������� � ValuesListBox
                    foreach (Weekday dayName in Enum.GetValues(typeof(Weekday)))

                        ValuesListBox.Items.Add(dayName);
                    break;
            }
            EnumsListBox.SelectedIndexChanged += new EventHandler(EnumsListBox_SelectedIndexChanged);

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //����������� ������ �������� � ValuesTextBox
            ValuesTextBox.Text = ValuesListBox.SelectedIndex.ToString();

        }
        private void parseButton_Click(object sender, EventArgs e)
        {
            var inputWeekday = ParsingTextBox.Text;
            Weekday outputWeekday;

            //���������, ����� �� ������������� ��������� �������� � ���� Weekday
            if (Enum.TryParse(inputWeekday, true, out outputWeekday))
            {
                //�������� ����� ��� ������ � ������� ���������
                int dayNumber = Array.IndexOf(Enum.GetValues(typeof(Weekday)), outputWeekday) + 1;
                ValueEquivalentLabel.Text = $" ��� ���� ������ ({outputWeekday} = {dayNumber})";

            }
            else
            {
                //���� �� ������� �������������
                ValueEquivalentLabel.Text = "��� ������ ��� ������";
            }

        }

        private void FillingSeasonComboBox()
        {
            //���������� SeasonComboBox
            foreach (TimeOfYear seasonName in Enum.GetValues(typeof(TimeOfYear)))

                SeasonComboBox.Items.Add(seasonName);
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            //��������� ����� ����� ���� ������� � SeasonComboBox
            switch (SeasonComboBox.Text)
            {
                //������ "Summer"
                case "Summer":

                    this.BackColor = SystemColors.Control;
                    SeasonLabel.Text = "���! ����!";
                    break;

                //������ "Autumn"
                case "Autumn":
                    SeasonLabel.Text = " ";
                    this.BackColor = System.Drawing.Color.SandyBrown;
                    break;

                //������ "Winter"
                case "Winter":
                    this.BackColor = SystemColors.Control;
                    SeasonLabel.Text = "����! �������!";
                    break;

                //������ "Spring"
                case "Spring":
                    
                    SeasonLabel.Text = "";
                    this.BackColor = System.Drawing.Color.Green;
                    break;

                //������ �� �������
                case "":
                    SeasonLabel.Text = "�������� ����� ����";
                    break;

                //������� ��� �� ������
                default:
                    this.BackColor = SystemColors.Control;
                    SeasonLabel.Text = "��� ������ ������� ����";
                    break;
            }

        }
    }
}
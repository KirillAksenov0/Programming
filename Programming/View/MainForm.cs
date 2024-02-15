using System.Windows.Forms;

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
            //Получение всех типов в сборке
            Type[] types = typeof(Program).Assembly.GetTypes();

            //Фильтруем только перечесления
            var enumTypes = Array.FindAll(types, t => t.IsEnum);

            //Добавление имен перечеслений в EnumsListBox

            foreach (var enumType in enumTypes)
            {
                EnumsListBox.Items.Add(enumType.Name);
            }


        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox EnumListBox = (ListBox)sender;
            
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Color":
                    ValuesListBox.Items.Clear();

                    foreach (Color colorName in Enum.GetValues(typeof(Color)))

                        ValuesListBox.Items.Add(colorName);
                    break;
                case "FormOfEducation":
                    ValuesListBox.Items.Clear();

                    foreach (FormOfEducation formName in Enum.GetValues(typeof(FormOfEducation)))

                        ValuesListBox.Items.Add(formName);
                    break;
                case "Genre":
                    ValuesListBox.Items.Clear();

                    foreach (Genre genreName in Enum.GetValues(typeof(Genre)))

                        ValuesListBox.Items.Add(genreName);
                    break;
                case "Manufactures":
                    ValuesListBox.Items.Clear();

                    foreach (Manufactures smartphoneName in Enum.GetValues(typeof(Manufactures)))

                        ValuesListBox.Items.Add(smartphoneName);
                    break;
                case "TimeOfYear":
                    ValuesListBox.Items.Clear();

                    foreach (TimeOfYear seasonName in Enum.GetValues(typeof(TimeOfYear)))

                        ValuesListBox.Items.Add(seasonName);
                    break;
                case "Weekday":
                    ValuesListBox.Items.Clear();

                    foreach (Weekday dayName in Enum.GetValues(typeof(Weekday)))

                        ValuesListBox.Items.Add(dayName);
                    break;
            }
            EnumsListBox.SelectedIndexChanged += new EventHandler(EnumsListBox_SelectedIndexChanged);
            

        }
    }
}
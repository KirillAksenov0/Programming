﻿using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        //Создаем массив прямоугольников
        private Rectangle[] _rectangles;
        private string[] colors;

        //Создаем поле _currentRangle
        private Rectangle _currentRectangle;
        public MainForm()
        {
            InitializeComponent();
            PopulateEnumsListBox();
            FillingSeasonComboBox();

            //Задаем рандомное значение для массива
            Random random = new Random();
            double min = 0.0;
            double max = 10.0;

            colors = new string[5] { "Orange", "Red", "Green", "Yellow", "Blue" };
            //Заполнение массива
            _rectangles = new Rectangle[5];

            for (int index = 0; index < _rectangles.Length; index++)
            {
                double randomLenght = Math.Round(min + (random.NextDouble() * (max - min)), 2);
                double randomWeight = Math.Round(min + (random.NextDouble() * (max - min)), 2);
                _rectangles[index] = new Rectangle(randomLenght, randomWeight, colors[index]);
            }

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

            //Проверяем какой цвет выбран в EnumsListBox
            switch (EnumsListBox.SelectedItem.ToString())
            {
                //Выбран "Color"
                case "Color":

                    //Очищаем от элементов
                    ValuesListBox.Items.Clear();

                    //Добавление соответсвтующих элемнтов в ValuesListBox
                    foreach (Color colorName in Enum.GetValues(typeof(Color)))

                        ValuesListBox.Items.Add(colorName);
                    break;
                //Выбран "FormOfEducation"
                case "FormOfEducation":

                    //Очищаем от элементов
                    ValuesListBox.Items.Clear();

                    //Добавление соответсвтующих элемнтов в ValuesListBox
                    foreach (FormOfEducation formName in Enum.GetValues(typeof(FormOfEducation)))

                        ValuesListBox.Items.Add(formName);
                    break;
                //Выбран "Genre"
                case "Genre":
                    //Очищаем от элементов
                    ValuesListBox.Items.Clear();

                    //Добавление соответсвтующих элемнтов в ValuesListBox
                    foreach (Genre genreName in Enum.GetValues(typeof(Genre)))

                        ValuesListBox.Items.Add(genreName);
                    break;
                //Выбран "Manufactories"
                case "Manufactures":
                    //Очищаем от элементов
                    ValuesListBox.Items.Clear();

                    //Добавление соответсвтующих элемнтов в ValuesListBox
                    foreach (Manufactures smartphoneName in Enum.GetValues(typeof(Manufactures)))

                        ValuesListBox.Items.Add(smartphoneName);
                    break;
                //Выбран "TimeOfYear"
                case "TimeOfYear":
                    //Очищаем от элементов
                    ValuesListBox.Items.Clear();

                    //Добавление соответсвтующих элемнтов в ValuesListBox
                    foreach (TimeOfYear seasonName in Enum.GetValues(typeof(TimeOfYear)))

                        ValuesListBox.Items.Add(seasonName);
                    break;
                //Выбран "Weekday"
                case "Weekday":
                    //Очищаем от элементов
                    ValuesListBox.Items.Clear();

                    //Добавление соответсвтующих элемнтов в ValuesListBox
                    foreach (Weekday dayName in Enum.GetValues(typeof(Weekday)))

                        ValuesListBox.Items.Add(dayName);
                    break;
            }
            EnumsListBox.SelectedIndexChanged += new EventHandler(EnumsListBox_SelectedIndexChanged);

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Отображение номера элемента в ValuesTextBox
            ValuesTextBox.Text = ValuesListBox.SelectedIndex.ToString();

        }
        private void parseButton_Click(object sender, EventArgs e)
        {
            var inputWeekday = ParsingTextBox.Text;
            Weekday outputWeekday;
            double number;
            //Проверяем, можно ли преобразовать введенное значение к типу Weekday
            if (Enum.TryParse(inputWeekday, true, out outputWeekday) && double.TryParse(inputWeekday, out number) == false)
            {
                //получаем номер дня недели и выводим сообщение
                int dayNumber = Array.IndexOf(Enum.GetValues(typeof(Weekday)), outputWeekday) + 1;
                ValueEquivalentLabel.Text = $" Это день недели ({outputWeekday} = {dayNumber})";

            }
            else
            {
                //Если не удалось преобразовать
                ValueEquivalentLabel.Text = "Нет такого дня недели";
            }

        }
        private void FillingSeasonComboBox()
        {
            //Заполнение SeasonComboBox
            foreach (TimeOfYear seasonName in Enum.GetValues(typeof(TimeOfYear)))

                SeasonComboBox.Items.Add(seasonName);
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            //Проверяем какое время года выбрано в SeasonComboBox
            switch (SeasonComboBox.Text)
            {
                //Выбран "Summer"
                case "Summer":

                    this.BackColor = SystemColors.Control;
                    SeasonLabel.Text = "Ура! Лето!";
                    break;

                //Выбран "Autumn"
                case "Autumn":
                    SeasonLabel.Text = " ";
                    this.BackColor = System.Drawing.Color.SandyBrown;
                    break;

                //Выбран "Winter"
                case "Winter":
                    this.BackColor = SystemColors.Control;
                    SeasonLabel.Text = "Бррр! Холодно!";
                    break;

                //Выбран "Spring"
                case "Spring":

                    SeasonLabel.Text = "";
                    this.BackColor = System.Drawing.Color.Green;
                    break;

                //Нечего не выбрано
                case "":
                    SeasonLabel.Text = "Выберите время года";
                    break;

                //Выбрано что то другое
                default:
                    this.BackColor = SystemColors.Control;
                    SeasonLabel.Text = "Нет такого времени года";
                    break;
            }

        }
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Получаем текущий выбранный индекс
            int selectedIndex = RectanglesListBox.SelectedIndex;

            //Проверяем, чтобы индекс был в пределах массива
            if (selectedIndex >= 0 && selectedIndex < _rectangles.Length)
            {
                //Устанавливаем текущий прямоугольник
                _currentRectangle = _rectangles[selectedIndex];
            }

            //Заполнение текстбоксов в зависимости от выбранного объекта
            switch (RectanglesListBox.SelectedItem.ToString())
            {
                //Если выбран "Rectangle1"
                case "Rectangle1":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    break;

                //Если выбран "Rectangle2"
                case "Rectangle2":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    break;

                //Если выбран "Rectangle3"
                case "Rectangle3":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    break;

                //Если выбран "Rectangle4"
                case "Rectangle4":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    break;

                //Если выбран "Rectangle5"
                case "Rectangle5":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    break;
            }

        }
    }
}
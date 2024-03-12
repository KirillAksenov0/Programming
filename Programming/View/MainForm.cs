using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class MainForm : Form
    {
        //Создаем массив прямоугольников
        private Rectangle[] _rectangles;

        //Флаг для события tabcontrol1_SelectedIndexChanged
        private bool listBoxFilled = false;

        //Массив цветов
        private string[] colors;

        //Создаем массив фильмов
        private Movie[] _movies;

        //Массивы с объектами фильмов
        private string[] name;
        private string[] genre;
        private int[] year;
        private double[] rating;
        private int[] duration;

        //Создаем поле _currentRangle
        private Rectangle _currentRectangle;

        //Создаем поле _currentMovie
        private Movie _currentMovie;
        public MainForm()
        {
            InitializeComponent();
            PopulateEnumsListBox();
            FillingSeasonComboBox();

            //Задаем рандомное значение длины и ширины прямоугольников 
            Random randomRec = new Random();
            double minRec = 0.0;
            double maxRec = 10.0;

            //Задаем рандомное значение рейтинга фильмов
            Random randomRating = new Random();
            double minRating = 0.0;
            double maxRating = 10.0;

            //Задаем рандомное значение точек X и Y
            Random randomPoint = new Random();

            //Заполнение массива цветов
            colors = new string[5] { "Orange", "Red", "Green", "Yellow", "Blue" };

            //Заполнение массивов объектов фильма
            name = new string[5] { "FightClub", "Infinity", "IronMan", "Avangers", "Klaus" };
            genre = new string[5] { "Drama", "Biography", "Action", "Adventure", "Family" };
            year = new int[5] { 2000, 1996, 2005, 2012, 2019 };
            duration = new int[5] { 112, 93, 99, 154, 200 };

            //Заполнение массива прямоугольников
            _rectangles = new Rectangle[5];

            for (int index = 0; index < _rectangles.Length; index++)
            {
                int randomNumberX = randomPoint.Next(1, 11);
                int randomNumberY = randomPoint.Next(1, 11);
                Point2D centerPoint = new Point2D(randomNumberX, randomNumberY);
                double randomLenght = Math.Round(minRec + (randomRec.NextDouble() * (maxRec - minRec)), 2);
                double randomWeight = Math.Round(minRec + (randomRec.NextDouble() * (maxRec - minRec)), 2);
                _rectangles[index] = new Rectangle(centerPoint, randomLenght, randomWeight, colors[index]);
            }
            //Заполнение массива фильмов
            _movies = new Movie[5];

            for (int index = 0; index < _movies.Length; index++)
            {
                double randomRate = Math.Round(minRating + (randomRating.NextDouble() *
                    (maxRating - minRating)), 2);

                _movies[index] = new Movie(name[index], duration[index], year[index],
                    genre[index], randomRate);

            }

        }
        /// <summary>
        /// Добавляет имена перечеслений в EnumsListBox
        /// </summary>
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

        /// <summary>
        /// Запоняет ValuesListBox в зависимости от выбранного значения в EnumsListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Отображает номер элемента ValuesListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Отображение номера элемента в ValuesTextBox
            ValuesTextBox.Text = ValuesListBox.SelectedIndex.ToString();

        }

        /// <summary>
        /// Выводит номер дня недели при нажатии кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Заполняет SeasonComboBox
        /// </summary>
        private void FillingSeasonComboBox()
        {
            //Заполнение SeasonComboBox
            foreach (TimeOfYear seasonName in Enum.GetValues(typeof(TimeOfYear)))

                SeasonComboBox.Items.Add(seasonName);
        }

        /// <summary>
        /// Выводит сообщение при нажатии кнопки в зависимости от выбранного времени года.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Заполняет MoviesListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 1 && !listBoxFilled)
            {
                //Заполнение MovieListBox
                foreach (var nameMovie in _movies)
                {
                    MoviesListBox.Items.Add(nameMovie.Name);
                }

                // Устанавливаем первый элемент в ListBox по умолчанию
                RectanglesListBox.SelectedIndex = 0;

                //Устанавливаем первый элемент в MoviesListBox по умолчанию
                MoviesListBox.SelectedIndex = 0;

                listBoxFilled = true;
            }
        }

        /// <summary>
        /// Заполнение параметров прямоугольников.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    XTextBox.Text = _currentRectangle.Center.X.ToString();
                    YTextBox.Text = _currentRectangle.Center.Y.ToString();
                    break;

                //Если выбран "Rectangle2"
                case "Rectangle2":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    XTextBox.Text = _currentRectangle.Center.X.ToString();
                    YTextBox.Text = _currentRectangle.Center.Y.ToString();
                    break;

                //Если выбран "Rectangle3"
                case "Rectangle3":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    XTextBox.Text = _currentRectangle.Center.X.ToString();
                    YTextBox.Text = _currentRectangle.Center.Y.ToString();
                    break;

                //Если выбран "Rectangle4"
                case "Rectangle4":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    XTextBox.Text = _currentRectangle.Center.X.ToString();
                    YTextBox.Text = _currentRectangle.Center.Y.ToString();
                    break;

                //Если выбран "Rectangle5"
                case "Rectangle5":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    XTextBox.Text = _currentRectangle.Center.X.ToString();
                    YTextBox.Text = _currentRectangle.Center.Y.ToString();
                    break;
            }

        }

        /// <summary>
        /// Обрабатывает неверно-введенное значение длины прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            //Присваивание длины прямоугольника _currentRectangle
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LenghtTextBox.Text);
            }

            //Обозначение неверно-введенного значения
            catch
            {
                LenghtTextBox.BackColor = System.Drawing.Color.LightPink;

                _currentRectangle.Length = -1;
            }
            //Окрашивание textBox в белый, если введено верное значение 
            finally
            {
                if (_currentRectangle.Length < 0
                    || LenghtTextBox.Text == "")
                {
                    LenghtTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    LenghtTextBox.BackColor = System.Drawing.Color.White;
                }
            }

        }

        /// <summary>
        /// Обрабатывает неверно-введенное значение ширины прямоугльника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            //Присваивание ширины прямоугольника _currentRectangle
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
            }

            //Обозначение неверно-введенного значения
            catch
            {

                WidthTextBox.BackColor = System.Drawing.Color.LightPink;

                _currentRectangle.Width = -1;
            }
            //Окрашивание textBox в белый, если введено верное значение
            finally
            {
                if (_currentRectangle.Width < 0 ||
                    WidthTextBox.Text == "")
                {
                    WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    WidthTextBox.BackColor = System.Drawing.Color.White;
                }

            }
        }
        /// <summary>
        /// Обрабатывает неверно-введенное значение цвета прямоугльника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            //Присваивание введенного цвета
            _currentRectangle.Color = ColorTextBox.Text;

            //Обработка неверного значения
            if (ColorTextBox.Text == "" || (double.TryParse(ColorTextBox.Text, out double result)))
            {
                //Окрашивание textBox в красный 
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            //Обработка верного значения
            else
            {
                //Окрашивание textBox в белый
                ColorTextBox.BackColor = System.Drawing.Color.White;
            }
        }

        /// <summary>
        /// Ищет прямоугольник с наибольшей шириной.
        /// </summary>
        /// <param name="_rectangles">Массив объектов класса Rectangle.</param>
        /// <returns>Возвращает индекс прямоугольника с наибольшей шириной.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] _rectangles)
        {
            double widthmax = _rectangles[0].Width;
            int index = 0;

            //Перебор прямоугольников
            for (int i = 0; i < _rectangles.Length; i++)
            {
                //Нахождение индекса прямоугольника с масимальной шириной
                if (_rectangles[i].Width > widthmax)
                {
                    widthmax = _rectangles[i].Width;
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Выбирает прямоугольник с максимальной шириной
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = FindRectangleWithMaxWidth(_rectangles);
            //Смена выбранного прямоугольника на прямоугольник с max шириной
            RectanglesListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Заполняет параметры для выбранного фильма.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Получаем текущий выбранный индекс
            int selectedIndex = MoviesListBox.SelectedIndex;

            //Проверяем, чтобы индекс был в пределах массива
            if (selectedIndex >= 0 && selectedIndex < _movies.Length)
            {
                //Устанавливаем текущий фильм
                _currentMovie = _movies[selectedIndex];
            }
            //Заполнение текстбоксов в зависимости от выбранного объекта
            switch (MoviesListBox.SelectedItem.ToString())
            {
                //Если выбран "FightClub"
                case "FightClub":
                    GenreTextBox.Text = _currentMovie.Genre;
                    YearTextBox.Text = _currentMovie.Year.ToString();
                    RatingTextBox.Text = _currentMovie.Rating.ToString();
                    DurationTextBox.Text = _currentMovie.DurationMinute.ToString();
                    break;

                //Если выбран "Infinity"
                case "Infinity":
                    GenreTextBox.Text = _currentMovie.Genre;
                    YearTextBox.Text = _currentMovie.Year.ToString();
                    RatingTextBox.Text = _currentMovie.Rating.ToString();
                    DurationTextBox.Text = _currentMovie.DurationMinute.ToString();
                    break;

                //Если выбран "IronMan"
                case "IronMan":
                    GenreTextBox.Text = _currentMovie.Genre;
                    YearTextBox.Text = _currentMovie.Year.ToString();
                    RatingTextBox.Text = _currentMovie.Rating.ToString();
                    DurationTextBox.Text = _currentMovie.DurationMinute.ToString();
                    break;

                //Если выбран "Avangers"
                case "Avangers":
                    GenreTextBox.Text = _currentMovie.Genre;
                    YearTextBox.Text = _currentMovie.Year.ToString();
                    RatingTextBox.Text = _currentMovie.Rating.ToString();
                    DurationTextBox.Text = _currentMovie.DurationMinute.ToString();
                    break;

                //Если выбран "Klaus"
                case "Klaus":
                    GenreTextBox.Text = _currentMovie.Genre;
                    YearTextBox.Text = _currentMovie.Year.ToString();
                    RatingTextBox.Text = _currentMovie.Rating.ToString();
                    DurationTextBox.Text = _currentMovie.DurationMinute.ToString();
                    break;
            }
        }

        /// <summary>
        /// Обрабатывает неверно-введенное значение рейтинга фильма.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            //Проверяем можно ли конвертировать в тип double
            if (double.TryParse(RatingTextBox.Text, out double value))
            {
                //Проверяем диапозон числовых значении
                if (value < 0 || value > 10)
                {
                    RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                }
                else
                {
                    _currentMovie.Rating = value;
                    RatingTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            //Если нельзя, меняем цвет textBox
            else
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Ищет фильм с наибольшим рейтингом.
        /// </summary>
        /// <param name="_movies">Массив с объектамии класса Movie.</param>
        /// <returns>Возвращает индекс фильма с наибольшим рейтингом.</returns>
        private int FindMovieRating(Movie[] _movies)
        {
            double ratingMax = _movies[0].Rating;
            int index = 0;

            //Перебор рейтинга
            for (int i = 0; i < _movies.Length; i++)
            {
                //Нахождение индекса фильма с масимальным рейтингом
                if (_movies[i].Rating > ratingMax)
                {
                    ratingMax = _movies[i].Rating;
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Выбирает фильм с максимальным рейтингом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindMoviesButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = FindMovieRating(_movies);
            //Смена выбранного фильма на фильм с максимальным рейтингом
            MoviesListBox.SelectedIndex = selectedIndex;

        }
    }
}
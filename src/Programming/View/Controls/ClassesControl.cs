using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class ClassesControl : UserControl
    {
        //Создаем массив прямоугольников
        private Rectangle[] _rectangles1;

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
        public ClassesControl()
        {
            InitializeComponent();

            //Задаем рандомное значение длины и ширины прямоугольников 
            Random randomRec = new Random();
            int minRec = 1;
            int maxRec = 300;

            //Задаем рандомное значение рейтинга фильмов
            Random randomRating = new Random();
            double minRating = 0.0;
            double maxRating = 10.0;

            //Заполнение массива цветов
            colors = new string[5] { "Orange", "Red", "Green", "Yellow", "Blue" };

            //Заполнение массивов объектов фильма
            name = new string[5] { "FightClub", "Infinity", "IronMan", "Avangers", "Klaus" };
            genre = new string[5] { "Drama", "Biography", "Action", "Adventure", "Family" };
            year = new int[5] { 2000, 1996, 2005, 2012, 2019 };
            duration = new int[5] { 112, 93, 99, 154, 200 };

            //Заполнение массива прямоугольников
            _rectangles1 = new Rectangle[5];

            for (int index = 0; index < _rectangles1.Length; index++)
            {
                int randomLenght = randomRec.Next(minRec, maxRec + 1);
                int randomWeight = randomRec.Next(minRec, maxRec + 1);
                int NumberX = randomRec.Next(minRec, maxRec + 1);
                int NumberY = randomRec.Next(minRec, maxRec + 1);
                Point2D centerPoint = new Point2D(NumberX, NumberY);
                _rectangles1[index] = new Rectangle(randomLenght, randomWeight, colors[index]);
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

            // Заполняем ListBox названиями фильмов из массива
            MoviesListBox.Items.AddRange(name);
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
            if (selectedIndex >= 0 && selectedIndex < _rectangles1.Length)
            {
                //Устанавливаем текущий прямоугольник
                _currentRectangle = _rectangles1[selectedIndex];
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
                    IDTextBox.Text = _currentRectangle.ID.ToString();
                    break;

                //Если выбран "Rectangle2"
                case "Rectangle2":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    XTextBox.Text = _currentRectangle.Center.X.ToString();
                    YTextBox.Text = _currentRectangle.Center.Y.ToString();
                    IDTextBox.Text = _currentRectangle.ID.ToString();
                    break;

                //Если выбран "Rectangle3"
                case "Rectangle3":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    XTextBox.Text = _currentRectangle.Center.X.ToString();
                    YTextBox.Text = _currentRectangle.Center.Y.ToString();
                    IDTextBox.Text = _currentRectangle.ID.ToString();
                    break;

                //Если выбран "Rectangle4"
                case "Rectangle4":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    XTextBox.Text = _currentRectangle.Center.X.ToString();
                    YTextBox.Text = _currentRectangle.Center.Y.ToString();
                    IDTextBox.Text = _currentRectangle.ID.ToString();
                    break;

                //Если выбран "Rectangle5"
                case "Rectangle5":
                    LenghtTextBox.Text = _currentRectangle.Length.ToString();
                    WidthTextBox.Text = _currentRectangle.Width.ToString();
                    ColorTextBox.Text = _currentRectangle.Color.ToString();
                    XTextBox.Text = _currentRectangle.Center.X.ToString();
                    YTextBox.Text = _currentRectangle.Center.Y.ToString();
                    IDTextBox.Text = _currentRectangle.ID.ToString();
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
                _currentRectangle.Length = Convert.ToInt32(LenghtTextBox.Text);
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
                _currentRectangle.Width = Convert.ToInt32(WidthTextBox.Text);
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
            int selectedIndex = FindRectangleWithMaxWidth(_rectangles1);
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

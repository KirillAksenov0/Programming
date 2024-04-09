using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        //Создаем поле _currentRangle
        private Rectangle _currentRectangle;

        private bool clicked = false;

        //Создаем список прямоугольников
        private List<Rectangle> _rectangles;

        //Создаем список панели
        private List<Panel> _rectanglesPanels;

        //Массив цветов
        private string[] colors;
        public RectanglesCollisionControl()
        {

            InitializeComponent();

            //Инициаоизация списка прямоугольников.
            _rectangles = new List<Rectangle>();

            //Инициализация спсика панелей.
            _rectanglesPanels = new List<Panel>();

            //Заполнение массива цветов
            colors = new string[5] { "Orange", "Red", "Green", "Yellow", "Blue" };
        }
        /// <summary>
        /// Заполняет текстбоксы соответствующими значениями выбранного прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex != -1)
            {
                UpdateRectangleInfo();
            }

            else
            {
                ClearRectangleInfo();
            }
        }

        /// <summary>
        /// Обрабатывает неверно-введенные значения ширины прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthTextBox2_TextChanged(object sender, EventArgs e)
        {
            //Проверяем выбран ли элемент RectanglesListBox2.
            if (RectanglesListBox2.SelectedIndex != -1)
            {
                //Проверяем можно ли преобразовать ширину к типу double.
                if (!int.TryParse(WidthTextBox2.Text, out int width) || width < 0)
                {
                    WidthTextBox2.BackColor = System.Drawing.Color.LightPink; // Устанавливаем красный цвет фона
                }
                else
                {

                    _currentRectangle.Width = width;

                    _rectanglesPanels[RectanglesListBox2.SelectedIndex].Size =
                        new Size((int)_currentRectangle.Width, (int)_currentRectangle.Length);
                    FindCollisions();
                    WidthTextBox2.BackColor = SystemColors.Window; // Устанавливаем белый цвет фона
                }
                FindCollisions();

            }

            else
            {
                WidthTextBox2.Text = " ";

            }

            FindCollisions();
        }

        /// <summary>
        /// Обрабатывает неверно-введенные значения высоты прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox2_TextChanged(object sender, EventArgs e)
        {
            //Проверяем выбран ли элемент RectanglesListBox2.
            if (RectanglesListBox2.SelectedIndex != -1)
            {
                //Проверяем можно ли преобразовать высоту к типу double.
                if (!int.TryParse(HeightTextBox2.Text, out int height) || height < 0)
                {
                    HeightTextBox2.BackColor = System.Drawing.Color.LightPink; // Устанавливаем красный цвет фона
                }
                else
                {
                    _currentRectangle.Length = height;
                    _rectanglesPanels[RectanglesListBox2.SelectedIndex].Size =
                        new Size((int)_currentRectangle.Width, (int)_currentRectangle.Length);
                    FindCollisions();

                    HeightTextBox2.BackColor = SystemColors.Window; // Устанавливаем белый цвет фона
                }
                FindCollisions();
            }

            else
            {
                HeightTextBox2.Text = " ";

            }
            FindCollisions();
        }

        /// <summary>
        /// Ищет пересекающиеся прямоугольники.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglesPanels.Count; i++)
            {
                _rectanglesPanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    bool k = CollisionManager.IsCollision(_rectangles[i], _rectangles[j]);
                    if (k)
                    {
                        _rectanglesPanels[i].BackColor =
                            System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglesPanels[j].BackColor =
                            System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }

                }
            }
        }

        /// <summary>
        /// Очищает текстбоксы параметров прямоугольника.
        /// </summary>
        private void ClearRectangleInfo()
        {
            WidthTextBox2.Text = " ";
            HeightTextBox2.Text = " ";
            XTextBox2.Text = " ";
            YTextBox2.Text = " ";
            IDTextBox2.Text = " ";
        }

        /// <summary>
        /// Обновляет данные прямоугольника.
        /// </summary>
        private void UpdateRectangleInfo()
        {
            _currentRectangle = _rectangles[RectanglesListBox2.SelectedIndex];
            IDTextBox2.Text = _rectangles[RectanglesListBox2.SelectedIndex].ID.ToString();
            WidthTextBox2.Text = _rectangles[RectanglesListBox2.SelectedIndex].Width.ToString();
            HeightTextBox2.Text = _rectangles[RectanglesListBox2.SelectedIndex].Length.ToString();
            XTextBox2.Text = _rectangles[RectanglesListBox2.SelectedIndex].Center.X.ToString();
            YTextBox2.Text = _rectangles[RectanglesListBox2.SelectedIndex].Center.Y.ToString();
        }

        /// <summary>
        /// Перерисовывает PlusPictureBox для сокращения времени между кликами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusPictureBox_Click(object sender, EventArgs e)
        {
            clicked = true;
            PlusPictureBox.Invalidate(); // Перерисовать PictureBox
        }

        /// <summary>
        /// Добавляет прямоугольник на канву и список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (clicked)
            {
                Random randomRec = new Random();
                int minXY = 1;
                int maxXY = 300;

                int minWAndH = 10;
                int maxWandH = 110;

                int index = 0;

                Panel panel = new Panel();

                for (; index < 1; index++)
                {
                    int randomLenght = randomRec.Next(minWAndH, maxWandH + 1);
                    int randomWidth = randomRec.Next(minWAndH, maxWandH + 1);

                    Rectangle rec1 = RectangleFactory.Randomize(colors);
                    _currentRectangle = rec1;

                    //Добавление прямоугольника в список
                    _rectangles.Add(_currentRectangle);

                    //Добавление прямоугольника в RectangleListBox2
                    RectanglesListBox2.Items.Add($"{_currentRectangle.ID}: (X= {_currentRectangle.Center.X};" +
                        $" Y= {_currentRectangle.Center.Y}; W= {_currentRectangle.Width}; H= {_currentRectangle.Length})");

                    panel.Location = new Point(rec1.Center.X, rec1.Center.Y);
                    panel.Size = new Size(_currentRectangle.Width, _currentRectangle.Length);
                    panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

                    panel1.Controls.Add(panel);

                    // Добавляем панель в список панелей
                    _rectanglesPanels.Add(panel);

                    FindCollisions();
                }

                index = 0;

                clicked = false;
            }
        }

        /// <summary>
        /// Удаляет прямоугольник с канвы и из списка. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusPictureBox_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex != -1)
            {
                panel1.Controls.RemoveAt(RectanglesListBox2.SelectedIndex);
                _rectanglesPanels.RemoveAt(RectanglesListBox2.SelectedIndex);
                _rectangles.RemoveAt(RectanglesListBox2.SelectedIndex);
                RectanglesListBox2.Items.RemoveAt(RectanglesListBox2.SelectedIndex);

                FindCollisions();
            }
        }


    }
}

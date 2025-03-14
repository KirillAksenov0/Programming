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
    public partial class EnumsGroupBoxWeekdayControl : UserControl
    {
        public EnumsGroupBoxWeekdayControl()
        {
            InitializeComponent();
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
    }
}

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
    public partial class EnumsSeasonHandleControl : UserControl
    {
        public EnumsSeasonHandleControl()
        {
            InitializeComponent();
            FillingSeasonComboBox();
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

                    
                    SeasonLabel.Text = "Ура! Лето!";
                    GoButton.BackColor = SystemColors.Control;
                    break;

                //Выбран "Autumn"
                case "Autumn":
                    SeasonLabel.Text = " ";
                    GoButton.BackColor = System.Drawing.Color.SandyBrown;
                    break;

                //Выбран "Winter"
                case "Winter":
                    
                    SeasonLabel.Text = "Бррр! Холодно!";
                    GoButton.BackColor = SystemColors.Control;
                    break;

                //Выбран "Spring"
                case "Spring":

                    SeasonLabel.Text = "";
                    GoButton.BackColor = System.Drawing.Color.Green;
                    break;

                //Нечего не выбрано
                case "":
                    SeasonLabel.Text = "Выберите время года";
                    break;

                //Выбрано что то другое
                default:
                    
                    SeasonLabel.Text = "Нет такого времени года";
                    break;
            }
        }


    }
}

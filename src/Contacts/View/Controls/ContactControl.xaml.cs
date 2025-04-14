using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml.
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Допустимые символы для номера телефона.
        /// </summary>
        private static readonly Regex _allowedPhoneNumber = new Regex(@"^[0-9\-\(\)\.\+]+$");

        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Запрещает ввод недопустимых символов в поле "PhoneNumber".
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Текст, введенный пользователем.</param>
        private void PhoneNumberReviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsPhoneNumberAllowed(e.Text);
        }

        /// <summary>
        /// Предотвращает копирование недопустимых символов.
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Текст, вставленный пользователем.</param>
        private void PhoneNumberPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsPhoneNumberAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        /// <summary>
        /// Проверяет, содержит ли номер телефона недопустимые символы.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <returns>true, если номер не содержит недопустимых символов,
        /// иначе false.</returns>
        private bool IsPhoneNumberAllowed(String phoneNumber)
        {
            return _allowedPhoneNumber.IsMatch(phoneNumber);
        }
    }
}

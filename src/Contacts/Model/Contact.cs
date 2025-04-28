using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;
using Model.Services;

namespace Model
{
    /// <summary>
    /// Хранит данные контакта.
    /// </summary>
    public partial class Contact : ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        [ObservableProperty]
        private string _phoneNumber;

        /// <summary>
        /// Электронная почта.
        /// </summary>
        [ObservableProperty]
        private string _email;

        /// <summary>
        /// Шаблон допустимого номера телефона.
        /// </summary>
        private string _phoneNumberPattern = "^\\+?\\d{1,4}?[-.\\s]?" +
            "\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$";

        /// <summary>
        /// Шаблон допустимой электронной почты.
        /// </summary>
        private string _emailPattern = "^\\S+@\\S+\\.\\S+$";

        /// <summary>
        /// Возвращает валидацию свойств класса Contact.
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Name":
                        if (!ValueValidator.NullOnEmptyStringMatching(Name))
                        {
                            error = "Name must not be empty";
                        }
                        else if (!ValueValidator.StringLengthMatching(Name, 100))
                        {
                            error = "Name must be less than 100 characters";
                        }
                        break;
                    case "PhoneNumber":
                        if (!ValueValidator.NullOnEmptyStringMatching(PhoneNumber))
                        {
                            error = "PhoneNumber must not be empty";
                        }
                        else if (!ValueValidator.PatternMatching(PhoneNumber, 
                            _phoneNumberPattern))
                        {
                            error = "Invalid phone number format";
                        }
                        break;
                    case "Email":
                        if (!ValueValidator.NullOnEmptyStringMatching(Email))
                        {
                            error = "Email must not be empty";
                        }
                        else if (!ValueValidator.PatternMatching(Email, _emailPattern))
                        {
                            error = "Invalid email format";
                        }
                        else if (!ValueValidator.StringLengthMatching(Email, 100))
                        {
                            error = "Email must be less than 100 characters";
                        }
                        break;

                }
                return error;
            }
        }

        /// <summary>
        /// Возвращает значение при ошибке.
        /// </summary>
        public string Error => null;
    }
}

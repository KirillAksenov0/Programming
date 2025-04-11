using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Text.RegularExpressions;

namespace View.ViewModel.Services
{
    /// <summary>
    /// Хранит данные контакта.
    /// </summary>
    public class Contact : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Электронная почта.
        /// </summary>
        private string _email;

        private string _phoneNumberPattern = "^\\+?\\d{1,4}?[-.\\s]?" +
            "\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$";

        private string _emailPattern = "^\\S+@\\S+\\.\\S+$";

        /// <summary>
        /// Извещает систему об изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }   
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                _phoneNumber = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Name":
                        if (ValueValidator.NullOnEmptyStringMatching(Name))
                        {
                            error = "Name must not be empty";
                        }
                        else if (ValueValidator.StringLengthMatching(Name, 100))
                        {
                            error = "Name must be less than 100 characters";
                        }
                        break;
                    case "PhoneNumber":
                        if (ValueValidator.NullOnEmptyStringMatching(PhoneNumber))
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
                        if (ValueValidator.NullOnEmptyStringMatching(Email))
                        {
                            error = "Email must not be empty";
                        }
                        else if (!ValueValidator.PatternMatching(Email, _emailPattern))
                        {
                            error = "Invalid email format";
                        }
                        break;

                }
                return error;
            }
        }

        public string Error => null;

        /// <summary>
        /// Отслеживает изменение значении свойства.
        /// </summary>
        /// <param name="prop"></param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}

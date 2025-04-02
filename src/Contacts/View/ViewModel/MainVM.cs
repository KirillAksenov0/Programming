using Newtonsoft.Json.Linq;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using View.ViewModel;
using View.ViewModel.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Содержит VM для главного окна.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Выбранный контакт человка.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Редактируемый контакт человека.
        /// </summary>
        private Contact _editableContact;

        /// <summary>
        /// Флаг режима редактирования.
        /// </summary>
        private bool _isEditing = false;

        /// <summary>
        /// Флаг режима добавления.
        /// </summary>
        private bool _isAdding = false;

        /// <summary>
        /// Извещает систему об изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();

        /// <summary>
        /// Возвращает условие для режима редактирования.
        /// </summary>
        public bool IsEditEnabled
        {
            get => SelectedContact != null && !_isEditing;
        }

        /// <summary>
        /// Возвращает и задает выбранный контакт человека.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (_isEditing) // Отменяем изменения при выборе другого контакта
                {
                    CancelEdit();
                }

                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));

                if (!_isAdding && _selectedContact != null)
                {
                    _editableContact = new Contact
                    {
                        Name = _selectedContact.Name,
                        PhoneNumber = _selectedContact.PhoneNumber,
                        Email = _selectedContact.Email
                    };
                }
                else
                {
                    _editableContact = null;
                }

                OnPropertyChanged(nameof(EditableContact));
            }
        }

        /// <summary>
        /// Возвращает и задает редактируемый контакт человека.
        /// </summary>
        public Contact EditableContact
        {
            get => _editableContact;
            set
            {
                _editableContact = value;
                OnPropertyChanged(nameof(EditableContact));
            }
        }

        /// <summary>
        /// Возвращает и задает флаг режима редактирования.
        /// </summary>
        public bool IsEditing
        {
            get => _isEditing;
            set
            {
                _isEditing = value;
                OnPropertyChanged(nameof(IsEditing));
                OnPropertyChanged(nameof(IsReadOnly));
                OnPropertyChanged(nameof(IsVisibility));
            }
        }

        /// <summary>
        /// Возвращает и задает флаг режима добавления.
        /// </summary>
        public bool IsAdding
        {
            get => _isAdding;
            set
            {
                _isAdding = value;
                OnPropertyChanged(nameof(IsAdding));
                OnPropertyChanged(nameof(IsReadOnly));
                OnPropertyChanged(nameof(IsVisibility));
            }
        }

        /// <summary>
        /// Возвращает флаг, показывающий доступны ли поля.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return !(IsEditing || IsAdding);
            }
        }

        /// <summary>
        /// Возвращает флаг, показывающий отображается ли кнопка.
        /// </summary>
        public bool IsVisibility
        {
            get
            {
                return (IsAdding || IsEditing);
            }
        }

        /// <summary>
        /// Возвращает команду добавления контакта.
        /// </summary>
        public RelayCommand AddCommand { get; }

        /// <summary>
        /// Возвращает команду редактирования контакта.
        /// </summary>
        public RelayCommand EditCommand { get; }

        /// <summary>
        /// Возвращает команду удаления контакта.
        /// </summary>
        public RelayCommand RemoveCommand { get; }

        /// <summary>
        /// Возвращает команду принятия изменений контакта.
        /// </summary>
        public RelayCommand ApplyCommand { get; }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM">. 
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.LoadContact();

            AddCommand = new RelayCommand(execute => AddContact(), canExecute => !IsEditing);
            EditCommand = new RelayCommand(execute => EditContact(), canExecute => IsEditEnabled);
            RemoveCommand = new RelayCommand(execute => RemoveContact(), canExecute => SelectedContact != null);
            ApplyCommand = new RelayCommand(execute => ApplyContactChanges(), canExecute => true);
        }

        /// <summary>
        /// Добавляет контакт в список.
        /// </summary>
        private void AddContact()
        {
            CancelEdit(); 

            EditableContact = new Contact();
            IsAdding = true;
            IsEditing = true;
        }

        /// <summary>
        /// Редактирует выбранный контакт.
        /// </summary>
        private void EditContact()
        {
            if (SelectedContact == null) return;

            EditableContact = new Contact
            {
                Name = SelectedContact.Name,
                PhoneNumber = SelectedContact.PhoneNumber,
                Email = SelectedContact.Email
            };

            IsEditing = true;
        }

        /// <summary>
        /// Принимает изменения выбранного контакта.
        /// </summary>
        private void ApplyContactChanges()
        {
            if (EditableContact == null)
                return;

            if (IsAdding) 
            {
                Contacts.Add(EditableContact);
                SelectedContact = EditableContact; 
            }
            else if (SelectedContact != null) 
            {
                SelectedContact.Name = EditableContact.Name;
                SelectedContact.PhoneNumber = EditableContact.PhoneNumber;
                SelectedContact.Email = EditableContact.Email;

                var index = Contacts.IndexOf(SelectedContact);
                if (index >= 0)
                {
                    Contacts[index] = SelectedContact; 
                    OnPropertyChanged(nameof(Contacts));
                }
            }

            ContactSerializer.SaveContact(Contacts);
            IsEditing = false;
            IsAdding = false;
        }

        /// <summary>
        /// Удаляет выбранный контакт.
        /// </summary>
        private void RemoveContact()
        {
            if (SelectedContact == null)
                return;

            int selectedIndex = Contacts.IndexOf(SelectedContact);

            Contacts.Remove(SelectedContact);

            if (Contacts.Count > 0)
            {
                if (selectedIndex >= Contacts.Count)
                {
                    SelectedContact = Contacts[Contacts.Count - 1];
                }
                else
                {
                    SelectedContact = Contacts[selectedIndex];
                }
            }
            else
            {
                SelectedContact = null;
            }

            ContactSerializer.SaveContact(Contacts);
            OnPropertyChanged(nameof(Contacts));
        }

        /// <summary>
        /// Отменяет изменения контакта.
        /// </summary>
        private void CancelEdit()
        {
            IsEditing = false;
            IsAdding = false;
            EditableContact = null;

        }

        /// <summary>
        /// Отслеживает изменение значении свойства.
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

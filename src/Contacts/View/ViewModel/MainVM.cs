using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;
using View.ViewModel;
using View.ViewModel.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Содержит VM для главного окна.
    /// </summary>
    public class MainVM : ObservableObject
    {
        /// <summary>
        /// Выбранный контакт человка.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Копия выбранного контакта.
        /// </summary>
        private Contact _originalContact;

        /// <summary>
        /// Флаг режима редактирования.
        /// </summary>
        private bool _isEditing = false;

        /// <summary>
        /// Флаг режима добавления.
        /// </summary>
        private bool _isAdding = false;

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
            get
            {
                return _selectedContact;
            }
            set
            {

                if (_selectedContact != value)
                {
                    if (IsAdding || IsEditing)
                    {
                        CancelEdit();
                    }
                    _selectedContact = value;
                    OnPropertyChanged();

                    // Уведомляем команды, что их CanExecute мог измениться
                    EditCommand.NotifyCanExecuteChanged();
                    RemoveCommand.NotifyCanExecuteChanged();
                    ApplyCommand.NotifyCanExecuteChanged();
                }
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

                // Уведомляем команды
                EditCommand.NotifyCanExecuteChanged();
                AddCommand.NotifyCanExecuteChanged();

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
            Contacts = ContactSerializer.LoadContact() ?? new ObservableCollection<Contact>();

            AddCommand = new RelayCommand(AddContact, () => !IsEditing);
            EditCommand = new RelayCommand(EditContact, () => IsEditEnabled);
            RemoveCommand = new RelayCommand( RemoveContact, () => 
            SelectedContact != null);
            ApplyCommand = new RelayCommand(ApplyContactChanges, () => CanApply());
        }

        /// <summary>
        /// Добавляет контакт в список.
        /// </summary>
        private void AddContact()
        {
            _originalContact = null;
            SelectedContact = new Contact();
            SelectedContact.PropertyChanged += OnSelectedContactPropertyChanged;
            IsAdding = true;
            IsEditing = true;
        }

        /// <summary>
        /// Редактирует выбранный контакт.
        /// </summary>
        private void EditContact()
        {
            if (SelectedContact == null)
            {
                return;
            }

            _originalContact = new Contact
            {
                Name = SelectedContact.Name,
                PhoneNumber = SelectedContact.PhoneNumber,
                Email = SelectedContact.Email
            };

            SelectedContact.PropertyChanged += OnSelectedContactPropertyChanged;
            IsEditing = true;
        }

        /// <summary>
        /// Принимает изменения выбранного контакта.
        /// </summary>
        private void ApplyContactChanges()
        {
            if(IsAdding)
            {
                Contacts.Add(SelectedContact);
                IsAdding = false;
            }

            if (IsEditing)
            {
                IsEditing = false;
                _originalContact = null;
            }
        }

        /// <summary>
        /// Удаляет выбранный контакт.
        /// </summary>
        private void RemoveContact()
        {
            if (SelectedContact == null)
            {
                return;
            }

            int selectedIndex = Contacts.IndexOf(SelectedContact);

            Contacts.Remove(SelectedContact);

            if (Contacts.Count > 0)
            {
                if (selectedIndex >= Contacts.Count)
                {
                    SelectedContact = Contacts[Contacts.Count - 1];
                }
                else if (selectedIndex < 0)
                {
                    SelectedContact = Contacts[0];
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

            OnPropertyChanged(nameof(Contacts));
        }

        /// <summary>
        /// Отменяет изменения контакта.
        /// </summary>
        private void CancelEdit()
        {
            if (_originalContact != null)
            {
                SelectedContact.Name = _originalContact.Name;
                SelectedContact.PhoneNumber = _originalContact.PhoneNumber;
                SelectedContact.Email = _originalContact.Email;
            }
            IsEditing = false;
            IsAdding = false;
        }

        /// <summary>
        /// Задает условия доступности кнопки Apply.
        /// </summary>
        /// <returns></returns>
        private bool CanApply()
        {
            return SelectedContact == null ||
                (string.IsNullOrWhiteSpace(SelectedContact[nameof(SelectedContact.Name)])
                && string.IsNullOrWhiteSpace(SelectedContact[nameof(SelectedContact.PhoneNumber)])
                && string.IsNullOrWhiteSpace(SelectedContact[nameof(SelectedContact.Email)]));
        }

        private void OnSelectedContactPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // При изменении любого свойства контакта обновляем состояние ApplyCommand
            ApplyCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Сохраняет данные при закрытии приложения.
        /// </summary>
        public void SaveOnExit()
        {
           ContactSerializer.SaveContact(Contacts);
        }
    }
}

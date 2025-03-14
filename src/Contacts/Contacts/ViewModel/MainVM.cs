using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

/// <summary>
/// Содержит VM для главного окна.
/// </summary>
public class MainVM : INotifyPropertyChanged
{
    /// <summary>
    /// Имя контакта.
    /// </summary>
    private string _name = "Юрfg";

    /// <summary>
    /// Номер телефона.
    /// </summary>
    private string _phoneNumber = "+7-345-24";

    /// <summary>
    /// Электронная почта.
    /// </summary>
    private string _email = "yrii.smirnov@jjf.com";

    /// <summary>
    /// Текущий контакт человека.
    /// </summary>
    private Contact _currentContact;

    /// <summary>
    /// Команда сохранения контакта человека.
    /// </summary>
    private SaveCommand _saveCommand;

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
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    /// <summary>
    /// Возвращает и задает номер телефона.
    /// </summary>
    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set
        {
            _phoneNumber = value;
            OnPropertyChanged(nameof(PhoneNumber));
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
            OnPropertyChanged(nameof(Email));
        }
    }

    /// <summary>
    /// Возвращает и задает текущий контакт человека.
    /// </summary>
    public Contact CurrentContact
    {
        get
        {
            return _currentContact;
        }
        set
        {
            _currentContact = new Contact(Name, PhoneNumber, Email);
            OnPropertyChanged(nameof(Contact));
        }
    }

    /// <summary>
    /// Возвращает и задает команду сохранения контакта человека.
    /// </summary>
    public SaveCommand SaveCommand
    {
        get
        {

            return _saveCommand ?? (_saveCommand = new SaveCommand(obj =>
            {
                CurrentContact = new Contact(Name, PhoneNumber, Email);
                ContactSerializer.SaveContact(CurrentContact);
            }));
        }
    }

    /// <summary>
    /// Возвращает и задает команду загрузки контакта человека.
    /// </summary>
    public LoadCommand LoadCommand { get; }

    /// <summary>
    /// Извещает систему об изменении свойства.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Создает экземпляр класса <see cref="MainVM">.
    /// </summary>
    public MainVM()
    {
        CurrentContact = new Contact(Name, PhoneNumber, Email);

        LoadCommand = new LoadCommand(this);
    }

    /// <summary>
    /// Отслеживает изменение значении свойства.
    /// </summary>
    /// <param name="prop"></param>
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }
}

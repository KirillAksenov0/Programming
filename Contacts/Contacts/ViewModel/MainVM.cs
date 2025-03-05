using System.ComponentModel;
using System.Runtime.CompilerServices;

/// <summary>
/// Содержит VM для главного окна.
/// </summary>
public class MainVM : INotifyPropertyChanged
{
    /// <summary>
    /// Имя контакта.
    /// </summary>
    private string _name = "Юрий Смирнов";

    /// <summary>
    /// Номер телефона.
    /// </summary>
    private string _phoneNumber = "+7-913-233-67-23";

    /// <summary>
    /// Электронная почта.
    /// </summary>
    private string _email = "yri.smirnov@mail.com";

    /// <summary>
    /// Контакт человека.
    /// </summary>
    private Contact _contact;

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
            OnPropertyChanged("Name");
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
            OnPropertyChanged("PhoneNumber");
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
            OnPropertyChanged("Email");
        }
    }

    /// <summary>
    /// Возвращает и задает контакт человека.
    /// </summary>
    public Contact Contact
    {
        get
        {
            return _contact;
        }
        set
        {
            _contact = new Contact(Name, PhoneNumber, Email);
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }
}

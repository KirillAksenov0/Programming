/// <summary>
/// Хранит контакт пользователя.
/// </summary>
public class Contact
{
    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Фамилия пользователя.
    /// </summary>
    public string Surname { get; set; }

    /// <summary>
    /// Номер телефона пользователя.
    /// </summary>
    private string _number;

    /// <summary>
    /// Возвращает и задает номер телефона пользователя.
    /// </summary>
    public string Number
    {
        get
        {
            return _number;
        }
        set
        {
            if (decimal.TryParse(value, out decimal number ) == true)
            {
                throw new ArgumentException();
            }
            _number = value;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Contact"/>.
    /// </summary>
    /// <param name="name">Имя пользователя.</param>
    /// <param name="surname">Фамилия пользователя.</param>
    /// <param name="number">Номер телефона человека. Должен состоять только из цифр.</param>
    public Contact(string name, string surname, string number)
    {
        Name = name;
        Surname = surname;
        Number = number;
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Contact"/> без инициализации полей.
    /// </summary>
    public Contact()
    {
        Name = "none";
        Surname = "none";
        Number = "none";
    }
}

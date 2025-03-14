using System.Security;
/// <summary>
/// Хранит контакт пользователя.
/// </summary>
public class Contact
{
    /// <summary>
    /// Имя пользователя.
    /// </summary>
    private string _name;

    /// <summary>
    /// Фамилия пользователя.
    /// </summary>
    private string _surname;

    /// <summary>
    /// Номер телефона пользователя.
    /// </summary>
    private string _number;

    /// <summary>
    /// Возвращает и задает имя пользователя.
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            AssertStringContainsOnlyLetters(value, "Name");
            _name = value;
        }
    }

    /// <summary>
    /// Возвращает и задает фамилию пользователя.
    /// </summary>
    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            AssertStringContainsOnlyLetters(value, "Surname");
            _name = value;
        }
    }
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
    /// Проверяет состоит ли строка только из букв английского алфавита.
    /// </summary>
    /// <param name="value">Входная строка.</param>
    /// <param name="propertyName">Название свойства. Должно состоять только из букв.</param>
    /// <exception cref="ArgumentException">Выводит ошибку, если в строке оказалась не буква.
    /// </exception>
    private void AssertStringContainsOnlyLetters(string value, string propertyName)
    {
        foreach (char c in value)
        {
            // Проверяем, является ли символ буквой английского алфавита
            if (!char.IsLetter(c))
            {
                throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. " +
                    $"Допускаются только символы английского алфавита.");
            }
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

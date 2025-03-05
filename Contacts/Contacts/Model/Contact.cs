/// <summary>
/// Хранит данные контакта.
/// </summary>
public class Contact
{
    /// <summary>
    /// Имя контакта.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Номер телефона.
    /// </summary>
    private string _phonNumber { get; set;}

    /// <summary>
    /// Электронная почта.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Возвращает и задает номер телефона.
    /// </summary>
    public string PhonNumber
    {
        get
        {
            return _phonNumber;
        }

        set
        {
            _phonNumber = value;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Contact">.
    /// </summary>
    /// <param name="name">Имя контакта.</param>
    /// <param name="phoneNumber">Номер телефона.</param>
    /// <param name="email">Электронная почта.</param>
    public Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        _phonNumber = phoneNumber;
        Email = email;
    }

}

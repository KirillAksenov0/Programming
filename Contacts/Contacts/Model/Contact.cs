/// <summary>
/// Хранит данные контакта.
/// </summary>
public class Contact
{
    /// <summary>
    /// Возвращает и задает имя контакта.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Возвращает и задает номер телефона.
    /// </summary>
    public string PhoneNumber { get; set;}

    /// <summary>
    /// Возвращает и задает электронную почту.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Создает экземпляр класса <see cref="Contact">.
    /// </summary>
    /// <param name="name">Имя контакта.</param>
    /// <param name="phoneNumber">Номер телефона.</param>
    /// <param name="email">Электронная почта.</param>
    public Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

}

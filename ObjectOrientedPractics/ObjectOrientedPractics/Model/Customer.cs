/// <summary>
/// Хранит данные о покупателе.
/// </summary>
public class Customer
{
    /// <summary>
    /// ID покупателя.
    /// </summary>
    private static int _id = 0;

    /// <summary>
    /// Полное имя покупателя.
    /// </summary>
    private string _fullname;

    /// <summary>
    /// Адресс доставки.
    /// </summary>
    private Address _address = new Address();

    /// <summary>
    /// Возвращает и задает ID.
    /// </summary>
    public int ID { get; private set; }
    /// <summary>
    /// Возвращает и задает полное имя покупателя.
    /// </summary>
    public string FullName
    {
        get
        {
            return _fullname;
        }

        set
        {
            ValueValidator.AssertStringOnLength(value, 200, "Fullname");
            if (value.Length == 0)
            {
                throw new Exception("Full Name не должен быть пустым");
            }
            _fullname = value;
        }
    }

    public Address CustomerAddress
    {
        get { return _address; }
        set
        {
            _address = value;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Customer">
    /// </summary>
    /// <param name="fullname">Полное имя покупателя. Длина не должна привышать 200 символов.</param>
    /// <param name="address">Адресс доставки. Должен иметь тип Address.</param>
    public Customer(string  fullname, Address address)
    {
        ID = _id++;
        FullName = fullname;
        CustomerAddress = address;
    }
}

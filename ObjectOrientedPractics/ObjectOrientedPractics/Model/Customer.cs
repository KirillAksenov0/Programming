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
    private string _address;

    /// <summary>
    /// Возвращает и задает ID.
    /// </summary>
    public int ID { get; private set; }
    /// <summary>
    /// Возвращает и задает полное имя покупателя.
    /// </summary>
    public string Fullname
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

    /// <summary>
    /// Возвращает и задает адресс доставки.
    /// </summary>
    public string Address
    {
        get
        {
            return _address;
        }

        set
        {
            ValueValidator.AssertStringOnLength(value, 500, "Address");
            _address = value;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Customer">
    /// </summary>
    /// <param name="fullname">Полное имя покупателя. Длина не должна привышать 200 символов.</param>
    /// <param name="address">Адресс доставки. Длина не должна привышать 500 символов.</param>
    public Customer(string  fullname, string address)
    {
        ID = _id++;
        Fullname = fullname;
        Address = address;
    }
}

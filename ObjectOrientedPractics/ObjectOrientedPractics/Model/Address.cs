/// <summary>
/// Хранит данные об адрессе.
/// </summary>
public class Address
{
    /// <summary>
    /// Почтовый индекс.
    /// </summary>
    private int _index;

    /// <summary>
    /// Название страны.
    /// </summary>
    private string _country;

    /// <summary>
    /// Название города.
    /// </summary>
    private string _city;

    /// <summary>
    /// Название улицы.
    /// </summary>
    private string _street;

    /// <summary>
    /// Номер дома.
    /// </summary>
    private string _building;

    /// <summary>
    /// Номер квартиры.
    /// </summary>
    private string _apartment;

    /// <summary>
    /// Возвращает и задает почтовый индекс.
    /// </summary>
    public int Index
    {
        get
        {
            return _index;
        }
        set
        {
            if (value < 99999 || value > 999999 || value <= 0)
            {
                throw new Exception("Index должен быть целым шестизначным числом");
            }
            else
            {
                _index = value;
            }
        }
    }

    /// <summary>
    /// Возвращает и задает название страны.
    /// </summary>
    public string Country
    {
        get
        {
            return _country;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 50, "Country");
            _country = value;
        }
    }

    /// <summary>
    /// Возвращает и задает название города.
    /// </summary>
    public string City
    {
        get
        {
            return _city;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 50, "City");
            _city = value;
        }
    }

    /// <summary>
    /// Возвращает и задает название улицы.
    /// </summary>
    public string Street
    {
        get
        {
            return _street;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 100, "Street");
            _street = value;
        }
    }

    /// <summary>
    /// Возвращает и задает номер дома.
    /// </summary>
    public string Building
    {
        get
        {
            return _building;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 10, "Building");
            _building = value;
        }
    }

    /// <summary>
    /// Возвращает и задает номер квартиры.
    /// </summary>
    public string Apartment
    {
        get
        {
            return _apartment;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 10, "Apartment");
            _apartment = value;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Address"> по умолчанию.
    /// </summary>
    public Address()
    {
        Index = 100000;
        Country = "";
        City = "";
        Street = "";
        Building = "";
        Apartment = "";
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Address">.
    /// </summary>
    /// <param name="index">Почтовый индекс. Целое шестизначное число.</param>
    /// <param name="country">Название страны. Строка длиной не более 50 символов.</param>
    /// <param name="city">Название города. Строка длиной не более 50 символов.</param>
    /// <param name="street">Название улицы. Строка длиной не более 100 символов.</param>
    /// <param name="building">Номер дома. Строка длиной не более 10 символов.</param>
    /// <param name="apartment">Номер квартиры. Строка длиной не более 10 символов.</param>
    public Address(int index, string country, string city, string street, string building, 
        string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
    }
}

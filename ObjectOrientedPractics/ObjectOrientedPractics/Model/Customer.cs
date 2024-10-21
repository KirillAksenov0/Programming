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
    /// Корзина покупателя.
    /// </summary>
    private Cart _cart;

    /// <summary>
    /// Список заказов.
    /// </summary>
    private List<Order> _orderList = new List<Order>();

    /// <summary>
    /// Преоритетность покупателя.
    /// </summary>
    private bool _isPriority = false;  

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

    /// <summary>
    /// Возвращает и задает адресс доставки.
    /// </summary>
    public Address CustomerAddress
    {
        get { return _address; }
        set
        {
            _address = value;
        }
    }

    /// <summary>
    /// Возвращает и задает корзину покупателя.
    /// </summary>
    public Cart CustomerCart
    {
        get
        {
            return _cart;
        }
        set
        {
            _cart = value;
        }
    }

    /// <summary>
    /// Возвращает и задает список заказов.
    /// </summary>
    public List<Order> OrderList
    {
        get { return _orderList; }
        set { _orderList = value; }
    }

    /// <summary>
    /// Возвращает и задает преоритетность покупателя.
    /// </summary>
    public bool IsPriority
    {
        get
        {
            return _isPriority;
        }
        set
        {
            _isPriority = value;
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
        CustomerCart = new Cart();
    }
}

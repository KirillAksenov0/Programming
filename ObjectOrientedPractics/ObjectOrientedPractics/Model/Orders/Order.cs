/// <summary>
/// Хранит данные о заказе.
/// </summary>
public class Order
{
    /// <summary>
    /// ID товара.
    /// </summary>
    private static int _id = 0;

    /// <summary>
    /// Адресс доставки.
    /// </summary>
    private protected Address _deliveryAddress;

    /// <summary>
    /// Дата создания заказа.
    /// </summary>
    private protected DateTime _orderData;

    /// <summary>
    /// Список товаров.
    /// </summary>
    private protected List<Item> _items = new List<Item>();

    /// <summary>
    /// Общая стоимость товаров.
    /// </summary>
    private protected double _amountCost;

    /// <summary>
    /// Имя покупателя.
    /// </summary>
    private protected string _customerFullName;

    /// <summary>
    /// Размер примененной скидки.
    /// </summary>
    private double _discountAmount;

    /// <summary>
    /// Конечная стоимость заказа.
    /// </summary>
    private double _total;

    /// <summary>
    /// Возвращает и задает ID.
    /// </summary>
    public int ID { get; private set; }
    
    /// <summary>
    /// Возвращает адресс доставки.
    /// </summary>
    public Address DeliveryAddress
    {
        get
        { return _deliveryAddress; }
        set { _deliveryAddress = value; }
    }

    /// <summary>
    /// Возвращает и задает дату создания заказа.
    /// </summary>
    public DateTime OrderDate
    { 
        get 
        {
            return _orderData;
        }
        set
        { _orderData = value; }
    }

    /// <summary>
    /// Возвращает и задает список товаров.
    /// </summary>
    public List<Item> Items
    {
        get { return _items; }
        set { _items = value; }
    }

    /// <summary>
    /// Возвращает и задает статус заказа.
    /// </summary>
    public OrderStatus OrderStatus { get; set; }

    /// <summary>
    /// Возвращает и задает имя покупателя.
    /// </summary>
    public string CustomerFullName
    {
        get
        { return _customerFullName; }
        set
        { _customerFullName = value; }
    }

    /// <summary>
    /// Возвращает и задает общую стоимость товаров заказа.
    /// </summary>
    public double ItemsAmount { get;set;}

    /// <summary>
    /// Возвращает и задает размер примененной скидки.
    /// </summary>
    public double DiscountAmount
    {
        get
        {
            return _discountAmount;
        }
        set
        { _discountAmount = value; }
    }

    /// <summary>
    /// Возвращает и задает конечную стоимость заказа.
    /// </summary>
    public double Total
    {
        get
        {
            return ItemsAmount - DiscountAmount;
        }
       
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Order">
    /// </summary>
    /// <param name="address">Адресс доставки заказа.</param>
    /// <param name="items">Список товаров.</param>
    public Order( List<Item> items, Address deliveryAddress, string customerFullName, double itemsAmount)
    {
        ID = _id++;
        OrderDate = DateTime.Now;
        DeliveryAddress = deliveryAddress;

        foreach (Item item in items)
        {
            Items.Add(item);
        }

        DeliveryAddress = deliveryAddress;
        OrderStatus = OrderStatus.New;
        CustomerFullName = customerFullName;
        ItemsAmount = itemsAmount;
    }

}

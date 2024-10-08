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
    private Address _deliveryAddress;

    /// <summary>
    /// Дата создания заказа.
    /// </summary>
    private static DateTime _orderData;

    /// <summary>
    /// Список товаров.
    /// </summary>
    private List<Item> _items;

    /// <summary>
    /// Общая стоимость товаров.
    /// </summary>
    private double _amountCost;

    /// <summary>
    /// Возвращает и задает ID.
    /// </summary>
    public int ID
    {
        get
        {
            return _id;
        }
        private set
        {
            _id = value;
        }
        
    }

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
    /// Возвразщает общую стоимость товаров.
    /// </summary>
    public double AmountCost
    {
        get
        {
            double amountCostItems = 0;
            if (Items.Count == 0 || Items == null)
            {
                return 0.0;
            }
            else
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    amountCostItems += Items[i].Cost;
                }

                return amountCostItems;
            }
        }
    }

    /// <summary>
    /// Возвращает и задает статус заказа.
    /// </summary>
    public OrderStatus OrderStatus { get; set; }

    /// <summary>
    /// Создает экземпляр класса <see cref="Order">
    /// </summary>
    /// <param name="address">Адресс доставки заказа.</param>
    /// <param name="items">Список товаров.</param>
    public Order( List<Item> items, Address deliveryAddress)
    {
        ID = _id++;
        OrderDate = DateTime.Now;
        DeliveryAddress = deliveryAddress;
        Items = items;
        DeliveryAddress = deliveryAddress;
        OrderStatus = OrderStatus.New;
    }

}

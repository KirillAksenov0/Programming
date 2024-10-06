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
    /// Дата создания закааз.
    /// </summary>
    private static DateTime _orderData;

    /// <summary>
    /// Возвращает и задает адресс доставки.
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Возвращает и задает список товаров.
    /// </summary>
    public List<Item> Items { get; set; }

    /// <summary>
    /// Возвращает и задает общую стоимость товаров.
    /// </summary>
    public double AmountCostItems
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
    /// Возвращает и задает ID заказа.
    /// </summary>
    public int ID 
    {
        get { return _id; }
        private set { _id = value; }
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
        private set
        {
            _orderData = value;
        }
    }

    /// <summary>
    /// Возвращает и задает статус заказа.
    /// </summary>
    public OrderStatus Status { get; set; }

    /// <summary>
    /// Создает экземпляр класса <see cref="Order">
    /// </summary>
    /// <param name="address">Адресс доставки заказа.</param>
    /// <param name="items">Список товаров.</param>
    public Order(string address, List<Item> items)
    {
        ID = _id++;
        OrderDate = DateTime.Now;
        Address = address;
        Items = items;
    }

}

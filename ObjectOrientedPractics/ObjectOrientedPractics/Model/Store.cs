/// <summary>
/// Хранит данные всех товаров и покупателей.
/// </summary>
public class Store
{ 
    /// <summary>
    /// Товары.
    /// </summary>
    private List<Item> _items;

    /// <summary>
    /// Покупатели.
    /// </summary>
    private List<Customer> _customeers;

    /// <summary>
    /// Возвращает и задает список товаров.
    /// </summary>
    public List<Item> Items
    {
        get { return _items; }
        set { _items = value; }
    }

    /// <summary>
    /// Возвращает и задает список покупателей.
    /// </summary>
    public List<Customer> Customers
    { 
        get { return _customeers; }
        set { _customeers = value; }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Store">.
    /// </summary>
    public Store()
    {
        Items = new List<Item>();
        Customers = new List<Customer>();
    }
}



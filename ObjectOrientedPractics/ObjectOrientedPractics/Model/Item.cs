 /// <summary>
 /// Хранит данные о товаре.
 /// </summary>
public class Item
{
    /// <summary>
    /// ID товара.
    /// </summary>
    private static int _id = 0;

    /// <summary>
    /// Название товара.
    /// </summary>
    private string _name;

    /// <summary>
    /// Описание товара.
    /// </summary>
    private string _info;

    /// <summary>
    /// Стоимость товара.
    /// </summary>
    private double _cost;

    /// <summary>
    /// Категория товара.
    /// </summary>
    public Category Category { get; set; }

    /// <summary>
    /// Возвращает и задает ID.
    /// </summary>
    public int ID { get; private set; }

    /// <summary>
    /// Возвращает и задает название товара.
    /// </summary>
    public string Name
    {
        get 
        { 
            return _name; 
        }

        set
        {
            ValueValidator.AssertStringOnLength(value, 200, "Name");
            if (value.Length == 0)
            {
                throw new Exception("Name не должен быть пустым");
            }
            else
            {
                _name = value;
            }    
        }
    }

    /// <summary>
    /// Возвращает и задает описание товара.
    /// </summary>
    public string Info
    {
        get
        {
            return _info;
        }

        set
        {
            ValueValidator.AssertStringOnLength(value, 1000, "Info");
            _info = value;
        }
    }

    /// <summary>
    /// Возвращает и задает стоимость товара.
    /// </summary>
    public double Cost
    {
        get
        {
            return _cost;
        }

        set
        {
            if (value < 0 || value > 100000)
                {
                  throw new Exception("Cost должен быть больше 0 и меньше 100000");
                }
            
            _cost = value;
            
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Item">
    /// </summary>
    /// <param name="name">Название товара. Длина не должна привышать 200 символво.</param>
    /// <param name="info">Описание товара. Длина не должна привышать 1000 символов.</param>
    /// <param name="cost">Стоимость товара. Вещественное число. От 0 до 100000. </param>
    /// <param name="category">Категория товара. Принадлежит к соответствующему перечислению. </param>
    public Item(string name, string info, double cost, Category category)
    {
        
        ID = _id++;
        Name = name;
        Info = info;
        Cost = cost;
        Category = category;
    }
}


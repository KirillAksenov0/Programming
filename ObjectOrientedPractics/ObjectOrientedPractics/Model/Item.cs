using System;
/// <summary>
/// Хранит данные о товаре.
/// </summary>
public class Item: ICloneable, IEquatable<Item>, IComparable<Object>
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
    /// Сравнивает объекты.
    /// </summary>
    /// <param name="other">Объект для сравнения.</param>
    /// <returns></returns>
    public bool Equals(Item other)
    {
        // Проверка на null
        if (other == null)
        {
            return false;
        }
        // Сравнение значений
        return this.ID == other.ID;
    }

    /// <summary>
    /// Сравнивает объекты.
    /// </summary>
    /// <param name="other">Объект для сравнения.</param>
    /// <returns></returns>
    public override bool Equals(object other)
    {
        if (other == null)
        {
            return false;
        }

        if (other is not Item)
        {
            return false;
        }

        if (object.ReferenceEquals(this, other))
        {
            return true;
        }
        var item2 = (Item)other;
        
        return (this.ID == item2.ID);
    }

    /// <summary>
    /// Сравнивает объекты через интерфейс IComparable.
    /// </summary>
    /// <param name="obj">Объект для сравнения.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public int CompareTo(object obj)
    {
        if (obj == null)
        {
            return 1;
        }

        Item otherItem = obj as Item;
        if (otherItem != null)
        {
            return this.Cost.CompareTo(otherItem.Cost);
        }
        else
        {
            throw new ArgumentException("Object is not a Item");
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

    /// <inheritdoc cref="Item.Item(string, string, double, Category)" />
    public object Clone()
    {
        return new Item(this.Name, this.Info, this.Cost, this.Category);
    }
}


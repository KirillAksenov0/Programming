/// <summary>
/// Хранит данные о процентной скидки.
/// </summary>
public class PercentDiscount
{
    /// <summary>
    /// Текущая скидка в процентах.
    /// </summary>
    private int _currentDiscountPercent = 1;

    /// <summary>
    /// Категория товара, на которую действует скидка.
    /// </summary>
    public Category Category { get; private set; }

    /// <summary>
    /// Сумма, на которую покупатель уже сделал покупки данной категории товаров.
    /// </summary>
    public double TotalSpentInCategory { get; private set; }

    /// <summary>
    /// Возвращает и задает текущую скидку в процентах.
    /// </summary>
    public int CurrentDiscountPercent
    {
        get { return _currentDiscountPercent; }
        private set { _currentDiscountPercent = value; }
    }

    /// <summary>
    /// Информация о текущей скидке.
    /// </summary>
    public string Info => $"Процентная «{Category}» - {CurrentDiscountPercent}%";

    /// <summary>
    /// Рассчитывает размер скидки.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Значение скидки.</returns>
    public double Calculate(List<Item> items)
    {
        double discount = 0;
        var categoryItems = items.Where(item => item.Category == Category).ToList();

        foreach (var item in categoryItems)
        {
            discount += item.Cost * CurrentDiscountPercent / 100;
        }

        return discount;
    }

    /// <summary>
    /// Применяет скидку к товарам.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Значение скидки.</returns>
    public double Apply(List<Item> items)
    {
        double discount = Calculate(items);
        TotalSpentInCategory += items.Where(item => item.Category == Category).Sum(item => item.Cost);
        CurrentDiscountPercent = Math.Min(10, 1 + (int)(TotalSpentInCategory / 1000));
        return discount;
    }

    /// <summary>
    /// Обновляет процент скидки.
    /// </summary>
    /// <param name="items"></param>
    public void Update(List<Item> items)
    {
        TotalSpentInCategory += items.Where(item => item.Category == Category).Sum(item => item.Cost);
        CurrentDiscountPercent = Math.Min(10, 1 + (int)(TotalSpentInCategory / 1000));
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="PercentDiscount">.
    /// </summary>
    /// <param name="category">Категория товара. Должна быть объектом перечисления Category.</param>
    public PercentDiscount(Category category)
    {
        Category = category;
    }
}

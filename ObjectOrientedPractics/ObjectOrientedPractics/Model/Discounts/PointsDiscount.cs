/// <summary>
/// Хранит данные о скидке накопительных баллов.
/// </summary>
public class PointsDiscount : IDiscount
{
    /// <summary>
    /// Количество баллов.
    /// </summary>
    private int _pointsCount = 0;

    /// <summary>
    /// Возвращает и задает количество баллов.
    /// </summary>
    public int PointsCount
    {
        get { return _pointsCount; }
        private set
        {
            if (value >= 0)
            _pointsCount = value;
        }
    }

    /// <summary>
    /// Возвращает информацию о скидке.
    /// </summary>
    public string Info
    {
        get 
        {
            return $"Накопительная – {_pointsCount} баллов"; 
        }
    }

    /// <summary>
    /// Рассчитывает размер скидки, доступной с текущим количеством баллов.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Скидка в виде количества баллов.</returns>
    public double Calculate(List<Item> items)
    {
       
        double sum = 0;
        foreach (var item in items)
        {
            sum += item.Cost;
        }

        double discount = (sum / 100) * 30;

        if (discount > _pointsCount)
        {
            return _pointsCount;
        }
        else
        {
            return discount;
        }
    }

    /// <summary>
    /// Применяет скидку к товарам.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Скидка в виде количества баллов.</returns>
    public double Apply(List<Item> items)
    {
       
        double sum = 0;
        foreach (var item in items)
        {
            sum += item.Cost;
        }

        double discount = (sum / 100) * 30;

        if (discount > _pointsCount)
        {
            discount = _pointsCount;
            _pointsCount = 0;
            return discount;
        }
        else
        {
            _pointsCount -= Convert.ToInt32(discount);
            return discount;
        }
    }

    /// <summary>
    /// Добавляет баллы на основе списка товаров.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    public void Update(List<Item> items)
    {
        
        double sum = 0;
        foreach (var item in items)
        {
            sum += item.Cost;
        }

        _pointsCount += Convert.ToInt32(sum / 10);
    }

    
}

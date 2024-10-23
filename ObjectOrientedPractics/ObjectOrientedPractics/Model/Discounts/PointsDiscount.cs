/// <summary>
/// Хранит данные о скидке накопительных баллов.
/// </summary>
public class PointsDiscount : IDiscount
{
    /// <summary>
    /// Количество баллов.
    /// </summary>
    private int _pointsCount;

    /// <summary>
    /// Возвращает и задает количество баллов.
    /// </summary>
    public int PointsCount
    {
        get { return _pointsCount; }
        private set
        {
            _pointsCount = value;
        }
    }

    /// <summary>
    /// Рассчитывает размер скидки, доступной с текущим количеством баллов.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Скидка в виде количества баллов.</returns>
    public double Calculate(List<Item> items)
    {
        double totalCost = 0;
        foreach (var item in items)
        {
            totalCost += item.Cost;
        }

        double maxDiscount = totalCost * 0.3;
        double discount = Math.Min(PointsCount, maxDiscount);

        return discount;
    }

    /// <summary>
    /// Применяет скидку к товарам.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Скидка в виде количества баллов.</returns>
    public double Apply(List<Item> items)
    {
        double discount = Calculate(items);
        if (discount > 0)
        {
            PointsCount -= (int)discount;
            return discount;
        }
        return 0;
    }

    /// <summary>
    /// Добавляет баллы на основе списка товаров.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    public void Update(List<Item> items)
    {
        double totalCost = 0;
        foreach (var item in items)
        {
            totalCost += item.Cost;
        }

        int earnedPoints = (int)Math.Ceiling(totalCost * 0.1);
        PointsCount += earnedPoints;
    }

    /// <summary>
    /// Информация о текущих баллах.
    /// </summary>
    public string Info => $"Накопительная – {PointsCount} баллов";
}

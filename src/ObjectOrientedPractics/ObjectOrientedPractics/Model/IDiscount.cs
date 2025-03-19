/// <summary>
/// Хранит объекты скидок.
/// </summary>
public interface IDiscount
{
    /// <summary>
    /// Информация о текущей скидке.
    /// </summary>
    string Info { get; }

    /// <summary>
    /// Рассчитывает размер скидки.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Значение скидки.</returns>
    double Calculate(List<Item> items);

    /// <summary>
    /// Применяет скидку к товарам.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Значение скидки.</returns>
    double Apply(List<Item> items);

    /// <summary>
    /// Обновляет данные о скидке.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    void Update(List<Item> items);
}
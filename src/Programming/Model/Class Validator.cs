/// <summary>
/// Хранит методы, используемые в нескольких классах.
/// </summary>
static class Validator
{
    /// <summary>
    /// Проверяет целое число на отрицательность.
    /// </summary>
    /// <param name="value">Входное значение типа. Должно быть целым.</param>
    /// <param name="propertyName">Название свойства. Должно состоять только из букв.</param>
    /// <exception cref="ArgumentException">Выводит ошибку, если целое число оказалось отрицательным.
    /// </exception>
    public static void AssertOnPositiveValue(int value, string propertyName)
    {
        if (value < 0)
            throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. " +
                    $"Допускаются только числа больше нуля.");
    }

    /// <summary>
    /// Проверяет вещественное число на отрицательность.
    /// </summary>
    /// <param name="value">Входное проверяемое значение. Должно быть вещественным.</param>
    /// <param name="propertyName">Название свойства. Должно состоять только из букв.</param>
    /// <exception cref="ArgumentException">Выводит ошибку, если вещественное число оказалось 
    /// отрицательным.</exception>
    public static void AssertOnPositiveValue(double value, string propertyName)
    {
        if (value < 0)
            throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. " +
                    $"Допускаются только числа больше нуля.");
    }

    /// <summary>
    /// Проверяеть принадлежность целого числа диапозону.
    /// </summary>
    /// <param name="value">Входное проверяемое значение. Должно быть целым.</param>
    /// <param name="min">Минимальное допустимое число. Должно быть целым.</param>
    /// <param name="max">Максимальное допустимое число. Должно быть целым.</param>
    /// <param name="propertyName">Название свойства. Должно состоять только из букв.</param>
    /// <exception cref="ArgumentException">Выводит ошибку, если число оказалось вне диапозона.
    /// </exception>
    public static void AssertValueInRange(int value, int min, int max, string propertyName)
    {
        if (value < min && value > max)
        {
            throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. " +
                    $"Допускаются только числа больше нуля.");
        }
    }

    /// <summary>
    /// Проверяеть принадлежность вещественного числа диапозону.
    /// </summary>
    /// <param name="value">Входное проверяемое значение. Должно быть вещественным.</param>
    /// <param name="min">Минимальное допустимое число. Должно быть вещественным.</param>
    /// <param name="max">Максимальное допустимое число. Должно быть вещественным.</param>
    /// <param name="propertyName">Название свойства. Должно состоять только из букв.</param>
    /// <exception cref="ArgumentException">Выводит ошибку, если число оказалось вне диапозона.
    /// </exception>
    public static void AssertValueInRange(double value, double min, double max, string propertyName)
    {
        if (value < min && value > max)
        {
            throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. " +
                    $"Допускаются только числа больше нуля.");
        }
    }
}
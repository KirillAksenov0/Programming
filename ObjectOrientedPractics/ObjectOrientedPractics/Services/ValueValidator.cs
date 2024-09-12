/// <summary>
/// Хранит методы для валидации значений.
/// </summary>
static class ValueValidator
{
    /// <summary>
    /// Проверяет строку на длину.
    /// </summary>
    /// <param name="value">Введенная строка.</param>
    /// <param name="maxLength">Максимально допустимая длина строки.</param>
    /// <param name="propertyName">Имя свойства, которое подлежит проверке.</param>
    /// <exception cref="Exception"></exception>
    public static void AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if (value.Length > maxLength)
        {
            throw new Exception($"{propertyName} должен быть меньше {maxLength} символов");
        }

    }
}

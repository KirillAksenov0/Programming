using System.Text.RegularExpressions;
using System.Xml.Linq;

/// <summary>
/// Содержит методы для валидации данных.
/// </summary>
public static class ValueValidator
{
    /// <summary>
    /// Проверяет значение на null.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <returns>true, если значение не null, иначе false.</returns>
    public static bool NullOnEmptyStringMatching(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Проверяет значение на допустимую длину.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="max">Максимальная длина.</param>
    /// <returns>true, если длина не превышает допустимую, иначе false.</returns>
    public static bool StringLengthMatching(string value, int max)
    {
        if (value.Length < max)
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Проверяет значение на корректность по шаблону.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="pattern">Шаблон, которому должно соответствовать значение.</param>
    /// <returns>true, если значение соответствует шаблону, иначе false.</returns>
    public static bool PatternMatching(string value, string pattern)
    {
        if (Regex.IsMatch(value, pattern))
        {
            return true;
        }
        return false;
    }
}

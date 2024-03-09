/// <summary>
/// Хранит данные о времени.
/// </summary>
public class Time
{
    /// <summary>
    /// Количество часов.
    /// </summary>
    private int _hours;

    /// <summary>
    /// Количество минут.
    /// </summary>
    private int _minutes;

    /// <summary>
    /// Количество секунд.
    /// </summary>
    private int _seconds;

    /// <summary>
    /// Возвращает и задает количество часов.
    /// </summary>
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 23, "Hours");
            _hours = value;
        }
    }

    /// <summary>
    /// Возвращает и задает количество минут.
    /// </summary>
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 60, "Minutes");
            _minutes = value;
        }
    }

    /// <summary>
    /// Возвращает и задает количество секунд.
    /// </summary>
    public int Seconds
    {
        get
        {
            return _seconds;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 60, "Seconds");
            _seconds = value;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Time"/>.
    /// </summary>
    /// <param name="hours">Количество часов.</param>
    /// <param name="minutes">Количество минут.</param>
    /// <param name="seconds">Количество секунд.</param>
    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Time"/>.
    /// Без инициализации полей.
    /// </summary>
    public Time()
    {
        Hours = 0;
        Minutes = 0;
        Seconds = 0;
    }
}

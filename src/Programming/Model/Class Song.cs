/// <summary>
/// Хранит данные о песне.
/// </summary>
public class Song
{
    /// <summary>
    /// Название песни.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Исполнитель песни.
    /// </summary>
    public string Executor { get; set; }

    /// <summary>
    /// Длительность песни в минутах.
    /// </summary>
    private int _durationMinute;

    /// <summary>
    /// Возвращает и задает длительность песни в минутах.
    /// </summary>
    public int DurationMinute
    {
        get
        {
            return _durationMinute;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, "DurationMinute");
            _durationMinute = value;
        }
    }
    /// <summary>
    /// Создает экземпляр класса <see cref="Song"/>.
    /// </summary>
    /// <param name="name">Название песни. Должно состоять только из букв.</param>
    /// <param name="executor">Исполнитель песни. Должен состоять только из букв.</param>
    /// <param name="durationMinute">Длительность песни в минутах.</param>
    public Song(string name, string executor, int durationMinute)
    {
        Name = name;
        Executor = executor;
        DurationMinute = durationMinute;
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Song"/> без инициализации полей.
    /// </summary>
    public Song()
    {
        Name = "none";
        Executor = "none";
        DurationMinute = 0;
    }
}

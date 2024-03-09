/// <summary>
/// Хранит данные о фильме.
/// </summary>
public class Movie
{
    /// <summary>
    /// Название фильма.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Длительность фильма в минутах.
    /// </summary>
    public int DurationMinute { get; set; }

    /// <summary>
    /// Год выхода фильма.
    /// </summary>
    private int _year;

    /// <summary>
    /// Жанр фильма.
    /// </summary>
    public string Genre { get; set; }

    /// <summary>
    /// Рейтинг фильма.
    /// </summary>
    private double _rating;

    /// <summary>
    /// Возвращает и задает год выхода фильма.
    /// </summary>
    public int Year
    {
        get
        {
            return _year;
        }
        set 
        {
            Validator.AssertValueInRange(value, 1900, 2024, "Year");
            _year = value;

        }
    }

    /// <summary>
    /// Возвращает и задает рейтинг фильма.
    /// </summary>
    public double Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 10, "Rating");
            _rating = value;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Movie"/>.
    /// </summary>
    /// <param name="name">Название фильма. Должно состоять только из букв.</param>
    /// <param name="durationminute">Длительность фильма в минутах.</param>
    /// <param name="year">Год выхода фильма.</param>
    /// <param name="genre">Жанр фильма. Должен состоять только из букв.</param>
    /// <param name="rating">Рейтинг фильма.</param>
    public Movie(string name, int durationminute, int year, string genre, double rating)
    {
        Name = name;
        DurationMinute = durationminute;
        Year = year;
        Genre = genre;
        Rating = rating;
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Movie"/> без инициализации полей.
    /// </summary>
    public Movie()
    {
        Name = "none";
        DurationMinute = 0;
        Year = 0;
        Genre = "none";
        Rating= 0;
    }
}
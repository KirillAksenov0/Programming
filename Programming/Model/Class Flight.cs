/// <summary>
/// Хранит данные о полете самолета.
/// </summary>
public class Flight
{
    /// <summary>
    /// Место вылета.
    /// </summary>
    public string DeparturePoint { get; set; }

    /// <summary>
    /// Место прилета.
    /// </summary>
    public string DestinationPoint { get; set; }

    /// <summary>
    /// Время полета в минутах.
    /// </summary>
    private int _flightTimeMinute;

    /// <summary>
    /// Возвращает и задает время полета а минутах.
    /// </summary>
    public int FlightTimeMinute
    {
        get
        {
            return _flightTimeMinute;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, "FlightTimeMinute");
            _flightTimeMinute = value;
        }
    }
    /// <summary>
    /// Создает экземпляр класса <see cref="Flight"/>.
    /// </summary>
    /// <param name="departurePoint">Место вылета. Должно состоять только из букв.</param>
    /// <param name="destinationPoint">Место прилета. Должно состоять только из букв.</param>
    /// <param name="flightTimeMinute">Время полета в минутах.</param>
    public Flight(string departurePoint, string destinationPoint, int flightTimeMinute)
    {
        DeparturePoint = departurePoint;
        DestinationPoint = destinationPoint;
        FlightTimeMinute = flightTimeMinute;
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Flight"/>.
    /// </summary>
    public Flight()
    {
        DeparturePoint = "none";
        DestinationPoint = "none";
        FlightTimeMinute = 0;
    }
}
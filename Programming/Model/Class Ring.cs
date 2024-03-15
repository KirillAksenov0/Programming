/// <summary>
/// Вычесляет и хранит площадь кольца.
/// </summary>
public class Ring
{
    /// <summary>
    /// Координаты центра кольца.
    /// </summary>
    public Point2D Center { get; set; }

    /// <summary>
    /// Внешний радиус.
    /// </summary>
    private double _externalRadius;

    /// <summary>
    /// Внутренний радиус.
    /// </summary>
    private double _internalRadius;

    /// <summary>
    /// Возвращает и задает внешний радиус.
    /// </summary>
    public double ExternalRadius
    {
        get
        {
            return _externalRadius;
        }
        set
        {
            //Проверка на отрицательность.
            Validator.AssertOnPositiveValue(value, "ExternalRadius");

            if (value < _internalRadius)
            {
                throw new ArgumentException($"Некорректное значение в свойстве {ExternalRadius}. " +
                    $"Допускаются только числа больше нуля.");
            }
            _externalRadius = value;
        }
    }

    /// <summary>
    /// Возвращает и задает внутренний радиус.
    /// </summary>
    public double InternalRadius
    {
        get
        {
            return _internalRadius;
        }
        set
        {
            //Проверка на отрицательность.
            Validator.AssertOnPositiveValue(value, "InternalRadius");
            if (value > _externalRadius)
            {
                throw new ArgumentException($"Некорректное значение в свойстве {InternalRadius}. " +
                    $"Допускаются только числа больше нуля.");
            }
            _internalRadius = value;
        }
    }

    /// <summary>
    /// Возвращает и задает площадь кольца.
    /// </summary>
    public double Area
    {
        get
        {
            double externalCircleArea = 3.14 * Math.Pow(_externalRadius,2);
            double internalCircleArea = 3.14 * Math.Pow(_internalRadius, 2);
            return externalCircleArea - internalCircleArea;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Ring"/>.
    /// </summary>
    /// <param name="center">Координаты центра прямоугольника. Должна быть объектом Point2D.</param>
    /// <param name="externalRadius">Внешний радиус. Должен быть вещественным числом.</param>
    /// <param name="internalRadius">Внутренний радиус. Должен быть вещественным числом.</param>
    public Ring(Point2D center, double externalRadius, double internalRadius)
    {
        Center = center;
        ExternalRadius = externalRadius;
        InternalRadius = internalRadius;
    }
}

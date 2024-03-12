/// <summary>
/// Хранит параметры прямоугольника.
/// </summary>
public class Rectangle
{
    /// <summary>
    /// Точка с координатами x,y.
    /// </summary>
    private Point2D _center;
    /// <summary>
    /// Длина прямоугольника.
    /// </summary>
    private double _length;

    /// <summary>
    /// Ширина прямоугольника.
    /// </summary>
    private double _width;

    /// <summary>
    /// Цвет прямоугольника. Должен состоять только из букв.
    /// </summary>
    public string Color { get; set; }

    /// <summary>
    /// Возвращает и задает точку с координатами.
    /// </summary>
    public Point2D Center
    {
        get
        {
            return _center;
        }
        set
        {
            _center = value;
        }
    }

    /// <summary>
    /// Возвращает и задает длину прямоугольника.
    /// </summary>
    public double Length
    {
        get
        {
            return _length;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, "Lenght");
            _length = value;
        }
    }

    /// <summary>
    /// Возвращает и задает ширину прямоугольника.
    /// </summary>
    public double Width
    {
        get
        {
            return _width;
        }
        set
        {
            Validator.AssertOnPositiveValue(value, "Width");
            _width = value;
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Rectangle"/>. 
    /// </summary>
    /// <param name="length">Длина прямоугольника.</param>
    /// <param name="width">Ширина прямоугольника.</param>
    /// <param name="color">Цвет прямоугольника. Должен состоять только из букв.</param>
    public Rectangle(Point2D center,double length, double width, string color)
    {
        Center = center;
        Length = length;
        Width = width;
        Color = color;
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Rectangle"/> без инициализации полей.
    /// </summary>
    public Rectangle()
    {
        Length = 0;
        Width = 0;
        Color = "none";
    }
}
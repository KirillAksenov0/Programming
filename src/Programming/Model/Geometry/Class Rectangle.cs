using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
/// <summary>
/// Хранит параметры прямоугольника.
/// </summary>
public class Rectangle
{
    /// <summary>
    /// Центр прямоугольника с координатами x,y.
    /// </summary>
    public Point2D Center { get; set; }

    /// <summary>
    /// Длина прямоугольника.
    /// </summary>
    private int _length;

    /// <summary>
    /// Ширина прямоугольника.
    /// </summary>
    private int _width;

    /// <summary>
    /// Цвет прямоугольника. 
    /// </summary>
    public string Color { get; set; }

    /// <summary>
    /// Счетчик прямоугольников.
    /// </summary>
    private static int _allRectanglesCount = 0;

    /// <summary>
    /// ID прямоугольника.
    /// </summary>
    private int _id;

    Random rand = new Random();

    /// <summary>
    /// Возвращает и задает длину прямоугольника.
    /// </summary>
    public int Length
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
    public int Width
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
    /// Возвращает количество прямоугольников.
    /// </summary>
    public static int AllRectanglesCount
    {
        get
        {
            return _allRectanglesCount;
        }
    }

    /// <summary>
    /// Возвращает ID прямоугольника.
    /// </summary>
    public int ID
    {
        get
        {
            return _id;
        }
        
    }
    /// <summary>
    /// Создает экземпляр класса <see cref="Rectangle"/>. 
    /// </summary>
    /// <param name="length">Длина прямоугольника.</param>
    /// <param name="width">Ширина прямоугольника.</param>
    /// <param name="color">Цвет прямоугольника. Должен состоять только из букв.</param>
    public Rectangle( int length, int width, string color)
    {
        
        Length = length;
        Width = width;
        Color = color;
        _allRectanglesCount++;
        _id = _allRectanglesCount;

        Center = new Point2D(rand.Next(5, 301), rand.Next(5, 301));
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
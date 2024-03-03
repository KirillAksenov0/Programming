/// <summary>
/// Хранит параметры прямоугольника.
/// </summary>
public class Rectangle
{
    /// <summary>
    /// Длина прямоугольника.
    /// </summary>
    public double Length { get; set; }

    /// <summary>
    /// Ширина прямоугольника.
    /// </summary>
    public double Width { get; set; }

    /// <summary>
    /// Цвет прямоугольника. Должен состоять только из букв.
    /// </summary>
    public string Color { get; set; }

    /// <summary>
    /// Создает экземпляр класса <see cref="Rectangle"/>. 
    /// </summary>
    /// <param name="length">Длина прямоугольника.</param>
    /// <param name="width">Ширина прямоугольника.</param>
    /// <param name="color">Цвет прямоугольника. Должен состоять только из букв.</param>
    public Rectangle(double length, double width, string color)
    {
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
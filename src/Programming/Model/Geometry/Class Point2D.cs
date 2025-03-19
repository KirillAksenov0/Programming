/// <summary>
/// Хранит координаты центра прямоугольника.
/// </summary>
public class Point2D
{
    /// <summary>
    /// Координата X.
    /// </summary>
    private int _x;

    /// <summary>
    /// Координата Y.
    /// </summary>
    private int _y;

    /// <summary>
    /// Возвращает и задает координату X.
    /// </summary>
    public int X
    {
        get
        {
            return _x;
        }
        private set
        {
            Validator.AssertOnPositiveValue(value, "x");
            _x = value;
        }
    }

    /// <summary>
    /// Возвращает и задает координату Y.
    /// </summary>
    public int Y
    {
        get
        {
            return _y;
        }
        private set
        {
            Validator.AssertOnPositiveValue(value, "y");
            _y = value;
        }
    }
    /// <summary>
    /// Создает экземпляр класса <see cref="Point2D"/> .
    /// </summary>
    /// <param name="x">Координата X. Должна быть целым числом.</param>
    /// <param name="y">Координата Y. Должна быть целым числом.</param>
    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }


}

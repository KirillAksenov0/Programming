/// <summary>
/// Хранит методы IsCollision.
/// </summary>
public static class CollisionManager
{
    /// <summary>
    /// Проверяет пересечение прямоугольников.
    /// </summary>
    /// <param name="rectangle1">Первый прямоугольник. Должен быть объектом класса rectangle.</param>
    /// <param name="rectangle2">Второй прямоугольник. Должен быть объектом класса rectangle.</param>
    /// <returns>Возвращает true, если прямоугольники пересекаются и false, если нет.</returns>
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        //Сумма половин ширин.
        double sumHalfWidth = (rectangle1.Length / 2) + (rectangle2.Length / 2);

        //Сумма половин высот.
        double sumHalfHeight = ((rectangle1.Width / 2) + (rectangle2.Width / 2));

        //Разница X.
        double dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);

        //Разница Y.
        double dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

        if (dX < sumHalfWidth && dY < sumHalfHeight)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Проверяет пересечение колец.
    /// </summary>
    /// <param name="ring1">Первое кольцо. Должен быть объектом класса ring.</param>
    /// <param name="ring2">Второк кольцо. Должен быть объектом класса ring.</param>
    /// <returns>Возвращает true, если кольца пересекаются и false, если нет.</returns>
    public static bool IsCollision(Ring ring1,  Ring ring2)
    {
        //Разница X.
        double dX = Math.Abs(ring1.Center.X - ring2.Center.X);

        //Разница Y.
        double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);

        //Сумма внешних радиусов.
        double sumExternalRadius = ring1.ExternalRadius + ring2.ExternalRadius;

        //Гипотенуза.
        double hypotenuse = Math.Sqrt((dX * dX) - (dY * dY));

        if (hypotenuse < sumExternalRadius)
        {
            return true;
        }
        return false;
    }
}
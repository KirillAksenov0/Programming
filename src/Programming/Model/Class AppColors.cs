using System.Drawing;

/// <summary>
/// Хранит цвета для индикации.
/// </summary>
public static class AppColors
{
    /// <summary>
    /// Цвет кнопки, если выбрано "Autumn".
    /// </summary>
    public static System.Drawing.Color AutumnColor = System.Drawing.Color.SandyBrown;

    /// <summary>
    /// Цвет кнопки, если выбрано "Spring".
    /// </summary>
    public static System.Drawing.Color SpringColor = System.Drawing.Color.Green;

    /// <summary>
    /// Цвет для обозначения не перескающихся прямоугольников.
    /// </summary>
    public static System.Drawing.Color CommonRectangleColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

    /// <summary>
    /// Цвет для обозначения перескающихся прямоугольников.
    /// </summary>
    public static System.Drawing.Color CollisionRectanglesColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);

    /// <summary>
    /// Цвет для валидации значений.
    /// </summary>
    public static System.Drawing.Color InvalidColor = System.Drawing.Color.LightPink;
}

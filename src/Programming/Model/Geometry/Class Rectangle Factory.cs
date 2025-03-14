using System.Windows.Forms;
using System;
using System.Drawing;
/// <summary>
/// Хранит метод генерации прямоугольников с рандомными параметрами.
/// </summary>
public static class RectangleFactory
{
    /// <summary>
    /// Создает новый прямоугольник с рандомными параметрами.
    /// </summary>
    /// <param name="colors">Массив цветов.</param>
    /// <returns>Возвращает объект типа Rectangle.</returns>
    public static Rectangle Randomize(string[] colors)
    {
        Random randomRec = new Random();
        int minXY = 1;
        int maxXY = 300;

        int minWAndH = 10;
        int maxWandH = 110;

        int index = randomRec.Next(0,5);

        
        int randomLenght = randomRec.Next(minWAndH, maxWandH + 1);
        int randomWidth = randomRec.Next(minWAndH, maxWandH + 1);

        Rectangle rect = new Rectangle(randomWidth, randomLenght, colors[index]);
        return rect;
    }
}

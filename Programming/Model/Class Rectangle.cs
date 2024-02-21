public class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }
    public string Color { get; set; }

    public Rectangle(double length, double width, string color)
    {
        Length = length;
        Width = width;
        Color = color;
    }
}
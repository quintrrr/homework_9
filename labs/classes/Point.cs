using System.Drawing;

namespace labs.classes;

public class Point : Figure
{
    public Point(int x, int y, Color color, bool isVisible)
    {
        this.x = x;
        this.y = y;
        Color = color;
        IsVisible = isVisible;
    }
}
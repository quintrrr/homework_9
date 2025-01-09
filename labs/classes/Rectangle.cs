using System.Drawing;
using labs.interfaces;

namespace labs.classes;

public class Rectangle : Point, IArea
{
    private int height;
    private int width;
    public Rectangle(int x, int y, Color color, bool isVisible, int height, int width) : base(x, y, color, isVisible)
    {
        this.height = height;
        this.width = width;
    }

    public double CalculateArea()
    {
        return height * width;
    }
    
    public override void printInfo()
    {
        Console.WriteLine("Информация о фигуре:");
        Console.WriteLine($"Позиция: x: {x}, y: {y}");
        Console.WriteLine($"Цвет: {Color}");
        Console.WriteLine($"Видимость: {(IsVisible ? "Видимая" : "Невидимая")}");
        Console.WriteLine($"Высота: {height}, Ширина: {width}");
    }
}
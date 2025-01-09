using System.Drawing;
using labs.interfaces;

namespace labs.classes;

public class Circle : Point, IArea
{
    private uint radius;
    public Circle(int x, int y, Color color, bool isVisible, uint radius) : base(x, y, color, isVisible)
    {
        this.radius = radius;
    }


    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    
    public override void printInfo()
    {
        Console.WriteLine("Информация о фигуре:");
        Console.WriteLine($"Позиция: x: {x}, y: {y}");
        Console.WriteLine($"Цвет: {Color}");
        Console.WriteLine($"Видимость: {(IsVisible ? "Видимая" : "Невидимая")}");
        Console.WriteLine($"Радиус: {radius}");
    }
}
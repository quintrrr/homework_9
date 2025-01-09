using System.Drawing;

namespace labs.classes;

public abstract class Figure
{
    protected int x;
    protected int y;
    private Color color; 
    private bool isVisible;
    
    public Color Color { protected get => color; set => color = value; }
    public bool IsVisible { get => isVisible; protected set => isVisible = value; }
    
    public void moveVertical(int distance)
    {
        y += distance;
    }
    public void moveHorizontal(int distance)
    {
        x += distance;
    }

    public virtual void printInfo()
    {
        Console.WriteLine("Информация о фигуре:");
        Console.WriteLine($"Позиция: x: {x}, y: {y}");
        Console.WriteLine($"Цвет: {color}");
        Console.WriteLine($"Видимость: {(isVisible ? "Видимая" : "Невидимая")}");
    }
    
    
}
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.ConcreteAlerts;

public class MacosAlert : IAlert
{
    private int Height { get; set; }
    private int Width { get; set; }
    private int StartingPositionX { get; set; }
    private int StartingPositionY { get; set; }

    public MacosAlert(int height, int width, int startingPositionX, int startingPositionY)
    {
        Height = height;
        Width = width;
        StartingPositionX = startingPositionX;
        StartingPositionY = startingPositionY;

        Console.WriteLine($"MacosAlert Created=> Height x Width: {Height} x {Width}");
    }

    public void Render()
    {
        Console.WriteLine($"MacosAlert Rendered=> X - Y: {StartingPositionX} - {StartingPositionY}");
    }
}

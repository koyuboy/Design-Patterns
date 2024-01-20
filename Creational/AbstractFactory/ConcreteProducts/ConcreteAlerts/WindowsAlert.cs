using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.ConcreteAlerts;

public class WindowsAlert : IAlert
{
    private int Height { get; set; }
    private int Width { get; set; }
    private int StartingPositionX { get; set; }
    private int StartingPositionY { get; set; }

    public WindowsAlert(int height, int width, int startingPositionX, int startingPositionY)
    {
        Height = height;
        Width = width;
        StartingPositionX = startingPositionX;
        StartingPositionY = startingPositionY;

        Console.WriteLine($"WindowsAlert Created=> Height x Width: {Height} x {Width}");
    }

    public void Render()
    {
        Console.WriteLine($"WindowsAlert Rendered=> X - Y: {StartingPositionX} - {StartingPositionY}");
    }
}

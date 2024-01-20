using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.ConcreteButtons;

public class MacosButton : IButton
{
    private int Height { get; set; }
    private int Width { get; set; }
    private int StartingPositionX { get; set; }
    private int StartingPositionY { get; set; }

    public MacosButton(int height, int width, int startingPositionX, int startingPositionY)
    {
        Height = height;
        Width = width;
        StartingPositionX = startingPositionX;
        StartingPositionY = startingPositionY;

        Console.WriteLine($"MacosButton Created=> Height x Width: {Height} x {Width}");
    }

    public void Render()
    {
        Console.WriteLine($"MacosButton Rendered=> X - Y: {StartingPositionX} - {StartingPositionY}");
    }

    public void OnClick(string eventName)
    {
        Console.WriteLine($"{eventName} triggered on MacosButton");
    }
}

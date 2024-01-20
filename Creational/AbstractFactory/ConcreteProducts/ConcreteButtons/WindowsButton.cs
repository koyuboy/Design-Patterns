using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.ConcreteButtons;

public class WindowsButton : IButton
{
    private int Height { get; set; }
    private int Width { get; set; }
    private int StartingPositionX { get; set; }
    private int StartingPositionY { get; set; }

    public WindowsButton(int height, int width, int startingPositionX, int startingPositionY)
    {
        Height = height;
        Width = width;
        StartingPositionX = startingPositionX;
        StartingPositionY = startingPositionY;

        Console.WriteLine($"WindowsButton Created=> Height x Width: {Height} x {Width}");
    }

    public void Render()
    {
        Console.WriteLine($"WindowsButton Rendered=> X - Y: {StartingPositionX} - {StartingPositionY}");
    }

    public void OnClick(string eventName)
    {
        Console.WriteLine($"{eventName} triggered on WindowsButton");
    }
}

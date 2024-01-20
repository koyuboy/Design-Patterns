using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.ConcreteTextBoxes;

public class WindowsTextBox : ITextBox
{
    private int Height { get; set; }
    private int Width { get; set; }
    private int StartingPositionX { get; set; }
    private int StartingPositionY { get; set; }
    private int CharacterSize { get; set; }

    public WindowsTextBox(int height, int width, int startingPositionX, int startingPositionY, int characterSize)
    {
        Height = height;
        Width = width;
        StartingPositionX = startingPositionX;
        StartingPositionY = startingPositionY;
        CharacterSize = characterSize;

        Console.WriteLine($"WindowsTextBox Created=> Height x Width: {Height} x {Width}");
    }

    public void Render()
    {
        Console.WriteLine($"WindowsTextBox Rendered=> X - Y: {StartingPositionX} - {StartingPositionY}");
    }

    public void OnChange(string text)
    {
        Console.WriteLine($"{text} ({text.Length}/{CharacterSize} character used)");
    }
}

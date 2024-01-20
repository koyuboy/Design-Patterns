using AbstractFactory.AbstractProducts;
using AbstractFactory.ConcreteProducts.ConcreteAlerts;
using AbstractFactory.ConcreteProducts.ConcreteButtons;
using AbstractFactory.ConcreteProducts.ConcreteTextBoxes;

namespace AbstractFactory.ConcreteFactories;

public class MacosGuiFactory : IGuiFactory
{
    public IAlert CreateAlert(int height, int width, int startingPositionX, int startingPositionY)
    {
        var alert = new MacosAlert(height, width, startingPositionX, startingPositionY);
        return alert;
    }

    public IButton CreateButton(int height, int width, int startingPositionX, int startingPositionY)
    {
        var button = new MacosButton(height, width, startingPositionX, startingPositionY);
        return button;
    }

    public ITextBox CreateTextBox(int height, int width, int startingPositionX, int startingPositionY, int characterSize)
    {
        var textBox = new MacosTextBox(height, width, startingPositionX, startingPositionY, characterSize);
        return textBox;
    }
}

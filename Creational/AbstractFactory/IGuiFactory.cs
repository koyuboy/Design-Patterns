using AbstractFactory.AbstractProducts;

namespace AbstractFactory;

public interface IGuiFactory
{
    IAlert CreateAlert(int height, int width, int startingPositionX, int startingPositionY);
    IButton CreateButton(int height, int width, int startingPositionX, int startingPositionY);
    ITextBox CreateTextBox(int height, int width, int startingPositionX, int startingPositionY, int characterSize);
}

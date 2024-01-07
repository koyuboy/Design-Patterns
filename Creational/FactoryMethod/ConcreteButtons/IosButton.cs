namespace FactoryMethod.ConcreteButtons;

public class IosButton : IButton
{
    public IosButton()
    {
        Console.WriteLine("IosButton Created");
    }
    public void Click(string eventName)
    {
        Console.WriteLine($"IOS button clicked and {eventName} is received!");
    }

    public void Render()
    {
        Console.WriteLine($"IOS button render is completed!");
    }
}

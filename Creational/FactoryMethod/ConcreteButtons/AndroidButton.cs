namespace FactoryMethod.ConcreteButtons;

public class AndroidButton : IButton
{
    public AndroidButton()
    {
        Console.WriteLine("AndroidButton Created");
    }
    public void Click(string eventName)
    {
        Console.WriteLine($"Android button clicked and {eventName} is received!");
    }

    public void Render()
    {
        Console.WriteLine($"Android button render is completed!");
    }
}

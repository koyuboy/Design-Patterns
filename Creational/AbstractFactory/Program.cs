using AbstractFactory;
using AbstractFactory.ConcreteFactories;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        var clientCode = new ClientCode(GetGuiFactory());
        clientCode.Main();
    }

    private static IGuiFactory GetGuiFactory()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return new WindowsGuiFactory();
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return new MacosGuiFactory();

        throw new Exception("Operating System Not Found!");
    }


    class ClientCode
    {
        private readonly IGuiFactory _guiFactory;
        public ClientCode(IGuiFactory guiFactory)
        {
            _guiFactory = guiFactory;
        }

        public void Main()
        {
            var alert = _guiFactory.CreateAlert(250, 500, 1000, 0);
            alert.Render();

            Console.WriteLine("\n");

            var textBox = _guiFactory.CreateTextBox(50, 150, 350, 650, 99);
            textBox.Render();
            textBox.OnChange("Hello World!");

            Console.WriteLine("\n");

            var button = _guiFactory.CreateButton(20, 60, 350, 700);
            button.Render();
            button.OnClick("CloseAlert");
        }
    }
}
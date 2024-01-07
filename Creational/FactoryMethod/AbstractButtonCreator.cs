namespace FactoryMethod;

public abstract class AbstractButtonCreator
{
    public abstract IButton CreateButtonFactoryMethod();

    public IButton CreateAndRenderButton()
    {
        var button = CreateButtonFactoryMethod();

        button.Render();

        return button;
    }
}

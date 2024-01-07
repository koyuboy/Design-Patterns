using FactoryMethod.ConcreteButtons;

namespace FactoryMethod.ConcreteFactories;

public class AndroidButtonCreator : AbstractButtonCreator
{
    public override IButton CreateButtonFactoryMethod()
    {
        return new AndroidButton();
    }
}

using FactoryMethod.ConcreteButtons;

namespace FactoryMethod.ConcreteFactories;

public class IosButtonCreator : AbstractButtonCreator
{
    public override IButton CreateButtonFactoryMethod()
    {
        return new IosButton();
    }
}

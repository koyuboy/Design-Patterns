using FactoryMethod;
using FactoryMethod.ConcreteFactories;

IButton button;

var creator = new AndroidButtonCreator();

button = creator.CreateAndRenderButton();

button.Click("CloseButtonEvent");
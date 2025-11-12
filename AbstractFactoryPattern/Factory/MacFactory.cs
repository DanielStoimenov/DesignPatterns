using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.Factory;

public class MacFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}
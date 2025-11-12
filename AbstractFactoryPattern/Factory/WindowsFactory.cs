using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.Factory;

public class WindowsFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}
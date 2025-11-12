using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern.Factory;

public interface IUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
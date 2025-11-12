using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Models;

namespace AbstractFactoryPattern;

public class Application
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;

    public Application(IUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void Render() 
    {
        _button.Render();
        _checkbox.Render();
    }

    public void Interact() 
    {
        _button.Click();
        _checkbox.Toggle();
    }
}
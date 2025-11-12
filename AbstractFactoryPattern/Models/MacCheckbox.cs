namespace AbstractFactoryPattern.Models;

public class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering macOS checkbox");
    }

    public void Toggle()
    {
        Console.WriteLine("macOS checkbox toggled");
    }
}
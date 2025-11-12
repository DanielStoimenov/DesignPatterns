namespace AbstractFactoryPattern.Models;

public class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering Windows checkbox");
    }

    public void Toggle()
    {
        Console.WriteLine("Windows checkbox toggled");
    }
}
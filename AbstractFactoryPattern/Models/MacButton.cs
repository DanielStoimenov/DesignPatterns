namespace AbstractFactoryPattern.Models;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering macOS button");
    }

    public void Click()
    {
        Console.WriteLine("macOS button clicked");
    }
}
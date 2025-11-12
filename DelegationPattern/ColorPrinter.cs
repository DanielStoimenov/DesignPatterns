namespace DelegationPattern;

public class ColorPrinter : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine($"Color printing: {content}");
    }
}
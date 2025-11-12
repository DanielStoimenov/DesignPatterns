namespace DelegationPattern;

public class RealPrinter : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine($"Printing: {content}");
    }
}
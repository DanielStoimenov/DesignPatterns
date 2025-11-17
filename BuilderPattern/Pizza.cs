namespace BuilderPattern;

public class Pizza
{
    public string Size { get; set; } = string.Empty;
    public string Crust { get; set; } = string.Empty;
    public List<string> Toppings { get; set; } = new List<string>();
    public bool ExtraCheese { get; set; }
    public bool Spicy { get; set; }

    public void Display()
    {
        Console.WriteLine("\nPizza Order:");
        Console.WriteLine($"   Size: {Size}");
        Console.WriteLine($"   Crust: {Crust}");
        Console.WriteLine($"   Toppings: {string.Join(", ", Toppings)}");
        Console.WriteLine($"   Extra Cheese: {(ExtraCheese ? "Yes" : "No")}");
        Console.WriteLine($"   Spicy: {(Spicy ? "Yes" : "No")}");
    }
}
namespace FactoryMethodPattern.Models;

public class Airplane : Transport
{
    public override void Deliver(string destination)
    {
        Console.WriteLine($"Delivering by airplane to {destination}");
    }

    public override decimal CalculateCost(double distance)
    {
        return (decimal)(distance * 5.0);
    }
}

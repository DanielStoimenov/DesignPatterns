namespace FactoryMethodPattern.Models;

public class Ship : Transport
{
    public override void Deliver(string destination)
    {
        Console.WriteLine($"Delivering by ship to {destination}");
    }

    public override decimal CalculateCost(double distance)
    {
        return (decimal)(distance * 1.5);
    }
}
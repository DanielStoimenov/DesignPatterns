namespace FactoryMethodPattern.Models;

public class Truck : Transport
{
    public override void Deliver(string destination)
    {
        Console.WriteLine($"Delivering by truck to {destination}");
    }

    public override decimal CalculateCost(double distance)
    {
        return (decimal)(distance * 2.5);
    }
}
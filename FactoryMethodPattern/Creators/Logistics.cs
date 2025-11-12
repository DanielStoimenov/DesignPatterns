using FactoryMethodPattern.Models;

namespace FactoryMethodPattern.Creators;

public abstract class Logistics
{
    public abstract Transport CreateTransport();

    public void PlanDelivery(string destination, double distance) 
    {
        Transport transport = CreateTransport();

        decimal cost = transport.CalculateCost(distance);
        Console.WriteLine($"Planning delivary to {destination}");
        Console.WriteLine($"Distance: {distance} km");
        Console.WriteLine($"Estimated cost: {cost:F2}");

        transport.Deliver(destination);
        Console.WriteLine("Delivery completed!\n");
    }
}
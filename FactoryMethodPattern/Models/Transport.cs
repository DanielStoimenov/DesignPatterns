namespace FactoryMethodPattern.Models;

public abstract class Transport
{
    public abstract void Deliver(string destination);
    public abstract decimal CalculateCost(double distance);
}
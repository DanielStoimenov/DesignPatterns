using FactoryMethodPattern.Models;

namespace FactoryMethodPattern.Creators;

public class RoadLogistics : Logistics
{
    public override Transport CreateTransport()
    {
        return new Truck();
    }
}
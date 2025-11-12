using FactoryMethodPattern.Models;

namespace FactoryMethodPattern.Creators;

public class SeaLogistics : Logistics
{
    public override Transport CreateTransport()
    {
        return new Ship();
    }
}
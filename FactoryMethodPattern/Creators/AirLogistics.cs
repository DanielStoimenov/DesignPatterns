using FactoryMethodPattern.Models;

namespace FactoryMethodPattern.Creators;

public class AirLogistics : Logistics
{
    public override Transport CreateTransport()
    {
        return new Airplane();
    }
}
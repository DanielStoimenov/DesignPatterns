using FactoryMethodPattern.Creators;

namespace FactoryMethodPattern;

public class Program
{
    //Какво е Factory Method Pattern?
    //    Factory Method е creational design pattern, който дефинира интерфейс за създаване на обект, но позволява
    //    на подкласовете да решат кой клас да инстанцират.Factory Method позволява на класа да делегира инстанцирането на подкласовете.
    //Основна идея
    //    Вместо да викате new директно, създавате метод(factory method), който връща обекта.
    //    Подкласовете могат да override-нат този метод и да върнат различни типове обекти.
    static void Main(string[] args)
    {
        Logistics logistics = new RoadLogistics();
        logistics.PlanDelivery("Sofia", 150);

        logistics = new SeaLogistics();
        logistics.PlanDelivery("Varna", 450);

        logistics = new AirLogistics();
        logistics.PlanDelivery("London", 2500);
    }
}
namespace BuilderPattern.Builders;

public interface IPizzaBuilder
{
    IPizzaBuilder SetSize(string size);
    IPizzaBuilder SetCrust(string crust);
    IPizzaBuilder AddTopping(string topping);
    IPizzaBuilder AddExtraCheese();
    IPizzaBuilder MakeItSpicy();
    Pizza Build();
}
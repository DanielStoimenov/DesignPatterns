namespace BuilderPattern.Builders;

public class PizzaBuilder : IPizzaBuilder
{
    private readonly Pizza _pizza;

    public PizzaBuilder()
    {
        _pizza = new Pizza();
    }

    public IPizzaBuilder SetSize(string size)
    {
        _pizza.Size = size;
        return this;
    }

    public IPizzaBuilder SetCrust(string crust)
    {
        _pizza.Crust = crust;
        return this;
    }

    public IPizzaBuilder AddTopping(string topping)
    {
        _pizza.Toppings.Add(topping);
        return this;
    }

    public IPizzaBuilder AddExtraCheese()
    {
        _pizza.ExtraCheese = true;
        return this;
    }

    public IPizzaBuilder MakeItSpicy()
    {
        _pizza.Spicy = true;
        return this;
    }

    public Pizza Build()
    {
        // Валидация преди построяване
        if (string.IsNullOrEmpty(_pizza.Size))
            throw new InvalidOperationException("Pizza size is required");
        if (string.IsNullOrEmpty(_pizza.Crust))
            throw new InvalidOperationException("Pizza crust is required");

        return _pizza;
    }
}
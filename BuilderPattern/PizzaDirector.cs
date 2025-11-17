using BuilderPattern.Builders;

namespace BuilderPattern;

public class PizzaDirector
{
    public static Pizza CreateMargherita() 
    {
        return new PizzaBuilder()
            .SetSize("Medium")
            .SetCrust("Thin")
            .AddTopping("Tomato Sauce")
            .AddTopping("Mozzarella")
            .AddTopping("Basil")
            .Build();
    }

    public static Pizza CreatePepperoni()
    {
        return new PizzaBuilder()
            .SetSize("Large")
            .SetCrust("Regular")
            .AddTopping("Tomato Sauce")
            .AddTopping("Mozzarella")
            .AddTopping("Pepperoni")
            .MakeItSpicy()
            .Build();
    }

    public static Pizza CreateVeggie()
    {
        return new PizzaBuilder()
            .SetSize("Medium")
            .SetCrust("Whole Wheat")
            .AddTopping("Tomato Sauce")
            .AddTopping("Mushrooms")
            .AddTopping("Bell Peppers")
            .AddTopping("Onions")
            .AddTopping("Olives")
            .Build();
    }
}
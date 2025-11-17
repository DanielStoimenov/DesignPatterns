using BuilderPattern.Builders;

namespace BuilderPattern;

// Какво е Builder Pattern?
//    Builder е creational design pattern, който позволява да създавате сложни обекти
//    стъпка по стъпка.Патърнът позволява да произвеждате различни типове и представяния
//    на обект, използвайки един и същ construction код.
// Основна идея:
//    Вместо голям constructor с много параметри, използвате builder който конструира
//    обекта постепенно.

public class Program
{
    static void Main(string[] args)
    {
        // Вариант 1: Ръчно строим пица
        Console.WriteLine("=== Custom Pizza ===");
        Pizza customPizza = new PizzaBuilder()
            .SetSize("Large")
            .SetCrust("Stuffed Crust")
            .AddTopping("Tomato sauce")
            .AddTopping("Mozzarella")
            .AddTopping("Mushrooms")
            .AddTopping("Olives")
            .AddExtraCheese()
            .MakeItSpicy()
            .Build();

        customPizza.Display();

        // Вариант 2: Използваме предефинирани рецепти
        Console.WriteLine("\n=== Predefined Pizza ===");
        Pizza margherita = PizzaDirector.CreateMargherita();
        margherita.Display();

        Pizza Pepperoni = PizzaDirector.CreatePepperoni();
        Pepperoni.Display();

        Pizza veggie = PizzaDirector.CreateVeggie();
        veggie.Display();
    }
}
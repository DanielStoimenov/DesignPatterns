namespace DelegationPattern;

public class Program
{
    //Какво е Delegation Pattern?
    //    Delegation е design pattern, при който обект обработва заявка като делегира изпълнението на друг helper
    //    обект(delegate). Обектът-получател делегира операциите на свой делегат вместо да ги имплементира сам.
    //Основна идея
    //    Вместо обект да прави работата сам(наследяване), той делегира работата на друг обект
    static void Main(string[] args)
    {
        // Започваме с обикновен принтер
        var controller = new PrinterController(new RealPrinter());
        controller.PrintDocument("Annual Report");

        // Сменяме с цветен принтер
        controller.SetPrinter(new ColorPrinter());
        controller.PrintDocument("Marketing Brochure");
    }
}
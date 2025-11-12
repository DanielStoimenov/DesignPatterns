using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern;

public class Program
{
    //Какво е Abstract Factory Pattern?
    //    Abstract Factory е creational design pattern, който предоставя интерфейс за създаване на 
    //    семейства от свързани или зависими обекти, без да се специфицира техният конкретен клас.
    //Основна идея
    //    Вместо да създавате обекти директно с new, използвате фабрика, която създава семейства от
    //    свързани обекти.Това позволява лесна смяна на цели семейства обекти без промяна в клиентския код.
    static void Main(string[] args)
    {
        // for Windows
        IUIFactory factory = new WindowsFactory();
        Application application = new Application(factory);
        application.Render();
        application.Interact();

        Console.WriteLine();

        // for macOS - just change the factory
        IUIFactory factory2 = new MacFactory();
        Application application2 = new Application(factory2);
        application2.Render();
        application2.Interact();
    }
}

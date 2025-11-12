using DecoratorPattern.Decorators;

namespace DecoratorPattern;

public class Program
{
    static void Main(string[] args)
    {
        string message = "Server is down!";

        Console.WriteLine($"=== Critical Alert - Email Only ===");
        INotifier notifier = new EmailNotifier("admin@company.com");
        notifier.Send(message);

        Console.WriteLine("\n=== Important Alert - Email + SMS ===");
        INotifier notifier2 = new SmsDecorator(new EmailNotifier("admin@company.com"), "+359888123456");
        notifier2.Send(message);

        Console.WriteLine("\n=== Emergency Alert - All Channels ===");
        INotifier notifier3 = new FacebookDecorator(
            new SlackDecorator(
                new SmsDecorator(
                    new EmailNotifier("admin@company.com"),
                    "+359888123456"),
                        "alerts"),
                            "admin");
        notifier3.Send(message);
    }
}
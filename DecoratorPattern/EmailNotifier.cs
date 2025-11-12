namespace DecoratorPattern;

public class EmailNotifier : INotifier
{
    private readonly string _email;

    public EmailNotifier(string email)
    {
        _email = email;
    }

    public void Send(string message)
    {
        Console.WriteLine($"Sending Email to {_email}: {message}");
    }
}
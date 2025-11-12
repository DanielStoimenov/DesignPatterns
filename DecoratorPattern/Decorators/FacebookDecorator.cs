namespace DecoratorPattern.Decorators;

public class FacebookDecorator : NotifierDecorator
{
    private readonly string _username;

    public FacebookDecorator(INotifier notifier, string username) : base(notifier)
    {
        _username = username;
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Posting to Facebook @{_username}: {message}");
    }
}
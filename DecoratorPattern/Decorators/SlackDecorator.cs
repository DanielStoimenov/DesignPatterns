namespace DecoratorPattern.Decorators;

public class SlackDecorator : NotifierDecorator
{
    private readonly string _channel;

    public SlackDecorator(INotifier notifier, string channel) : base(notifier)
    {
        _channel = channel;
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Posting to Slack #{_channel}: {message}");
    }
}
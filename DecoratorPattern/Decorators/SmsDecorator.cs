namespace DecoratorPattern.Decorators;

public class SmsDecorator : NotifierDecorator
{
    private readonly string _phoneNumber;

    public SmsDecorator(INotifier notifier, string phoneNumber) : base(notifier)
    {
        _phoneNumber = phoneNumber;
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Sending SMS to {_phoneNumber}: {message}");
    }
}
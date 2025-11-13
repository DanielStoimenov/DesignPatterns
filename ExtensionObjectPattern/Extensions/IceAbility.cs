namespace ExtensionObjectPattern.Extensions;

public class IceAbility : IAbility
{
    public string Name => "Ice";

    public void Execute()
    {
        Console.WriteLine("Freezing enemy! Slow effect applied");
    }
}

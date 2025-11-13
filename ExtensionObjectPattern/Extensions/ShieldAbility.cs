namespace ExtensionObjectPattern.Extensions;

public class ShieldAbility : IAbility
{
    public string Name => "Shield";

    public void Execute()
    {
        Console.WriteLine("Shield activated! Absorbing damage");
    }
}
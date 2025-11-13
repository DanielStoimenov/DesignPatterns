namespace ExtensionObjectPattern.Extensions;

public class FireAbility : IAbility
{
    public string Name => "Fire";

    public void Execute()
    {
        Console.WriteLine("Casting fireball! Damage: 50");
    }
}
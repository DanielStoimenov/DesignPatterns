namespace ExtensionObjectPattern.Extensions;

public class HealAbility : IAbility
{
    public string Name => "Heal";

    public void Execute()
    {
        Console.WriteLine("Healing 30 HP");
    }
}
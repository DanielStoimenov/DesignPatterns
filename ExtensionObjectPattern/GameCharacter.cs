using ExtensionObjectPattern.Extensions;

namespace ExtensionObjectPattern;

public class GameCharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    private readonly Dictionary<string, IAbility> _abilities;

    public GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
        _abilities = new Dictionary<string, IAbility>();
    }

    public void AddAbility(IAbility ability) 
    {
        if (!_abilities.ContainsKey(ability.Name))
        {
            _abilities[ability.Name] = ability;
            Console.WriteLine($"{Name} learned {ability.Name} ability!");
        }
    }

    public void RemoveAbility(string abilityName) 
    {
        if (_abilities.Remove(abilityName)) 
        {
            Console.WriteLine($"{Name} forgot {abilityName} ability");
        }
    }

    public void UseAbility(string abilityName) 
    {
        if (_abilities.TryGetValue(abilityName, out IAbility? ability)) 
        {
            Console.WriteLine($"\n{Name} uses {abilityName}:");
            ability.Execute();
        }
    }

    public void ShowAbilities() 
    {
        Console.WriteLine($"{Name}'s abilities:");
        if (_abilities.Count > 0)
        {
            foreach (var ability in _abilities.Values)
            {
                Console.WriteLine($" - {ability.Name}");
            }
        }
        else 
        {
            Console.WriteLine(" (none)");
        }
    }

    // Generic метод за достъп до extension
    public T? GetAbility<T>() where T : class, IAbility
    {
        return _abilities.Values.OfType<T>().FirstOrDefault();
    }
}
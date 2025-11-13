using ExtensionObjectPattern.Extensions;

namespace ExtensionObjectPattern;

// Какво е Extension Object Pattern?
//    Extension Object е structural design pattern, който позволява да добавяте нова функционалност към обекти
//    без да променяте техния клас.Това се постига чрез прикачване на extension обекти към основния обект.
// Основна идея:
//    Обектът държи колекция от "extension" обекти, които добавят допълнителна функционалност.
// Принцип:
//    Обектът е разширяем чрез прикачване на extensions, без да се променя кодът му.
// Важно:
//    Extension Object е различен от C# Extension Methods!

public class Program
{
    static void Main(string[] args)
    {
        GameCharacter warrior = new GameCharacter("Warrior", 100);
        GameCharacter mage = new GameCharacter("Mage", 80);

        // Warrior получава abilities
        warrior.AddAbility(new ShieldAbility());
        warrior.AddAbility(new HealAbility());

        // Mage получава abilities
        mage.AddAbility(new FireAbility());
        mage.AddAbility(new IceAbility());
        mage.AddAbility(new HealAbility());

        // Показваме abilities
        warrior.ShowAbilities();
        mage.ShowAbilities();

        // Използваме abilities
        warrior.UseAbility("Shield");
        warrior.UseAbility("Heal");

        mage.UseAbility("Fire");
        mage.UseAbility("Ice");

        // Премахваме ability
        Console.WriteLine();
        mage.RemoveAbility("Fire");
        mage.RemoveAbility("Ice");
        mage.RemoveAbility("Heal");
        mage.ShowAbilities();
    }
}

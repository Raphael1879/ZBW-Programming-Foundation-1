
namespace OOP.Interfaces
{
    public abstract class CharacterBase
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Xp { get; set; }
        public int Luck { get; set; }
        public int Strength { get; set; }

        public void ShowStats()
        
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"============== {GetType().Name.ToUpper()} STATS ==============");
            Console.ResetColor();

            Console.Write(" Name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Name);
            Console.ResetColor();

            Console.WriteLine(" --------------------------------------------");

            Console.Write(" Level: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Level);
            Console.ResetColor();

            Console.Write(" Health: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Health);
            Console.ResetColor();

            Console.Write(" XP: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Xp);
            Console.ResetColor();

            Console.Write(" Luck: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Luck);
            Console.ResetColor();

            Console.Write(" Strength: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Strength);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=============================================");
            Console.ResetColor();
            Console.WriteLine();

        }

        public abstract Actions GetAction();
        


        public void Attack(CharacterBase victim)
        {
            victim.Health--;
            Console.WriteLine($"{Name} attacked {victim.Name}!!! {victim.Name} new health is: {victim.Health}");

            if (victim.Health <= 0)
            {
                Console.WriteLine($"{Name} has KILLED {victim.Name}");
            }
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moved");
        }

        public void Heal(CharacterBase target = null)
        {
            if (target is null)
            {
                Console.WriteLine($"{Name} healed himself!");
            }
            else
            {
                Console.WriteLine($"{Name} healed {target.Name}!");
            }
        }
    }
}

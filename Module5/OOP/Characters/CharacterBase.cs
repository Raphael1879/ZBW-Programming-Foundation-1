using OOP.Interfaces;

namespace OOP.Characters
{
    public abstract class CharacterBase
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Xp { get; set; }
        public int Luck { get; set; }
        public int TempoaryLuck{ get; set; }
        public int Strength { get; set; }
        public int TempoaryStrengt { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }

        public required List<ISkill> Skills { get; set; }


        public abstract ActionInfo GetAction();




        public void GiveXp(int xp)
        {
            Xp += xp;
            Console.WriteLine($"{Name} gained {xp}xp");

            while (Xp >= Level * Level) {
               Xp = Xp - Level * Level;
               Console.WriteLine($"{Name} is now Level {Level}");
                
                Level++;
            }
        }
    }
}

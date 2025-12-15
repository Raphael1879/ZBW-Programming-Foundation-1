using OOP.Characters;
using OOP.Interfaces;

namespace OOP.Inventory
{
    internal class HealthPotion : IItem
    {
        public string Name { get; set; } = "Health Potion";
        public string Description { get; set; } = "Heals 20% of Max Health";

        public void Use(CharacterBase user, CharacterBase target)
        {
            var healingAmount = (int)Math.Round(user.MaxHealth * 0.2);


            if(user.Health + healingAmount > user.MaxHealth)
            {
                user.Health = user.MaxHealth;
            } else
            {
                user.Health += healingAmount;
            }
        }
    }
}

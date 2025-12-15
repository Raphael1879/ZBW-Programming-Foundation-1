using OOP.Characters;
using OOP.Interfaces;

namespace OOP.Inventory
{
    internal class CleansePotion : IItem
    {
        public string Name { get; set; } = "Cleanse Potion";
        public string Description { get; set; } = "Removes all Debuffs";

        public void Use(CharacterBase user, CharacterBase target)
        {
            user.Effects.RemoveAll(e => e.Type == StatusEffectType.Debuff);
        }
    }
}

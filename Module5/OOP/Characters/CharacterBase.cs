using OOP.Helpers;
using OOP.Interfaces;
using OOP.Inventory;
using OOP.Skills;
using OOP.StatusEffects;

namespace OOP.Characters
{
    public abstract class CharacterBase
    {
        public required string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int DamageModifier { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public string? SpritePath { get; set; }


        public required List<ISkill> Skills { get; set; }

        public List<IItem> Items { get; set; } = [];

        public List<StatusEffect> Effects { get; set; } = [];


        public abstract ActionInfo GetAction();

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public int CalculateDamage(int damage)
        {
            return damage + DamageModifier;
        }

        public void AddStatusEffect(StatusEffect effect)
        {
            effect.OnApply(this);
            var existing = Effects.Find(i => i.Equals(effect));

            if (existing is not null)
            {
                existing.Stack += effect.Stack;
            } else
            {
                Effects.Add(effect);
            }
        }

        public void OnCombatStart()
        {
            Effects.Clear();
            DamageModifier = 0;
        }

        public void OnTrunStart()
        {
            Mana = MaxMana;
            Effects.ForEach(e => e.OnTurnStart(this));
            Effects = Effects.Where(e => e.Stack > 0).ToList();
        }

        public void OnTurnEnd()
        {
            Effects.ForEach(e => e.OnTurnEnd(this));

        }
    }
}

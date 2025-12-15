using OOP.Characters;
using OOP.Interfaces;

namespace OOP.StatusEffects
{
    public abstract class StatusEffect
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract string Symbol { get; set; }
        public abstract int Stack {  get; set; }
        public abstract StatusEffectType Type { get; set; }

        public abstract void OnTurnStart(CharacterBase target);
        public abstract void OnTurnEnd(CharacterBase target);
        public abstract void OnCombatStart(CharacterBase target);
        public abstract void OnApply(CharacterBase target);



        public bool Equals(StatusEffect? other)
        {
            if (other is null)
                return false;

            return Name == other.Name;
        }

        public override bool Equals(object? obj)
            => obj is StatusEffect other && Equals(other);

        public override int GetHashCode()
            => Name.GetHashCode();

        public static bool operator ==(StatusEffect? left, StatusEffect? right)
            => EqualityComparer<StatusEffect>.Default.Equals(left, right);

        public static bool operator !=(StatusEffect? left, StatusEffect? right)
            => !(left == right);
    }
}

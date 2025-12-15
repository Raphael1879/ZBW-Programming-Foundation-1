using OOP.Characters;
using OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.StatusEffects.Impl
{
    public class Rage : StatusEffect
    {
        public override string Name { get; set; } = "Rage";
        public override string Description { get; set; } = "3 Extra Damage for the rest of Combat";
        public override string Symbol { get; set; } = "💢";
        public override int Stack { get; set; } = 1;
        public override StatusEffectType Type { get; set; } = StatusEffectType.Buff;

        public override void OnApply(CharacterBase target)
        {
            target.DamageModifier += 3;
        }

        public override void OnCombatStart(CharacterBase target)
        {
        }

        public override void OnTurnEnd(CharacterBase target)
        {
        }

        public override void OnTurnStart(CharacterBase target)
        {

        }
    }
}

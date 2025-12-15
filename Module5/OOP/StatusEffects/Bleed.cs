using OOP.Characters;
using OOP.Helpers;
using OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.StatusEffects
{
    public class Bleed : StatusEffect
    {
        public override string Name { get; set; } = "Bleed";
        public override string Description { get; set; } = "At the end Your Turn The target takes X Amount of damage.";
        public override string Symbol { get; set; } = "🩸";
        public override int Stack { get; set; } = 1;
        public override StatusEffectType Type { get; set; } = StatusEffectType.Debuff;


        public override void OnApply(CharacterBase target)
        {
        }

        public override void OnCombatStart(CharacterBase target)
        {
        }

        public override void OnTurnEnd(CharacterBase target)
        {
        }

        public override void OnTurnStart(CharacterBase target)
        {
            target.Health -= Stack;
            ConsoleHelper.Speak($"{target.Name} Bleeds. -{Stack} Hp", ConsoleColor.Red);
            Stack--;
        }
    }
}

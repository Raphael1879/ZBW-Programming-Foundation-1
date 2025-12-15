using OOP.Characters;
using OOP.Helpers;
using OOP.Interfaces;
using OOP.StatusEffects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Skills
{
    public class Slice : ISkill
    {
        public string Name { get; set; } = "Slice";
        public string Description { get; set; } = "Deal 4 Damage and Apply 1 Stack of Bleed";
        public int Cost { get; set; } = 1;
        public SkillType Type { get; set; } = SkillType.Attack;
        public int Damage { get; set; } = 4;
        public int Level { get; set; } = 1;


        public int BleedStacks = 1;

        public void Use(CharacterBase user, CharacterBase target)
        {
            var damage = user.CalculateDamage(Damage);
            target.TakeDamage(damage);
            target.AddStatusEffect(new Bleed { Stack = BleedStacks});
            ConsoleHelper.Speak($"{user.Name} Slices {target.Name} and delas {Damage} Damage! {target.Name} Bleeds +{BleedStacks}", ConsoleColor.Red);

        }

        public void Upgrade()
        {
            Level++;
            Damage += 1;
            BleedStacks += 1;
            Description = $"Deal {Damage} Damage and Apply {BleedStacks} Stack of Bleed";
        }
    }
}

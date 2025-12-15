using OOP.Characters;
using OOP.Helpers;
using OOP.Interfaces;
using System;


namespace OOP.Skills.Impl
{
    internal class Strike : ISkill
    {
        public string Name { get; set; } = "Strike";
        public string Description { get; set; } = "Strike an Enemy and deal 5 Damage";
        public int Cost { get; set; } = 1;
        public SkillType Type { get; set; } = SkillType.Attack;
        public int Damage { get; set; } = 5;
        public int Level { get; set; } = 1;


        public void Use(CharacterBase user, CharacterBase target)
        {
            var damage = user.CalculateDamage(Damage);
            target.TakeDamage(damage);
            ConsoleHelper.Speak($"{user.Name} Strikes and delas {damage} Damage!", ConsoleColor.Red);
        }

        public void Upgrade()
        {
            Level++;
            Damage += 1;
            Description = $"Strike an Enemy and deal {Damage} Damage";
        }
    }
}

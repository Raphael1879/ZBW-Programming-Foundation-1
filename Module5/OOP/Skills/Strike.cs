using OOP.Characters;
using OOP.Interfaces;


namespace OOP.Skills
{
    internal class Strike : ISkill
    {
        public string Name { get; set; } = "Strike";
        public string Description { get; set; } = "Strike an Enemy and deal Damage";
        public int Cost { get; set; } = 1;
        public SkillType Type { get; set; } = SkillType.Attack;

        public void Use(CharacterBase user, CharacterBase target)
        {
            target.Health = target.Health - user.Strength;
        }
    }
}

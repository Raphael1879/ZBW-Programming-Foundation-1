using OOP.Interfaces;
using OOP.Skills;

namespace OOP.Characters
{
    internal class Enemy : CharacterBase
    {
        public override ActionInfo GetAction()
        {
            Thread.Sleep(1000);
            if(Mana > 0)
            {
                return new ActionInfo
                {
                    Type = FightActions.Fight,
                    ObjectRef = Skills.First()
                };
            } else
            {
                return new ActionInfo
                {
                    Type = FightActions.End_Turn
                };
            }
        }
    }
}

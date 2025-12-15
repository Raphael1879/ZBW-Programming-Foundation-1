using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    public enum MenuActions
    {
        GO_DEEPER = 1,
        SPEND_SKILLPOINTS = 2,
    }

    public enum RoomType
    {
        Empty,
        Monster,
        Item,
        Campfire,
        Random,
        Boss
    }

    public enum SkillType
    {
        Attack,
        Buff,
    }

    public enum FightActions
    {
        Fight,
        Item,
        End_Turn
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public enum StatusEffectType
    {
        Buff,
        Debuff
    }
}

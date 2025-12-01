using OOP.Characters;
using OOP.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Map
{
    public partial class Room
    {
        public void EnterMonsterRoom(CharacterBase player)
        {
            var enemy1 = new Enemy
            {
                Name = "Fungus",
                Level = 1,
                Health = 100,
                MaxHealth = 100,
                Strength = 1,
                Skills = [new Strike()]
            };

            Game.Fight(player, enemy1);
        }
    }
}

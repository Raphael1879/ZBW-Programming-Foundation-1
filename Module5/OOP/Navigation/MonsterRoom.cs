using OOP.Characters;
using OOP.Helpers;
using OOP.Interfaces;
using OOP.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Navigation
{
    public class MonsterRoom : IRoomContent
    {
        public bool Cleared { get; set; } = false;

        //public void EnterMonsterRoom(CharacterBase player)
        //{




        //}

        public void OnRoomEnter(CharacterBase player)
        {
            if (Cleared)
            {
                return;
            }

            var enemy1 = new Enemy
            {
                Name = "Fungus",
                SpritePath = "C:\\Repos\\ZBW-Programming-Foundation-1\\Module5\\OOP\\Sprites\\dude.txt",
                Level = 1,
                Health = 30,
                MaxHealth = 30,
                Mana = 1,
                MaxMana = 1,
                Skills = [new Slice() { BleedStacks = 5, Damage = 1}]
            };


            Console.Clear();
            ConsoleHelper.Speak($"{enemy1.Name} Comes out of Nowhere and Attacks", ConsoleColor.DarkMagenta);

            var fight = new Fight { Character1 = player, Character2 = enemy1 };

            fight.StartFight();

            if (fight.Winner == player)
            {
                Game.GiveXpBasedOnEnemy(player, enemy1);
                Cleared = true;
            }

        }
    }
}

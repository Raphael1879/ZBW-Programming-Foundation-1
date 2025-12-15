using OOP.Characters;
using OOP.Helpers;
using OOP.Skills;
using OOP.Skills.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Navigation.Rooms
{
    internal class BossRoom : IRoomContent
    {
        public bool Cleared { get; set; } = false;

        public void OnRoomEnter(CharacterBase player)
        {
            var boss = new Enemy
            {
                Name = "Mega Fungus",
                SpritePath = "C:\\Repos\\ZBW-Programming-Foundation-1\\Module5\\OOP\\Sprites\\dude.txt",
                Health = 100,
                MaxHealth = 100,
                Mana = 3,
                MaxMana = 3,
                Skills = [new Strike()]
            };


            Console.Clear();
            ConsoleHelper.Speak($"{boss.Name} is Ready", ConsoleColor.DarkRed);

            var fight = new Fight { Character1 = player, Character2 = boss };

            fight.StartFight();

            if (fight.Winner == player)
            {

                Cleared = true;
            }
        }
    }
}

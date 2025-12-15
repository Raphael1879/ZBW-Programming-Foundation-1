using OOP.Characters;
using OOP.Helpers;
using OOP.Interfaces;
using OOP.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Navigation
{

    public class ItemRoom : IRoomContent
    {
        public bool Cleared { get; set; } = false;

        public void OnRoomEnter(CharacterBase player)
        {
            throw new NotImplementedException();
        }
    }
    //public partial class MonsterRoom
    //{
    //    public void EnterItemRoom(CharacterBase player)
    //    {
    //        Console.Clear();

    //        var randomItem = RewardGenerator.GetRandomItem(); 

    //        player.Items.Add(randomItem);

    //        ConsoleHelper.Speak($"Player as found a {randomItem.Name}", ConsoleColor.Green);

    //    }
    //}
}

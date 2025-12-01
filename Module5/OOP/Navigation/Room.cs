using OOP.Characters;
using OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Map
{
    public partial class Room
    {
        public RoomType RoomType { get; set; }

        public void OnRoomEnter(CharacterBase player)
        {
            Console.Clear();
            Console.WriteLine("Entered new Room " + RoomType.ToString());
            switch (RoomType)
            {
                case RoomType.Monster: {
                        EnterMonsterRoom(player);
                }
                break;
            }
        }
    }
}

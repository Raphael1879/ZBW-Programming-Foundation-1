using OOP.Characters;
using OOP.Helpers;
using OOP.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Navigation.Rooms
{

    public class ItemRoom : IRoomContent
    {
        public bool Cleared { get; set; } = false;

        public void OnRoomEnter(CharacterBase player)
        {
            throw new NotImplementedException();
        }
    }
}

using OOP.Characters;
using OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inventory
{
    internal class RagePotion : IItem
    {
        public string Name { get; set; } = "Rage Potion";
        public string Description { get; set; } = "+3 Strength till Rest of Combat";

        public void Use(CharacterBase user, CharacterBase target)
        {
            user.TempoaryStrengt += 3;
        }
    }
}

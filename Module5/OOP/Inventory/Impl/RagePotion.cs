using OOP.Characters;
using OOP.StatusEffects;
using OOP.StatusEffects.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inventory.Impl
{
    internal class RagePotion : IItem
    {
        public string Name { get; set; } = "Rage Potion";
        public string Description { get; set; } = "+3 Strength till Rest of Combat";

        public void Use(CharacterBase user, CharacterBase target)
        {
            user.AddStatusEffect(new Rage { Stack = 3 });
        }
    }
}

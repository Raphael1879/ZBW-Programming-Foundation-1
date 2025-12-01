using OOP.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    public interface IUseable
    {
        public void Use(CharacterBase user, CharacterBase target);
    }
}

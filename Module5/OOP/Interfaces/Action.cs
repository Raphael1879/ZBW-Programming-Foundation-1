using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    public struct ActionInfo
    {
        public FightActions Type { get; set; }

        public IUseable ObjectRef { get; set; }
    }
}

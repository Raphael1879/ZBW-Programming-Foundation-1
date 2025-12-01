using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    public interface IItem : IUseable
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

using OOP.Characters;
using OOP.Interfaces;
using OOP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Skills
{
    public interface ISkill : IUseable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
        public SkillType Type { get; set; }

        public void Upgrade();
    }
}

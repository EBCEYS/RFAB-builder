using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    internal interface IBaseEnchant
    {
        string Name { get; set; }
        string Description { get; set; }
        void Effect(Character character);
    }
}

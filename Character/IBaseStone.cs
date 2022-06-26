using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    internal interface IBaseStone
    {
        string Name { get; set; }
        void Effect();
        string Description { get; set; }
        void Active(Character character);
    }
}

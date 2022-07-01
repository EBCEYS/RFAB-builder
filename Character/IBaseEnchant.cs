using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character
{
    public interface IBaseEnchant
    {
        string Name { get; set; }
        string Description { get; set; }
        void Effect(Characters character);
    }
}

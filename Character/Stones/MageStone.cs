using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class MageStone : IBaseStone
    {
        public string Name { get; set; } = "Маг";
        public string Description { get; set; } = "50 МП [ранг 2]. 20 к навыку всех школ магии. 15% длительности заклинаний. 15% дальности заклинаний. Вражеские заклинания молнии больше не сжигают МП.";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.WhiteMana += 50;
            character.MPRangTwo = true;
            character.Destruction += 20;
            character.Illusion += 20;
            character.Alteration += 20;
            character.Conjuration += 20;
            character.Restoration += 20;
        }
    }
}

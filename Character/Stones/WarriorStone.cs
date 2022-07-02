using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class WarriorStone : IBaseStone
    {
        public string Name { get; set; } = "Воин";
        public string Description { get; set; } = "50 ХП [ранг 2]. 1% ХП регена. 10% снижение входящего физического урона";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BlueHP += 50;
            character.HPRangTwo = true;
            character.HPRegenMultiplyer += 1.0;
            character.PhysicalResistanceOverCup += 0.1;
        }
    }
}

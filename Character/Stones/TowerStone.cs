using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Stones
{
    public class TowerStone : IBaseStone
    {
        public string Name { get; set; } = "Башня";
        public string Description { get; set; } = "30% снижения входящего урона от стрел и болтов. 100 брони. 100% устойчивости. 95% снижение урона от падения.";

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.RangeDamageReduction += 0.3;
            character.ArmourClass += 100;
            character.Stability += 1.0;
            character.FallDamage += 0.95;
        }
    }
}

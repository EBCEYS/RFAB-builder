using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class HeraldOfTheStormEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Вестник бури.";
        public string Description { get; set; } = "10% физического урона по имперцам. 10% физического урона по эльфам[по всем]. 50 брони. 5% сопротивления холоду.";
        public PassiveEffectType Type { get; set; }
        public int? PowerLevel { get; set; }
        public Color Color { get; set; }

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.ArmourClass += 50;
            character.ColdResistance += 0.05;
        }
    }
}

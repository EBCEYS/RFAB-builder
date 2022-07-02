using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class LegateEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Легат";
        public string Description { get; set; } = "10% физического урона по нордам. 50 брони. 5% сопротивления молниям.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.CivilWar;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Purple;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.ArmourClass += 50;
            character.LightningResistance += 0.05;
        }
    }
}

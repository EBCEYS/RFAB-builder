using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class WaterStoneEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Камень Воды";
        public string Description { get; set; } = "+50 МП [ранг 1]. +3 МП регена. -20% сопротивления электричеству.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.AllMakerStone;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Teal;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BlueMana += 50;
            character.MPRegenDigit += 3;
            character.LightningResistance -= 0.2;
        }
    }
}

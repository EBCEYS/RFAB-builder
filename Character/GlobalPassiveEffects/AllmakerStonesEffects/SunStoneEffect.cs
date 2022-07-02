using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class SunStoneEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Камень Солнца";
        public string Description { get; set; } = "+50 ХП [ранг 1]. +3 ХП регена. -20% сопротивления холоду.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.AllMakerStone;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Teal;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BlueHP += 50;
            character.HPRegenDigit += 3;
            character.ColdResistance -= 0.2;
        }
    }
}

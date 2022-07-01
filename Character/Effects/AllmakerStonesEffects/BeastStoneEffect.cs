using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class BeastStoneEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Камень Зверя";
        public string Description { get; set; } = "+20% наносимого физического урона. -10% сопротивления физическому урону.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.AllMakerStone;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Teal;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.PhysicalDamageReduction -= 0.1;
            character.WeaponDamageMultiplier += 0.2;
        }
    }
}

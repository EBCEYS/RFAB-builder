using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class DjulianosEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Джулианос";
        public string Description { get; set; } = "50 МП [ранг 1]. 100% регенирации магии. 5% сопротивления магии.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.GodBlessing;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Purple;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            if (character.IsGood)
            {
                character.BlueMana += 50;
                character.MPRegenPercents += 1.0;
                character.MageResistance += 0.05;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class AzuraEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Азуры";
        public string Description { get; set; } = "5/10% сопротивления магии. 25/50 ХП|МП. 10/20% сопротивления холоду и огню.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.GodBlessing;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Purple;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            if (PowerLevel == 1)
            {
                character.MageResistance += 0.05;
                character.BlueHP += 25;
                character.BlueMana += 25;
                character.FireResistance += 0.1;
                character.ColdResistance += 0.1;
            }
            else
            {
                character.MageResistance += 0.1;
                character.BlueHP += 50;
                character.BlueMana += 50;
                character.FireResistance += 0.2;
                character.ColdResistance += 0.2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class ScientistsIntuitionEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Интуиция ученого";
        public string Description { get; set; } = "+5% сопротивления стихиям.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.BlackBooks;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Gray;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.FireResistance += 0.05;
            character.ColdResistance += 0.05;
            character.LightningResistance += 0.05;
        }
    }
}

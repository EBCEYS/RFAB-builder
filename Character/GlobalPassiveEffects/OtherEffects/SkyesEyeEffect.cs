using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class SkyesEyeEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Глас небесный";
        public string Description { get; set; } = "-15% урона от животных.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Another;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Yellow;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BeastResistance += 0.15;
        }
    }
}

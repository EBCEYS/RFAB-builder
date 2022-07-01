using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class KarghstagSpiritEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Дух Карстаага";
        public string Description { get; set; } = "+30 ХП [ранг 1]. +250% ХП регена.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.Another;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Yellow;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BlueHP += 30;
            character.HPRegenPercents += 2.5;
        }
    }
}

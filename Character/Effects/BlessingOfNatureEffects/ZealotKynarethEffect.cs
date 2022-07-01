using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder.Character.Effects
{
    public class ZealotKynarethEffect : IBasePassiveEffect
    {
        public string Name { get; set; } = "Фанатик Кинарет";
        public string Description { get; set; } = "10% урона по животным. 50% СТ регена.";
        public PassiveEffectType Type { get; set; } = PassiveEffectType.BlessingOfNature;
        public int? PowerLevel { get; set; } = 1;
        public Color Color { get; set; } = Color.Green;

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Characters character)
        {
            character.BeastsDamage += 0.1;
            character.STRegenPercents += 0.5;
        }
    }
}
